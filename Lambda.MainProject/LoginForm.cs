using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Lambda.ClientModel;

namespace Lambda.MainProject
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm, ILoginView
    {
        private LoginPresenter _loginPresenter;
        public LoginForm()
        {
            InitializeComponent();

            _loginPresenter = new LoginPresenter(this);
            ModelCore.SetDefaultLocalConfig();
        }


        private void DangnhapsimpleButton_Click(object sender, EventArgs e)
        {
            try {
                _loginPresenter.Login();
                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            using (var Main = new MainForm())
            {
                this.Hide(); 
                Main.ShowDialog();
            }
                
        }

        public string stringUsername
        {
            get { return usernameTextEdit.Text.Trim(); }
        }

        public string stringPassword
        {
            get { return MatkhautextEdit .Text.Trim(); }
        }

        private void ThoatsimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshData()
        {
            
        }
    }

}