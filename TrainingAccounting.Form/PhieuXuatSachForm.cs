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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Report;

namespace TrainingAccounting.Form
{
    public partial class PhieuXuatSachForm : DevExpress.XtraEditors.XtraForm, IPhieuXuatSachView
    {
        PhieuXuatSachPresenter _presenter;
        private List<SachModel> _sachItems;
        public PhieuXuatSachForm()
        {
            InitializeComponent();
        }

        private void PhieuXuatSachForm_Load(object sender, EventArgs e)
        {
            _presenter = new PhieuXuatSachPresenter(this);
            _presenter.LoadData();
        }

        public List<SachModel> SachItems
        {
            set { sachModelBindingSource.DataSource = value; _sachItems = value; }
        }

        public List<PhieuXuatThuSachModel> PhieuXuatSachItems
        {
            get
            {
                return phieuXuatThuSachModelBindingSource.DataSource as List<PhieuXuatThuSachModel>;
            }
            set
            {
                phieuXuatThuSachModelBindingSource.DataSource = value;
            }
        }

        public PhieuXuatThuSachModel PhieuXuatSachCurrent
        {
            get { return phieuXuatThuSachModelBindingSource.Current as PhieuXuatThuSachModel; }
        }

        public List<ChitietPhieuXuatThuSachModel> ChitietItems
        {
            get
            {
                return chitietPhieuXuatThuSachModelBindingSource.DataSource as List<ChitietPhieuXuatThuSachModel>;
            }
            set
            {
                chitietPhieuXuatThuSachModelBindingSource.DataSource = value;
            }
        }

        public ChitietPhieuXuatThuSachModel ChitietCurrent
        {
            get { return chitietPhieuXuatThuSachModelBindingSource.Current as ChitietPhieuXuatThuSachModel; }
        }

        public void RefreshData()
        {
            phieuXuatThuSachModelGridControl.RefreshDataSource();
            chitietPhieuXuatThuSachModelGridControl.RefreshDataSource();
        }

        private void phieuXuatThuSachModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.LoadChitiet();
            if(PhieuXuatSachCurrent != null)
                if (PhieuXuatSachCurrent.Trangthai.Value == true)
                {
                    AddSachButton.Enabled = false;
                    DelSachButton.Enabled = false;
                    SaveSachButton.Enabled = false;
                    XuatButton.Enabled = false;
                }
                else
                {
                    AddSachButton.Enabled = true;
                    DelSachButton.Enabled = true;
                    SaveSachButton.Enabled = true;
                    XuatButton.Enabled = true;
                }
        }

        private void AddPhieuButton_Click(object sender, EventArgs e)
        {
            _presenter.AddPhieu();
        }

        private void DelPhieuButton_Click(object sender, EventArgs e)
        {
            _presenter.DeletePhieu();
        }

        private void SavePhieuButton_Click(object sender, EventArgs e)
        {
            _presenter.SavePhieu();
        }

        private void AddSachButton_Click(object sender, EventArgs e)
        {
            _presenter.AddChitietSach();
        }

        private void DelSachButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteChitietSach();
        }

        private void SaveSachButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveChitietSach();
        }

        private void repositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit look = (LookUpEdit)sender;
            foreach (var i in _sachItems)
                if (i.SachId == ChitietCurrent.SachId)
                {
                    ChitietCurrent.Dongia = i.Dongia;
                    break;
                }
            RefreshData();
        }

        private void PrintChitietButton_Click(object sender, EventArgs e)
        {
            if (PhieuXuatSachCurrent == null)
                return;
            using (var f = new PhieuXuatSachReport(PhieuXuatSachCurrent))
            {
                f.ShowPreviewDialog();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _presenter.UpdateTien();
        }

        private void XuatButton_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn sẽ không thể chỉnh sửa phiếu xuất, Chọn chốt phiếu?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                _presenter.Xuatphieu();
                phieuXuatThuSachModelBindingSource_PositionChanged(new object(), new EventArgs());
                XtraMessageBox.Show("Đã chốt phiếu xuất, bạn không thể chỉnh sửa.", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}