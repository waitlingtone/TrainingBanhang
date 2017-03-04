namespace TrainingAccounting.Form
{
    partial class DanhmucChiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhmucChiForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.HuyButton = new DevExpress.XtraEditors.SimpleButton();
            this.ChonButton = new DevExpress.XtraEditors.SimpleButton();
            this.daumucThuchiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daumucThuchiModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDaumuc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.HuyButton);
            this.panelControl1.Controls.Add(this.ChonButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 250);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(364, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // HuyButton
            // 
            this.HuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HuyButton.Image = ((System.Drawing.Image)(resources.GetObject("HuyButton.Image")));
            this.HuyButton.Location = new System.Drawing.Point(265, 16);
            this.HuyButton.Name = "HuyButton";
            this.HuyButton.Size = new System.Drawing.Size(75, 23);
            this.HuyButton.TabIndex = 0;
            this.HuyButton.Text = "Hủy bỏ";
            this.HuyButton.Click += new System.EventHandler(this.HuyButton_Click);
            // 
            // ChonButton
            // 
            this.ChonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChonButton.Image = ((System.Drawing.Image)(resources.GetObject("ChonButton.Image")));
            this.ChonButton.Location = new System.Drawing.Point(174, 16);
            this.ChonButton.Name = "ChonButton";
            this.ChonButton.Size = new System.Drawing.Size(75, 23);
            this.ChonButton.TabIndex = 0;
            this.ChonButton.Text = "Chọn";
            this.ChonButton.Click += new System.EventHandler(this.ChonButton_Click);
            // 
            // daumucThuchiModelBindingSource
            // 
            this.daumucThuchiModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.DaumucThuchiModel);
            // 
            // daumucThuchiModelGridControl
            // 
            this.daumucThuchiModelGridControl.DataSource = this.daumucThuchiModelBindingSource;
            this.daumucThuchiModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daumucThuchiModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.daumucThuchiModelGridControl.MainView = this.gridView1;
            this.daumucThuchiModelGridControl.Name = "daumucThuchiModelGridControl";
            this.daumucThuchiModelGridControl.Size = new System.Drawing.Size(364, 250);
            this.daumucThuchiModelGridControl.TabIndex = 2;
            this.daumucThuchiModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDaumuc});
            this.gridView1.GridControl = this.daumucThuchiModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenDaumuc
            // 
            this.colTenDaumuc.Caption = "Danh mục Chi";
            this.colTenDaumuc.FieldName = "TenDaumuc";
            this.colTenDaumuc.Name = "colTenDaumuc";
            this.colTenDaumuc.Visible = true;
            this.colTenDaumuc.VisibleIndex = 0;
            // 
            // DanhmucChiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 301);
            this.Controls.Add(this.daumucThuchiModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "DanhmucChiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH MỤC CHI";
            this.Load += new System.EventHandler(this.DanhmucThuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton HuyButton;
        private DevExpress.XtraEditors.SimpleButton ChonButton;
        private System.Windows.Forms.BindingSource daumucThuchiModelBindingSource;
        private DevExpress.XtraGrid.GridControl daumucThuchiModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDaumuc;
    }
}