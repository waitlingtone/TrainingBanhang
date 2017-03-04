using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrainingAccounting.Presenter;
using TrainingAccounting.View;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.Form
{
    public partial class DanhmucChiForm: DevExpress.XtraEditors.XtraForm, IDanhmucChiView
    {
        DanhmucChiPresenter _presenter;
        public DaumucThuchiModel DaumucChi;
        public DanhmucChiForm()
        {
            InitializeComponent();
        }

        private void DanhmucThuForm_Load(object sender, EventArgs e)
        {
            _presenter = new DanhmucChiPresenter(this);
            _presenter.LoadData();
        }

        public List<DaumucThuchiModel> DanhmucChiItems
        {
            set { daumucThuchiModelBindingSource.DataSource = value; }
        }

        public void RefreshData()
        {
            
        }

        private void ChonButton_Click(object sender, EventArgs e)
        {
            DaumucThuchiModel md = daumucThuchiModelBindingSource.Current as DaumucThuchiModel;
            if (md == null)
                return;
            DaumucChi = md;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}