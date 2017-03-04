using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Localization;
using TrainingAccounting.View;
using TrainingAccounting.Presenter;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.Form
{
    public partial class QuanhuyenForm : DevExpress.XtraEditors.XtraForm, IQuanhuyenView
    {
        QuanhuyenPresenter _presenter;
        public QuanhuyenForm()
        {
            InitializeComponent();
        }

        private void QuanhuyenForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new QuanhuyenPresenter(this);
            _presenter.LoadData();
        }

        public List<Model.BusinessObject.QuanhuyenModel> QuanhuyenItems
        {
            get
            {
                return quanhuyenModelBindingSource.DataSource as List<QuanhuyenModel>;
            }
            set
            {
                quanhuyenModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.QuanhuyenModel QuanhuyenCurrent
        {
            get { return quanhuyenModelBindingSource.Current as QuanhuyenModel; }
        }

        public List<Model.BusinessObject.TinhthanhModel> TinhthanhItems
        {
            set { tinhthanhModelBindingSource.DataSource = value; }
        }

        public Guid? TinhthanhId
        {
            get { return tinhThanhcomboBox.SelectedValue as Guid?; }
        }

        public void RefreshData()
        {
            quanhuyenModelGridControl.RefreshDataSource();
        }

        private void tinhThanhcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (TinhthanhId == null)
                return;
            _presenter.GetQuanhuyenByTinh();
        }

        private void addSmallButton_Click(object sender, EventArgs e)
        {
            _presenter.Add();
        }

        private void deleteSmallButton_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void saveSmallButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }
    }
}