namespace TrainingAccounting.Form
{
    partial class ChonNoidungForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonNoidungForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.SelectButton = new DevExpress.XtraEditors.SimpleButton();
            this.nDGiangdayModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nDGiangdayModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDGiangdayModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDGiangdayModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.SelectButton);
            this.panelControl1.Controls.Add(this.CancelButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 442);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(426, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.Location = new System.Drawing.Point(337, 18);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Hủy bỏ";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectButton.Image")));
            this.SelectButton.Location = new System.Drawing.Point(245, 18);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Chọn";
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // nDGiangdayModelBindingSource
            // 
            this.nDGiangdayModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.NDGiangdayModel);
            // 
            // nDGiangdayModelGridControl
            // 
            this.nDGiangdayModelGridControl.DataSource = this.nDGiangdayModelBindingSource;
            this.nDGiangdayModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nDGiangdayModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.nDGiangdayModelGridControl.MainView = this.gridView1;
            this.nDGiangdayModelGridControl.Name = "nDGiangdayModelGridControl";
            this.nDGiangdayModelGridControl.Size = new System.Drawing.Size(426, 442);
            this.nDGiangdayModelGridControl.TabIndex = 2;
            this.nDGiangdayModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNoidung,
            this.colSelected});
            this.gridView1.GridControl = this.nDGiangdayModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNoidung
            // 
            this.colNoidung.Caption = "Nội dung";
            this.colNoidung.FieldName = "Noidung";
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.Visible = true;
            this.colNoidung.VisibleIndex = 0;
            this.colNoidung.Width = 916;
            // 
            // colSelected
            // 
            this.colSelected.Caption = "Chọn";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 1;
            this.colSelected.Width = 244;
            // 
            // ChonNoidungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 495);
            this.Controls.Add(this.nDGiangdayModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChonNoidungForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHỌN NỘI DUNG";
            this.Load += new System.EventHandler(this.ChonNoidungForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nDGiangdayModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDGiangdayModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton SelectButton;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private System.Windows.Forms.BindingSource nDGiangdayModelBindingSource;
        private DevExpress.XtraGrid.GridControl nDGiangdayModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNoidung;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
    }
}