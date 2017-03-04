using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Model.BusinessObject;
using System.Collections.Generic;

namespace TrainingAccounting.Report
{
    public partial class PhieubaoLuongReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieubaoLuongReport(PhieubaoLuongNhanvienModel phieubao, int Thang, int Nam, List<PhieubaoLuong> Tinhluong, List<ChitietPhieubaoLuongNhanvienModel> DanhmucLuong)
        {
            InitializeComponent();
            ThangLabel.Text = String.Format("Tháng {0} năm {1}", Thang, Nam);
            NhanvienLabel.Text = String.Format("{0}", phieubao.TenNhanvien);
            TinhLuongbindingSource.DataSource = Tinhluong;
            int stt = 1;
            foreach (var i in DanhmucLuong)
                i.STT = stt ++;
            DanhmucLuongbindingSource.DataSource = DanhmucLuong;
            dateLabel.Text = DateTime.Now.ToString();
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
