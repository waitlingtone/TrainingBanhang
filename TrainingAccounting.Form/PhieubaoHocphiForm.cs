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
using TrainingAccounting.Report;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Localization;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace TrainingAccounting.Form
{
    public partial class PhieubaoHocphiForm : DevExpress.XtraEditors.XtraForm, IPhieubaoHocphiView
    {
        PhieubaoHocphiPresenter _presenter;
        private DaumucThuchiModel _daumucThuchi;
        public PhieubaoHocphiForm()
        {
            InitializeComponent();
        }

        private void PhieubaoHocphiForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new PhieubaoHocphiPresenter(this);
            _presenter.LoadData();
            ThangcomboBox.SelectedValue = DateTime.Now.Month;
            NamspinEdit.EditValue = DateTime.Now.Year;
            _presenter.GetTre();
        }

        public List<ThangModel> ThangItems
        {
            set { thangModelBindingSource.DataSource = value; }
        }

        public int Thang
        {
            get 
            {
                if (ThangcomboBox.SelectedValue != null)
                    return (int)ThangcomboBox.SelectedValue;
                else
                    return 0;
            }
        }

        public int Nam
        {
            get 
            {
                if (NamspinEdit.Text != null)
                    return int.Parse(NamspinEdit.Text);
                else
                    return 0;
            }
        }

        public void RefreshData()
        {
            phieubaoHocphiGridControl.RefreshDataSource();
        }

        private void LocButton_Click(object sender, EventArgs e)
        {

        }

        public List<PhieubaoHocphiModel> DanhsachTreItems
        {
            set { phieubaoHocphiModelBindingSource.DataSource = value; }
        }

        public PhieubaoHocphiModel PhieubaoHocphiCurrent
        {
            get { return phieubaoHocphiModelBindingSource.Current as PhieubaoHocphiModel; }
        }


        private void ReloadButton_Click(object sender, EventArgs e)
        {
            _presenter.GetTre();
            _presenter.GetHocphiByTre();
        }


        public List<PhieubaoHocphi> PhieubaoHocphiItems
        {
            get
            {
                return phieubaoHocphiBindingSource.DataSource as List<PhieubaoHocphi>;
            }
            set
            {
                phieubaoHocphiBindingSource.DataSource = value;
            }
        }

        private void XemChitietButton_Click(object sender, EventArgs e)
        {
            using (var f = new ChitietPhieubaoHocphiForm(PhieubaoHocphiCurrent, Thang, Nam))
            {
                f.ShowDialog();
            }
        }

        private void InbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new PhieubaoHocphiReport(PhieubaoHocphiCurrent, Thang, Nam, phieubaoHocphiBindingSource.DataSource as List<PhieubaoHocphi>))
            {
                f.ShowPreviewDialog();
            }
        }

        private void InChitietbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new ChitietPhieubaoHocphiReport(PhieubaoHocphiCurrent, Thang, Nam))
            {
                f.ShowPreviewDialog();
            }
        }

        private void DathuHocphibarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void GhinobarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //_presenter.GhinoHocphi();
            //XtraMessageBox.Show("Đã chốt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //_presenter.GetTre();
            //_presenter.GetHocphiByTre();
        }


        public DaumucThuchiModel DaumucThuchi
        {
            get { return _daumucThuchi; }
        }


        public bool DaKhoa
        {
            set
            {
                if (value)
                {
                    UpdateDongiaCurentbarButtonItem.Enabled = false;
                    TinhHocphiCurrentbarButtonItem.Enabled = false;
                }
                else
                {
                    UpdateDongiaCurentbarButtonItem.Enabled = true;
                    TinhHocphiCurrentbarButtonItem.Enabled = true;
                }
            }
        }
        public bool DaDong
        {
            set
            {
                if (value)
                {
                    ThanhtoanButton.Enabled = false;
                }
                else
                {
                    ThanhtoanButton.Enabled = true;
                }
            }
        }
        public string Msg
        {
            set { ThongbaomemoEdit.Text = value; }
        }

        private void phieubaoHocphiModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetHocphiByTre();
        }

        private void PrintDSButton_Click(object sender, EventArgs e)
        {
            using (var f = new DanhsachHocphiTreReport(phieubaoHocphiModelBindingSource.DataSource as List<PhieubaoHocphiModel>, Thang, Nam))
            {
                f.ShowPreviewDialog();
            }
        }

        private void PrintAllButton_Click(object sender, EventArgs e)
        {
            using (var f = new AllPhieubaoHocphiReport(Thang, Nam))
            {
                f.ShowPreviewDialog();
            }
        }

        private void CapnhatDanhsachButton_Click(object sender, EventArgs e)
        {
            using (var f = new CapnhatDanhsachTreCoHocphiForm(Thang, Nam))
            {
                f.ShowDialog();
                ReloadButton.PerformClick();
            }
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            if (PhieubaoHocphiCurrent == null)
                return;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";// |All files (*.*)|*.*";//|(*.xls)|*.xls |
            saveDialog.RestoreDirectory = true;
            saveDialog.FileName = "Phieu bao Hoc phi_" + String.Format("{0} {1}-{2}-{3}", PhieubaoHocphiCurrent.Hodem, PhieubaoHocphiCurrent.Ten, Thang, Nam);
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

                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Hocphi");
                    worksheet.Cells["A1"].Value = "PHIẾU BÁO HỌC PHÍ TRẺ";
                    worksheet.Cells["A1"].Style.Font.Size = 20;
                    worksheet.Cells[3, 1].Value = "Tháng: "+ String.Format("{0}-{1}", Thang, Nam);
                    worksheet.Cells[4, 1].Value = "Tên trẻ: " + String.Format("{0} {1}", PhieubaoHocphiCurrent.Hodem, PhieubaoHocphiCurrent.Ten);
                    worksheet.Cells[5, 1].Value = "Ngày sinh: " + String.Format("{0}", PhieubaoHocphiCurrent.Ngaysinh.ToShortDateString());
                    worksheet.Cells[6, 1].Value = "Phụ huynh: " + String.Format("{0}", PhieubaoHocphiCurrent.Phuhuynh);
                    worksheet.Cells[8, 1].Value = "Bảng kê chi tiết";

                    worksheet.Cells[9, 1].Value = "STT";
                    worksheet.Cells[9, 2].Value = "Tháng";
                    worksheet.Cells[9, 3].Value = "Thứ";
                    worksheet.Cells[9, 4].Value = "Ngày";
                    worksheet.Cells[9, 5].Value = "Thời gian";
                    worksheet.Cells[9, 6].Value = "Số giờ";
                    worksheet.Cells[9, 7].Value = "Số buổi";
                    worksheet.Cells[9, 8].Value = "Tổng giờ";
                    worksheet.Cells[9, 9].Value = "Đơn giá";
                    worksheet.Cells[9, 10].Value = "Tổng tiền";
                    int r = 10;
                    double tong = 0;
                    if (PhieubaoHocphiItems != null)
                        foreach (var row in PhieubaoHocphiItems)
                        {
                            worksheet.Cells[r, 1].Value = row.STT;
                            worksheet.Cells[r, 2].Value = row.Thang;
                            worksheet.Cells[r, 3].Value = row.SThu;
                            worksheet.Cells[r, 4].Value = row.Ngay;
                            worksheet.Cells[r, 5].Value = row.Thoigian;
                            worksheet.Cells[r, 6].Value = row.Sogio;
                            worksheet.Cells[r, 7].Value = row.Sobuoi;
                            worksheet.Cells[r, 8].Value = row.Tonggio;
                            worksheet.Cells[r, 9].Value = row.Dongia;
                            worksheet.Cells[r, 10].Value = row.Tongtien;
                            tong += row.Tongtien;
                            r++;
                        }
                    worksheet.Cells[r, 8].Value = "Tổng thanh toán:";
                    worksheet.Cells[r, 10].Value = tong;
                    worksheet.Cells[10, 9, r-1, 9].Style.Numberformat.Format = "#,#";
                    worksheet.Cells[10, 10, r, 10].Style.Numberformat.Format = "#,#";
                    var cell = worksheet.Cells[9, 1, r - 1, 10];
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

        private void UnblockCurrentbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.UnblockCurent();
            XtraMessageBox.Show("Đã mở khóa học phí cho trẻ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadButton.PerformClick();
        }

        private void UnblockAllbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.UnblockAll();
            XtraMessageBox.Show("Đã mở khóa học phí cho tất cả các trẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadButton.PerformClick();
        }

        private void UpdateDongiaCurentbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            float dongia = _presenter.GetDongiaHocphi();
            if (XtraMessageBox.Show("Đơn giá học phí của trẻ là " + dongia.ToString() + "\nCập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _presenter.UpdateDongiaCurrent();
                XtraMessageBox.Show("Cập nhật đơn giá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ReloadButton.PerformClick();
        }

        private void UpdateDongiaAllbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Học phí của trẻ phải ở trạng thái chưa khóa." + "\nMở khóa tất cả học phí?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                UnblockAllbarButtonItem.PerformClick();
                _presenter.UpdateDongiaAll();
                XtraMessageBox.Show("Cập nhật đơn giá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ReloadButton.PerformClick();
        }

        private void ThanhtoanButton_Click(object sender, EventArgs e)
        {
            using (var f = new DanhmucThuForm())
            {
                f.ShowDialog();
                if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this._daumucThuchi = f.DaumucThu;
                    if (this._daumucThuchi != null)
                    {
                        _presenter.UpdateDaThanhtoan();
                        XtraMessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _presenter.GetTre();
                        _presenter.GetHocphiByTre();
                    }
                    else
                        XtraMessageBox.Show("Vui lòng chọn mục Thu học phí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TinhHocphiAllButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Tính học phí sẽ khóa các nghiệp vụ phát sinh học phí trong tháng này!" + "\nTính học phí?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (XtraMessageBox.Show("Học phí của trẻ phải ở trạng thái chưa khóa." + "\nMở khóa tất cả học phí?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    _presenter.TinhAllHocphi();
                    XtraMessageBox.Show("Đã tính xong học phí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ReloadButton.PerformClick();
            }
        }

        private void TinhHocphiCurrentbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Tính học phí sẽ khóa các nghiệp vụ phát sinh học phí trong tháng này!" + "\nTính học phí?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _presenter.TinhHocphiCurrent();
                XtraMessageBox.Show("Đã tính xong học phí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadButton.PerformClick();
            }
        }


        
    }
}