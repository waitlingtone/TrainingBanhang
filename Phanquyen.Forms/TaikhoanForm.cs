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
    public partial class TaikhoanForm : DevExpress.XtraEditors.XtraForm, ITaikhoanView
    {
        TaikhoanPresenter _presenter;
        public TaikhoanForm()
        {
            InitializeComponent();
        }

        private void TaikhoanForm_Load(object sender, EventArgs e)
        {
            _presenter = new TaikhoanPresenter(this);
            _presenter.LoadData();
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

        public void RefreshData()
        {
            _UserModelGridControl.RefreshDataSource();
            canboModelGridControl.RefreshDataSource();
        }

        private void ChonButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _presenter.AddUser();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }



        public List<NguoidungModel> NguoidungItems
        {
            get
            {
                return nguoidungModelBindingSource.DataSource as List<NguoidungModel>;
            }
            set
            {
                nguoidungModelBindingSource.DataSource = value;
            }
        }

        public NguoidungModel NguoidungCurrent
        {
            get { return nguoidungModelBindingSource.Current as NguoidungModel; }
        }

        private void AddNDButton_Click(object sender, EventArgs e)
        {
            _presenter.AddNguoidung();
        }

        private void DeleteNDButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteNguoidung();
        }

        private void SaveNDButton_Click(object sender, EventArgs e)
        {
            _presenter.SaveNguoidung();
        }
    }
}