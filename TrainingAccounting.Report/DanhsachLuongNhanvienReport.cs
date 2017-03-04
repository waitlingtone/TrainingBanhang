using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Lambda.BusinessObject;
using System.Data;
using TrainingAccounting.Model.BusinessObjectReport;
using System.Drawing.Printing;

namespace TrainingAccounting.Report
{
    public partial class DanhsachLuongNhanvienReport : DevExpress.XtraReports.UI.XtraReport
    {
        int Thang, Nam;
        List<TrAcc_Danh_GetColunmTinhLuongNhanvienModel> listColumn;
        DataTable dtData;
        public DanhsachLuongNhanvienReport(int thang, int nam)
        {
            InitializeComponent();
            Thang = thang;
            Nam = nam;
            ThangLabel.Text = String.Format("Tháng {0} năm {1}", thang, nam);
            DateLabel.Text = DateTime.Now.ToString();
            Lambda.ClientModel.ModelCore model = new Lambda.ClientModel.ModelCore();

            var items = new List<AutoItem>();
            items.Add(new AutoItem { Name = "Thang", Value = thang, SqlType = System.Data.SqlDbType.Int });
            items.Add(new AutoItem { Name = "Nam", Value = nam, SqlType = System.Data.SqlDbType.Int });
            listColumn = model.Get < TrAcc_Danh_GetColunmTinhLuongNhanvienModel>(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetColunmTinhLuongNhanvien" });
            dtData = model.GetDataTable(new AutoObject { Items = items, SpName = "TrAcc_Danh_GetAllBangLuongNhanvien" });

            CreateColumnTable();
            xrPictureBox1.Image = Info.Info.image;
        }

        public void CreateColumnTable()
        {
            int cellsInRow = listColumn.Count;
            int rowsCount = 1;
            float rowHeight = 25f;

            ColumnTable.BeginInit();
            ColumnTable.Rows.RemoveAt(0);
            XRTableRow row = new XRTableRow();
            XRTableCell cell = new XRTableCell();
            cell.Text = "STT";
            cell.WidthF = 50;
            row.Cells.Add(cell);

            for (int i = 0; i < rowsCount; i++)
            {
                row.HeightF = rowHeight;
                for (int j = 0; j < cellsInRow; j++)
                {
                    cell = new XRTableCell();
                    cell.Text = listColumn[j].Ten;
                    cell.WidthF = listColumn[j].Width;
                    row.Cells.Add(cell);
                }
                ColumnTable.Rows.Add(row);
            }

            ColumnTable.BeforePrint += new PrintEventHandler(Columntable_BeforePrint);
            ColumnTable.AdjustSize();
            ColumnTable.EndInit();
        }
        private void XtraReport1_BeforePrint(object sender, PrintEventArgs e)
        {
            this.Detail.Controls.Add(CreateXRTable());
        }
        public XRTable CreateXRTable()
        {
            if (dtData == null)
                return new XRTable();
            int cellsInRow = listColumn.Count; ;
            int rowsCount = dtData.Rows.Count;
            float rowHeight = 25f;
            XRTable table = new XRTable();
            table.Borders = DevExpress.XtraPrinting.BorderSide.All;
            table.BeginInit();
            XRTableCell cell;
            for (int i = 0; i < rowsCount; i++)
            {
                XRTableRow row = new XRTableRow();
                cell = new XRTableCell();
                cell.Text = (i + 1).ToString();
                cell.WidthF = 50;
                row.Cells.Add(cell);
                row.HeightF = rowHeight;
                DataRow dtRow = dtData.Rows[i];

                foreach (var col in listColumn)
                {
                    cell = new XRTableCell();
                    float IsInt;
                    if (float.TryParse(dtRow[col.Ma].ToString(), out IsInt))
                        cell.Text = String.Format("{0:#,#}", dtRow[col.Ma]);
                    else cell.Text = String.Format("{0}", dtRow[col.Ma]);

                    cell.WidthF = col.Width;
                    row.Cells.Add(cell);
                }

                table.Rows.Add(row);
            }

            table.BeforePrint += new PrintEventHandler(Datatable_BeforePrint);
            table.AdjustSize();
            table.EndInit();
            return table;
        }

        // The following code makes the table span to the entire page width.
        void Datatable_BeforePrint(object sender, PrintEventArgs e)
        {
            XRTable table = ((XRTable)sender);
            table.LocationF = new DevExpress.Utils.PointFloat(0F, 0F);
            table.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
            table.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        }

        // The following code makes the table span to the entire page width.
        void Columntable_BeforePrint(object sender, PrintEventArgs e)
        {
            XRTable table = ((XRTable)sender);
            this.ColumnTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 88.54166F);
            table.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
        }

    }
}
