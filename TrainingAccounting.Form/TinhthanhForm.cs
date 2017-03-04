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
    public partial class TinhthanhForm : DevExpress.XtraEditors.XtraForm,ITinhthanhView
    {
        TinhthanhPresenter _presenter;
        public TinhthanhForm()
        {
            InitializeComponent();
        }

        private void TinhthanhForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new TinhthanhPresenter(this);
            _presenter.LoadData();
        }


        public List<TinhthanhModel> TinhthanhItems
        {
            get
            {
                return tinhthanhModelBindingSource.DataSource as List<TinhthanhModel>;
            }
            set
            {
                tinhthanhModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.TinhthanhModel TinhthanhCurrent
        {
            get { return tinhthanhModelBindingSource.Current as TinhthanhModel; }
        }

        public void RefreshData()
        {
            tinhthanhModelGridControl.RefreshDataSource();
        }

        private void QuocgiacomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
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