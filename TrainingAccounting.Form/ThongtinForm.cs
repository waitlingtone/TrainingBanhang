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
    public partial class ThongtinForm : DevExpress.XtraEditors.XtraForm, IThongtinView
    {
        ThongtinPresenter _presenter;
        public ThongtinForm()
        {
            InitializeComponent();
        }

        private void ThongtinForm_Load(object sender, EventArgs e)
        {
            _presenter = new ThongtinPresenter(this);
            _presenter.LoadData();
        }

        public List<Model.BusinessObject.ThongtinModel> ThongtinItem
        {
            get
            {
                return thongtinModelBindingSource.DataSource as List<ThongtinModel>;
            }
            set
            {
                thongtinModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
            Info.Info.CreateImage();
            XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}