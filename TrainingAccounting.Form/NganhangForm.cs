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
using DevExpress.XtraGrid.Localization;

namespace TrainingAccounting.Form
{
    public partial class NganhangForm : DevExpress.XtraEditors.XtraForm, INganhangView
    {
        NganhangPresenter _presenter;
        public NganhangForm()
        {
            InitializeComponent();
        }

        private void NganhangForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new NganhangPresenter(this);
            _presenter.LoadData();
        }

        public List<NganhangModel> NganhangItems
        {
            get
            {
                return nganhangModelBindingSource.DataSource as List<NganhangModel>;
            }
            set
            {
                nganhangModelBindingSource.DataSource = value;
            }
        }

        public NganhangModel NganhangCurrent
        {
            get { return nganhangModelBindingSource.Current as NganhangModel; }
        }

        public List<ChinhanhNganhangModel> ChinhanhItems
        {
            get
            {
                return chinhanhNganhangModelBindingSource.DataSource as List<ChinhanhNganhangModel>;
            }
            set
            {
                chinhanhNganhangModelBindingSource.DataSource = value;
            }
        }

        public ChinhanhNganhangModel ChinhanhCurrent
        {
            get { return chinhanhNganhangModelBindingSource.Current as ChinhanhNganhangModel; }
        }

        public void RefreshData()
        {
            nganhangModelGridControl.RefreshDataSource();
            chinhanhNganhangModelGridControl.RefreshDataSource();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.AddNganhang();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteNganhang();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveNganhang();
        }

        private void AddCNButton_Click(object sender, EventArgs e)
        {
            _presenter.AddCNNganhang();
        }

        private void DeleteCNButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteCNNganhang();
        }

        private void SaveCNButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveCNNganhang();
        }

        private void nganhangModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetChinhanh();
        }
    }
}