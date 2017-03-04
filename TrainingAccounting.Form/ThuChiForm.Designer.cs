namespace TrainingAccounting.Form
{
    partial class ThuChiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuChiForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DaumucThuChicomboBox = new System.Windows.Forms.ComboBox();
            this.daumucThuchiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.thuchiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuchiModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDaumuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddNewButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.PrintButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.colNgayThanhtoan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.DaumucThuChicomboBox);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.radioGroup);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(722, 75);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hình thức";
            // 
            // DaumucThuChicomboBox
            // 
            this.DaumucThuChicomboBox.DataSource = this.daumucThuchiModelBindingSource;
            this.DaumucThuChicomboBox.DisplayMember = "TenDaumuc";
            this.DaumucThuChicomboBox.FormattingEnabled = true;
            this.DaumucThuChicomboBox.Location = new System.Drawing.Point(319, 35);
            this.DaumucThuChicomboBox.Name = "DaumucThuChicomboBox";
            this.DaumucThuChicomboBox.Size = new System.Drawing.Size(280, 21);
            this.DaumucThuChicomboBox.TabIndex = 2;
            this.DaumucThuChicomboBox.ValueMember = "DaumucThuchiId";
            this.DaumucThuChicomboBox.SelectedValueChanged += new System.EventHandler(this.DaumucThuChicomboBox_SelectedValueChanged);
            // 
            // daumucThuchiModelBindingSource
            // 
            this.daumucThuchiModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.DaumucThuchiModel);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(221, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Đầu mục Thu Chi";
            // 
            // radioGroup
            // 
            this.radioGroup.EditValue = 1;
            this.radioGroup.Location = new System.Drawing.Point(23, 36);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Thu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Chi")});
            this.radioGroup.Size = new System.Drawing.Size(172, 20);
            this.radioGroup.TabIndex = 0;
            // 
            // thuchiModelBindingSource
            // 
            this.thuchiModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ThuchiModel);
            // 
            // thuchiModelGridControl
            // 
            this.thuchiModelGridControl.DataSource = this.thuchiModelBindingSource;
            this.thuchiModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thuchiModelGridControl.Location = new System.Drawing.Point(0, 75);
            this.thuchiModelGridControl.MainView = this.gridView1;
            this.thuchiModelGridControl.Name = "thuchiModelGridControl";
            this.thuchiModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit});
            this.thuchiModelGridControl.Size = new System.Drawing.Size(722, 226);
            this.thuchiModelGridControl.TabIndex = 2;
            this.thuchiModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDaumuc,
            this.colSoTien,
            this.colNgayThanhtoan,
            this.colState});
            this.gridView1.GridControl = this.thuchiModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số tiền";
            this.colSoTien.DisplayFormat.FormatString = "#,#";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 1;
            // 
            // colTenDaumuc
            // 
            this.colTenDaumuc.Caption = "Đầu mục Thu Chi";
            this.colTenDaumuc.ColumnEdit = this.repositoryItemMemoEdit;
            this.colTenDaumuc.FieldName = "TenDaumuc";
            this.colTenDaumuc.Name = "colTenDaumuc";
            this.colTenDaumuc.Visible = true;
            this.colTenDaumuc.VisibleIndex = 0;
            // 
            // repositoryItemMemoEdit
            // 
            this.repositoryItemMemoEdit.Name = "repositoryItemMemoEdit";
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddNewButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Controls.Add(this.PrintButton);
            this.panelControl1.Controls.Add(this.CancelButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 301);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(722, 46);
            this.panelControl1.TabIndex = 3;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNewButton.Image")));
            this.AddNewButton.Location = new System.Drawing.Point(23, 11);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(128, 23);
            this.AddNewButton.TabIndex = 0;
            this.AddNewButton.Text = "Tạo Thu/Chi khác";
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(435, 11);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.Location = new System.Drawing.Point(538, 11);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 0;
            this.PrintButton.Text = "In";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.Location = new System.Drawing.Point(635, 11);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Hủy bỏ";
            // 
            // colNgayThanhtoan
            // 
            this.colNgayThanhtoan.Caption = "Ngày Thanh toán";
            this.colNgayThanhtoan.FieldName = "NgayThanhtoan";
            this.colNgayThanhtoan.Name = "colNgayThanhtoan";
            this.colNgayThanhtoan.Visible = true;
            this.colNgayThanhtoan.VisibleIndex = 2;
            // 
            // ThuChiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 347);
            this.Controls.Add(this.thuchiModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ThuChiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THU CHI";
            this.Load += new System.EventHandler(this.ThuChiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daumucThuchiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox DaumucThuChicomboBox;
        private System.Windows.Forms.BindingSource daumucThuchiModelBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
        private System.Windows.Forms.BindingSource thuchiModelBindingSource;
        private DevExpress.XtraGrid.GridControl thuchiModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDaumuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton PrintButton;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton AddNewButton;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThanhtoan;
    }
}