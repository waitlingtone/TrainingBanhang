namespace TrainingAccounting.Form
{
    partial class DongiaHocphiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DongiaHocphiForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.dongiaHocphiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dongiaHocphiModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayApdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dongiaHocphiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongiaHocphiModelGridControl)).BeginInit();
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
            this.panelControl1.Location = new System.Drawing.Point(0, 340);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(751, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(475, 12);
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
            this.DeleteButton.Location = new System.Drawing.Point(571, 12);
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
            this.SaveButton.Location = new System.Drawing.Point(664, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dongiaHocphiModelBindingSource
            // 
            this.dongiaHocphiModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.DongiaHocphiModel);
            // 
            // dongiaHocphiModelGridControl
            // 
            this.dongiaHocphiModelGridControl.DataSource = this.dongiaHocphiModelBindingSource;
            this.dongiaHocphiModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dongiaHocphiModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.dongiaHocphiModelGridControl.MainView = this.gridView1;
            this.dongiaHocphiModelGridControl.Name = "dongiaHocphiModelGridControl";
            this.dongiaHocphiModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemCheckEdit});
            this.dongiaHocphiModelGridControl.Size = new System.Drawing.Size(751, 340);
            this.dongiaHocphiModelGridControl.TabIndex = 2;
            this.dongiaHocphiModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSotien,
            this.colNgayApdung,
            this.colSudung,
            this.colGhichu,
            this.colState});
            this.gridView1.GridControl = this.dongiaHocphiModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSotien
            // 
            this.colSotien.Caption = "Đơn giá";
            this.colSotien.DisplayFormat.FormatString = "#,#";
            this.colSotien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSotien.FieldName = "Sotien";
            this.colSotien.Name = "colSotien";
            this.colSotien.Visible = true;
            this.colSotien.VisibleIndex = 0;
            // 
            // colNgayApdung
            // 
            this.colNgayApdung.Caption = "Ngày áp dụng";
            this.colNgayApdung.FieldName = "NgayApdung";
            this.colNgayApdung.Name = "colNgayApdung";
            this.colNgayApdung.Visible = true;
            this.colNgayApdung.VisibleIndex = 1;
            // 
            // colSudung
            // 
            this.colSudung.Caption = "Sử dụng";
            this.colSudung.ColumnEdit = this.ItemCheckEdit;
            this.colSudung.FieldName = "Sudung";
            this.colSudung.Name = "colSudung";
            this.colSudung.Visible = true;
            this.colSudung.VisibleIndex = 2;
            // 
            // ItemCheckEdit
            // 
            this.ItemCheckEdit.AutoHeight = false;
            this.ItemCheckEdit.Name = "ItemCheckEdit";
            this.ItemCheckEdit.CheckedChanged += new System.EventHandler(this.ItemCheckEdit_CheckedChanged);
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 4;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 3;
            // 
            // DongiaHocphiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 388);
            this.Controls.Add(this.dongiaHocphiModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "DongiaHocphiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đơn giá Học phí";
            this.Load += new System.EventHandler(this.DongiaHocphiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dongiaHocphiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongiaHocphiModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource dongiaHocphiModelBindingSource;
        private DevExpress.XtraGrid.GridControl dongiaHocphiModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSotien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayApdung;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colSudung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
    }
}