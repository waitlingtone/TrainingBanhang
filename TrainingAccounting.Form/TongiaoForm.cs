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
    public partial class TongiaoForm : DevExpress.XtraEditors.XtraForm, ITongiaoView
    {
        TongiaoPresenter _presenter;
        public TongiaoForm()
        {
            InitializeComponent();
        }

        private void TongiaoForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new TongiaoPresenter(this);
            _presenter.LoadData();
        }

        public List<Model.BusinessObject.TongiaoModel> TongiaoItems
        {
            get
            {
                return tongiaoModelBindingSource.DataSource as List<TongiaoModel>;
            }
            set
            {
                tongiaoModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.TongiaoModel TongiaoCurrent
        {
            get { return tongiaoModelBindingSource.Current as TongiaoModel; }
        }

        public void RefreshData()
        {
            tongiaoModelGridControl.RefreshDataSource();
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