using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.Report
{
    public partial class ThuChiReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ThuChiReport(List<ThuchiModel> thuchiItems, DateTime Start, DateTime End)
        {
            InitializeComponent();
            if (Start.Date != End.Date)
                NgayLabel.Text = "Từ ngày: " + Start.ToShortDateString() + " đến ngày: " + End.ToShortDateString();
            else
                NgayLabel.Text = "Ngày: " + Start.ToShortDateString();
            bindingSource.DataSource = thuchiItems;
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
