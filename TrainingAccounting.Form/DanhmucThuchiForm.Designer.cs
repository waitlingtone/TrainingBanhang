namespace TrainingAccounting.Form
{
    partial class DanhmucThuchiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhmucThuchiForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.daumucThuchiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daumucThuchiModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDaumuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 446);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(427, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(142, 12);
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
            this.DeleteButton.Location = new System.Drawing.Point(239, 12);
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
            this.SaveButton.Location = new System.Drawing.Point(331, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.daumucThuchiModelGridControl.Size = new System.Drawing.Size(427, 446);
            this.daumucThuchiModelGridControl.TabIndex = 2;
            this.daumucThuchiModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDaumuc,
            this.colIsThu,
            this.colState});
            this.gridView1.GridControl = this.daumucThuchiModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenDaumuc
            // 
            this.colTenDaumuc.Caption = "Đầu mục Thu/Chi";
            this.colTenDaumuc.FieldName = "TenDaumuc";
            this.colTenDaumuc.Name = "colTenDaumuc";
            this.colTenDaumuc.Visible = true;
            this.colTenDaumuc.VisibleIndex = 0;
            // 
            // colIsThu
            // 
            this.colIsThu.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsThu.Caption = "Là khoản thu";
            this.colIsThu.FieldName = "IsThu";
            this.colIsThu.Name = "colIsThu";
            this.colIsThu.Visible = true;
            this.colIsThu.VisibleIndex = 1;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            // 
            // DanhmucThuchiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 493);
            this.Controls.Add(this.daumucThuchiModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "DanhmucThuchiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH MỤC THU / CHI";
            this.Load += new System.EventHandler(this.DanhmucThuchiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource daumucThuchiModelBindingSource;
        private DevExpress.XtraGrid.GridControl daumucThuchiModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDaumuc;
        private DevExpress.XtraGrid.Columns.GridColumn colIsThu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
    }
}