using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrainingAccounting.Model.BusinessObject;
using Lambda.BusinessObject;

namespace TrainingAccounting.Form
{
    public partial class ChitietThuchiLuongNhanvienForm : DevExpress.XtraEditors.XtraForm
    {
        ThuchiModel _thuchiItem;
        public ChitietThuchiLuongNhanvienForm(ThuchiModel thuchiItems)
        {
            InitializeComponent();
            _thuchiItem = thuchiItems;
            if (thuchiItems != null)
                this.Text = "CHI TIẾT CHI LƯƠNG, Nhân viên: " + thuchiItems.TenNhanvien;
        }

        private void ChitietThuchiLuongNhanvienForm_Load(object sender, EventArgs e)
        {
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "PhieubaoLuongNhanvienId", Value = _thuchiItem.PhieubaoLuongNhanvienId, SqlType = SqlDbType.UniqueIdentifier });
            chitietPhieubaoLuongNhanvienModelBindingSource.DataSource = model.Get<ChitietPhieubaoLuongNhanvienModel>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetChitietPhieubaoLuongNhanvien" });
        }
    }
}