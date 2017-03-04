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
    public partial class BosungLuongNhanvienForm : DevExpress.XtraEditors.XtraForm, IBosungLuongNhanvienView
    {
        BosungLuongNhanvienPresenter _presenter;
        private int _thang;
        private int _nam;
        public BosungLuongNhanvienForm(int thang, int nam)
        {
            InitializeComponent();
            this._thang = thang;
            this._nam = nam;
        }

        private void BosungLuongNhanvienForm_Load(object sender, EventArgs e)
        {
            _presenter = new BosungLuongNhanvienPresenter(this);
            _presenter.LoadData();
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

        public int Thang
        {
            get { return _thang; }
        }

        public int Nam
        {
            get { return _nam; }
        }

        public void RefreshData()
        {
            nhanvienModelGridControl.RefreshDataSource();
        }


        public bool ConLamviec
        {
            get { return checkEdit.Checked; }
        }

        private void checkEdit_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.LoadData();
        }

        private void BosungButton_Click(object sender, EventArgs e)
        {
            _presenter.Add();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}