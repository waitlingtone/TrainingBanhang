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
    public partial class NhomtreForm : DevExpress.XtraEditors.XtraForm,INhomtreView
    {
        NhomtrePresenter _presenter;
        public NhomtreForm()
        {
            InitializeComponent();
        }

        private void NhomtreForm_Load(object sender, EventArgs e)
        {
            _presenter = new NhomtrePresenter(this);
            _presenter.LoadData();
        }

        public List<NhomTreModel> NhomtreItems
        {
            get
            {
                return nhomTreModelBindingSource.DataSource as List<NhomTreModel>;
            }
            set
            {
                nhomTreModelBindingSource.DataSource = value;
            }
        }

        public NhomTreModel NhomtreCurrent
        {
            get { return nhomTreModelBindingSource.Current as NhomTreModel; }
        }

        public void RefreshData()
        {
            nhomTreModelGridControl.RefreshDataSource();
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