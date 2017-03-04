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
    public partial class CahocForm : DevExpress.XtraEditors.XtraForm, ICahocView
    {
        CahocPresenter _presenter;
        public CahocForm()
        {
            InitializeComponent();
        }

        private void CahocForm_Load(object sender, EventArgs e)
        {
            _presenter = new CahocPresenter(this);
            _presenter.LoadData();
        }
        public List<CahocModel> CahocItems
        {
            get
            {
                return cahocModelBindingSource.DataSource as List<CahocModel>;
            }
            set
            {
                cahocModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.CahocModel CahocCurrent
        {
            get { return cahocModelBindingSource.Current as CahocModel; }
        }

        public void RefreshData()
        {
            cahocModelGridControl.RefreshDataSource();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.Add();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

    }
}