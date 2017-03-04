using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Model.BusinessObject;
using System.Collections.Generic;
using Lambda.BusinessObject;

namespace TrainingAccounting.Report
{
    public partial class ChitietPhieubaoHocphiReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ChitietPhieubaoHocphiReport(PhieubaoHocphiModel TreCurrent, int Thang, int Nam)
        {
            InitializeComponent();
            if (TreCurrent == null)
                return;
            ThangLabel.Text = String.Format("Tháng {0} năm {1}", Thang, Nam);
            TenTreLabel.Text = String.Format("{0} {1}", TreCurrent.Hodem, TreCurrent.Ten);
            NgaysinhLabel.Text = String.Format("{0}", TreCurrent.Ngaysinh.ToShortDateString());
            PhuhuynhLabel.Text = TreCurrent.Phuhuynh;
            DatetimeLabel.Text = DateTime.Now.ToShortDateString();

            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "TreId", Value = TreCurrent.TreId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
            items.Add(new AutoItem { Name = "Thang", Value = Thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = Nam, SqlType = System.Data.SqlDbType.Int });
            ChitietPhieubaobindingSource.DataSource = model.Get<ChitietPhieubaoHocphi>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetChitietHocphiByTreId" });
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
