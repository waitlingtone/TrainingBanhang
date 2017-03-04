﻿namespace TrainingAccounting.Form
{
    partial class CacPhieuThuChiForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CacPhieuThuChiForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.thuchiModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.thuchiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDaumuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThanhtoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThucte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LoadDataButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.EnddateEdit = new DevExpress.XtraEditors.DateEdit();
            this.StartdateEdit = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ExcelButton = new DevExpress.XtraEditors.SimpleButton();
            this.PrintButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnddateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnddateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartdateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartdateEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.thuchiModelGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(882, 478);
            this.splitContainerControl1.SplitterPosition = 253;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // thuchiModelGridControl
            // 
            this.thuchiModelGridControl.DataSource = this.thuchiModelBindingSource;
            this.thuchiModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thuchiModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.thuchiModelGridControl.MainView = this.gridView1;
            this.thuchiModelGridControl.Name = "thuchiModelGridControl";
            this.thuchiModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonEdit});
            this.thuchiModelGridControl.Size = new System.Drawing.Size(624, 478);
            this.thuchiModelGridControl.TabIndex = 0;
            this.thuchiModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // thuchiModelBindingSource
            // 
            this.thuchiModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ThuchiModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colTenDaumuc,
            this.colNgayThanhtoan,
            this.colTienThucte,
            this.colTenTre,
            this.colTenNhanvien,
            this.gridColumn1});
            this.gridView1.GridControl = this.thuchiModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
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
            this.colSTT.Width = 61;
            // 
            // colTenDaumuc
            // 
            this.colTenDaumuc.Caption = "Đầu mục Thu/Chi";
            this.colTenDaumuc.FieldName = "TenDaumuc";
            this.colTenDaumuc.Name = "colTenDaumuc";
            this.colTenDaumuc.Visible = true;
            this.colTenDaumuc.VisibleIndex = 1;
            this.colTenDaumuc.Width = 184;
            // 
            // colNgayThanhtoan
            // 
            this.colNgayThanhtoan.Caption = "Ngày Thu/Chi";
            this.colNgayThanhtoan.FieldName = "NgayThanhtoan";
            this.colNgayThanhtoan.Name = "colNgayThanhtoan";
            this.colNgayThanhtoan.Visible = true;
            this.colNgayThanhtoan.VisibleIndex = 3;
            this.colNgayThanhtoan.Width = 184;
            // 
            // colTienThucte
            // 
            this.colTienThucte.Caption = "Số tiền";
            this.colTienThucte.DisplayFormat.FormatString = "#,#";
            this.colTienThucte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTienThucte.FieldName = "TienThucte";
            this.colTienThucte.Name = "colTienThucte";
            this.colTienThucte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TienThucte", "{0:#,#}")});
            this.colTienThucte.Visible = true;
            this.colTienThucte.VisibleIndex = 2;
            this.colTienThucte.Width = 184;
            // 
            // colTenTre
            // 
            this.colTenTre.Caption = "Thu từ Trẻ";
            this.colTenTre.FieldName = "TenTre";
            this.colTenTre.Name = "colTenTre";
            this.colTenTre.Visible = true;
            this.colTenTre.VisibleIndex = 4;
            this.colTenTre.Width = 184;
            // 
            // colTenNhanvien
            // 
            this.colTenNhanvien.Caption = "Chi Nhân viên";
            this.colTenNhanvien.FieldName = "TenNhanvien";
            this.colTenNhanvien.Name = "colTenNhanvien";
            this.colTenNhanvien.Visible = true;
            this.colTenNhanvien.VisibleIndex = 5;
            this.colTenNhanvien.Width = 184;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Xem chi tiết";
            this.gridColumn1.ColumnEdit = this.ItemButtonEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 188;
            // 
            // ItemButtonEdit
            // 
            this.ItemButtonEdit.AutoHeight = false;
            this.ItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xem chi tiết", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ItemButtonEdit.Name = "ItemButtonEdit";
            this.ItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ItemButtonEdit_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LoadDataButton);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.EnddateEdit);
            this.groupControl1.Controls.Add(this.StartdateEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 269);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(253, 161);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Lọc Tìm kiếm";
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(112, 110);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDataButton.TabIndex = 2;
            this.LoadDataButton.Text = "Tải dữ liệu";
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Đến ngày";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Từ ngày";
            // 
            // EnddateEdit
            // 
            this.EnddateEdit.EditValue = null;
            this.EnddateEdit.Location = new System.Drawing.Point(87, 72);
            this.EnddateEdit.Name = "EnddateEdit";
            this.EnddateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EnddateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EnddateEdit.Size = new System.Drawing.Size(100, 20);
            this.EnddateEdit.TabIndex = 0;
            // 
            // StartdateEdit
            // 
            this.StartdateEdit.EditValue = null;
            this.StartdateEdit.Location = new System.Drawing.Point(87, 37);
            this.StartdateEdit.Name = "StartdateEdit";
            this.StartdateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartdateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.StartdateEdit.Size = new System.Drawing.Size(100, 20);
            this.StartdateEdit.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNavigator);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo ngày";
            // 
            // dateNavigator
            // 
            this.dateNavigator.DateTime = new System.DateTime(2014, 7, 31, 0, 0, 0, 0);
            this.dateNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator.HotDate = null;
            this.dateNavigator.Location = new System.Drawing.Point(3, 17);
            this.dateNavigator.Name = "dateNavigator";
            this.dateNavigator.CellPadding = new System.Windows.Forms.Padding(2);
            this.dateNavigator.Size = new System.Drawing.Size(247, 205);
            this.dateNavigator.TabIndex = 0;
            this.dateNavigator.EditDateModified += new System.EventHandler(this.dateNavigator_EditDateModified);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.radioGroup);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(253, 44);
            this.panelControl2.TabIndex = 3;
            // 
            // radioGroup
            // 
            this.radioGroup.EditValue = 0;
            this.radioGroup.Location = new System.Drawing.Point(18, 11);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tất cả"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Thu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Chi")});
            this.radioGroup.Size = new System.Drawing.Size(223, 25);
            this.radioGroup.TabIndex = 0;
            this.radioGroup.SelectedIndexChanged += new System.EventHandler(this.radioGroup_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ExcelButton);
            this.panelControl1.Controls.Add(this.PrintButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 430);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(253, 48);
            this.panelControl1.TabIndex = 2;
            // 
            // ExcelButton
            // 
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.Location = new System.Drawing.Point(103, 13);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(84, 23);
            this.ExcelButton.TabIndex = 0;
            this.ExcelButton.Text = "Xuất Excel";
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.Location = new System.Drawing.Point(18, 13);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(64, 23);
            this.PrintButton.TabIndex = 0;
            this.PrintButton.Text = "In";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // CacPhieuThuChiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 478);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "CacPhieuThuChiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CÁC PHIẾU THU CHI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CacPhieuThuChiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnddateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnddateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartdateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartdateEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl thuchiModelGridControl;
        private System.Windows.Forms.BindingSource thuchiModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDaumuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThanhtoan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton LoadDataButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit EnddateEdit;
        private DevExpress.XtraEditors.DateEdit StartdateEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton PrintButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTre;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThucte;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEdit;
        private DevExpress.XtraEditors.SimpleButton ExcelButton;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
    }
}