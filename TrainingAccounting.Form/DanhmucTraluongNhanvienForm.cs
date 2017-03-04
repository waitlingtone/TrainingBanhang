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
    public partial class DanhmucTraluongNhanvienForm : DevExpress.XtraEditors.XtraForm, IDanhmucTraluongNhanvienView
    {
        DanhmucTraluongNhanvienPresenter _presenter;
        public DanhmucTraluongNhanvienForm()
        {
            InitializeComponent();
        }

        private void DanhmucTraluongNhanvienForm_Load(object sender, EventArgs e)
        {
            _presenter = new DanhmucTraluongNhanvienPresenter(this);
            _presenter.LoadData();
        }

        public List<DanhmucTraluongNhanvienModel> DanhmucTraluongItems
        {
            get
            {
                return danhmucTraluongNhanvienModelBindingSource.DataSource as List<DanhmucTraluongNhanvienModel>;
            }
            set
            {
                danhmucTraluongNhanvienModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.DanhmucTraluongNhanvienModel DanhmucTraluongCurrent
        {
            get { return danhmucTraluongNhanvienModelBindingSource.Current as DanhmucTraluongNhanvienModel; }
        }

        public void RefreshData()
        {
            danhmucTraluongNhanvienModelGridControl.RefreshDataSource();
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