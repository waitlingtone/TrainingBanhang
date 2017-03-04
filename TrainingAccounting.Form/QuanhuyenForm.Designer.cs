namespace TrainingAccounting.Form
{
    partial class QuanhuyenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanhuyenForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tinhThanhcomboBox = new System.Windows.Forms.ComboBox();
            this.tinhthanhModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.quanhuyenModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanhuyenModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaQuanhuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenQuanhuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.tinhThanhcomboBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(777, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Chọn Tỉnh / Thành";
            // 
            // tinhThanhcomboBox
            // 
            this.tinhThanhcomboBox.DataSource = this.tinhthanhModelBindingSource;
            this.tinhThanhcomboBox.DisplayMember = "TenTinh";
            this.tinhThanhcomboBox.FormattingEnabled = true;
            this.tinhThanhcomboBox.Location = new System.Drawing.Point(120, 12);
            this.tinhThanhcomboBox.Name = "tinhThanhcomboBox";
            this.tinhThanhcomboBox.Size = new System.Drawing.Size(245, 21);
            this.tinhThanhcomboBox.TabIndex = 0;
            this.tinhThanhcomboBox.ValueMember = "TinhthanhId";
            this.tinhThanhcomboBox.SelectedValueChanged += new System.EventHandler(this.tinhThanhcomboBox_SelectedValueChanged);
            // 
            // tinhthanhModelBindingSource
            // 
            this.tinhthanhModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.TinhthanhModel);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.SaveButton);
            this.panelControl2.Controls.Add(this.DeleteButton);
            this.panelControl2.Controls.Add(this.AddButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 427);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(777, 48);
            this.panelControl2.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(690, 13);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.Click += new System.EventHandler(this.saveSmallButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(592, 13);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.deleteSmallButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(495, 13);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.addSmallButton_Click);
            // 
            // quanhuyenModelBindingSource
            // 
            this.quanhuyenModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.QuanhuyenModel);
            // 
            // quanhuyenModelGridControl
            // 
            this.quanhuyenModelGridControl.DataSource = this.quanhuyenModelBindingSource;
            this.quanhuyenModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanhuyenModelGridControl.Location = new System.Drawing.Point(0, 45);
            this.quanhuyenModelGridControl.MainView = this.gridView1;
            this.quanhuyenModelGridControl.Name = "quanhuyenModelGridControl";
            this.quanhuyenModelGridControl.Size = new System.Drawing.Size(777, 382);
            this.quanhuyenModelGridControl.TabIndex = 3;
            this.quanhuyenModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaQuanhuyen,
            this.colTenQuanhuyen,
            this.colState});
            this.gridView1.GridControl = this.quanhuyenModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaQuanhuyen
            // 
            this.colMaQuanhuyen.Caption = "Mã Quận/Huyện";
            this.colMaQuanhuyen.FieldName = "MaQuanhuyen";
            this.colMaQuanhuyen.Name = "colMaQuanhuyen";
            this.colMaQuanhuyen.Visible = true;
            this.colMaQuanhuyen.VisibleIndex = 0;
            // 
            // colTenQuanhuyen
            // 
            this.colTenQuanhuyen.Caption = "Tên Quận/Huyện";
            this.colTenQuanhuyen.FieldName = "TenQuanhuyen";
            this.colTenQuanhuyen.Name = "colTenQuanhuyen";
            this.colTenQuanhuyen.Visible = true;
            this.colTenQuanhuyen.VisibleIndex = 1;
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
            // QuanhuyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 475);
            this.Controls.Add(this.quanhuyenModelGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "QuanhuyenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẬN / HUYỆN";
            this.Load += new System.EventHandler(this.QuanhuyenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox tinhThanhcomboBox;
        private System.Windows.Forms.BindingSource quanhuyenModelBindingSource;
        private DevExpress.XtraGrid.GridControl quanhuyenModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaQuanhuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colTenQuanhuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private System.Windows.Forms.BindingSource tinhthanhModelBindingSource;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton AddButton;
    }
}