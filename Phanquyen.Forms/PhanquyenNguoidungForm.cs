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
    public partial class PhanquyenNguoidungForm : DevExpress.XtraEditors.XtraForm, IPhanquyenNguoidungView
    {
        PhanquyenNguoidungPresenter _presenter;
        private List<UserRoleModel> _userRoleItems;
        public PhanquyenNguoidungForm()
        {
            InitializeComponent();
        }

        private void PhanquyenNguoidungForm_Load(object sender, EventArgs e)
        {
            _presenter = new PhanquyenNguoidungPresenter(this);
            _presenter.LoadData();
            _UserModelBindingSource_PositionChanged(new object(), new EventArgs());
        }

        public List<_UserModel> UserItems
        {
            get
            {
                return _UserModelBindingSource.DataSource as List<_UserModel>;
            }
            set
            {
                _UserModelBindingSource.DataSource = value;
            }
        }

        public _UserModel UserCurrent
        {
            get { return _UserModelBindingSource.Current as _UserModel; }
        }

        public List<RoleModel> RoleItems
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

        public void RefreshData()
        {
            _UserModelGridControl.RefreshDataSource();
            roleModelGridControl.RefreshDataSource();
        }

        private void _UserModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.GetVaitroCanbo();
        }


        public List<UserRoleModel> UserRoleItems
        {
            get
            {
                return _userRoleItems;
            }
            set
            {
                _userRoleItems = value;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
            XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public List<NguoidungModel> NguoidungItems
        {
            set { nguoidungModelBindingSource.DataSource = value; }
        }
    }
}