namespace TrainingAccounting.Form
{
    partial class BosungLuongNhanvienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BosungLuongNhanvienForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BosungButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.nhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHodem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.BosungButton);
            this.panelControl1.Controls.Add(this.CancelButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 332);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(621, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // BosungButton
            // 
            this.BosungButton.Image = ((System.Drawing.Image)(resources.GetObject("BosungButton.Image")));
            this.BosungButton.Location = new System.Drawing.Point(431, 16);
            this.BosungButton.Name = "BosungButton";
            this.BosungButton.Size = new System.Drawing.Size(75, 23);
            this.BosungButton.TabIndex = 0;
            this.BosungButton.Text = "Bổ sung";
            this.BosungButton.Click += new System.EventHandler(this.BosungButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.Location = new System.Drawing.Point(534, 16);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Hủy bỏ";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // nhanvienModelBindingSource
            // 
            this.nhanvienModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.NhanvienModel);
            // 
            // nhanvienModelGridControl
            // 
            this.nhanvienModelGridControl.DataSource = this.nhanvienModelBindingSource;
            this.nhanvienModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvienModelGridControl.Location = new System.Drawing.Point(0, 43);
            this.nhanvienModelGridControl.MainView = this.gridView1;
            this.nhanvienModelGridControl.Name = "nhanvienModelGridControl";
            this.nhanvienModelGridControl.Size = new System.Drawing.Size(621, 289);
            this.nhanvienModelGridControl.TabIndex = 2;
            this.nhanvienModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHodem,
            this.colTen,
            this.colSelected});
            this.gridView1.GridControl = this.nhanvienModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colHodem
            // 
            this.colHodem.Caption = "Họ đệm";
            this.colHodem.FieldName = "Hodem";
            this.colHodem.Name = "colHodem";
            this.colHodem.Visible = true;
            this.colHodem.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            // 
            // colSelected
            // 
            this.colSelected.AppearanceHeader.Options.UseTextOptions = true;
            this.colSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSelected.Caption = "Chọn bổ sung";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.checkEdit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(621, 43);
            this.panelControl2.TabIndex = 3;
            // 
            // checkEdit
            // 
            this.checkEdit.EditValue = true;
            this.checkEdit.Location = new System.Drawing.Point(12, 12);
            this.checkEdit.Name = "checkEdit";
            this.checkEdit.Properties.Caption = " Còn làm việc";
            this.checkEdit.Size = new System.Drawing.Size(102, 19);
            this.checkEdit.TabIndex = 0;
            this.checkEdit.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // BosungLuongNhanvienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 383);
            this.Controls.Add(this.nhanvienModelGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "BosungLuongNhanvienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BỔ SUNH NHÂN VIÊN VÀO BẢNG TÍNH LƯƠNG";
            this.Load += new System.EventHandler(this.BosungLuongNhanvienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton BosungButton;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private System.Windows.Forms.BindingSource nhanvienModelBindingSource;
        private DevExpress.XtraGrid.GridControl nhanvienModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHodem;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit;
    }
}