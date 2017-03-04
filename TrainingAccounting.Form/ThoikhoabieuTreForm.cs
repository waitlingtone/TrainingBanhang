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
using DevExpress.XtraScheduler;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraScheduler.Printing;
using DevExpress.XtraPrinting;

namespace TrainingAccounting.Form
{
    public partial class ThoikhoabieuTreForm : DevExpress.XtraEditors.XtraForm, IThoikhoabieuTreView
    {
        ThoikhoabieuTrePresenter _presenter;
        private PhieubaoHocphiModel _phieubaoHocphi;
        private Guid? _buoihocDeleted;
        public ThoikhoabieuTreForm()
        {
            InitializeComponent();
        }

        private void ThoikhoabieuTreForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            NamspinEdit.Value = DateTime.Now.Year;
            _presenter = new ThoikhoabieuTrePresenter(this);
            _presenter.LoadData();
            ThangcomboBox.SelectedValue = DateTime.Now.Month;
            _presenter.GetLichhocByTre();
        }

        public List<ThangModel> ThangItems
        {
            set { thangModelBindingSource.DataSource = value; }
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

        public void RefreshData()
        {
            treModelGridControl.RefreshDataSource();
            schedulerControl1.RefreshData();
        }

        private void ThangcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ThangcomboBox.SelectedValue == null)
                return;
            DateTime first = new DateTime(Nam, (int)ThangcomboBox.SelectedValue, 1);
            DateTime nextFirst;
            if (first.Month == 12) nextFirst = new DateTime(first.Year + 1, 1, 1);
            else nextFirst = new DateTime(first.Year, (int)ThangcomboBox.SelectedValue + 1, 1);
            DateTime last = nextFirst.AddDays(-1);

            TungaydateEdit.DateTime = first;
            DenngaydateEdit.DateTime = last;
            NhomtrecomboBox_SelectedValueChanged(new object(), new EventArgs());
            _presenter.GetLichhocByTre();
        }

        private void TungaydateEdit_EditValueChanged(object sender, EventArgs e)
        {
            schedulerControl1.LimitInterval.Start = TungaydateEdit.DateTime;
            
        }

        private void DenngaydateEdit_EditValueChanged(object sender, EventArgs e)
        {
            schedulerControl1.LimitInterval.End = DenngaydateEdit.DateTime.AddDays(1);
        }

        private void NhomtrecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (NhomtreId == null)
                return;
            if (NhomtrecomboBox.SelectedIndex == 0)
                _presenter.GetAllTre();
            else
                _presenter.GetTreByNhomtre();
            treModelBindingSource_PositionChanged(new object(), new EventArgs());
        }


        public Guid? NhomtreId
        {
            get { return NhomtrecomboBox.SelectedValue as Guid?; }
        }

        private void treModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (TreCurrent == null) return;
            _presenter.GetLichhocByTre();
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


        public int Thang
        {
            get { return (int)ThangcomboBox.SelectedValue; }
        }

        public int Nam
        {
            get { return (int)NamspinEdit.Value; }
        }

        private void LapLichButton_Click(object sender, EventArgs e)
        {
            if (_presenter.TontaiDangkyLich())
            {
                if (!_presenter.TontaiNghihoc())
                {
                    if (_presenter.KiemtraTontaiPhieubaoHocphi())
                    {
                        if (!_presenter.KiemtraDadongHocphi())
                        {
                            DialogResult dr = XtraMessageBox.Show("Tạo lại lịch mới cho Trẻ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dr == System.Windows.Forms.DialogResult.Yes)
                            {
                                _presenter.UpdateLich();
                            }
                        }
                        else
                        {
                            DialogResult dr = XtraMessageBox.Show("Lịch học đã được tính học phí hoặc đã khóa. \nBạn không thể tạo lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        _presenter.LaplichNew();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Thời gian tạo lịch trùng với thời gian nghỉ học của trẻ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa tồn tại đăng ký lịch học của trẻ.\nVui lòng đăng ký lịch học cho trẻ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NhomtrecomboBox_SelectedValueChanged(new object(), new EventArgs());
        }


        public PhieubaoHocphiModel PhieubaoHocphi
        {
            get
            {
                return _phieubaoHocphi;
            }
            set
            {
                _phieubaoHocphi = value;
            }
        }


        public DateTime StartTime
        {
            get
            {
                return TungaydateEdit.DateTime;
            }
            set
            {
                TungaydateEdit.DateTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return DenngaydateEdit.DateTime;
            }
            set
            {
                DenngaydateEdit.DateTime = value;
            }
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            Appointment apt = e.Appointment;

            // Required to open the recurrence form via context menu.
            bool openRecurrenceForm = apt.IsRecurring && schedulerStorage1.Appointments.IsNewAppointment(apt);

            // Create a custom form.
            LichhocDayhocAppointmentForm myForm = new LichhocDayhocAppointmentForm((SchedulerControl)sender, apt, openRecurrenceForm, TreCurrent);

            try
            {
                // Required for skins support.
                myForm.LookAndFeel.ParentLookAndFeel = schedulerControl1.LookAndFeel;

                e.DialogResult = myForm.ShowDialog();
                schedulerControl1.Refresh();
                e.Handled = true;
                _presenter.GetLichhocByTre();
            }
            finally
            {
                myForm.Dispose();
            }
        }

        private void BosungLichButton_Click(object sender, EventArgs e)
        {
            using (var f = new BosungLichhocForm(TreCurrent, Thang, Nam))
            {
                f.ShowDialog();
            }
            treModelBindingSource_PositionChanged(new object(), new EventArgs());
        }

        private void schedulerStorage1_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
           
            for (int i = 0; i < schedulerControl1.SelectedAppointments.Count; i++)
            {
                Appointment apt = schedulerControl1.SelectedAppointments[i];
                _buoihocDeleted = apt.Id as Guid?;
                if (_presenter.DaDongtien())
                {
                    MessageBox.Show("Lịch học đã tính học phí hoặc đã khóa! \nVui lòng thiết lập vắng hợp lệ cho lịch học này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn muốn xóa buổi học này?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        e.Cancel = true;
                    else
                        _presenter.DeleteBuoihoc();
                }
            }
            
        }


        public Guid? BuoihocDeleted
        {
            get { return _buoihocDeleted; }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (TreCurrent == null)
                return;
            MonthlyPrintStyle style = schedulerControl1.PrintStyles[SchedulerPrintStyleKind.Monthly] as MonthlyPrintStyle;
            style.CalendarHeaderVisible = false;
            style.CompressWeekend = false;
            style.StartRangeDate = StartTime;
            style.EndRangeDate = EndTime;
            style.OneMonthPerPage = true;
            style.PageSettings.Landscape = true;

            printableComponentLink.PageHeaderFooter = new PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                String.Format("Họ tên trẻ: {0} {1}", TreCurrent.Hodem, TreCurrent.Ten) + "\r\n" +
                "Ngày sinh: " + TreCurrent.Ngaysinh.Value.ToShortDateString() + "\r\n" +
                "Tên thường gọi: " + TreCurrent.TenThuonggoi,
               "THỜI KHÓA BIỂU THÁNG " + Thang + "\r\n", DateTime.Now.ToString()
            }, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near), null);
            printableComponentLink.ClearDocument();
            printableComponentLink.Component = schedulerControl1;
            printableComponentLink.ShowPreviewDialog();
        }

        private void schedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e)
        {
            //e.Text = String.Format("{0}-{1}\r\n GV: {2}", e.Appointment.Start.ToShortTimeString(), e.Appointment.End.ToShortTimeString(), e.Appointment.Subject);
            e.Text = e.Appointment.Subject;
            
        }

        private void schedulerControl1_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            e.ViewInfo.Appearance.Font = new Font("Arial", 8, FontStyle.Regular);
        }

        private void NumspinEdit_EditValueChanged(object sender, EventArgs e)
        {
            schedulerControl1.Views.MonthView.WeekCount = (int)NumspinEdit.Value;
        }
    }
}