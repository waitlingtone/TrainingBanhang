namespace TrainingAccounting.Form
{
    partial class NganhangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NganhangForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nganhangModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.nganhangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenNganhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chinhanhNganhangModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.chinhanhNganhangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenChinhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.AddCNButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveCNButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteCNButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nganhangModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganhangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chinhanhNganhangModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhanhNganhangModelBindingSource)).BeginInit();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(933, 471);
            this.splitContainerControl1.SplitterPosition = 324;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nganhangModelGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(324, 423);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ngân hàng";
            // 
            // nganhangModelGridControl
            // 
            this.nganhangModelGridControl.DataSource = this.nganhangModelBindingSource;
            this.nganhangModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nganhangModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.nganhangModelGridControl.MainView = this.gridView1;
            this.nganhangModelGridControl.Name = "nganhangModelGridControl";
            this.nganhangModelGridControl.Size = new System.Drawing.Size(320, 400);
            this.nganhangModelGridControl.TabIndex = 1;
            this.nganhangModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nganhangModelBindingSource
            // 
            this.nganhangModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.NganhangModel);
            this.nganhangModelBindingSource.PositionChanged += new System.EventHandler(this.nganhangModelBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenNganhang,
            this.colState});
            this.gridView1.GridControl = this.nganhangModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenNganhang
            // 
            this.colTenNganhang.Caption = "Ngân hàng";
            this.colTenNganhang.FieldName = "TenNganhang";
            this.colTenNganhang.Name = "colTenNganhang";
            this.colTenNganhang.Visible = true;
            this.colTenNganhang.VisibleIndex = 0;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 423);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(324, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(46, 13);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(139, 13);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(231, 13);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.chinhanhNganhangModelGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(603, 423);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi nhánh Ngân hàng";
            // 
            // chinhanhNganhangModelGridControl
            // 
            this.chinhanhNganhangModelGridControl.DataSource = this.chinhanhNganhangModelBindingSource;
            this.chinhanhNganhangModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chinhanhNganhangModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.chinhanhNganhangModelGridControl.MainView = this.gridView2;
            this.chinhanhNganhangModelGridControl.Name = "chinhanhNganhangModelGridControl";
            this.chinhanhNganhangModelGridControl.Size = new System.Drawing.Size(599, 400);
            this.chinhanhNganhangModelGridControl.TabIndex = 0;
            this.chinhanhNganhangModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // chinhanhNganhangModelBindingSource
            // 
            this.chinhanhNganhangModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ChinhanhNganhangModel);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenChinhanh,
            this.colDiachi,
            this.colState1});
            this.gridView2.GridControl = this.chinhanhNganhangModelGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colTenChinhanh
            // 
            this.colTenChinhanh.Caption = "Chi nhánh";
            this.colTenChinhanh.FieldName = "TenChinhanh";
            this.colTenChinhanh.Name = "colTenChinhanh";
            this.colTenChinhanh.Visible = true;
            this.colTenChinhanh.VisibleIndex = 0;
            this.colTenChinhanh.Width = 390;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 1;
            this.colDiachi.Width = 656;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 2;
            this.colState1.Width = 124;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.AddCNButton);
            this.panelControl2.Controls.Add(this.SaveCNButton);
            this.panelControl2.Controls.Add(this.DeleteCNButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 423);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(603, 48);
            this.panelControl2.TabIndex = 0;
            // 
            // AddCNButton
            // 
            this.AddCNButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCNButton.Image = ((System.Drawing.Image)(resources.GetObject("AddCNButton.Image")));
            this.AddCNButton.Location = new System.Drawing.Point(323, 13);
            this.AddCNButton.Name = "AddCNButton";
            this.AddCNButton.Size = new System.Drawing.Size(75, 23);
            this.AddCNButton.TabIndex = 0;
            this.AddCNButton.Text = "Thêm";
            this.AddCNButton.Click += new System.EventHandler(this.AddCNButton_Click);
            // 
            // SaveCNButton
            // 
            this.SaveCNButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCNButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveCNButton.Image")));
            this.SaveCNButton.Location = new System.Drawing.Point(508, 13);
            this.SaveCNButton.Name = "SaveCNButton";
            this.SaveCNButton.Size = new System.Drawing.Size(75, 23);
            this.SaveCNButton.TabIndex = 0;
            this.SaveCNButton.Text = "Lưu lại";
            this.SaveCNButton.Click += new System.EventHandler(this.SaveCNButton_Click);
            // 
            // DeleteCNButton
            // 
            this.DeleteCNButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCNButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCNButton.Image")));
            this.DeleteCNButton.Location = new System.Drawing.Point(416, 13);
            this.DeleteCNButton.Name = "DeleteCNButton";
            this.DeleteCNButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCNButton.TabIndex = 0;
            this.DeleteCNButton.Text = "Xóa";
            this.DeleteCNButton.Click += new System.EventHandler(this.DeleteCNButton_Click);
            // 
            // NganhangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 471);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "NganhangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NGÂN HÀNG";
            this.Load += new System.EventHandler(this.NganhangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nganhangModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganhangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chinhanhNganhangModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhanhNganhangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl nganhangModelGridControl;
        private System.Windows.Forms.BindingSource nganhangModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganhang;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl chinhanhNganhangModelGridControl;
        private System.Windows.Forms.BindingSource chinhanhNganhangModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChinhanh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton AddCNButton;
        private DevExpress.XtraEditors.SimpleButton SaveCNButton;
        private DevExpress.XtraEditors.SimpleButton DeleteCNButton;
    }
}