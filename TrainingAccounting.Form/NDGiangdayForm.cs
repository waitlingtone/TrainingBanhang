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
using DevExpress.XtraGrid.Localization;

namespace TrainingAccounting.Form
{
    public partial class NDGiangdayForm : DevExpress.XtraEditors.XtraForm, INDGiangdayView
    {
        NDGiangdayPresenter _presenter;
        public NDGiangdayForm()
        {
            InitializeComponent();
        }

        private void NDGiangdayForm_Load(object sender, EventArgs e)
        {
            GridLocalizer.Active = new MyGridLocalizer();
            _presenter = new NDGiangdayPresenter(this);
            _presenter.LoadData();
        }

        public List<Model.BusinessObject.NDGiangdayModel> NDGiangdayItems
        {
            get
            {
                return nDGiangdayModelBindingSource.DataSource as List<NDGiangdayModel>;
            }
            set
            {
                nDGiangdayModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.NDGiangdayModel NDGiangdayCurrent
        {
            get { return nDGiangdayModelBindingSource.Current as NDGiangdayModel; }
        }

        public void RefreshData()
        {
            nDGiangdayModelGridControl.RefreshDataSource();
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