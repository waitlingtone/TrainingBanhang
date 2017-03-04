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
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace TrainingAccounting.Form
{
    public partial class DanhmucSachForm : DevExpress.XtraEditors.XtraForm, IDanhmucSachView
    {
        DanhmucSachPresenter _presenter;
        public DanhmucSachForm()
        {
            InitializeComponent();
        }

        private void DanhmucSachForm_Load(object sender, EventArgs e)
        {
            _presenter = new DanhmucSachPresenter(this);
            _presenter.LoadData();
        }

        public List<SachModel> SachItems
        {
            get
            {
                return sachModelBindingSource.DataSource as List<SachModel>;
            }
            set
            {
                sachModelBindingSource.DataSource = value;
            }
        }

        public SachModel SachCurrent
        {
            get { return sachModelBindingSource.Current as SachModel; }
        }

        public List<GiaSachModel> GiaSachItems
        {
            get
            {
                return giaSachModelBindingSource.DataSource as List<GiaSachModel>;
            }
            set
            {
                giaSachModelBindingSource.DataSource = value;
            }
        }

        public GiaSachModel GiaSachCurrent
        {
            get { return giaSachModelBindingSource.Current as GiaSachModel; }
        }

        public void RefreshData()
        {
            sachModelGridControl.RefreshDataSource();
            giaSachModelGridControl.RefreshDataSource();
        }

        private void AddSachButton_Click(object sender, EventArgs e)
        {
            _presenter.AddSach();
        }

        private void DelSachButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteSach();
        }

        private void SaveSachButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveSach();
        }

        private void AddPriceButton_Click(object sender, EventArgs e)
        {
            _presenter.AddGiaSach();
        }

        private void DelPriceButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteGiaSach();
        }

        private void SavePriceButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveGiaSach();
        }

        private void sachModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.LoadGiasach();
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";// |All files (*.*)|*.*";//|(*.xls)|*.xls |
            saveDialog.RestoreDirectory = true;
            saveDialog.FileName = "Sach";
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

                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sach");
                    worksheet.Cells["A1"].Value = "DANH MỤC SÁCH";
                    worksheet.Cells["A1"].Style.Font.Size = 20;

                    worksheet.Cells[3, 1].Value = "STT";
                    worksheet.Cells[3, 2].Value = "Sách";
                    worksheet.Cells[3, 3].Value = "Tác giả";
                    worksheet.Cells[3, 4].Value = "Ngày xuất bản";
                    
                    int r = 4;
                    if (SachItems != null)
                        foreach (var row in SachItems)
                        {
                            worksheet.Cells[r, 1].Value = row.STT;
                            worksheet.Cells[r, 2].Value = row.TenSach;
                            worksheet.Cells[r, 3].Value = row.Tacgia;
                            worksheet.Cells[r, 4].Value = row.NgayXuatban != null ? row.NgayXuatban.Value.ToShortDateString() : "";
                            r++;
                        }

                    var cell = worksheet.Cells[3, 1, r - 1, 4];
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