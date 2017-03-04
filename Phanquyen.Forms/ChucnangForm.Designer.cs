namespace Phanquyen.Forms
{
    partial class ChucnangForm
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
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label largeImageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucnangForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddChildButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.imagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.itemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.largeImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.ItemstreeList = new DevExpress.XtraTreeList.TreeList();
            this.colWidth = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsLarge = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colShowImage = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEnable = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVisible = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLock = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllow = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBeginGroup = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colThutu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTypeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colObjectTypeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colText = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTenForm = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTenFileDLL = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colShowFormAsTab = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ClasscomboBox = new System.Windows.Forms.ComboBox();
            this.GetItemButton = new DevExpress.XtraEditors.SimpleButton();
            this.BrownsbuttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.NhomChucnangcomboBox = new System.Windows.Forms.ComboBox();
            this.groupItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            imageLabel = new System.Windows.Forms.Label();
            largeImageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemstreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrownsbuttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupItemModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(15, 12);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(41, 13);
            imageLabel.TabIndex = 0;
            imageLabel.Text = "Image:";
            // 
            // largeImageLabel
            // 
            largeImageLabel.AutoSize = true;
            largeImageLabel.Location = new System.Drawing.Point(164, 12);
            largeImageLabel.Name = "largeImageLabel";
            largeImageLabel.Size = new System.Drawing.Size(71, 13);
            largeImageLabel.TabIndex = 2;
            largeImageLabel.Text = "Large Image:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(largeImageLabel);
            this.panelControl1.Controls.Add(this.AddChildButton);
            this.panelControl1.Controls.Add(imageLabel);
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Controls.Add(this.imagePictureEdit);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.largeImagePictureEdit);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 340);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(993, 94);
            this.panelControl1.TabIndex = 0;
            // 
            // AddChildButton
            // 
            this.AddChildButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddChildButton.Image = ((System.Drawing.Image)(resources.GetObject("AddChildButton.Image")));
            this.AddChildButton.Location = new System.Drawing.Point(684, 61);
            this.AddChildButton.Name = "AddChildButton";
            this.AddChildButton.Size = new System.Drawing.Size(110, 23);
            this.AddChildButton.TabIndex = 1;
            this.AddChildButton.Text = "Thêm mục con";
            this.AddChildButton.Click += new System.EventHandler(this.AddChildButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(554, 61);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Thêm mục cha";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // imagePictureEdit
            // 
            this.imagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "Image", true));
            this.imagePictureEdit.Location = new System.Drawing.Point(62, 9);
            this.imagePictureEdit.Name = "imagePictureEdit";
            this.imagePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.imagePictureEdit.Size = new System.Drawing.Size(69, 60);
            this.imagePictureEdit.TabIndex = 1;
            // 
            // itemModelBindingSource
            // 
            this.itemModelBindingSource.DataSource = typeof(Phanquyen.Model.BusinessObject.Item);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(813, 61);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // largeImagePictureEdit
            // 
            this.largeImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemModelBindingSource, "LargeImage", true));
            this.largeImagePictureEdit.Location = new System.Drawing.Point(241, 9);
            this.largeImagePictureEdit.Name = "largeImagePictureEdit";
            this.largeImagePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.largeImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.largeImagePictureEdit.Size = new System.Drawing.Size(85, 75);
            this.largeImagePictureEdit.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(906, 61);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ItemstreeList
            // 
            this.ItemstreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colWidth,
            this.colIsLarge,
            this.colShowImage,
            this.colEnable,
            this.colVisible,
            this.colLock,
            this.colAllow,
            this.colBeginGroup,
            this.colThutu,
            this.colTypeName,
            this.colObjectTypeName,
            this.colName,
            this.colText,
            this.colTenForm,
            this.colState,
            this.colTenFileDLL,
            this.colShowFormAsTab});
            this.ItemstreeList.DataSource = this.itemModelBindingSource;
            this.ItemstreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemstreeList.KeyFieldName = "ItemId";
            this.ItemstreeList.Location = new System.Drawing.Point(0, 42);
            this.ItemstreeList.Name = "ItemstreeList";
            this.ItemstreeList.OptionsBehavior.DragNodes = true;
            this.ItemstreeList.OptionsView.ShowFocusedFrame = false;
            this.ItemstreeList.ParentFieldName = "ItemChaId";
            this.ItemstreeList.Size = new System.Drawing.Size(993, 298);
            this.ItemstreeList.TabIndex = 1;
            // 
            // colWidth
            // 
            this.colWidth.FieldName = "Width";
            this.colWidth.Name = "colWidth";
            this.colWidth.Visible = true;
            this.colWidth.VisibleIndex = 2;
            this.colWidth.Width = 86;
            // 
            // colIsLarge
            // 
            this.colIsLarge.FieldName = "IsLarge";
            this.colIsLarge.Name = "colIsLarge";
            this.colIsLarge.Visible = true;
            this.colIsLarge.VisibleIndex = 3;
            this.colIsLarge.Width = 84;
            // 
            // colShowImage
            // 
            this.colShowImage.FieldName = "ShowImage";
            this.colShowImage.Name = "colShowImage";
            this.colShowImage.Visible = true;
            this.colShowImage.VisibleIndex = 4;
            this.colShowImage.Width = 84;
            // 
            // colEnable
            // 
            this.colEnable.FieldName = "Enable";
            this.colEnable.Name = "colEnable";
            this.colEnable.Visible = true;
            this.colEnable.VisibleIndex = 7;
            this.colEnable.Width = 94;
            // 
            // colVisible
            // 
            this.colVisible.FieldName = "Visible";
            this.colVisible.Name = "colVisible";
            this.colVisible.Width = 60;
            // 
            // colLock
            // 
            this.colLock.FieldName = "Lock";
            this.colLock.Name = "colLock";
            this.colLock.Width = 60;
            // 
            // colAllow
            // 
            this.colAllow.FieldName = "Allow";
            this.colAllow.Name = "colAllow";
            this.colAllow.Width = 60;
            // 
            // colBeginGroup
            // 
            this.colBeginGroup.FieldName = "BeginGroup";
            this.colBeginGroup.Name = "colBeginGroup";
            this.colBeginGroup.Width = 50;
            // 
            // colThutu
            // 
            this.colThutu.FieldName = "Thutu";
            this.colThutu.Name = "colThutu";
            this.colThutu.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colThutu.Visible = true;
            this.colThutu.VisibleIndex = 1;
            this.colThutu.Width = 84;
            // 
            // colTypeName
            // 
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 5;
            this.colTypeName.Width = 84;
            // 
            // colObjectTypeName
            // 
            this.colObjectTypeName.FieldName = "ObjectTypeName";
            this.colObjectTypeName.Name = "colObjectTypeName";
            this.colObjectTypeName.Visible = true;
            this.colObjectTypeName.VisibleIndex = 6;
            this.colObjectTypeName.Width = 84;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 50;
            // 
            // colText
            // 
            this.colText.FieldName = "Text";
            this.colText.Name = "colText";
            this.colText.Visible = true;
            this.colText.VisibleIndex = 0;
            this.colText.Width = 96;
            // 
            // colTenForm
            // 
            this.colTenForm.FieldName = "TenForm";
            this.colTenForm.Name = "colTenForm";
            this.colTenForm.Visible = true;
            this.colTenForm.VisibleIndex = 8;
            this.colTenForm.Width = 85;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 10;
            this.colState.Width = 85;
            // 
            // colTenFileDLL
            // 
            this.colTenFileDLL.FieldName = "TenFileDLL";
            this.colTenFileDLL.Name = "colTenFileDLL";
            // 
            // colShowFormAsTab
            // 
            this.colShowFormAsTab.FieldName = "ShowFormAsTab";
            this.colShowFormAsTab.Name = "colShowFormAsTab";
            this.colShowFormAsTab.Visible = true;
            this.colShowFormAsTab.VisibleIndex = 9;
            this.colShowFormAsTab.Width = 109;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.ClasscomboBox);
            this.panelControl2.Controls.Add(this.GetItemButton);
            this.panelControl2.Controls.Add(this.BrownsbuttonEdit);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.NhomChucnangcomboBox);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(993, 42);
            this.panelControl2.TabIndex = 2;
            // 
            // ClasscomboBox
            // 
            this.ClasscomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClasscomboBox.FormattingEnabled = true;
            this.ClasscomboBox.Location = new System.Drawing.Point(684, 12);
            this.ClasscomboBox.Name = "ClasscomboBox";
            this.ClasscomboBox.Size = new System.Drawing.Size(210, 21);
            this.ClasscomboBox.TabIndex = 4;
            // 
            // GetItemButton
            // 
            this.GetItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetItemButton.Location = new System.Drawing.Point(906, 12);
            this.GetItemButton.Name = "GetItemButton";
            this.GetItemButton.Size = new System.Drawing.Size(75, 21);
            this.GetItemButton.TabIndex = 3;
            this.GetItemButton.Text = "Get Item";
            this.GetItemButton.Click += new System.EventHandler(this.GetItemButton_Click);
            // 
            // BrownsbuttonEdit
            // 
            this.BrownsbuttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrownsbuttonEdit.Location = new System.Drawing.Point(308, 13);
            this.BrownsbuttonEdit.Name = "BrownsbuttonEdit";
            this.BrownsbuttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BrownsbuttonEdit.Size = new System.Drawing.Size(370, 20);
            this.BrownsbuttonEdit.TabIndex = 2;
            this.BrownsbuttonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BrownsbuttonEdit_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nhóm Chức năng";
            // 
            // NhomChucnangcomboBox
            // 
            this.NhomChucnangcomboBox.DataSource = this.groupItemModelBindingSource;
            this.NhomChucnangcomboBox.DisplayMember = "Tennhom";
            this.NhomChucnangcomboBox.FormattingEnabled = true;
            this.NhomChucnangcomboBox.Location = new System.Drawing.Point(114, 12);
            this.NhomChucnangcomboBox.Name = "NhomChucnangcomboBox";
            this.NhomChucnangcomboBox.Size = new System.Drawing.Size(172, 21);
            this.NhomChucnangcomboBox.TabIndex = 0;
            this.NhomChucnangcomboBox.ValueMember = "GroupItemId";
            this.NhomChucnangcomboBox.SelectedValueChanged += new System.EventHandler(this.NhomChucnangcomboBox_SelectedValueChanged);
            // 
            // groupItemModelBindingSource
            // 
            this.groupItemModelBindingSource.DataSource = typeof(Phanquyen.Model.BusinessObject.GroupItemModel);
            // 
            // ChucnangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 434);
            this.Controls.Add(this.ItemstreeList);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ChucnangForm";
            this.Text = "CHỨC NĂNG";
            this.Load += new System.EventHandler(this.ChucnangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemstreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrownsbuttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupItemModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraTreeList.TreeList ItemstreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colWidth;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsLarge;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colShowImage;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEnable;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVisible;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLock;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllow;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBeginGroup;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colThutu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTypeName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colObjectTypeName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colText;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenForm;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colState;
        private System.Windows.Forms.BindingSource itemModelBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit imagePictureEdit;
        private DevExpress.XtraEditors.SimpleButton AddChildButton;
        private DevExpress.XtraEditors.PictureEdit largeImagePictureEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenFileDLL;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox NhomChucnangcomboBox;
        private System.Windows.Forms.BindingSource groupItemModelBindingSource;
        private DevExpress.XtraEditors.ButtonEdit BrownsbuttonEdit;
        private DevExpress.XtraEditors.SimpleButton GetItemButton;
        private System.Windows.Forms.ComboBox ClasscomboBox;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colShowFormAsTab;
    }
}