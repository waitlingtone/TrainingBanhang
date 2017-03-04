using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrainingAccounting.View;
using TrainingAccounting.Presenter;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.Model.BusinessObjectReport;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Report;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace TrainingAccounting.Form
{
    public partial class TreForm : DevExpress.XtraEditors.XtraForm,ITreView
    {
        TrePresenter _presenter;
        public TreForm()
        {
            InitializeComponent();
        }

        private void TreForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new TrePresenter(this);
            _presenter.LoadData();
        }

        public List<NhomTreModel> NhomtreItems
        {
            set { nhomTreModelBindingSource.DataSource = value; }
        }

        public Guid? NhomtreId
        {
            get { return NhomtrecomboBox.SelectedValue as Guid?; }
        }

        public List<TreModel> TreItems
        {
            get
            {
                return treModelBindingSource.DataSource as List<TreModel>;
            }
            set
            {
                treModelBindingSource.DataSource = value;
            }
        }

        public TreModel TreCurrent
        {
            get { return treModelBindingSource.Current as TreModel; }
        }

        public void RefreshData()
        {
            treModelGridControl.RefreshDataSource();
            dongiaHocphiModelGridControl.RefreshDataSource();
            thannhanModelGridControl.RefreshDataSource();
        }

        private void NhomtrecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (NhomtrecomboBox.SelectedIndex == 0)
                _presenter.GetAllTre();
            else if (NhomtreId != null)
                _presenter.GetTreByNhomtre();
        }


        public bool Conhoc
        {
            get { 
                if(ConhoccheckEdit.CheckState == CheckState.Checked)
                    return true;
                else return false;
            }
        }

        private void ConhoccheckEdit_CheckStateChanged(object sender, EventArgs e)
        {
            NhomtrecomboBox_SelectedValueChanged(new object(), new EventArgs());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.Add();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
             _presenter.Delete();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                _presenter.Save();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã có dữ liệu của trẻ!\nBạn không thể xóa trẻ này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public List<TinhthanhModel> TinhthanhItems
        {
            set { tinhthanhModelBindingSource.DataSource = value; }
        }

        public Guid? TinhthanhId
        {
            get { return TinhthanhLookUpEdit.EditValue as Guid?; }
        }

        public List<QuanhuyenModel> QuanhuyenItems
        {
            set { quanhuyenModelBindingSource.DataSource = value; }
        }

        public List<DantocModel> DantocItems
        {
            set { dantocModelBindingSource.DataSource = value; }
        }
        public List<TongiaoModel> TongiaoItems
        {
            set { tongiaoModelBindingSource.DataSource = value; }
        }


        public List<NhomTreModel> NhomtreInfoItems
        {
            set { NhomtreInfobindingSource.DataSource = value; }
        }

        private void treModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetDongiaHocphi();
            _presenter.GetThannhan();
            barCodeControl.Refresh();
        }


        public List<DongiaHocphiModel> DongiaHocphiItems
        {
            get
            {
                return dongiaHocphiModelBindingSource.DataSource as List<DongiaHocphiModel>;
            }
            set
            {
                dongiaHocphiModelBindingSource.DataSource = value;
            }
        }

        public DongiaHocphiModel DongiaHocphiCurrent
        {
            get { return dongiaHocphiModelBindingSource.Current as DongiaHocphiModel; }
        }

        private void AddDongiaButton_Click(object sender, EventArgs e)
        {
            _presenter.AddDongiaHocphi();
        }

        private void DeleteDongiaButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteDongiaHocphi();
        }

        private void SaveDongiaButton_Click(object sender, EventArgs e)
        {
            foreach (var i in DongiaHocphiItems)
                if (i != DongiaHocphiCurrent && i.NgayApdung.Value.Equals(DongiaHocphiCurrent.NgayApdung.Value))
                {
                    XtraMessageBox.Show("Đã tồn tại thời điểm này, vui lòng chọn thời điểm khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            _presenter.SaveDongiaHocphi();
        }


        public List<ThannhanModel> ThannhanItems
        {
            get
            {
                return thannhanModelBindingSource.DataSource as List<ThannhanModel>;
            }
            set
            {
                thannhanModelBindingSource.DataSource = value;
            }
        }

        public ThannhanModel ThannhanCurrent
        {
            get { return thannhanModelBindingSource.Current as ThannhanModel; }
        }

        private void AddThannhanButton_Click(object sender, EventArgs e)
        {
            _presenter.AddThannhan();
        }

        private void DeleteThannhanButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteThannhan();
        }

        private void SaveThannhanButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveThannhan();
        }

        private void TinhthanhLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (TinhthanhId == null)
                return;
            _presenter.GetQuanhuyen();
        }

        private void ItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.CheckUnCheck();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            using(var f = new PhieuDangkyTreReport())
            {
                f.ShowPreviewDialog();
            }
        }

        private void PrintAllButton_Click(object sender, EventArgs e)
        {
            using(var f = new DanhsachTreReport(NhomtreId, Conhoc))
            {
                f.ShowPreviewDialog();
            }
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            List<TrAcc_Danh_GetDanhsachTreReportModel> data = _presenter.GetDataExcel();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";// |All files (*.*)|*.*";//|(*.xls)|*.xls |
            saveDialog.RestoreDirectory = true;
            saveDialog.FileName = "Danh sach Tre";
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

                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("DSTre");
                    worksheet.Cells["A1"].Value = "DANH SÁCH TRẺ";
                    worksheet.Cells["A1"].Style.Font.Size = 20;
                    if(data != null && data.Count > 0)
                        worksheet.Cells[3, 1].Value = "Nhóm: " + data[0].TenNhom;
                    if(Conhoc)
                        worksheet.Cells[4, 1].Value = "Tình trạng: Còn học";
                    else
                        worksheet.Cells[4, 1].Value = "Tình trạng: Nghỉ học";

                    worksheet.Cells[6, 1].Value = "STT";
                    worksheet.Cells[6, 2].Value = "Mã vạch";
                    worksheet.Cells[6, 3].Value = "Họ đệm";
                    worksheet.Cells[6, 4].Value = "Tên";
                    worksheet.Cells[6, 5].Value = "Tên thường gọi";
                    worksheet.Cells[6, 6].Value = "Giới tính";
                    worksheet.Cells[6, 7].Value = "Ngày sinh";
                    worksheet.Cells[6, 8].Value = "Địa chỉ";
                    worksheet.Cells[6, 9].Value = "Quận huyện";
                    worksheet.Cells[6, 10].Value = "Tỉnh thành";
                    worksheet.Cells[6, 11].Value = "Dân tộc";
                    worksheet.Cells[6, 12].Value = "Tôn giáo";
                    worksheet.Cells[6, 13].Value = "Phụ huynh";
                    worksheet.Cells[6, 14].Value = "Ghi chú";
                    int r = 7;
                    if (data != null)
                        foreach (var row in data)
                        {
                            worksheet.Cells[r, 1].Value = row.STT;
                            worksheet.Cells[r, 2].Value = row.Mavach;
                            worksheet.Cells[r, 3].Value = row.Hodem;
                            worksheet.Cells[r, 4].Value = row.Ten;
                            worksheet.Cells[r, 5].Value = row.TenThuonggoi;
                            worksheet.Cells[r, 6].Value = row.TenGioitinh;
                            worksheet.Cells[r, 7].Value = row.Ngaysinh.Value.ToShortDateString();
                            worksheet.Cells[r, 8].Value = row.Diachi;
                            worksheet.Cells[r, 9].Value = row.Quanhuyen;
                            worksheet.Cells[r, 10].Value = row.TenTinh;
                            worksheet.Cells[r, 11].Value = row.Dantoc;
                            worksheet.Cells[r, 12].Value = row.Tongiao;
                            worksheet.Cells[r, 13].Value = row.Phuhuynh;
                            worksheet.Cells[r, 14].Value = row.Ghichu;
                            r++;
                        }

                    var cell = worksheet.Cells[6, 1, r - 1, 14];
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

        private void DongiaCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.CheckChanged();
        }
    }
}