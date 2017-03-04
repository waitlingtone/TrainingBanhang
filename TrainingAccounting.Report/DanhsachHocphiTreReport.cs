using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Model.BusinessObject;
using System.Collections.Generic;

namespace TrainingAccounting.Report
{
    public partial class DanhsachHocphiTreReport : DevExpress.XtraReports.UI.XtraReport
    {
        public DanhsachHocphiTreReport(List<PhieubaoHocphiModel> Phieubao, int thang, int nam)
        {
            InitializeComponent();
            HocphibindingSource.DataSource = Phieubao;
            ThangNamLabel.Text = String.Format("Tháng {0} năm {1}", thang, nam);
            DateLabel.Text = DateTime.Now.ToString();
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
