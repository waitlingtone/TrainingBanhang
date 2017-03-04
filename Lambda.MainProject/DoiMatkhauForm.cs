using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Lambda.MainProject
{
    public partial class DoiMatkhauForm : DevExpress.XtraEditors.XtraForm, IDoiMatkhauView
    {
        public DoiMatkhauForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(!NewPass.Equals(CfNewPass))
            {
                XtraMessageBox.Show("Mật khẩu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _presenter.Save();
                XtraMessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Mật khẩu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string OldPass
        {
            get { return OldPasstextEdit.Text; }
        }

        public string NewPass
        {
            get { return NewPasstextEdit.Text; }
        }

        public string CfNewPass
        {
            get { return CfNewPasstextEdit.Text; }
        }

        public void RefreshData()
        {
            
        }
        DoiMatkhauPresenter _presenter;
        private void DoiMatkhauForm_Load(object sender, EventArgs e)
        {
            _presenter = new DoiMatkhauPresenter(this);
        }
    }
}