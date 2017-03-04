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
    public partial class BosungLichhocForm : DevExpress.XtraEditors.XtraForm, IBosungLichhocView
    {
        BosungLichhocPresenter _presenter;
        private TreModel _treCurrent;
        private int _thang;
        private int _nam;
        public BosungLichhocForm(TreModel TreCurrent, int Thang, int Nam)
        {
            InitializeComponent();
            this._treCurrent = TreCurrent;
            this._thang = Thang;
            this._nam = Nam;
        }

        private void BosungLichhocForm_Load(object sender, EventArgs e)
        {
            _presenter = new BosungLichhocPresenter(this);
            _presenter.LoadData();
            if(_treCurrent != null)
                HotentextEdit.Text = String.Format("{0} {1}", _treCurrent.Hodem, _treCurrent.Ten);
            ThangtextEdit.Text = _thang.ToString();
            DateTime first = new DateTime(_nam, _thang, 1);
            DateTime nextFirst;
            if (first.Month == 12) nextFirst = new DateTime(first.Year + 1, 1, 1);
            else nextFirst = new DateTime(first.Year, _thang + 1, 1);
            DateTime last = nextFirst.AddDays(-1);
            StartdateEdit.DateTime = first;
            EnddateEdit.DateTime = last;
        }

        public Guid? TreId
        {
            get { return _treCurrent.TreId; }
        }

        public DateTime StartDate
        {
            get { return StartdateEdit.DateTime; }
        }

        public DateTime EndDate
        {
            get { return EnddateEdit.DateTime; }
        }

        public TimeSpan StartTime
        {
            get { return new TimeSpan(StarttimeEdit.Time.Hour, StarttimeEdit.Time.Minute, 0); }
        }

        public TimeSpan EndTime
        {
            get { return new TimeSpan(EndtimeEdit.Time.Hour, EndtimeEdit.Time.Minute, 0); }
        }

        public int Thu
        {
            get { return (int)ThucomboBox.SelectedValue; }
        }

        public int Nam
        {
            get { return _nam; }
        }

        public List<CahocModel> CahocItems
        {
            get { return cahocModelBindingSource.DataSource as List<CahocModel>; }
            set { cahocModelBindingSource.DataSource = value; }
        }

        public Guid? CahocId
        {
            get { return CahoccomboBox.SelectedValue as Guid?; }
        }

        public bool Laplai
        {
            get { return LaplaicheckEdit.Checked; }
        }

        public void RefreshData()
        {
            
        }


        public List<ThuModel> ThuItems
        {
            set { thuModelBindingSource.DataSource = value; }
        }


        public int Thang
        {
            get { return _thang; }
        }

        private void radioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)radioGroup.EditValue == 1)
            {
                CahoccomboBox.Enabled = false;
                StarttimeEdit.Enabled = true;
                EndtimeEdit.Enabled = true;
            }
            else
            {
                CahoccomboBox_SelectedValueChanged(new object(), new EventArgs());
                CahoccomboBox.Enabled = true;
                StarttimeEdit.Enabled = false;
                EndtimeEdit.Enabled = false;
            }
        }

        private void CahoccomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CahocItems == null)
                return;
            foreach (var i in CahocItems)
            {
                if (i.CahocId == CahocId)
                {
                    StarttimeEdit.Time = Convert.ToDateTime(i.GioBatdau);
                    EndtimeEdit.Time = Convert.ToDateTime(i.GioKetthuc);
                    break;
                }
            }
        }


        public bool Tuychon
        {
            get
            {
                if ((int)radioGroup.EditValue == 1)
                    return true;
                else
                    return false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Ngaychon.Month != Thang)
            {
                XtraMessageBox.Show("Vui lòng chọn lại Ngày trong tháng " + Thang, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Laplai)
            {
                if ((int)Ngaychon.DayOfWeek + 1 != Thu)
                {
                    String tmp = (Thu == 1?"Chủ nhật":"Thứ " + Thu);
                    XtraMessageBox.Show("Vui lòng chọn lại Ngày Tháng Năm của " + tmp, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            _presenter.Save();
            this.Close();
        }

        private void LaplaicheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (LaplaicheckEdit.Checked)
            {
                NgaydateEdit.Enabled = false;
                StartdateEdit.Enabled = true;
                EnddateEdit.Enabled = true;
            }
            else
            {
                NgaydateEdit.Enabled = true;
                StartdateEdit.Enabled = false;
                EnddateEdit.Enabled = false;
            }
        }

        public DateTime Ngaychon
        {
            get { return NgaydateEdit.DateTime; }
        }

        private void HuyboButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}