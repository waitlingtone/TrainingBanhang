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
    public partial class ChitietThuchiHocphiForm : DevExpress.XtraEditors.XtraForm
    {
        ThuchiModel _thuchiItem;
        public ChitietThuchiHocphiForm(ThuchiModel thuchiItem)
        {
            InitializeComponent();
            _thuchiItem = thuchiItem;
            if(thuchiItem != null)
                this.Text = "CHI TIẾT THU HỌC PHÍ, Trẻ " + thuchiItem.TenTre;
        }

        private void ChitietThuchiHocphiForm_Load(object sender, EventArgs e)
        {
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            var item = new List<AutoItem>();
            item.Add(new AutoItem { Name = "PhieubaoHocphiId", Value = _thuchiItem.PhieubaoHocphiId, SqlType = SqlDbType.UniqueIdentifier });
            phieubaoHocphiBindingSource.DataSource = model.Get<PhieubaoHocphi>(new AutoObject { Items = item, SpName = "TrAcc_Danh_GetChitietPhieubaoHocphiByPhieubaoHocphiId" });
        }
    }
}