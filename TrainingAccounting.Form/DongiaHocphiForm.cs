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
    public partial class DongiaHocphiForm : DevExpress.XtraEditors.XtraForm, IDongiaHocphiView
    {
        DongiaHocphiPresenter _presenter;
        public DongiaHocphiForm()
        {
            InitializeComponent();
        }

        private void DongiaHocphiForm_Load(object sender, EventArgs e)
        {
            _presenter = new DongiaHocphiPresenter(this);
            _presenter.LoadData();
        }

        public List<DongiaHocphiModel> DongiaHocphiItems
        {
            get
            {
                return dongiaHocphiModelBindingSource.DataSource as List<DongiaHocphiModel>;
            }
            set
            {
                dongiaHocphiModelBindingSource.DataSource = value;
            }
        }

        public Model.BusinessObject.DongiaHocphiModel DongiaHocphiCurrent
        {
            get { return dongiaHocphiModelBindingSource.Current as DongiaHocphiModel; }
        }

        public void RefreshData()
        {
            dongiaHocphiModelGridControl.RefreshDataSource();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.AddDongiaHocphi();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteDongiaHocphi();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (var i in DongiaHocphiItems)
                if (i != DongiaHocphiCurrent && i.NgayApdung.Value.Equals(DongiaHocphiCurrent.NgayApdung.Value))
                {
                    XtraMessageBox.Show("Đã tồn tại thời điểm này, vui lòng chọn thời điểm khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            _presenter.SaveDongiaHocphi();
        }

        private void ItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.CheckChanged();
        }

    }
}