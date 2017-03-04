namespace TrainingAccounting.Form
{
    partial class BangluongChuyenKhoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangluongChuyenKhoanForm));
            this.bangluongChuyenkhoanModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangluongChuyenkhoanModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNhanvienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.nhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTenNganhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChinhanhNganhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TailaiButton = new DevExpress.XtraEditors.SimpleButton();
            this.NamspinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ThangcomboBox = new System.Windows.Forms.ComboBox();
            this.thangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.PrintButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bangluongChuyenkhoanModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangluongChuyenkhoanModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamspinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangluongChuyenkhoanModelBindingSource
            // 
            this.bangluongChuyenkhoanModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.BangluongChuyenkhoanModel);
            // 
            // bangluongChuyenkhoanModelGridControl
            // 
            this.bangluongChuyenkhoanModelGridControl.DataSource = this.bangluongChuyenkhoanModelBindingSource;
            this.bangluongChuyenkhoanModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bangluongChuyenkhoanModelGridControl.Location = new System.Drawing.Point(0, 46);
            this.bangluongChuyenkhoanModelGridControl.MainView = this.gridView1;
            this.bangluongChuyenkhoanModelGridControl.Name = "bangluongChuyenkhoanModelGridControl";
            this.bangluongChuyenkhoanModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.bangluongChuyenkhoanModelGridControl.Size = new System.Drawing.Size(988, 411);
            this.bangluongChuyenkhoanModelGridControl.TabIndex = 2;
            this.bangluongChuyenkhoanModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colNhanvienId,
            this.colTenNganhang,
            this.colChinhanhNganhang,
            this.colSoTaikhoan,
            this.colDiachi,
            this.colNoidung,
            this.colSotien,
            this.colState});
            this.gridView1.GridControl = this.bangluongChuyenkhoanModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNhanvienId
            // 
            this.colNhanvienId.Caption = "Nhân viên";
            this.colNhanvienId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colNhanvienId.FieldName = "NhanvienId";
            this.colNhanvienId.Name = "colNhanvienId";
            this.colNhanvienId.OptionsColumn.AllowEdit = false;
            this.colNhanvienId.Visible = true;
            this.colNhanvienId.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.nhanvienModelBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "HoTenNhanvien";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "NhanvienId";
            // 
            // nhanvienModelBindingSource
            // 
            this.nhanvienModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.NhanvienModel);
            // 
            // colTenNganhang
            // 
            this.colTenNganhang.Caption = "Ngân hàng";
            this.colTenNganhang.FieldName = "TenNganhang";
            this.colTenNganhang.Name = "colTenNganhang";
            this.colTenNganhang.Visible = true;
            this.colTenNganhang.VisibleIndex = 2;
            // 
            // colChinhanhNganhang
            // 
            this.colChinhanhNganhang.Caption = "Chi nhánh";
            this.colChinhanhNganhang.FieldName = "ChinhanhNganhang";
            this.colChinhanhNganhang.Name = "colChinhanhNganhang";
            this.colChinhanhNganhang.Visible = true;
            this.colChinhanhNganhang.VisibleIndex = 3;
            // 
            // colSoTaikhoan
            // 
            this.colSoTaikhoan.Caption = "Số Tài khoản";
            this.colSoTaikhoan.FieldName = "SoTaikhoan";
            this.colSoTaikhoan.Name = "colSoTaikhoan";
            this.colSoTaikhoan.Visible = true;
            this.colSoTaikhoan.VisibleIndex = 4;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 6;
            // 
            // colNoidung
            // 
            this.colNoidung.Caption = "Nội dung";
            this.colNoidung.FieldName = "Noidung";
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.Visible = true;
            this.colNoidung.VisibleIndex = 5;
            // 
            // colSotien
            // 
            this.colSotien.Caption = "Số tiền";
            this.colSotien.FieldName = "Sotien";
            this.colSotien.Name = "colSotien";
            this.colSotien.Visible = true;
            this.colSotien.VisibleIndex = 7;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.TailaiButton);
            this.panelControl1.Controls.Add(this.NamspinEdit);
            this.panelControl1.Controls.Add(this.ThangcomboBox);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(988, 46);
            this.panelControl1.TabIndex = 3;
            // 
            // TailaiButton
            // 
            this.TailaiButton.Location = new System.Drawing.Point(297, 12);
            this.TailaiButton.Name = "TailaiButton";
            this.TailaiButton.Size = new System.Drawing.Size(75, 21);
            this.TailaiButton.TabIndex = 3;
            this.TailaiButton.Text = "Tải lại";
            this.TailaiButton.Click += new System.EventHandler(this.TailaiButton_Click);
            // 
            // NamspinEdit
            // 
            this.NamspinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NamspinEdit.Location = new System.Drawing.Point(205, 12);
            this.NamspinEdit.Name = "NamspinEdit";
            this.NamspinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.NamspinEdit.Size = new System.Drawing.Size(65, 20);
            this.NamspinEdit.TabIndex = 2;
            // 
            // ThangcomboBox
            // 
            this.ThangcomboBox.DataSource = this.thangModelBindingSource;
            this.ThangcomboBox.DisplayMember = "Tenthang";
            this.ThangcomboBox.FormattingEnabled = true;
            this.ThangcomboBox.Location = new System.Drawing.Point(64, 12);
            this.ThangcomboBox.Name = "ThangcomboBox";
            this.ThangcomboBox.Size = new System.Drawing.Size(79, 21);
            this.ThangcomboBox.TabIndex = 1;
            this.ThangcomboBox.ValueMember = "Thang";
            // 
            // thangModelBindingSource
            // 
            this.thangModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ThangModel);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(169, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Năm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tháng";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.PrintButton);
            this.panelControl2.Controls.Add(this.DeleteButton);
            this.panelControl2.Controls.Add(this.SaveButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 457);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(988, 49);
            this.panelControl2.TabIndex = 4;
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.Location = new System.Drawing.Point(681, 14);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(102, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "In Danh sách";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(805, 14);
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
            this.SaveButton.Location = new System.Drawing.Point(901, 14);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // BangluongChuyenKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(988, 506);
            this.Controls.Add(this.bangluongChuyenkhoanModelGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "BangluongChuyenKhoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BẢNG LƯƠNG CHUYỂN KHOẢN";
            this.Load += new System.EventHandler(this.BangluongChuyenKhoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangluongChuyenkhoanModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangluongChuyenkhoanModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamspinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bangluongChuyenkhoanModelBindingSource;
        private DevExpress.XtraGrid.GridControl bangluongChuyenkhoanModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanvienId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource nhanvienModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganhang;
        private DevExpress.XtraGrid.Columns.GridColumn colChinhanhNganhang;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTaikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colNoidung;
        private DevExpress.XtraGrid.Columns.GridColumn colSotien;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton TailaiButton;
        private DevExpress.XtraEditors.SpinEdit NamspinEdit;
        private System.Windows.Forms.ComboBox ThangcomboBox;
        private System.Windows.Forms.BindingSource thangModelBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton PrintButton;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
    }
}