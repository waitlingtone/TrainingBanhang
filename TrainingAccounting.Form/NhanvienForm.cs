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
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace TrainingAccounting.Form
{
    public partial class NhanvienForm : DevExpress.XtraEditors.XtraForm,INhanvienView
    {
        NhanvienPresenter _presenter;
        public NhanvienForm()
        {
            InitializeComponent();
        }

        private void NhanvienForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new NhanvienPresenter(this);
            _presenter.LoadData();
        }
        public List<NhanvienModel> NhanvienItems
        {
            get
            {
                return nhanvienModelBindingSource.DataSource as List<NhanvienModel>;
            }
            set
            {
                nhanvienModelBindingSource.DataSource = value;
            }
        }

        public NhanvienModel NhanvienCurrent
        {
            get { return nhanvienModelBindingSource.Current as NhanvienModel; }
        }

        public void RefreshData()
        {
            nhanvienModelGridControl.RefreshDataSource();
            luongNhanvienModelGridControl.RefreshDataSource();
        }

        private void AddNVButton_Click(object sender, EventArgs e)
        {
            _presenter.Add();
        }

        private void DeleteNVButton_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void SaveNVButton_Click(object sender, EventArgs e)
        {
            if (tenTextEdit.Text == "" || ngayBatdauLamDateEdit.Text == "" || condayCheckEdit.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _presenter.Save();
        }

        private void AddLuongButton_Click(object sender, EventArgs e)
        {
            _presenter.AddLuong();
        }


        public List<LuongNhanvienModel> LuongNhanvienItems
        {
            get
            {
                return luongNhanvienModelBindingSource.DataSource as List<LuongNhanvienModel>;
            }
            set
            {
                luongNhanvienModelBindingSource.DataSource = value;
            }
        }

        public LuongNhanvienModel LuongNhanvienCurrent
        {
            get { return luongNhanvienModelBindingSource.Current as LuongNhanvienModel; }
        }

        private void DeleteLuongButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteLuong();
        }

        private void SaveLuongButton_Click(object sender, EventArgs e)
        {
            foreach (var i in LuongNhanvienItems)
                if (i != LuongNhanvienCurrent && i.NgayApdung.Value.Equals(LuongNhanvienCurrent.NgayApdung.Value))
                {
                    XtraMessageBox.Show("Đã tồn tại thời điểm này, vui lòng chọn thời điểm khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            _presenter.SaveLuong();
        }

        private void nhanvienModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetLuongByNhanvien();
            barCodeControl.Refresh();
        }

        private void SudungItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.CheckUnCheck();
        }


        public List<NganhangModel> NganhangItems
        {
            set { nganhangModelBindingSource.DataSource = value; }
        }

        public List<ChinhanhNganhangModel> ChinhanhNganhangItems
        {
            set { chinhanhNganhangModelBindingSource.DataSource = value; }
        }

        private void nganhangIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (NganhangId == null)
                return;
            _presenter.GetChinhanh();
        }


        public Guid? NganhangId
        {
            get { return nganhangIdTextEdit.EditValue as Guid?; }
        }


        public bool ConHoatdong
        {
            get { return ConHoatdongcheckEdit.Checked; }
        }

        private void ConHoatdongcheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (_presenter != null)
                _presenter.LoadNhanvien();
            RefreshData();
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";// |All files (*.*)|*.*";//|(*.xls)|*.xls |
            saveDialog.RestoreDirectory = true;
            saveDialog.FileName = "Danh sach Nhan vien";
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

                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("DSNhanvien");
                    worksheet.Cells["A1"].Value = "DANH SÁCH NHÂN VIÊN";
                    worksheet.Cells["A1"].Style.Font.Size = 20;
                    if (ConHoatdong)
                        worksheet.Cells[4, 1].Value = "Tình trạng: Còn làm việc";
                    else
                        worksheet.Cells[4, 1].Value = "Tình trạng: Nghỉ làm việc";

                    worksheet.Cells[6, 1].Value = "STT";
                    worksheet.Cells[6, 2].Value = "Mã vạch";
                    worksheet.Cells[6, 3].Value = "Họ đệm";
                    worksheet.Cells[6, 4].Value = "Tên";
                    worksheet.Cells[6, 5].Value = "Giới tính";
                    worksheet.Cells[6, 6].Value = "Ngày sinh";
                    worksheet.Cells[6, 7].Value = "Địa chỉ";
                    worksheet.Cells[6, 8].Value = "Email";
                    worksheet.Cells[6, 9].Value = "Số điện thoại";
                    worksheet.Cells[6, 10].Value = "Ngân hàng";
                    worksheet.Cells[6, 11].Value = "Số tài khoản";
                    worksheet.Cells[6, 12].Value = "Loại";
                    worksheet.Cells[6, 13].Value = "Ngày bắt đầu làm";
                    int r = 7;
                    if (NhanvienItems != null)
                        foreach (var row in NhanvienItems)
                        {
                            worksheet.Cells[r, 1].Value = row.STT;
                            worksheet.Cells[r, 2].Value = row.Mavach;
                            worksheet.Cells[r, 3].Value = row.Hodem;
                            worksheet.Cells[r, 4].Value = row.Ten;
                            worksheet.Cells[r, 5].Value = row.TenGioitinh;
                            worksheet.Cells[r, 6].Value = row.Ngaysinh != null? row.Ngaysinh.Value.ToShortDateString():"";
                            worksheet.Cells[r, 7].Value = row.Diachi;
                            worksheet.Cells[r, 8].Value = row.Email;
                            worksheet.Cells[r, 9].Value = row.SoDT;
                            worksheet.Cells[r, 10].Value = row.TenNganhang;
                            worksheet.Cells[r, 11].Value = row.SoTaikhoan;
                            worksheet.Cells[r, 12].Value = row.Loai;
                            worksheet.Cells[r, 13].Value = row.NgayBatdauLam != null? row.NgayBatdauLam.Value.ToShortDateString():"";
                            r++;
                        }

                    var cell = worksheet.Cells[6, 1, r - 1, 13];
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