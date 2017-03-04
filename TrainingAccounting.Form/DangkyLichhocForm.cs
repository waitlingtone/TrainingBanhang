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

namespace TrainingAccounting.Form
{
    public partial class DangkyLichhocForm : DevExpress.XtraEditors.XtraForm, IDangkyLichhocView
    {
        DangkyLichhocPresenter _presenter;
        public DangkyLichhocForm()
        {
            InitializeComponent();
        }

        private void DangkyLichhocForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new DangkyLichhocPresenter(this);
            _presenter.LoadData();
        }

        public List<NhomTreModel> NhomtreItems
        {
            set { nhomTreModelBindingSource.DataSource = value; }
        }

        public List<TreModel> TreItems
        {
            set { treModelBindingSource.DataSource = value; }
        }

        public TreModel TreCurrent
        {
            get { return treModelBindingSource.Current as TreModel; }
        }

        public List<BangNgayhocTrongtuan> NgayhocTrongtuanItems
        {
            get
            {
                return bangNgayhocTrongtuanBindingSource.DataSource as List<BangNgayhocTrongtuan>;
            }
            set
            {
                bangNgayhocTrongtuanBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
            treModelGridControl.RefreshDataSource();
            bangNgayhocTrongtuanGridControl.RefreshDataSource();
            dangkyLichhocModelGridControl.RefreshDataSource();
        }


        public Guid? NhomtreId
        {
            get { return NhomtrecomboBox.SelectedValue as Guid?; }
        }

        private void NhomtrecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (NhomtreId == null)
                return;
            if (NhomtrecomboBox.SelectedIndex == 0)
                _presenter.GetAllTre();
            else
                _presenter.GetTreByNhomtre();
            treModelBindingSource_PositionChanged(new object(), new EventArgs()); //truong hop dang chon dong 1, loc ra chi co 1 dong
        }

        private void treModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetLichDangky();
        }

        private void SaveBangDKButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveDangky();
            XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public List<ThuModel> ThuItems
        {
            set { thuModelBindingSource.DataSource = value; }
        }

        private void AddCakhacButton_Click(object sender, EventArgs e)
        {
            _presenter.AddCakhac();
        }


        public List<DangkyLichhocModel> CakhacItems
        {
            get
            {
                return dangkyLichhocModelBindingSource.DataSource as List<DangkyLichhocModel>;
            }
            set
            {
                dangkyLichhocModelBindingSource.DataSource = value;
            }
        }

        private void DeleteCakhacButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteCakhac();
        }


        public DangkyLichhocModel CakhacCurrent
        {
            get { return dangkyLichhocModelBindingSource.Current as DangkyLichhocModel; }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            using (var f = new PhieuDangkyLichhocReport())
            {
                f.ShowPreviewDialog();
            }
        }
    }
}