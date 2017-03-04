namespace TrainingAccounting.Form
{
    partial class ChitietThuchiLuongNhanvienForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chitietPhieubaoLuongNhanvienModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.chitietPhieubaoLuongNhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhmucTraluongNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieubaoLuongNhanvienModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieubaoLuongNhanvienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chitietPhieubaoLuongNhanvienModelGridControl
            // 
            this.chitietPhieubaoLuongNhanvienModelGridControl.DataSource = this.chitietPhieubaoLuongNhanvienModelBindingSource;
            this.chitietPhieubaoLuongNhanvienModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chitietPhieubaoLuongNhanvienModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.chitietPhieubaoLuongNhanvienModelGridControl.MainView = this.gridView1;
            this.chitietPhieubaoLuongNhanvienModelGridControl.Name = "chitietPhieubaoLuongNhanvienModelGridControl";
            this.chitietPhieubaoLuongNhanvienModelGridControl.Size = new System.Drawing.Size(648, 343);
            this.chitietPhieubaoLuongNhanvienModelGridControl.TabIndex = 1;
            this.chitietPhieubaoLuongNhanvienModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // chitietPhieubaoLuongNhanvienModelBindingSource
            // 
            this.chitietPhieubaoLuongNhanvienModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ChitietPhieubaoLuongNhanvienModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMa,
            this.colDanhmucTraluongNhanvien,
            this.colMota,
            this.colSoTien});
            this.gridView1.GridControl = this.chitietPhieubaoLuongNhanvienModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã";
            this.colMa.FieldName = "Ma";
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 1;
            // 
            // colDanhmucTraluongNhanvien
            // 
            this.colDanhmucTraluongNhanvien.Caption = "Danh mục lương";
            this.colDanhmucTraluongNhanvien.FieldName = "DanhmucTraluongNhanvien";
            this.colDanhmucTraluongNhanvien.Name = "colDanhmucTraluongNhanvien";
            this.colDanhmucTraluongNhanvien.Visible = true;
            this.colDanhmucTraluongNhanvien.VisibleIndex = 2;
            // 
            // colMota
            // 
            this.colMota.Caption = "Mô tả";
            this.colMota.FieldName = "Mota";
            this.colMota.Name = "colMota";
            this.colMota.Visible = true;
            this.colMota.VisibleIndex = 3;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số tiền";
            this.colSoTien.DisplayFormat.FormatString = "#,#";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoTien", "{0:#,#}")});
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 4;
            // 
            // ChitietThuchiLuongNhanvienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 343);
            this.Controls.Add(this.chitietPhieubaoLuongNhanvienModelGridControl);
            this.Name = "ChitietThuchiLuongNhanvienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChitietThuchiLuongNhanvienForm";
            this.Load += new System.EventHandler(this.ChitietThuchiLuongNhanvienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieubaoLuongNhanvienModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieubaoLuongNhanvienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource chitietPhieubaoLuongNhanvienModelBindingSource;
        private DevExpress.XtraGrid.GridControl chitietPhieubaoLuongNhanvienModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhmucTraluongNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colMota;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
    }
}