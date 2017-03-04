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
using System.Configuration;

namespace TrainingAccounting.Form
{
    public partial class BackupInfoForm : DevExpress.XtraEditors.XtraForm, IBackupInfoView
    {
        BackupInfoPresenter _presenter;
        private string _path;
        private string _fileName;
        public BackupInfoForm()
        {
            InitializeComponent();
        }

        private void BackupInfoForm_Load(object sender, EventArgs e)
        {
            _presenter = new BackupInfoPresenter(this);
            _presenter.LoadData();
        }

        public List<Model.BusinessObject.BackupInfoModel> InfoItems
        {
            set { backupInfoModelBindingSource.DataSource = value; }
        }

        public void RefreshData()
        {
            backupInfoModelGridControl.RefreshDataSource();
        }


        public string Path
        {
            get { return _path; }
        }
        
        public string NameFile
        {
            get { return _fileName; }
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Backup file (*.bak)|*.bak";
            saveDialog.RestoreDirectory = true;
            _fileName = DateTime.Now.Year.ToString() + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            saveDialog.FileName = _fileName;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _path = saveDialog.FileName;
                _fileName = System.IO.Path.GetFileName(saveDialog.FileName);
                _presenter = new BackupInfoPresenter(this);
                try
                {
                    _presenter.BackupData();
                    XtraMessageBox.Show("Backup dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _presenter.LoadData();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Xảy ra lỗi trong quá trình backup dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}