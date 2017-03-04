using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Phanquyen.View;
using Phanquyen.Model.BusinessObject;
using Phanquyen.Presenter;

namespace Phanquyen.Forms
{
    public partial class NhomChucnangForm : DevExpress.XtraEditors.XtraForm, INhomChucnangView
    {
        NhomChucnangPresenter _presenter;
        public NhomChucnangForm()
        {
            InitializeComponent();
        }

        private void NhomChucnangForm_Load(object sender, EventArgs e)
        {
            _presenter = new NhomChucnangPresenter(this);
            _presenter.LoadData();
        }

        public List<GroupItemModel> NhomChucnangItems
        {
            get
            {
                return groupItemModelBindingSource.DataSource as List<GroupItemModel>;
            }
            set
            {
                groupItemModelBindingSource.DataSource = value;
            }
        }

        public GroupItemModel NhomchucnangCurrent
        {
            get { return groupItemModelBindingSource.Current as GroupItemModel; }
        }

        public void RefreshData()
        {
            groupItemModelGridControl.RefreshDataSource();
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