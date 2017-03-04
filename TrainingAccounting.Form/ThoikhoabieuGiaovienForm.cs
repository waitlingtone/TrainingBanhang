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
using DevExpress.XtraScheduler.Printing;
using DevExpress.XtraPrinting;

namespace TrainingAccounting.Form
{
    public partial class ThoikhoabieuGiaovienForm : DevExpress.XtraEditors.XtraForm, IThoikhoabieuGiaovienView
    {
        ThoikhoabieuGiaovienPresenter _presenter;
        public ThoikhoabieuGiaovienForm()
        {
            InitializeComponent();
        }

        private void ThoikhoabieuGiaovienForm_Load(object sender, EventArgs e)
        {
            _presenter = new ThoikhoabieuGiaovienPresenter(this);
            _presenter.LoadData();
            NamspinEdit.Value = DateTime.Now.Year;
            ThangcomboBox.SelectedValue = DateTime.Now.Month;
            _presenter.GetNhanvien();
        }

        public List<ThangModel> ThangItems
        {
            set { thangModelBindingSource.DataSource = value; }
        }

        public List<NhanvienModel> NhanvienItems
        {
            set { nhanvienModelBindingSource.DataSource = value; }
        }

        public NhanvienModel NhanvienCurrent
        {
            get { return nhanvienModelBindingSource.Current as NhanvienModel; }
        }

        public List<LichhocDayhocModel> LichhocDayhocItems
        {
            set { lichhocDayhocModelBindingSource.DataSource = value; }
        }


        public int Thang
        {
            get { return (int)ThangcomboBox.SelectedValue; }
        }

        public int Nam
        {
            get { return (int)NamspinEdit.Value; }
        }
        public void RefreshData()
        {
            nhanvienModelGridControl.RefreshDataSource();
            schedulerControl1.RefreshData();
        }

        private void ThangcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ThangcomboBox.SelectedValue == null)
                return;
            DateTime first = new DateTime(DateTime.Now.Year, (int)ThangcomboBox.SelectedValue, 1);
            DateTime nextFirst;
            if (first.Month == 12) nextFirst = new DateTime(first.Year + 1, 1, 1);
            else nextFirst = new DateTime(first.Year, (int)ThangcomboBox.SelectedValue + 1, 1);
            DateTime last = nextFirst.AddDays(-1);

            schedulerControl1.LimitInterval.Start = first;
            schedulerControl1.LimitInterval.End = last;
        }

        private void nhanvienModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetLichday();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            _presenter.GetNhanvien();
            _presenter.GetLichday();
        }

        private void schedulerControl1_InitAppointmentDisplayText(object sender, DevExpress.XtraScheduler.AppointmentDisplayTextEventArgs e)
        {
            e.Text = e.Appointment.Subject;
            //e.Text = String.Format("{0}-{1}\r\n Trẻ: {2}", e.Appointment.Start.ToShortTimeString(), e.Appointment.End.ToShortTimeString(), e.Appointment.Subject);
        }

        private void InLichButton_Click(object sender, EventArgs e)
        {
            if (NhanvienCurrent == null)
                return;
            DateTime first = new DateTime(Nam, (int)ThangcomboBox.SelectedValue, 1);
            DateTime nextFirst;
            if (first.Month == 12) nextFirst = new DateTime(first.Year + 1, 1, 1);
            else nextFirst = new DateTime(first.Year, (int)ThangcomboBox.SelectedValue + 1, 1);
            DateTime last = nextFirst.AddDays(-1);

            MonthlyPrintStyle style = schedulerControl1.PrintStyles[SchedulerPrintStyleKind.Monthly] as MonthlyPrintStyle;
            style.CalendarHeaderVisible = false;
            style.CompressWeekend = false;
            style.StartRangeDate = first;
            style.EndRangeDate = last;
            style.OneMonthPerPage = true;
            style.PageSettings.Landscape = true;

            printableComponentLink.PageHeaderFooter = new PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                String.Format("Nhân viên: {0} {1}", NhanvienCurrent.Hodem, NhanvienCurrent.Ten) + "\r\n",
                "LỊCH DẠY THÁNG " + Thang + "\r\n", DateTime.Now.ToString()
            }, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near), null);
            printableComponentLink.ClearDocument();
            printableComponentLink.Component = schedulerControl1;
            printableComponentLink.ShowPreviewDialog();
        }

        private void NumspinEdit_EditValueChanged(object sender, EventArgs e)
        {
            schedulerControl1.Views.MonthView.WeekCount = (int)NumspinEdit.Value;
        }

    }
}