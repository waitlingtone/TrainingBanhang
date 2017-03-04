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
using TrainingAccounting.Report;
using DevExpress.XtraReports.UI;

namespace TrainingAccounting.Form
{
    public partial class DangkyLichdayForm : DevExpress.XtraEditors.XtraForm, IDangkyLichdayView
    {
        DangkyLichdayPresenter _presenter;
        public DangkyLichdayForm()
        {
            InitializeComponent();
        }

        private void DangkyLichdayForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new DangkyLichdayPresenter(this);
            _presenter.LoadData();
        }

        public List<NhanvienModel> NhanvienItems
        {
            set { nhanvienModelBindingSource.DataSource = value; }
        }

        public NhanvienModel NhanvienCurrent
        {
            get { return nhanvienModelBindingSource.Current as NhanvienModel; }
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

        public List<DangkyLichdayModel> CakhacItems
        {
            get
            {
                return dangkyLichdayModelBindingSource.DataSource as List<DangkyLichdayModel>;
            }
            set
            {
                dangkyLichdayModelBindingSource.DataSource = value;
            }
        }

        public DangkyLichdayModel CakhacCurrent
        {
            get { return dangkyLichdayModelBindingSource.Current as DangkyLichdayModel; }
        }

        public List<ThuModel> ThuItems
        {
            set { thuModelBindingSource.DataSource = value; }
        }

        public void RefreshData()
        {
            nhanvienModelGridControl.RefreshDataSource();
            dangkyLichdayModelGridControl.RefreshDataSource();
        }

        private void nhanvienModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetLichDangky();
        }

        private void AddDangkyButton_Click(object sender, EventArgs e)
        {
            _presenter.AddCakhac();
        }

        private void DeleteDangkyButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteCakhac();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveDangky();
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            using (var f = new PhieuDangkyLichdayReport())
            {
                f.ShowPreviewDialog();
            }
        }
    }
}