namespace TrainingAccounting.Form
{
    partial class BackupInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupInfoForm));
            this.backupInfoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backupInfoModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BackupButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.backupInfoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupInfoModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backupInfoModelBindingSource
            // 
            this.backupInfoModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.BackupInfoModel);
            // 
            // backupInfoModelGridControl
            // 
            this.backupInfoModelGridControl.DataSource = this.backupInfoModelBindingSource;
            this.backupInfoModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupInfoModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.backupInfoModelGridControl.MainView = this.gridView1;
            this.backupInfoModelGridControl.Name = "backupInfoModelGridControl";
            this.backupInfoModelGridControl.Size = new System.Drawing.Size(751, 400);
            this.backupInfoModelGridControl.TabIndex = 1;
            this.backupInfoModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTime,
            this.colTenFile,
            this.colPath});
            this.gridView1.GridControl = this.backupInfoModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTime, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colTime
            // 
            this.colTime.Caption = "Thời gian";
            this.colTime.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTime.FieldName = "Time";
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 0;
            // 
            // colTenFile
            // 
            this.colTenFile.Caption = "Tên file";
            this.colTenFile.FieldName = "TenFile";
            this.colTenFile.Name = "colTenFile";
            this.colTenFile.Visible = true;
            this.colTenFile.VisibleIndex = 1;
            // 
            // colPath
            // 
            this.colPath.Caption = "Địa chỉ lưu";
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.Visible = true;
            this.colPath.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.BackupButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 400);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(751, 59);
            this.panelControl1.TabIndex = 2;
            // 
            // BackupButton
            // 
            this.BackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupButton.Image = ((System.Drawing.Image)(resources.GetObject("BackupButton.Image")));
            this.BackupButton.Location = new System.Drawing.Point(587, 13);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(148, 34);
            this.BackupButton.TabIndex = 0;
            this.BackupButton.Text = "Tạo Backup dữ liệu";
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // BackupInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 459);
            this.Controls.Add(this.backupInfoModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "BackupInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN BACKUP DỮ LIỆU";
            this.Load += new System.EventHandler(this.BackupInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backupInfoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupInfoModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource backupInfoModelBindingSource;
        private DevExpress.XtraGrid.GridControl backupInfoModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraGrid.Columns.GridColumn colTenFile;
        private DevExpress.XtraGrid.Columns.GridColumn colPath;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton BackupButton;
    }
}