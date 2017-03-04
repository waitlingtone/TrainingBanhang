using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrainingAccounting.View;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.Presenter;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Report;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace TrainingAccounting.Form
{
    public partial class CacPhieuThuChiForm : DevExpress.XtraEditors.XtraForm, ICacPhieuThuChiView
    {
        CacPhieuThuChiPresenter _presenter;
        public CacPhieuThuChiForm()
        {
            InitializeComponent();
        }

        private void CacPhieuThuChiForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new CacPhieuThuChiPresenter(this);
            StartdateEdit.DateTime = DateTime.Now;
            EnddateEdit.DateTime = DateTime.Now;
        }

        public DateTime Ngay
        {
            get { return dateNavigator.DateTime ; }
        }

        public DateTime TuNgay
        {
            get { return StartdateEdit.DateTime; }
        }

        public DateTime DenNgay
        {
            get { return EnddateEdit.DateTime; }
        }

        public List<ThuchiModel> ThuchiItems
        {
            get { return thuchiModelBindingSource.DataSource as List<ThuchiModel>; }
            set { thuchiModelBindingSource.DataSource = value; }
        }

        public ThuchiModel ThuchiCurrent
        {
            get { return thuchiModelBindingSource.Current as ThuchiModel; ; }
        }

        public int Type
        {
            get {
                return (int)radioGroup.EditValue;
            }
        }

        public void RefreshData()
        {
            thuchiModelGridControl.RefreshDataSource();
        }

        private void dateNavigator_EditDateModified(object sender, EventArgs e)
        {
            StartdateEdit.DateTime = dateNavigator.SelectionStart;
            EnddateEdit.DateTime = dateNavigator.SelectionEnd;
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            _presenter.LoadDataNgay();
        }

        private void radioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.LoadDataNgay();
        }

        private void ItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ThuchiCurrent.PhieubaoHocphiId != null)
            {
                using (var f = new ChitietThuchiHocphiForm(ThuchiCurrent))
                {
                    f.ShowDialog();
                    return;
                }
            }
            else if (ThuchiCurrent.PhieubaoLuongNhanvienId != null)
            {
                using (var f = new ChitietThuchiLuongNhanvienForm(ThuchiCurrent))
                {
                    f.ShowDialog();
                    return;
                }
            }
            else
            {
                using (var f = new Thu_ChiReport(ThuchiCurrent.IsThu.Value, ThuchiCurrent.TenDaumuc, ThuchiCurrent.SoTien.Value, ThuchiCurrent.NgayThanhtoan.Value))
                {
                    f.ShowPreviewDialog();
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            using (var f = new ThuChiReport(thuchiModelBindingSource.DataSource as List<ThuchiModel>,TuNgay, DenNgay))
            {
                f.ShowPreviewDialog();
            }
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            String date = "";
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";// |All files (*.*)|*.*";//|(*.xls)|*.xls |
            saveDialog.RestoreDirectory = true;
            if (TuNgay.Date != DenNgay.Date)
            {
                saveDialog.FileName = "Thuchi_" + TuNgay.ToShortDateString() + "_" + DenNgay.ToShortDateString();
                date = "Ngày: Từ " + TuNgay.ToShortDateString() + " đến " + DenNgay.ToShortDateString();
            }
            else
            {
                saveDialog.FileName = "Thuchi_" + TuNgay.ToShortDateString();
                date = "Ngày: " + TuNgay.ToShortDateString();
            }
            saveDialog.FileName = saveDialog.FileName.Replace("/", "-");

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                String dic = saveDialog.FileName;
                var newFile = new FileInfo(dic);
                if (File.Exists(saveDialog.FileName))
                {
                    try
                    {
                        File.Delete(saveDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Không thể xóa file!\nFile có thể được mở bởi chương trình khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                } 
                using (var package = new ExcelPackage(newFile))
                {
                    
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Thuchi");
                    worksheet.Cells["A1"].Value = "DANH SÁCH THU CHI";
                    worksheet.Cells["A1"].Style.Font.Size = 20;
                    worksheet.Cells[3, 1].Value = date;

                    worksheet.Cells[5, 1].Value = "STT";
                    worksheet.Cells[5, 2].Value = "Danh mục thu/chi";
                    worksheet.Cells[5, 3].Value = "Số tiền";
                    worksheet.Cells[5, 4].Value = "Ngày thanh toán";
                    worksheet.Cells[5, 5].Value = "Thu học phí trẻ";
                    worksheet.Cells[5, 6].Value = "Trả lương nhân viên";
                    int r = 6;
                    if(ThuchiItems!= null)
                        foreach (var row in ThuchiItems)
                        {
                            worksheet.Cells[r, 1].Value = row.STT;
                            worksheet.Cells[r, 2].Value = row.TenDaumuc;
                            worksheet.Cells[r, 3].Value = row.TienThucte;
                            worksheet.Cells[r, 4].Value = row.NgayThanhtoan.Value.ToShortDateString();
                            worksheet.Cells[r, 5].Value = row.TenTre;
                            worksheet.Cells[r, 6].Value = row.TenNhanvien;
                            r ++;
                        }

                    var cell = worksheet.Cells[5,1,r-1,6];
                    var border = cell.Style.Border;
                    border.Bottom.Style = border.Top.Style = border.Left.Style = border.Right.Style = ExcelBorderStyle.Thin;
                    package.Save();

                }
                if (XtraMessageBox.Show("Mở file?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(String.Format("{0}", dic));
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Không thể mở file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}