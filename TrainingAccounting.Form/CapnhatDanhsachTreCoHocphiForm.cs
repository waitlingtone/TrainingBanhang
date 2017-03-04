using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrainingAccounting.View;
using TrainingAccounting.Presenter;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.Form
{
    public partial class CapnhatDanhsachTreCoHocphiForm : DevExpress.XtraEditors.XtraForm, ICapnhatDanhsachTreCoHocphiView
    {
        private int _thang;
        private int _nam;
        CapnhatDanhsachTreCoHocphiPresenter _presenter;
        public CapnhatDanhsachTreCoHocphiForm(int thang, int nam)
        {
            InitializeComponent();
            _thang = thang;
            _nam = nam;
        }

        private void CapnhatDanhsachTreCoHocphiForm_Load(object sender, EventArgs e)
        {
            _presenter = new CapnhatDanhsachTreCoHocphiPresenter(this);
            _presenter.LoadData();
        }

        public List<DanhsachButruHocphi> DanhsachItems
        {
            get
            {
                return danhsachButruHocphiBindingSource.DataSource as List<DanhsachButruHocphi>;
            }
            set
            {
                danhsachButruHocphiBindingSource.DataSource = value;
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
            danhsachButruHocphiGridControl.RefreshDataSource();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}