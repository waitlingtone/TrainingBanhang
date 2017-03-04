namespace TrainingAccounting.Form
{
    partial class ChitietThuchiHocphiForm
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
            this.phieubaoHocphiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoigian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSogio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSobuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonggio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieubaoHocphiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.phieubaoHocphiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieubaoHocphiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phieubaoHocphiGridControl
            // 
            this.phieubaoHocphiGridControl.DataSource = this.phieubaoHocphiBindingSource;
            this.phieubaoHocphiGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieubaoHocphiGridControl.Location = new System.Drawing.Point(0, 0);
            this.phieubaoHocphiGridControl.MainView = this.gridView1;
            this.phieubaoHocphiGridControl.Name = "phieubaoHocphiGridControl";
            this.phieubaoHocphiGridControl.Size = new System.Drawing.Size(753, 371);
            this.phieubaoHocphiGridControl.TabIndex = 1;
            this.phieubaoHocphiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colThang,
            this.colSThu,
            this.colNgay,
            this.colThoigian,
            this.colSogio,
            this.colSobuoi,
            this.colTonggio,
            this.colDongia,
            this.colTongtien});
            this.gridView1.GridControl = this.phieubaoHocphiGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colThang
            // 
            this.colThang.Caption = "Tháng";
            this.colThang.FieldName = "Thang";
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 1;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 3;
            // 
            // colThoigian
            // 
            this.colThoigian.Caption = "Thời gian";
            this.colThoigian.FieldName = "Thoigian";
            this.colThoigian.Name = "colThoigian";
            this.colThoigian.Visible = true;
            this.colThoigian.VisibleIndex = 4;
            // 
            // colSogio
            // 
            this.colSogio.Caption = "Số giờ";
            this.colSogio.FieldName = "Sogio";
            this.colSogio.Name = "colSogio";
            this.colSogio.Visible = true;
            this.colSogio.VisibleIndex = 5;
            // 
            // colSobuoi
            // 
            this.colSobuoi.Caption = "Số buổi";
            this.colSobuoi.FieldName = "Sobuoi";
            this.colSobuoi.Name = "colSobuoi";
            this.colSobuoi.Visible = true;
            this.colSobuoi.VisibleIndex = 6;
            // 
            // colTonggio
            // 
            this.colTonggio.Caption = "Tổng giờ";
            this.colTonggio.FieldName = "Tonggio";
            this.colTonggio.Name = "colTonggio";
            this.colTonggio.Visible = true;
            this.colTonggio.VisibleIndex = 7;
            // 
            // colDongia
            // 
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.DisplayFormat.FormatString = "#,#";
            this.colDongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDongia.FieldName = "Dongia";
            this.colDongia.Name = "colDongia";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 8;
            // 
            // colTongtien
            // 
            this.colTongtien.Caption = "Thành tiền";
            this.colTongtien.DisplayFormat.FormatString = "#,#";
            this.colTongtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongtien.FieldName = "Tongtien";
            this.colTongtien.Name = "colTongtien";
            this.colTongtien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tongtien", "{0:#,#}")});
            this.colTongtien.Visible = true;
            this.colTongtien.VisibleIndex = 9;
            // 
            // colSThu
            // 
            this.colSThu.Caption = "Thứ";
            this.colSThu.FieldName = "SThu";
            this.colSThu.Name = "colSThu";
            this.colSThu.OptionsColumn.ReadOnly = true;
            this.colSThu.Visible = true;
            this.colSThu.VisibleIndex = 2;
            // 
            // phieubaoHocphiBindingSource
            // 
            this.phieubaoHocphiBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.PhieubaoHocphi);
            // 
            // ChitietThuchiHocphiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 371);
            this.Controls.Add(this.phieubaoHocphiGridControl);
            this.Name = "ChitietThuchiHocphiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHI TIẾT THU CHI HỌC PHÍ";
            this.Load += new System.EventHandler(this.ChitietThuchiHocphiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phieubaoHocphiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieubaoHocphiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource phieubaoHocphiBindingSource;
        private DevExpress.XtraGrid.GridControl phieubaoHocphiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colThang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colThoigian;
        private DevExpress.XtraGrid.Columns.GridColumn colSogio;
        private DevExpress.XtraGrid.Columns.GridColumn colSobuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colTonggio;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraGrid.Columns.GridColumn colTongtien;
        private DevExpress.XtraGrid.Columns.GridColumn colSThu;
    }
}