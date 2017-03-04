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
    public partial class DantocForm : DevExpress.XtraEditors.XtraForm, IDantocView
    {
        DantocPresenter _presenter;
        public DantocForm()
        {
            InitializeComponent();
        }

        private void DantocForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new DantocPresenter(this);
            _presenter.LoadData();
        }
        public List<Model.BusinessObject.DantocModel> DantocItems
        {
            get
            {
                return dantocModelBindingSource.DataSource as List<DantocModel>;
            }
            set
            {
                dantocModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.DantocModel DantocCurrent
        {
            get { return dantocModelBindingSource.Current as DantocModel; }
        }

        public void RefreshData()
        {
            dantocModelGridControl.RefreshDataSource();
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