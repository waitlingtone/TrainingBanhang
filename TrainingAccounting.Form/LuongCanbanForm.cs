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

namespace TrainingAccounting.Form
{
    public partial class LuongCanbanForm : DevExpress.XtraEditors.XtraForm, ILuongCanbanView
    {
        LuongCanbanPresenter _presenter;
        public LuongCanbanForm()
        {
            InitializeComponent();
        }

        private void LuongCanbanForm_Load(object sender, EventArgs e)
        {
            _presenter = new LuongCanbanPresenter(this);
            _presenter.LoadData();
        }

        public List<LuongNhanvienModel> LuongCanbanItems
        {
            get
            {
                return luongNhanvienModelBindingSource.DataSource as List<LuongNhanvienModel>;
            }
            set
            {
                luongNhanvienModelBindingSource.DataSource = value;
            }
        }

        public LuongNhanvienModel LuongCanbanCurrent
        {
            get { return luongNhanvienModelBindingSource.Current as LuongNhanvienModel; }
        }

        public void RefreshData()
        {
            luongNhanvienModelGridControl.RefreshDataSource();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.AddLuong();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.DeleteLuong();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (var i in LuongCanbanItems)
                if (i != LuongCanbanCurrent && i.NgayApdung.Value.Equals(LuongCanbanCurrent.NgayApdung.Value))
                {
                    XtraMessageBox.Show("Đã tồn tại thời điểm này, vui lòng chọn thời điểm khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            _presenter.SaveLuong();
        }
    }
}