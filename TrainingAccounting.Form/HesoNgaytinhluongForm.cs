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

namespace TrainingAccounting.Form
{
    public partial class HesoNgaytinhluongForm : DevExpress.XtraEditors.XtraForm, IHesoNgaytinhluongView
    {
        HesoNgaytinhluongPresenter _presenter;
        public HesoNgaytinhluongForm()
        {
            InitializeComponent();
        }

        private void HesoNgaytinhluongForm_Load(object sender, EventArgs e)
        {
            _presenter = new HesoNgaytinhluongPresenter(this);
            _presenter.LoadData();
        }

        public List<HesoTinhluongModel> HesoTinhluongItems
        {
            get
            {
                return hesoTinhluongModelBindingSource.DataSource as List<HesoTinhluongModel>;
            }
            set
            {
                hesoTinhluongModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.HesoTinhluongModel HesoTinhluongCurrent
        {
            get { return hesoTinhluongModelBindingSource.Current as HesoTinhluongModel; }
        }

        public void RefreshData()
        {
            hesoTinhluongModelGridControl.RefreshDataSource();
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

        private void ItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.CheckedChange();
        }
    }
}