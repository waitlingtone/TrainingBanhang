using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TrainingAccounting.Model.BusinessObjectReport;
using Lambda.BusinessObject;

namespace TrainingAccounting.Report
{
    public partial class BangluongChuyenkhoanReport : DevExpress.XtraReports.UI.XtraReport
    {
        private int Thang;
        private int Nam;
        public BangluongChuyenkhoanReport(int thang, int nam)
        {
            InitializeComponent();
            Thang = thang;
            Nam = nam;
            ThangLabel.Text = String.Format("Tháng {0} năm {1}", thang, nam);
        }

        private void BangluongChuyenkhoanReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            List<TrAcc_Danh_GetBangLuongchuyenkhoanByThangNamV2Model> list;

            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = Nam, SqlType = System.Data.SqlDbType.Int });
            list = model.Get<TrAcc_Danh_GetBangLuongchuyenkhoanByThangNamV2Model>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetBangLuongchuyenkhoanByThangNamV2" });
            bindingSource.DataSource = list;
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
