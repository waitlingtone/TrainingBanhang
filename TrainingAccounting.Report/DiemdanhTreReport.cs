using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.Report
{
    public partial class DiemdanhTreReport : DevExpress.XtraReports.UI.XtraReport
    {
        public DiemdanhTreReport(List<LichhocDayhocModel> lichhocDayhocItems, DateTime ngay)
        {
            InitializeComponent();
            bindingSource.DataSource = lichhocDayhocItems;
            NgayLabel.Text = "Ngày " + ngay.ToShortDateString();
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
