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

namespace TrainingAccounting.Form
{
    public partial class TonghopDanhsachTreDangkyHocForm : DevExpress.XtraEditors.XtraForm, ITonghopDanhsachTreDangkyHocView
    {
        TonghopDanhsachTreDangkyHocPresenter _presenter;
        public TonghopDanhsachTreDangkyHocForm()
        {
            InitializeComponent();
        }

        public DateTime StartDate
        {
            get
            {
                return StartdateEdit.DateTime;
            }
            set
            {
                StartdateEdit.DateTime = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return EnddateEdit.DateTime;
            }
            set
            {
                EnddateEdit.DateTime = value;
            }
        }

        public List<LichhocDayhocModel> LichhocDayhocItems
        {
            
            set
            {
                lichhocDayhocModelBindingSource.DataSource = value;
            }
        }

        public List<ThangModel> ThangItems
        {
            set { thangModelBindingSource.DataSource = value; }
        }

        public void RefreshData()
        {
            schedulerControl1.RefreshData();
        }

        private void TonghopDanhsachTreDangkyHocForm_Load(object sender, EventArgs e)
        {
            _presenter = new TonghopDanhsachTreDangkyHocPresenter(this);
            _presenter.LoadData();
            ThangcomboBox.SelectedValue = DateTime.Now.Month;
            NamspinEdit.EditValue = DateTime.Now.Year;

            
        }

        private void TaiButton_Click(object sender, EventArgs e)
        {
            _presenter.TaiDanhsach();
        }

        private void schedulerControl1_InitAppointmentDisplayText(object sender, DevExpress.XtraScheduler.AppointmentDisplayTextEventArgs e)
        {
            e.Text = e.Appointment.Subject;
        }

        private void NumspinEdit_EditValueChanged(object sender, EventArgs e)
        {
            schedulerControl1.Views.MonthView.WeekCount = (int)NumspinEdit.Value;
        }



        public int Thang
        {
            get
            { 
                if(ThangcomboBox.SelectedValue != null) 
                    return (int)ThangcomboBox.SelectedValue;
                return 1;
            }
        }

        public int Nam
        {
            get 
            {  
                if(NamspinEdit.Value != 0)
                    return (int)NamspinEdit.Value;
                return 2014;
            }
        }

        private void ThangcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime first = new DateTime(Nam, Thang, 1);
            DateTime nextFirst;
            if (first.Month == 12) nextFirst = new DateTime(first.Year + 1, 1, 1);
            else nextFirst = new DateTime(first.Year, Thang + 1, 1);
            DateTime last = nextFirst.AddDays(-1);

            StartdateEdit.DateTime = first;
            EnddateEdit.DateTime = last;
            schedulerControl1.LimitInterval.Start = StartdateEdit.DateTime;
            schedulerControl1.LimitInterval.End = EnddateEdit.DateTime;
            
        }
    }
}