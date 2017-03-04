using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using TrainingAccounting.View;
using TrainingAccounting.Model.BusinessObject;
using DevExpress.XtraScheduler.UI;
using TrainingAccounting.Presenter;

namespace TrainingAccounting.Form
{
    public partial class LichhocDayhocAppointmentForm : DevExpress.XtraEditors.XtraForm, ILichhocDayhocAppointmentView
    {
        LichhocDayhocAppointmentPresenter _presenter;
        private Appointment apt;
        private bool openRecurrenceForm;
        private TreModel _treItems;
        private MyAppointmentFormController controller;
        private NhanvienModel _nhanvien;
        private bool _laplai = false;
        private List<NDGiangdayModel> _nDGiangdaySelected;

        public LichhocDayhocAppointmentForm(SchedulerControl schedulerControl, Appointment apt, bool openRecurrenceForm, TreModel TreItem)
        {
            InitializeComponent();
            this.controller = new MyAppointmentFormController(schedulerControl, apt);
            this.apt = apt;
            this.openRecurrenceForm = openRecurrenceForm;
            this._treItems = TreItem;
            UpdateForm();
            _presenter = new LichhocDayhocAppointmentPresenter(this);
            _presenter.LoadData();
            _presenter.GetNhanvien();
            if(_nhanvien != null)
                GiaovientextEdit.Text = String.Format("{0} {1}", _nhanvien.Hodem, _nhanvien.Ten);
        }
        void UpdateForm()
        {
            
            try
            {
                TretextEdit.Text = String.Format("{0} {1}", _treItems.Hodem, _treItems.Ten);
                dateEdit.DateTime = controller.DisplayStart;
                StarttimeEdit.Time = new DateTime(controller.DisplayStart.TimeOfDay.Ticks);
                EndtimeEdit.Time = new DateTime(controller.DisplayEnd.TimeOfDay.Ticks);
                //String a = controller.ResourceId.ToString();
                if (!controller.ResourceId.ToString().Equals("DevExpress.XtraScheduler.Native.EmptyResource"))
                    GhichumemoEdit.Text = controller.ResourceId.ToString();
            }
            finally
            {
            }
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
        public TreModel TreItem
        {
            get { return _treItems; }
        }

        public void RefreshData()
        {
            nhanvienModelGridControl.RefreshDataSource();
        }


        public DateTime StartTine
        {
            get { return controller.DisplayStart; }
        }

        public DateTime EndTine
        {
            get { return controller.DisplayEnd; }
        }

        private void GVItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit chk = (CheckEdit)sender;
            if (chk.CheckState == CheckState.Checked)
            {
                List<LichhocDayhocModel> lst = _presenter.GetTreCungCahoc();
                if (lst.Count != 0)
                {
                    string msg = "";
                    foreach (var i in lst)
                        msg += "Giáo viên dạy trẻ " + i.TenTre + ", giờ học: " + i.Text3 + "\n";
                    msg += "\nGhép ca cho trẻ này?";
                    if (XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        isCaghep = true;
                    }
                    else
                        isCaghep = false;
                }
                else
                {
                    isCaghep = false;
                }
            }
            _presenter.Check();
            RefreshData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Lặp lại phân công giáo viên cho các tuần khác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                _laplai = true;
            else
                _laplai = false;
            _presenter.SavePhanGiaovien();
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (_nhanvien != null)
                GiaovientextEdit.Text = String.Format("{0} {1}", _nhanvien.Hodem, _nhanvien.Ten);
        }


        public Guid? LichhocDayhocId
        {
            get { return apt.Id as Guid?; }
        }


        public Guid? NhanvienId
        {
            get {
                if (apt.Description != null && apt.Description.Length == 36)
                    return new Guid(apt.Description);
                else return null;
            }
        }


        public NhanvienModel Nhanvien
        {
            get
            {
                return _nhanvien;
            }
            set
            {
                _nhanvien = value;
            }
        }


        public bool Laplai
        {
            get { return _laplai; }
        }

        private void GetOrderGiaovien_Click(object sender, EventArgs e)
        {
            _presenter.GetOrderGiaovien();
        }

        private void GetGiaovienKhoplichButton_Click(object sender, EventArgs e)
        {
            _presenter.LoadData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string Ghichu
        {
            get { return GhichumemoEdit.Text; }
        }

        private void NoidungButton_Click(object sender, EventArgs e)
        {
            using (var f = new ChonNoidungForm(LichhocDayhocId.Value))
            {
                f.ShowDialog();
                if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    _nDGiangdaySelected = f._nDGiangdaySelected;
                    string nd = "";
                    foreach (var i in _nDGiangdaySelected)
                        nd += i.Noidung + "; ";
                    GhichumemoEdit.Text = nd;
                }
            }
        }


        public List<NDGiangdayModel> NDGiangdaySelected
        {
            get { return _nDGiangdaySelected; }
        }


        public bool isCaghep
        {
            get { return IsCaghepcheckEdit.Checked; }
            set { IsCaghepcheckEdit.Checked = value; }
        }

        private void SaveNoidungButton_Click(object sender, EventArgs e)
        {
            _presenter.UpdateGhichu();
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class MyAppointmentFormController : AppointmentFormController
    {

        public string CustomName { get { return (string)EditedAppointmentCopy.CustomFields["CustomName"]; } set { EditedAppointmentCopy.CustomFields["CustomName"] = value; } }
        public string CustomStatus { get { return (string)EditedAppointmentCopy.CustomFields["CustomStatus"]; } set { EditedAppointmentCopy.CustomFields["CustomStatus"] = value; } }

        string SourceCustomName { get { return (string)SourceAppointment.CustomFields["CustomName"]; } set { SourceAppointment.CustomFields["CustomName"] = value; } }
        string SourceCustomStatus { get { return (string)SourceAppointment.CustomFields["CustomStatus"]; } set { SourceAppointment.CustomFields["CustomStatus"] = value; } }

        public MyAppointmentFormController(SchedulerControl control, Appointment apt)
            : base(control, apt)
        {
        }

        public override bool IsAppointmentChanged()
        {
            if (base.IsAppointmentChanged())
                return true;
            return SourceCustomName != CustomName ||
                SourceCustomStatus != CustomStatus;
        }
    }
}