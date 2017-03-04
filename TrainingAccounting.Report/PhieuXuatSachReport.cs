using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Model.BusinessObject;
using Lambda.BusinessObject;
using System.Collections.Generic;

namespace TrainingAccounting.Report
{
    public partial class PhieuXuatSachReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieuXuatSachReport(PhieuXuatThuSachModel PhieuXuatItems)
        {
            InitializeComponent();
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "PhieuXuatThuSachId", Value = PhieuXuatItems.PhieuXuatThuSachId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            bindingSource.DataSource = model.Get<ChitietPhieuXuatThuSachModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_ReportChitietPhieuxuatSach" });
            NgayLabel.Text = PhieuXuatItems.Ngay.Value.ToShortDateString(); ;
            DonviLabel.Text = PhieuXuatItems.DonviNhan;
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
