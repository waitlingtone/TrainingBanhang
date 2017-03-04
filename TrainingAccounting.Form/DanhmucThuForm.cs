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
    public partial class DanhmucThuForm : DevExpress.XtraEditors.XtraForm, IDanhmucThuView
    {
        DanhmucThuPresenter _presenter;
        public DaumucThuchiModel DaumucThu;
        public DanhmucThuForm()
        {
            InitializeComponent();
        }

        private void DanhmucThuForm_Load(object sender, EventArgs e)
        {
            _presenter = new DanhmucThuPresenter(this);
            _presenter.LoadData();
        }

        public List<DaumucThuchiModel> DanhmucThuItems
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
            DaumucThu = md;
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