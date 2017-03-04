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

namespace TrainingAccounting.Form
{
    public partial class PhieubaoLuongNhanvienForm : DevExpress.XtraEditors.XtraForm, IPhieubaoLuongNhanvienView
    {
        PhieubaoLuongNhanvienPresenter _presenter;
        private DaumucThuchiModel _daumucThuchi;
        public PhieubaoLuongNhanvienForm()
        {
            InitializeComponent();
        }

        private void PhieubaoLuongNhanvienForm_Load(object sender, EventArgs e)
        {
            _presenter = new PhieubaoLuongNhanvienPresenter(this);
            _presenter.LoadData();
            ThangcomboBox.SelectedValue = DateTime.Now.Month;
            NamspinEdit.Value = DateTime.Now.Year;
            _presenter.GetNhanvien();
        }

        public List<ThangModel> ThangItems
        {
            set { thangModelBindingSource.DataSource = value; }
        }

        public int Thang
        {
            get { return (int)ThangcomboBox.SelectedValue; }
        }

        public int Nam
        {
            get { return (int)NamspinEdit.Value; }
        }

        public List<DanhmucTraluongNhanvienModel> DanhmucTraluongItems
        {
            set { danhmucTraluongNhanvienModelBindingSource.DataSource = value; }
        }

        public List<PhieubaoLuong> PhieubaoLuong
        {
            set { phieubaoLuongBindingSource.DataSource = value; }
        }
        public void RefreshData()
        {
            phieubaoLuongNhanvienModelGridControl.RefreshDataSource();
            chitietPhieubaoLuongNhanvienModelGridControl.RefreshDataSource();
            phieubaoLuongGridControl.RefreshDataSource();
        }

        private void phieubaoluongModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetPhieubaoLuong();
            _presenter.TinhLuong();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            _presenter.GetNhanvien();
            _presenter.GetPhieubaoLuong();
            _presenter.TinhLuong();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.AddDanhmuc();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteDanhmuc();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach(var i in ChitietPhieubaoLuongItems)
                if (i.Ma == null)
                {
                    XtraMessageBox.Show("Mã Lương không được trắng", "Thông báo");
                    return;
                }
            _presenter.SaveDanhmuc();
            _presenter.GetNhanvien();
            RefreshData();
        }




        public List<DanhmucTraluongNhanvienModel> DanhmucLuongSelectedItems
        {
            get 
            {
                List<DanhmucTraluongNhanvienModel> tmp = new List<DanhmucTraluongNhanvienModel>();
                for (int i = 0; i < DanhmucLuongcheckedComboBox.Properties.Items.Count; i++)
                    if (DanhmucLuongcheckedComboBox.Properties.Items[i].CheckState == CheckState.Checked)
                        tmp.Add(new DanhmucTraluongNhanvienModel { Ma = DanhmucLuongcheckedComboBox.Properties.Items[i].Value.ToString(), Ten = DanhmucLuongcheckedComboBox.Properties.Items[i].Description });
                return tmp;
            }
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            if (PhieubaoLuongCurrent == null) return;
            using (var f = new PhieubaoLuongReport(PhieubaoLuongCurrent, Thang, Nam, phieubaoLuongBindingSource.DataSource as List<PhieubaoLuong>,
                chitietPhieubaoLuongNhanvienModelBindingSource.DataSource as List<ChitietPhieubaoLuongNhanvienModel>))
            {
                f.ShowPreviewDialog();
            }
        }


        public PhieubaoLuongNhanvienModel PhieubaoLuongCurrent
        {
            get
            {
                return phieubaoLuongNhanvienModelBindingSource.Current as PhieubaoLuongNhanvienModel; ;
            }
        }

        public List<ChitietPhieubaoLuongNhanvienModel> ChitietPhieubaoLuongItems
        {
            get
            {
                return chitietPhieubaoLuongNhanvienModelBindingSource.DataSource as List<ChitietPhieubaoLuongNhanvienModel>;
            }
            set
            {
                chitietPhieubaoLuongNhanvienModelBindingSource.DataSource = value;
            }
        }

        public ChitietPhieubaoLuongNhanvienModel ChitietPhieubaoLuongCurrent
        {
            get { return chitietPhieubaoLuongNhanvienModelBindingSource.Current as ChitietPhieubaoLuongNhanvienModel; }
        }

        private void ThanhtoanButton_Click(object sender, EventArgs e)
        {
            if (PhieubaoLuongCurrent == null)
                return;
            using (var f = new DanhmucChiForm())
            {
                f.ShowDialog();
                if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this._daumucThuchi = f.DaumucChi;
                    _presenter.Thanhtoan();
                    MessageBox.Show("Thanh toán thành công", "Thông báo");
                    _presenter.GetNhanvien();
                    _presenter.GetPhieubaoLuong();
                }
            }
        }

        private void ChuyenTKButton_Click(object sender, EventArgs e)
        {
            if (PhieubaoLuongCurrent == null)
                return;
            using (var f = new BangluongChuyenKhoanForm(PhieubaoLuongCurrent, Thang, Nam))
            {
                f.ShowDialog();
            }
        }


        public DaumucThuchiModel DaumucThuchi
        {
            get { return _daumucThuchi; }
        }

        public bool DaThanhtoan
        {
            set
            {
                if (value)
                {
                    ThanhtoanButton.Enabled = false;
                    AddButton.Enabled = false;
                    DeleteButton.Enabled = false;
                    SaveButton.Enabled = false;
                }
                else
                {
                    ThanhtoanButton.Enabled = true;
                    AddButton.Enabled = true;
                    DeleteButton.Enabled = true;
                    SaveButton.Enabled = true;
                }
            }
        }

        public string Msg
        {
            set { ThongbaomemoEdit.Text = value; }
        }

        public List<PhieubaoLuongNhanvienModel> PhieubaoLuongItems
        {
            get { return phieubaoLuongNhanvienModelBindingSource.DataSource as List<PhieubaoLuongNhanvienModel>; }
            set { phieubaoLuongNhanvienModelBindingSource.DataSource = value; }
        }

        private void TinhLuongButton_Click(object sender, EventArgs e)
        {
            _presenter.TinhAllLuong();
            ReloadButton.PerformClick();
        }

        private void PrintDSButton_Click(object sender, EventArgs e)
        {
            using (var f = new DanhsachLuongNhanvienReport(Thang, Nam))
            {
                f.ShowPreviewDialog();
            }
        }

        private void BosungButton_Click(object sender, EventArgs e)
        {
            using (var f = new BosungLuongNhanvienForm(Thang, Nam))
            {
                f.ShowDialog();
                ReloadButton.PerformClick();
            }
        }

        private void NhanvienCurrentbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PhieubaoLuongCurrent == null)
                return;
            using (var f = new BangluongChuyenKhoanForm(PhieubaoLuongCurrent, Thang, Nam))
            {
                f.ShowDialog();
            }
        }

        private void NhanvienAllbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PhieubaoLuongItems == null)
                return;
            using (var f = new BangluongChuyenKhoanForm(PhieubaoLuongItems, Thang, Nam))
            {
                f.ShowDialog();
            }
        }
    }
}