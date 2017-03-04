namespace TrainingAccounting.Form
{
    partial class DanhmucSachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhmucSachForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sachModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.sachModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTacgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuatban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ExcelButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddSachButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveSachButton = new DevExpress.XtraEditors.SimpleButton();
            this.DelSachButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.giaSachModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.giaSachModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayApdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.AddPriceButton = new DevExpress.XtraEditors.SimpleButton();
            this.SavePriceButton = new DevExpress.XtraEditors.SimpleButton();
            this.DelPriceButton = new DevExpress.XtraEditors.SimpleButton();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sachModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaSachModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaSachModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1037, 369);
            this.splitContainerControl1.SplitterPosition = 650;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sachModelGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(650, 317);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Sách";
            // 
            // sachModelGridControl
            // 
            this.sachModelGridControl.DataSource = this.sachModelBindingSource;
            this.sachModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sachModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.sachModelGridControl.MainView = this.gridView1;
            this.sachModelGridControl.Name = "sachModelGridControl";
            this.sachModelGridControl.Size = new System.Drawing.Size(646, 294);
            this.sachModelGridControl.TabIndex = 1;
            this.sachModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sachModelBindingSource
            // 
            this.sachModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.SachModel);
            this.sachModelBindingSource.PositionChanged += new System.EventHandler(this.sachModelBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colTenSach,
            this.colTacgia,
            this.colNgayXuatban,
            this.colState});
            this.gridView1.GridControl = this.sachModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenSach
            // 
            this.colTenSach.Caption = "Tên sách";
            this.colTenSach.FieldName = "TenSach";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Visible = true;
            this.colTenSach.VisibleIndex = 1;
            this.colTenSach.Width = 559;
            // 
            // colTacgia
            // 
            this.colTacgia.Caption = "Tác giả";
            this.colTacgia.FieldName = "Tacgia";
            this.colTacgia.Name = "colTacgia";
            this.colTacgia.Visible = true;
            this.colTacgia.VisibleIndex = 2;
            this.colTacgia.Width = 150;
            // 
            // colNgayXuatban
            // 
            this.colNgayXuatban.Caption = "Ngày Xuất bản";
            this.colNgayXuatban.FieldName = "NgayXuatban";
            this.colNgayXuatban.Name = "colNgayXuatban";
            this.colNgayXuatban.Visible = true;
            this.colNgayXuatban.VisibleIndex = 3;
            this.colNgayXuatban.Width = 190;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 4;
            this.colState.Width = 169;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ExcelButton);
            this.panelControl1.Controls.Add(this.AddSachButton);
            this.panelControl1.Controls.Add(this.SaveSachButton);
            this.panelControl1.Controls.Add(this.DelSachButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 317);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(650, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // ExcelButton
            // 
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.Location = new System.Drawing.Point(12, 17);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(91, 23);
            this.ExcelButton.TabIndex = 3;
            this.ExcelButton.Text = "Xuất Excel";
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // AddSachButton
            // 
            this.AddSachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSachButton.Image = ((System.Drawing.Image)(resources.GetObject("AddSachButton.Image")));
            this.AddSachButton.Location = new System.Drawing.Point(331, 17);
            this.AddSachButton.Name = "AddSachButton";
            this.AddSachButton.Size = new System.Drawing.Size(87, 23);
            this.AddSachButton.TabIndex = 2;
            this.AddSachButton.Text = "Thêm Sách";
            this.AddSachButton.Click += new System.EventHandler(this.AddSachButton_Click);
            // 
            // SaveSachButton
            // 
            this.SaveSachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSachButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveSachButton.Image")));
            this.SaveSachButton.Location = new System.Drawing.Point(545, 17);
            this.SaveSachButton.Name = "SaveSachButton";
            this.SaveSachButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSachButton.TabIndex = 1;
            this.SaveSachButton.Text = "Lưu lại";
            this.SaveSachButton.Click += new System.EventHandler(this.SaveSachButton_Click);
            // 
            // DelSachButton
            // 
            this.DelSachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelSachButton.Image = ((System.Drawing.Image)(resources.GetObject("DelSachButton.Image")));
            this.DelSachButton.Location = new System.Drawing.Point(441, 17);
            this.DelSachButton.Name = "DelSachButton";
            this.DelSachButton.Size = new System.Drawing.Size(81, 23);
            this.DelSachButton.TabIndex = 0;
            this.DelSachButton.Text = "Xóa Sách";
            this.DelSachButton.Click += new System.EventHandler(this.DelSachButton_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.giaSachModelGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(382, 317);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Bảng giá từng sách";
            // 
            // giaSachModelGridControl
            // 
            this.giaSachModelGridControl.DataSource = this.giaSachModelBindingSource;
            this.giaSachModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giaSachModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.giaSachModelGridControl.MainView = this.gridView2;
            this.giaSachModelGridControl.Name = "giaSachModelGridControl";
            this.giaSachModelGridControl.Size = new System.Drawing.Size(378, 294);
            this.giaSachModelGridControl.TabIndex = 0;
            this.giaSachModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // giaSachModelBindingSource
            // 
            this.giaSachModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.GiaSachModel);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgayApdung,
            this.colDongia,
            this.colState1});
            this.gridView2.GridControl = this.giaSachModelGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colNgayApdung
            // 
            this.colNgayApdung.Caption = "Ngày áp dụng";
            this.colNgayApdung.FieldName = "NgayApdung";
            this.colNgayApdung.Name = "colNgayApdung";
            this.colNgayApdung.Visible = true;
            this.colNgayApdung.VisibleIndex = 0;
            // 
            // colDongia
            // 
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.DisplayFormat.FormatString = "#,#";
            this.colDongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDongia.FieldName = "Dongia";
            this.colDongia.Name = "colDongia";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 1;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.AddPriceButton);
            this.panelControl2.Controls.Add(this.SavePriceButton);
            this.panelControl2.Controls.Add(this.DelPriceButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 317);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(382, 52);
            this.panelControl2.TabIndex = 0;
            // 
            // AddPriceButton
            // 
            this.AddPriceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPriceButton.Image = ((System.Drawing.Image)(resources.GetObject("AddPriceButton.Image")));
            this.AddPriceButton.Location = new System.Drawing.Point(80, 17);
            this.AddPriceButton.Name = "AddPriceButton";
            this.AddPriceButton.Size = new System.Drawing.Size(87, 23);
            this.AddPriceButton.TabIndex = 2;
            this.AddPriceButton.Text = "Thêm Giá";
            this.AddPriceButton.Click += new System.EventHandler(this.AddPriceButton_Click);
            // 
            // SavePriceButton
            // 
            this.SavePriceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePriceButton.Image = ((System.Drawing.Image)(resources.GetObject("SavePriceButton.Image")));
            this.SavePriceButton.Location = new System.Drawing.Point(294, 17);
            this.SavePriceButton.Name = "SavePriceButton";
            this.SavePriceButton.Size = new System.Drawing.Size(75, 23);
            this.SavePriceButton.TabIndex = 1;
            this.SavePriceButton.Text = "Lưu Giá";
            this.SavePriceButton.Click += new System.EventHandler(this.SavePriceButton_Click);
            // 
            // DelPriceButton
            // 
            this.DelPriceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelPriceButton.Image = ((System.Drawing.Image)(resources.GetObject("DelPriceButton.Image")));
            this.DelPriceButton.Location = new System.Drawing.Point(190, 17);
            this.DelPriceButton.Name = "DelPriceButton";
            this.DelPriceButton.Size = new System.Drawing.Size(81, 23);
            this.DelPriceButton.TabIndex = 0;
            this.DelPriceButton.Text = "Xóa Giá";
            this.DelPriceButton.Click += new System.EventHandler(this.DelPriceButton_Click);
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
            this.colSTT.Width = 95;
            // 
            // DanhmucSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 369);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "DanhmucSachForm";
            this.Text = "DANH MỤC SÁCH";
            this.Load += new System.EventHandler(this.DanhmucSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sachModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giaSachModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaSachModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddSachButton;
        private DevExpress.XtraEditors.SimpleButton SaveSachButton;
        private DevExpress.XtraEditors.SimpleButton DelSachButton;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton AddPriceButton;
        private DevExpress.XtraEditors.SimpleButton SavePriceButton;
        private DevExpress.XtraEditors.SimpleButton DelPriceButton;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl sachModelGridControl;
        private System.Windows.Forms.BindingSource sachModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSach;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl giaSachModelGridControl;
        private System.Windows.Forms.BindingSource giaSachModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayApdung;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraGrid.Columns.GridColumn colTacgia;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuatban;
        private DevExpress.XtraEditors.SimpleButton ExcelButton;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;

    }
}