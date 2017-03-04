using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TrainingAccounting.Report
{
    public partial class Thu_ChiReport : DevExpress.XtraReports.UI.XtraReport
    {
        public Thu_ChiReport(bool isThu, String danhmuc, double sotien, DateTime ngaythanhtoan)
        {
            InitializeComponent();
            if (isThu)
            {
                NameLabel.Text = "PHIẾU THU";
                NguoinhanLabel.Visible = false;
                NguoinhanLine.Visible = false;
            }
            else
            {
                NameLabel.Text = "PHIẾU CHI";
                NguoiThuChiLabel.Text = "Người chi";
            }
            DanhmucTableCell.Text = danhmuc;
            SotienTableCell.Text = sotien.ToString();
            NgayTableCell.Text = ngaythanhtoan.ToShortDateString();
            DateLabel.Text = DateTime.Now.ToShortDateString();
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
