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
    public partial class DiemdanhTrongngayForm : DevExpress.XtraEditors.XtraForm,IDiemdanhTrongngayView
    {
        DiemdanhTrongngayPresenter _presenter;
        public DiemdanhTrongngayForm()
        {
            InitializeComponent();
        }

        private void DiemdanhTrongngayForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new DiemdanhTrongngayPresenter(this);
            _presenter.LoadData();
            NamspinEdit.Value = DateTime.Now.Year;
            ThangcomboBox.SelectedValue = DateTime.Now.Month;
            DateTime now = DateTime.Now;
            while (now.DayOfWeek != DayOfWeek.Monday)
            {
                now = now.AddDays(-1);
            }
            TungaydateEdit.DateTime = now;
            DenngaydateEdit.DateTime = now.AddDays(6);
        }

        public List<LichhocDayhocModel> LichhocDayhocItems
        {
            get
            {
                return lichhocDayhocModelBindingSource.DataSource as List<LichhocDayhocModel>;
            }
            set
            {
                lichhocDayhocModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
            lichhocDayhocModelGridControl.RefreshDataSource();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        private void InDSButton_Click(object sender, EventArgs e)
        {
            //using (var f = new DiemdanhTreReport(LichhocDayhocItems, dateEdit.DateTime))
            //{
                //f.ShowPreviewDialog();
            //}
        }


        public DateTime Tungay
        {
            get { return TungaydateEdit.DateTime; }
        }

        public DateTime Denngay
        {
            get { return DenngaydateEdit.DateTime; }
        }

        public int Thang
        {
            get { return (int)ThangcomboBox.SelectedValue; }
        }

        public int Nam
        {
            get { return (int)NamspinEdit.Value; }
        }

        public List<NhanvienModel> NhanvienItems
        {
            set { nhanvienModelBindingSource.DataSource = value; }
        }

        public NhanvienModel NhanvienCurrent
        {
            get { return nhanvienModelBindingSource.Current as NhanvienModel; }
        }


        public List<ThangModel> ThangItems
        {
            set { thangModelBindingSource.DataSource = value; }
        }

        private void ThangcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ThangcomboBox.SelectedValue != null && NamspinEdit.Value != null && Nam != 0)
            {
                try
                {
                    TungaydateEdit.DateTime = new DateTime(Nam, Thang, Tungay.Day);
                    DenngaydateEdit.DateTime = new DateTime(Nam, Thang, Denngay.Day);
                }
                catch (Exception ex) { }
            }
        }
    }
}