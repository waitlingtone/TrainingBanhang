namespace TrainingAccounting.Form
{
    partial class TinhthanhForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhthanhForm));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.tinhthanhModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhthanhModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.DeleteButton);
            this.panelControl2.Controls.Add(this.SaveButton);
            this.panelControl2.Controls.Add(this.AddButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 447);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(831, 50);
            this.panelControl2.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(640, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.deleteSmallButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(740, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.Click += new System.EventHandler(this.saveSmallButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(544, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.addSmallButton_Click);
            // 
            // tinhthanhModelBindingSource
            // 
            this.tinhthanhModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.TinhthanhModel);
            // 
            // tinhthanhModelGridControl
            // 
            this.tinhthanhModelGridControl.DataSource = this.tinhthanhModelBindingSource;
            this.tinhthanhModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinhthanhModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.tinhthanhModelGridControl.MainView = this.gridView1;
            this.tinhthanhModelGridControl.Name = "tinhthanhModelGridControl";
            this.tinhthanhModelGridControl.Size = new System.Drawing.Size(831, 447);
            this.tinhthanhModelGridControl.TabIndex = 3;
            this.tinhthanhModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenTinh,
            this.colMaTinh,
            this.colState});
            this.gridView1.GridControl = this.tinhthanhModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenTinh
            // 
            this.colTenTinh.Caption = "Tên Tỉnh";
            this.colTenTinh.FieldName = "TenTinh";
            this.colTenTinh.Name = "colTenTinh";
            this.colTenTinh.Visible = true;
            this.colTenTinh.VisibleIndex = 1;
            // 
            // colMaTinh
            // 
            this.colMaTinh.Caption = "Mã Tỉnh";
            this.colMaTinh.FieldName = "MaTinh";
            this.colMaTinh.Name = "colMaTinh";
            this.colMaTinh.Visible = true;
            this.colMaTinh.VisibleIndex = 0;
            // 
            // colState
            // 
            this.colState.Caption = "Trạng thái";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            // 
            // TinhthanhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 497);
            this.Controls.Add(this.tinhthanhModelGridControl);
            this.Controls.Add(this.panelControl2);
            this.Name = "TinhthanhForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TỈNH THÀNH";
            this.Load += new System.EventHandler(this.TinhthanhForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource tinhthanhModelBindingSource;
        private DevExpress.XtraGrid.GridControl tinhthanhModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton AddButton;
    }
}