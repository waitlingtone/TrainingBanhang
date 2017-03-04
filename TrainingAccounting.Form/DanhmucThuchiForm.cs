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
    public partial class DanhmucThuchiForm : DevExpress.XtraEditors.XtraForm, IDanhmucThuchiView
    {
        DaumucThuchiPresenter _presenter;
        public DanhmucThuchiForm()
        {
            InitializeComponent();
        }

        private void DanhmucThuchiForm_Load(object sender, EventArgs e)
        {
            _presenter = new DaumucThuchiPresenter(this);
            _presenter.LoadData();
        }

        public List<DaumucThuchiModel> DaumucThuchiItems
        {
            get
            {
                return daumucThuchiModelBindingSource.DataSource as List<DaumucThuchiModel>;
            }
            set
            {
                daumucThuchiModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.DaumucThuchiModel DaumucThuchiCurrent
        {
            get { return daumucThuchiModelBindingSource.Current as DaumucThuchiModel; }
        }

        public void RefreshData()
        {
            daumucThuchiModelGridControl.RefreshDataSource();
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