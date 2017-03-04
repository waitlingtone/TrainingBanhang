using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Lambda.BusinessObject;
using TrainingAccounting.Model.BusinessObjectReport;

namespace TrainingAccounting.Report
{
    public partial class DanhsachTreReport : DevExpress.XtraReports.UI.XtraReport
    {
        public DanhsachTreReport(Guid? NhomTreId, bool Conhoc)
        {
            InitializeComponent();
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "NhomTreId", Value = NhomTreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Conhoc", Value = Conhoc, SqlType = System.Data.SqlDbType.Bit });
            bindingSource.DataSource = model.Get<TrAcc_Danh_GetDanhsachTreReportModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetDanhsachTreReport" });
            if (Conhoc)
                TinhtrangLabel.Text = "Còn học";
            else
                TinhtrangLabel.Text = "Đã nghỉ";
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
