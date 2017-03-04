using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Lambda.ClientModel;
using TrainingAccounting.Solution;

namespace TrainingAccounting.Main
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm, ILoginView
    {
        LoginPresenter _presenter;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.Login();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            using (var Main = new MainForm())
            {
                this.Hide();
                Main.ShowDialog();
            }
        }

        public string stringPassword
        {
            get { return PASStextEdit.Text.Trim(); }
        }

        public string stringUsername
        {
            get { return USERtextEdit.Text.Trim() ; }
        }

        public void RefreshData()
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _presenter = new LoginPresenter(this);
            ModelCore.SetDefaultLocalConfig();
        }
    }
}