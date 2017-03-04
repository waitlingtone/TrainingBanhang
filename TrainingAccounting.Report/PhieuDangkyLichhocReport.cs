using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Model.BusinessObjectReport;

namespace TrainingAccounting.Report
{
    public partial class PhieuDangkyLichhocReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieuDangkyLichhocReport()
        {
            InitializeComponent();
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();
            bindingSource.DataSource = model.Get<TrAcc_Danh_GetCahocModel>("TrAcc_Danh_GetCahoc");
            xrPictureBox1.Image = Info.Info.image;
        }

    }
}
