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
using DevExpress.XtraReports.UI;
using TrainingAccounting.Report;

namespace TrainingAccounting.Form
{
    public partial class ThuChiForm : DevExpress.XtraEditors.XtraForm, IThuChiView
    {
        ThuChiPresenter _presenter;
        public ThuChiForm()
        {
            InitializeComponent();
        }

        private void ThuChiForm_Load(object sender, EventArgs e)
        {
            _presenter = new ThuChiPresenter(this);
            _presenter.LoadData();
        }

        public List<DaumucThuchiModel> DaumucThuchiItems
        {
            set { daumucThuchiModelBindingSource.DataSource = value; }
        }

        public Guid? DaumucThuchiId
        {
            get { return DaumucThuChicomboBox.SelectedValue as Guid?; }
        }

        public List<ThuchiModel> ThuchiItem
        {
            get
            {
                return thuchiModelBindingSource.DataSource as List<ThuchiModel>;
            }
            set
            {
                thuchiModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
            thuchiModelGridControl.RefreshDataSource();
        }


        public bool isThu
        {
            get {
                if ((int)radioGroup.EditValue == 1)
                    return true;
                else
                    return false;
            }
        }

        private void DaumucThuChicomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DaumucThuchiId == null || ThuchiItem == null)
                return;

            if (DaumucThuChicomboBox.SelectedIndex == 0)
            {
                ThuchiItem[0].TenDaumuc = "";
                ThuchiItem[0].DaumucThuchiId = null;
            }
            else
            {
                ThuchiItem[0].TenDaumuc = DaumucThuChicomboBox.Text;
                ThuchiItem[0].DaumucThuchiId = DaumucThuchiId;
            }
            RefreshData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ThuchiItem[0].TenDaumuc == "" || ThuchiItem[0].SoTien == 0)
                XtraMessageBox.Show("Vui lòng điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _presenter.SaveThuchi();
            }
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            _presenter.LoadData();
            RefreshData();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (ThuchiItem[0].TenDaumuc == "" || ThuchiItem[0].SoTien == 0)
            {
                XtraMessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ThuchiItem[0].State != Lambda.BusinessObject.RowState.UnChange)
            {
                XtraMessageBox.Show("Vui lòng lưu trước khi in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var f = new Thu_ChiReport(isThu, ThuchiItem[0].TenDaumuc, ThuchiItem[0].SoTien.Value, ThuchiItem[0].NgayThanhtoan.Value))
            {
                f.ShowPreviewDialog();
            }
        }
    }
}