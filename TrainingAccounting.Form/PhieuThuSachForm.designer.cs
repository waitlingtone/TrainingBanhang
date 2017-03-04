namespace TrainingAccounting.Form
{
    partial class PhieuThuSachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuThuSachForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.phieuXuatThuSachModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.phieuXuatThuSachModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddPhieuButton = new DevExpress.XtraEditors.SimpleButton();
            this.DelPhieuButton = new DevExpress.XtraEditors.SimpleButton();
            this.UpdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.SavePhieuButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chitietPhieuXuatThuSachModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.chitietPhieuXuatThuSachModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSachId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sachModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.LapHoadonButton = new DevExpress.XtraEditors.SimpleButton();
            this.XuatButton = new DevExpress.XtraEditors.SimpleButton();
            this.PrintChitietButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddSachButton = new DevExpress.XtraEditors.SimpleButton();
            this.DelSachButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveSachButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatThuSachModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatThuSachModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieuXuatThuSachModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieuXuatThuSachModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachModelBindingSource)).BeginInit();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1042, 458);
            this.splitContainerControl1.SplitterPosition = 460;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.phieuXuatThuSachModelGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(460, 406);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách Phiếu thu";
            // 
            // phieuXuatThuSachModelGridControl
            // 
            this.phieuXuatThuSachModelGridControl.DataSource = this.phieuXuatThuSachModelBindingSource;
            this.phieuXuatThuSachModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieuXuatThuSachModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.phieuXuatThuSachModelGridControl.MainView = this.gridView1;
            this.phieuXuatThuSachModelGridControl.Name = "phieuXuatThuSachModelGridControl";
            this.phieuXuatThuSachModelGridControl.Size = new System.Drawing.Size(456, 383);
            this.phieuXuatThuSachModelGridControl.TabIndex = 0;
            this.phieuXuatThuSachModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // phieuXuatThuSachModelBindingSource
            // 
            this.phieuXuatThuSachModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.PhieuXuatThuSachModel);
            this.phieuXuatThuSachModelBindingSource.PositionChanged += new System.EventHandler(this.phieuXuatThuSachModelBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgay,
            this.colTongtien,
            this.colState});
            this.gridView1.GridControl = this.phieuXuatThuSachModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày thu về";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 0;
            // 
            // colTongtien
            // 
            this.colTongtien.Caption = "Tổng tiền";
            this.colTongtien.DisplayFormat.FormatString = "#,#";
            this.colTongtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongtien.FieldName = "Tongtien";
            this.colTongtien.Name = "colTongtien";
            this.colTongtien.Visible = true;
            this.colTongtien.VisibleIndex = 1;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddPhieuButton);
            this.panelControl1.Controls.Add(this.DelPhieuButton);
            this.panelControl1.Controls.Add(this.UpdateButton);
            this.panelControl1.Controls.Add(this.SavePhieuButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 406);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(460, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // AddPhieuButton
            // 
            this.AddPhieuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPhieuButton.Image = ((System.Drawing.Image)(resources.GetObject("AddPhieuButton.Image")));
            this.AddPhieuButton.Location = new System.Drawing.Point(146, 17);
            this.AddPhieuButton.Name = "AddPhieuButton";
            this.AddPhieuButton.Size = new System.Drawing.Size(97, 23);
            this.AddPhieuButton.TabIndex = 0;
            this.AddPhieuButton.Text = "Tạo phiếu mới ";
            this.AddPhieuButton.Click += new System.EventHandler(this.AddPhieuButton_Click);
            // 
            // DelPhieuButton
            // 
            this.DelPhieuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelPhieuButton.Image = ((System.Drawing.Image)(resources.GetObject("DelPhieuButton.Image")));
            this.DelPhieuButton.Location = new System.Drawing.Point(267, 17);
            this.DelPhieuButton.Name = "DelPhieuButton";
            this.DelPhieuButton.Size = new System.Drawing.Size(77, 23);
            this.DelPhieuButton.TabIndex = 0;
            this.DelPhieuButton.Text = "Xóa phiếu";
            this.DelPhieuButton.Click += new System.EventHandler(this.DelPhieuButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.Location = new System.Drawing.Point(14, 17);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(106, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Cập nhật tiền";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SavePhieuButton
            // 
            this.SavePhieuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePhieuButton.Image = ((System.Drawing.Image)(resources.GetObject("SavePhieuButton.Image")));
            this.SavePhieuButton.Location = new System.Drawing.Point(368, 17);
            this.SavePhieuButton.Name = "SavePhieuButton";
            this.SavePhieuButton.Size = new System.Drawing.Size(75, 23);
            this.SavePhieuButton.TabIndex = 0;
            this.SavePhieuButton.Text = "Lưu lại";
            this.SavePhieuButton.Click += new System.EventHandler(this.SavePhieuButton_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.chitietPhieuXuatThuSachModelGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(577, 406);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi tiết Phiếu thu";
            // 
            // chitietPhieuXuatThuSachModelGridControl
            // 
            this.chitietPhieuXuatThuSachModelGridControl.DataSource = this.chitietPhieuXuatThuSachModelBindingSource;
            this.chitietPhieuXuatThuSachModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chitietPhieuXuatThuSachModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.chitietPhieuXuatThuSachModelGridControl.MainView = this.gridView2;
            this.chitietPhieuXuatThuSachModelGridControl.Name = "chitietPhieuXuatThuSachModelGridControl";
            this.chitietPhieuXuatThuSachModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit});
            this.chitietPhieuXuatThuSachModelGridControl.Size = new System.Drawing.Size(573, 383);
            this.chitietPhieuXuatThuSachModelGridControl.TabIndex = 0;
            this.chitietPhieuXuatThuSachModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // chitietPhieuXuatThuSachModelBindingSource
            // 
            this.chitietPhieuXuatThuSachModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ChitietPhieuXuatThuSachModel);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colSachId,
            this.colSoluong,
            this.colDongia,
            this.colThanhtien,
            this.colState1});
            this.gridView2.GridControl = this.chitietPhieuXuatThuSachModelGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // colSachId
            // 
            this.colSachId.Caption = "Sách";
            this.colSachId.ColumnEdit = this.repositoryItemLookUpEdit;
            this.colSachId.FieldName = "SachId";
            this.colSachId.Name = "colSachId";
            this.colSachId.Visible = true;
            this.colSachId.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit
            // 
            this.repositoryItemLookUpEdit.AutoHeight = false;
            this.repositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenSach", "Sách")});
            this.repositoryItemLookUpEdit.DataSource = this.sachModelBindingSource;
            this.repositoryItemLookUpEdit.DisplayMember = "TenSach";
            this.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit";
            this.repositoryItemLookUpEdit.NullText = "[Chọn sách]";
            this.repositoryItemLookUpEdit.ValueMember = "SachId";
            this.repositoryItemLookUpEdit.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEdit_EditValueChanged);
            // 
            // sachModelBindingSource
            // 
            this.sachModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.SachModel);
            // 
            // colSoluong
            // 
            this.colSoluong.Caption = "Số lượng";
            this.colSoluong.FieldName = "Soluong";
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.Visible = true;
            this.colSoluong.VisibleIndex = 2;
            // 
            // colDongia
            // 
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.DisplayFormat.FormatString = "#,#";
            this.colDongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDongia.FieldName = "Dongia";
            this.colDongia.Name = "colDongia";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 3;
            // 
            // colThanhtien
            // 
            this.colThanhtien.Caption = "Thành tiền";
            this.colThanhtien.DisplayFormat.FormatString = "#,#";
            this.colThanhtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colThanhtien.FieldName = "Thanhtien";
            this.colThanhtien.Name = "colThanhtien";
            this.colThanhtien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanhtien", "{0:#,#}")});
            this.colThanhtien.Visible = true;
            this.colThanhtien.VisibleIndex = 4;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.LapHoadonButton);
            this.panelControl2.Controls.Add(this.XuatButton);
            this.panelControl2.Controls.Add(this.PrintChitietButton);
            this.panelControl2.Controls.Add(this.AddSachButton);
            this.panelControl2.Controls.Add(this.DelSachButton);
            this.panelControl2.Controls.Add(this.SaveSachButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 406);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(577, 52);
            this.panelControl2.TabIndex = 0;
            // 
            // LapHoadonButton
            // 
            this.LapHoadonButton.Image = ((System.Drawing.Image)(resources.GetObject("LapHoadonButton.Image")));
            this.LapHoadonButton.Location = new System.Drawing.Point(461, 17);
            this.LapHoadonButton.Name = "LapHoadonButton";
            this.LapHoadonButton.Size = new System.Drawing.Size(103, 23);
            this.LapHoadonButton.TabIndex = 1;
            this.LapHoadonButton.Text = "Lập Hóa đơn";
            // 
            // XuatButton
            // 
            this.XuatButton.Image = ((System.Drawing.Image)(resources.GetObject("XuatButton.Image")));
            this.XuatButton.Location = new System.Drawing.Point(362, 17);
            this.XuatButton.Name = "XuatButton";
            this.XuatButton.Size = new System.Drawing.Size(84, 23);
            this.XuatButton.TabIndex = 1;
            this.XuatButton.Text = "Chốt phiếu";
            this.XuatButton.Click += new System.EventHandler(this.XuatButton_Click);
            // 
            // PrintChitietButton
            // 
            this.PrintChitietButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintChitietButton.Image")));
            this.PrintChitietButton.Location = new System.Drawing.Point(286, 17);
            this.PrintChitietButton.Name = "PrintChitietButton";
            this.PrintChitietButton.Size = new System.Drawing.Size(61, 23);
            this.PrintChitietButton.TabIndex = 1;
            this.PrintChitietButton.Text = "In";
            this.PrintChitietButton.Click += new System.EventHandler(this.PrintChitietButton_Click);
            // 
            // AddSachButton
            // 
            this.AddSachButton.Image = ((System.Drawing.Image)(resources.GetObject("AddSachButton.Image")));
            this.AddSachButton.Location = new System.Drawing.Point(18, 17);
            this.AddSachButton.Name = "AddSachButton";
            this.AddSachButton.Size = new System.Drawing.Size(85, 23);
            this.AddSachButton.TabIndex = 0;
            this.AddSachButton.Text = "Thêm sách";
            this.AddSachButton.Click += new System.EventHandler(this.AddSachButton_Click);
            // 
            // DelSachButton
            // 
            this.DelSachButton.Image = ((System.Drawing.Image)(resources.GetObject("DelSachButton.Image")));
            this.DelSachButton.Location = new System.Drawing.Point(120, 17);
            this.DelSachButton.Name = "DelSachButton";
            this.DelSachButton.Size = new System.Drawing.Size(64, 23);
            this.DelSachButton.TabIndex = 0;
            this.DelSachButton.Text = "Xóa";
            this.DelSachButton.Click += new System.EventHandler(this.DelSachButton_Click);
            // 
            // SaveSachButton
            // 
            this.SaveSachButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveSachButton.Image")));
            this.SaveSachButton.Location = new System.Drawing.Point(199, 17);
            this.SaveSachButton.Name = "SaveSachButton";
            this.SaveSachButton.Size = new System.Drawing.Size(71, 23);
            this.SaveSachButton.TabIndex = 0;
            this.SaveSachButton.Text = "Lưu lại";
            this.SaveSachButton.Click += new System.EventHandler(this.SaveSachButton_Click);
            // 
            // PhieuThuSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 458);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "PhieuThuSachForm";
            this.Text = "PHIẾU THU SÁCH";
            this.Load += new System.EventHandler(this.PhieuXuatSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatThuSachModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatThuSachModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieuXuatThuSachModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieuXuatThuSachModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl phieuXuatThuSachModelGridControl;
        private System.Windows.Forms.BindingSource phieuXuatThuSachModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colTongtien;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton AddPhieuButton;
        private DevExpress.XtraEditors.SimpleButton DelPhieuButton;
        private DevExpress.XtraEditors.SimpleButton UpdateButton;
        private DevExpress.XtraEditors.SimpleButton SavePhieuButton;
        private DevExpress.XtraGrid.GridControl chitietPhieuXuatThuSachModelGridControl;
        private System.Windows.Forms.BindingSource chitietPhieuXuatThuSachModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSachId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource sachModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraEditors.SimpleButton LapHoadonButton;
        private DevExpress.XtraEditors.SimpleButton XuatButton;
        private DevExpress.XtraEditors.SimpleButton PrintChitietButton;
        private DevExpress.XtraEditors.SimpleButton AddSachButton;
        private DevExpress.XtraEditors.SimpleButton DelSachButton;
        private DevExpress.XtraEditors.SimpleButton SaveSachButton;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
    }
}