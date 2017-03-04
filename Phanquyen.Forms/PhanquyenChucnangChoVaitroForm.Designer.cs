namespace Phanquyen.Forms
{
    partial class PhanquyenChucnangChoVaitroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanquyenChucnangChoVaitroForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.roleModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.roleModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.TailaiButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ItemtreeList = new DevExpress.XtraTreeList.TreeList();
            this.colThutu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colText = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.itemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.NhomChucnangcomboBox = new System.Windows.Forms.ComboBox();
            this.groupItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemtreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(992, 474);
            this.splitContainerControl1.SplitterPosition = 284;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.roleModelGridControl);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(284, 474);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Vai trò";
            // 
            // roleModelGridControl
            // 
            this.roleModelGridControl.DataSource = this.roleModelBindingSource;
            this.roleModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleModelGridControl.Location = new System.Drawing.Point(2, 21);
            this.roleModelGridControl.MainView = this.gridView1;
            this.roleModelGridControl.Name = "roleModelGridControl";
            this.roleModelGridControl.Size = new System.Drawing.Size(280, 406);
            this.roleModelGridControl.TabIndex = 0;
            this.roleModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // roleModelBindingSource
            // 
            this.roleModelBindingSource.DataSource = typeof(Phanquyen.Model.BusinessObject.RoleModel);
            this.roleModelBindingSource.PositionChanged += new System.EventHandler(this.roleModelBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.gridView1.GridControl = this.roleModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.TailaiButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 427);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(280, 45);
            this.panelControl2.TabIndex = 1;
            // 
            // TailaiButton
            // 
            this.TailaiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TailaiButton.Location = new System.Drawing.Point(187, 12);
            this.TailaiButton.Name = "TailaiButton";
            this.TailaiButton.Size = new System.Drawing.Size(75, 23);
            this.TailaiButton.TabIndex = 0;
            this.TailaiButton.Text = "Tải lại";
            this.TailaiButton.Click += new System.EventHandler(this.TailaiButton_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ItemtreeList);
            this.groupControl2.Controls.Add(this.panelControl3);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(703, 474);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Chức năng";
            // 
            // ItemtreeList
            // 
            this.ItemtreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colText,
            this.colThutu});
            this.ItemtreeList.DataSource = this.itemModelBindingSource;
            this.ItemtreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemtreeList.KeyFieldName = "ItemId";
            this.ItemtreeList.Location = new System.Drawing.Point(2, 64);
            this.ItemtreeList.Name = "ItemtreeList";
            this.ItemtreeList.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.ItemtreeList.OptionsBehavior.Editable = false;
            this.ItemtreeList.OptionsView.ShowCheckBoxes = true;
            this.ItemtreeList.ParentFieldName = "ItemChaId";
            this.ItemtreeList.Size = new System.Drawing.Size(699, 363);
            this.ItemtreeList.TabIndex = 0;
            // 
            // colThutu
            // 
            this.colThutu.Caption = "Thứ tự";
            this.colThutu.FieldName = "Thutu";
            this.colThutu.Name = "colThutu";
            this.colThutu.Visible = true;
            this.colThutu.VisibleIndex = 1;
            this.colThutu.Width = 49;
            // 
            // colText
            // 
            this.colText.Caption = "Menu";
            this.colText.FieldName = "Text";
            this.colText.MinWidth = 32;
            this.colText.Name = "colText";
            this.colText.Visible = true;
            this.colText.VisibleIndex = 0;
            this.colText.Width = 65;
            // 
            // itemModelBindingSource
            // 
            this.itemModelBindingSource.DataSource = typeof(Phanquyen.Model.BusinessObject.Item);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.NhomChucnangcomboBox);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 21);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(699, 43);
            this.panelControl3.TabIndex = 2;
            // 
            // NhomChucnangcomboBox
            // 
            this.NhomChucnangcomboBox.DataSource = this.groupItemModelBindingSource;
            this.NhomChucnangcomboBox.DisplayMember = "Tennhom";
            this.NhomChucnangcomboBox.FormattingEnabled = true;
            this.NhomChucnangcomboBox.Location = new System.Drawing.Point(109, 10);
            this.NhomChucnangcomboBox.Name = "NhomChucnangcomboBox";
            this.NhomChucnangcomboBox.Size = new System.Drawing.Size(175, 21);
            this.NhomChucnangcomboBox.TabIndex = 1;
            this.NhomChucnangcomboBox.ValueMember = "GroupItemId";
            this.NhomChucnangcomboBox.SelectedValueChanged += new System.EventHandler(this.NhomChucnangcomboBox_SelectedValueChanged);
            // 
            // groupItemModelBindingSource
            // 
            this.groupItemModelBindingSource.DataSource = typeof(Phanquyen.Model.BusinessObject.GroupItemModel);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhóm Chức năng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 427);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(699, 45);
            this.panelControl1.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(610, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PhanquyenChucnangChoVaitroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 474);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "PhanquyenChucnangChoVaitroForm";
            this.Text = "CHỨC NĂNG CHO VAI TRÒ";
            this.Load += new System.EventHandler(this.PhanquyenChucnangChoVaitroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roleModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemtreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl roleModelGridControl;
        private System.Windows.Forms.BindingSource roleModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTreeList.TreeList ItemtreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colThutu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colText;
        private System.Windows.Forms.BindingSource itemModelBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton TailaiButton;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.ComboBox NhomChucnangcomboBox;
        private System.Windows.Forms.BindingSource groupItemModelBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}