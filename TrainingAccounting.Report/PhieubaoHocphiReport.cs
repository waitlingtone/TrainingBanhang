using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Model.BusinessObject;
using System.Collections.Generic;

namespace TrainingAccounting.Report
{
    public partial class PhieubaoHocphiReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieubaoHocphiReport(PhieubaoHocphiModel TreCurrent, int Thang, int Nam, List<PhieubaoHocphi> PhieubaoHocphi)
        {
            InitializeComponent();
            if (TreCurrent == null)
                return;
            ThangLabel.Text = String.Format("Tháng {0} năm {1}", Thang, Nam);
            TenTreLabel.Text = String.Format("{0} {1}", TreCurrent.Hodem, TreCurrent.Ten);
            NgaysinhLabel.Text = String.Format("{0}", TreCurrent.Ngaysinh.ToShortDateString());
            PhuhuynhLabel.Text = TreCurrent.Phuhuynh;
            PhieubaoHocphibindingSource.DataSource = PhieubaoHocphi;
            DatetimeLabel.Text = DateTime.Now.ToShortDateString();
            xrPictureBox1.Image = Info.Info.image;
            if (Info.Info.PrintLuuy)
                LuuyLabel.Text = Info.Info.Luuy;
            else
                LuuyLabel.Visible = false;
        }

    }
}
