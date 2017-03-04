using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Phanquyen.View;
using Phanquyen.Presenter;
using Phanquyen.Model.BusinessObject;

namespace Phanquyen.Forms
{
    public partial class VaitroForm : DevExpress.XtraEditors.XtraForm, IVaitroView
    {
        VaitroPresenter _presenter;
        public VaitroForm()
        {
            InitializeComponent();
        }

        private void VaitroForm_Load(object sender, EventArgs e)
        {
            _presenter = new VaitroPresenter(this);
            _presenter.LoadData();
        }

        public List<RoleModel> VaitroItems
        {
            get
            {
                return roleModelBindingSource.DataSource as List<RoleModel>;
            }
            set
            {
                roleModelBindingSource.DataSource = value;
            }
        }

        public RoleModel VaitroCurrent
        {
            get { return roleModelBindingSource.Current as RoleModel; }
        }

        public void RefreshData()
        {
            roleModelGridControl.RefreshDataSource();
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