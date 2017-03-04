namespace Phanquyen.Forms
{
    partial class TaikhoanForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaikhoanForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.canboModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.nguoidungModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenNguoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChonButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.AddNDButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteNDButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveNDButton = new DevExpress.XtraEditors.SimpleButton();
            this._UserModelGridControl = new DevExpress.XtraGrid.GridControl();
            this._UserModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNguoidungId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTenDangnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatkhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canboModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoidungModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChonButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._UserModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._UserModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(989, 385);
            this.splitContainerControl1.SplitterPosition = 395;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // canboModelGridControl
            // 
            this.canboModelGridControl.DataSource = this.nguoidungModelBindingSource;
            this.canboModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canboModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.canboModelGridControl.MainView = this.gridView1;
            this.canboModelGridControl.Name = "canboModelGridControl";
            this.canboModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ChonButtonEdit});
            this.canboModelGridControl.Size = new System.Drawing.Size(391, 312);
            this.canboModelGridControl.TabIndex = 0;
            this.canboModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nguoidungModelBindingSource
            // 
            this.nguoidungModelBindingSource.DataSource = typeof(Phanquyen.Model.BusinessObject.NguoidungModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenNguoidung,
            this.colState,
            this.gridColumn1});
            this.gridView1.GridControl = this.canboModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenNguoidung
            // 
            this.colTenNguoidung.Caption = "Người dùng";
            this.colTenNguoidung.FieldName = "TenNguoidung";
            this.colTenNguoidung.Name = "colTenNguoidung";
            this.colTenNguoidung.Visible = true;
            this.colTenNguoidung.VisibleIndex = 0;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.ChonButtonEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // ChonButtonEdit
            // 
            this.ChonButtonEdit.AutoHeight = false;
            this.ChonButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Tạo Tài khoản", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ChonButtonEdit.Name = "ChonButtonEdit";
            this.ChonButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ChonButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ChonButtonEdit_ButtonClick);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.AddNDButton);
            this.panelControl2.Controls.Add(this.DeleteNDButton);
            this.panelControl2.Controls.Add(this.SaveNDButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 335);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(395, 50);
            this.panelControl2.TabIndex = 1;
            // 
            // AddNDButton
            // 
            this.AddNDButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNDButton.Image")));
            this.AddNDButton.Location = new System.Drawing.Point(106, 15);
            this.AddNDButton.Name = "AddNDButton";
            this.AddNDButton.Size = new System.Drawing.Size(81, 23);
            this.AddNDButton.TabIndex = 0;
            this.AddNDButton.Text = "Thêm mới";
            this.AddNDButton.Click += new System.EventHandler(this.AddNDButton_Click);
            // 
            // DeleteNDButton
            // 
            this.DeleteNDButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteNDButton.Image")));
            this.DeleteNDButton.Location = new System.Drawing.Point(209, 15);
            this.DeleteNDButton.Name = "DeleteNDButton";
            this.DeleteNDButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNDButton.TabIndex = 0;
            this.DeleteNDButton.Text = "Xóa";
            this.DeleteNDButton.Click += new System.EventHandler(this.DeleteNDButton_Click);
            // 
            // SaveNDButton
            // 
            this.SaveNDButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveNDButton.Image")));
            this.SaveNDButton.Location = new System.Drawing.Point(302, 15);
            this.SaveNDButton.Name = "SaveNDButton";
            this.SaveNDButton.Size = new System.Drawing.Size(75, 23);
            this.SaveNDButton.TabIndex = 0;
            this.SaveNDButton.Text = "Lưu lại";
            this.SaveNDButton.Click += new System.EventHandler(this.SaveNDButton_Click);
            // 
            // _UserModelGridControl
            // 
            this._UserModelGridControl.DataSource = this._UserModelBindingSource;
            this._UserModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._UserModelGridControl.Location = new System.Drawing.Point(2, 21);
            this._UserModelGridControl.MainView = this.gridView2;
            this._UserModelGridControl.Name = "_UserModelGridControl";
            this._UserModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this._UserModelGridControl.Size = new System.Drawing.Size(585, 312);
            this._UserModelGridControl.TabIndex = 0;
            this._UserModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // _UserModelBindingSource
            // 
            this._UserModelBindingSource.DataSource = typeof(Phanquyen.Model.BusinessObject._UserModel);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNguoidungId,
            this.colTenDangnhap,
            this.colMatkhau,
            this.colEnable,
            this.colState1});
            this.gridView2.GridControl = this._UserModelGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colNguoidungId
            // 
            this.colNguoidungId.Caption = "Tên Người dùng";
            this.colNguoidungId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colNguoidungId.FieldName = "NguoidungId";
            this.colNguoidungId.Name = "colNguoidungId";
            this.colNguoidungId.OptionsColumn.AllowEdit = false;
            this.colNguoidungId.Visible = true;
            this.colNguoidungId.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.nguoidungModelBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "TenNguoidung";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "NguoidungId";
            // 
            // colTenDangnhap
            // 
            this.colTenDangnhap.Caption = "Tên đăng nhập";
            this.colTenDangnhap.FieldName = "TenDangnhap";
            this.colTenDangnhap.Name = "colTenDangnhap";
            this.colTenDangnhap.Visible = true;
            this.colTenDangnhap.VisibleIndex = 1;
            // 
            // colMatkhau
            // 
            this.colMatkhau.Caption = "Mật khẩu";
            this.colMatkhau.FieldName = "Matkhau";
            this.colMatkhau.Name = "colMatkhau";
            this.colMatkhau.Visible = true;
            this.colMatkhau.VisibleIndex = 2;
            // 
            // colEnable
            // 
            this.colEnable.Caption = "Kích hoạt";
            this.colEnable.FieldName = "Enable";
            this.colEnable.Name = "colEnable";
            this.colEnable.Visible = true;
            this.colEnable.VisibleIndex = 3;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 335);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(589, 50);
            this.panelControl1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(396, 15);
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
            this.SaveButton.Location = new System.Drawing.Point(493, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.canboModelGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(395, 335);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Người dùng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this._UserModelGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(589, 335);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Tài khoản Người dùng";
            // 
            // TaikhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 385);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "TaikhoanForm";
            this.Text = "TÀI KHOẢN";
            this.Load += new System.EventHandler(this.TaikhoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canboModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoidungModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChonButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._UserModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._UserModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl canboModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl _UserModelGridControl;
        private System.Windows.Forms.BindingSource _UserModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colEnable;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ChonButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangnhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMatkhau;
        private System.Windows.Forms.BindingSource nguoidungModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNguoidung;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoidungId;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton AddNDButton;
        private DevExpress.XtraEditors.SimpleButton DeleteNDButton;
        private DevExpress.XtraEditors.SimpleButton SaveNDButton;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}