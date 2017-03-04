namespace TrainingAccounting.Form
{
    partial class HesoNgaytinhluongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesoNgaytinhluongForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.hesoTinhluongModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hesoTinhluongModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayApdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesoTinhluongModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesoTinhluongModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 266);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(382, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(292, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(199, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(108, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // hesoTinhluongModelBindingSource
            // 
            this.hesoTinhluongModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.HesoTinhluongModel);
            // 
            // hesoTinhluongModelGridControl
            // 
            this.hesoTinhluongModelGridControl.DataSource = this.hesoTinhluongModelBindingSource;
            this.hesoTinhluongModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hesoTinhluongModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.hesoTinhluongModelGridControl.MainView = this.gridView1;
            this.hesoTinhluongModelGridControl.Name = "hesoTinhluongModelGridControl";
            this.hesoTinhluongModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemCheckEdit});
            this.hesoTinhluongModelGridControl.Size = new System.Drawing.Size(382, 266);
            this.hesoTinhluongModelGridControl.TabIndex = 2;
            this.hesoTinhluongModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHeso,
            this.colNgayApdung,
            this.colSudung,
            this.colState});
            this.gridView1.GridControl = this.hesoTinhluongModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colHeso
            // 
            this.colHeso.AppearanceCell.Options.UseTextOptions = true;
            this.colHeso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeso.AppearanceHeader.Options.UseTextOptions = true;
            this.colHeso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeso.Caption = "Hệ số";
            this.colHeso.FieldName = "Heso";
            this.colHeso.Name = "colHeso";
            this.colHeso.Visible = true;
            this.colHeso.VisibleIndex = 0;
            // 
            // colNgayApdung
            // 
            this.colNgayApdung.Caption = "Ngày Áp dụng";
            this.colNgayApdung.FieldName = "NgayApdung";
            this.colNgayApdung.Name = "colNgayApdung";
            this.colNgayApdung.Visible = true;
            this.colNgayApdung.VisibleIndex = 1;
            // 
            // colSudung
            // 
            this.colSudung.AppearanceHeader.Options.UseTextOptions = true;
            this.colSudung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSudung.Caption = "Sử dụng";
            this.colSudung.ColumnEdit = this.ItemCheckEdit;
            this.colSudung.FieldName = "Sudung";
            this.colSudung.Name = "colSudung";
            this.colSudung.Visible = true;
            this.colSudung.VisibleIndex = 2;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 3;
            // 
            // ItemCheckEdit
            // 
            this.ItemCheckEdit.AutoHeight = false;
            this.ItemCheckEdit.Name = "ItemCheckEdit";
            this.ItemCheckEdit.CheckedChanged += new System.EventHandler(this.ItemCheckEdit_CheckedChanged);
            // 
            // HesoNgaytinhluongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 312);
            this.Controls.Add(this.hesoTinhluongModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "HesoNgaytinhluongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HỆ SỐ NGÀY TÍNH LƯƠNG";
            this.Load += new System.EventHandler(this.HesoNgaytinhluongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hesoTinhluongModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesoTinhluongModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource hesoTinhluongModelBindingSource;
        private DevExpress.XtraGrid.GridControl hesoTinhluongModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHeso;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayApdung;
        private DevExpress.XtraGrid.Columns.GridColumn colSudung;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ItemCheckEdit;
    }
}