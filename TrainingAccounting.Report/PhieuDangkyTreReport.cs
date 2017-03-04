using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TrainingAccounting.Report
{
    public partial class PhieuDangkyTreReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieuDangkyTreReport()
        {
            InitializeComponent();
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
