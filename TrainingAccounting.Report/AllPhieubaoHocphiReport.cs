using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.Model.BusinessObjectReport;
using Lambda.BusinessObject;

namespace TrainingAccounting.Report
{
    public partial class AllPhieubaoHocphiReport : DevExpress.XtraReports.UI.XtraReport
    {
        public AllPhieubaoHocphiReport(int thang, int nam)
        {
            InitializeComponent();
            ThangLabel.Text = String.Format("Tháng {0} năm {1}", thang, nam);
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            List<TrAcc_Danh_GetPhieubaoHocphiByThangNamModel> list;

            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = nam, SqlType = System.Data.SqlDbType.Int });
            list = model.Get<TrAcc_Danh_GetPhieubaoHocphiByThangNamModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetPhieubaoHocphiByThangNam" });

            foreach (var i in list)
            {
                var item_ = new List<AutoItem>();
                item_.Add(new AutoItem { Name = "TreId", Value = i.TreId.Value, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                item_.Add(new AutoItem { Name = "Thang", Value = thang, SqlType = System.Data.SqlDbType.Int });
                item_.Add(new AutoItem { Name = "Nam", Value = nam, SqlType = System.Data.SqlDbType.Int });
                i.PhieubaoHocphiItems = model.Get<PhieubaoHocphi>(new AutoObject { Items = item_, SpName = "TrAcc_Danh_GetHocphiByTreId" });
            }
            
            bindingSource.DataSource = list;
            xrPictureBox1.Image = Info.Info.image;
            if (Info.Info.PrintLuuy)
                LuuyLabel.Text = Info.Info.Luuy;
            else
                LuuyLabel.Visible = false;
        }

    }
}
