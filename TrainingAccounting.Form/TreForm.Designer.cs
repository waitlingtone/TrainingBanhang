namespace TrainingAccounting.Form
{
    partial class TreForm
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
            System.Windows.Forms.Label mavachLabel;
            System.Windows.Forms.Label hodemLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tenThuonggoiLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label nhomTreIdLabel;
            System.Windows.Forms.Label quanhuyenIdLabel;
            System.Windows.Forms.Label ghichuLabel;
            System.Windows.Forms.Label dantocIdLabel;
            System.Windows.Forms.Label tongiaoIdLabel;
            System.Windows.Forms.Label conhocLabel;
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label diachiLabel;
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.treModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMavach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHodem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThuonggoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ConhoccheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.NhomtrecomboBox = new System.Windows.Forms.ComboBox();
            this.nhomTreModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.diachiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.barCodeControl = new DevExpress.XtraEditors.BarCodeControl();
            this.imagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.gioitinhRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.conhocCheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.ngaysinhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenThuonggoiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hodemTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mavachTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ExcelButton = new DevExpress.XtraEditors.SimpleButton();
            this.PrintAllButton = new DevExpress.XtraEditors.SimpleButton();
            this.PrintButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.quanhuyenIdTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.quanhuyenModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenQuanhuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dantocIdTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dantocModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDantoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhomTreIdTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.NhomtreInfobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tongiaoIdTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tongiaoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.TinhthanhLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tinhthanhModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.thannhanModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.thannhanModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuanhe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNghenghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLaDaidienChinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colState2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.AddThannhanButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteThannhanButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveThannhanButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.dongiaHocphiModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.dongiaHocphiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayApdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DongiaCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.AddDongiaButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteDongiaButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveDongiaButton = new DevExpress.XtraEditors.SimpleButton();
            mavachLabel = new System.Windows.Forms.Label();
            hodemLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tenThuonggoiLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            nhomTreIdLabel = new System.Windows.Forms.Label();
            quanhuyenIdLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            dantocIdLabel = new System.Windows.Forms.Label();
            tongiaoIdLabel = new System.Windows.Forms.Label();
            conhocLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConhoccheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTreModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diachiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioitinhRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conhocCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenThuonggoiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hodemTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavachTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dantocIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dantocModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTreIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomtreInfobindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongiaoIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongiaoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhthanhLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thannhanModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thannhanModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dongiaHocphiModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongiaHocphiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DongiaCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mavachLabel
            // 
            mavachLabel.AutoSize = true;
            mavachLabel.Location = new System.Drawing.Point(25, 53);
            mavachLabel.Name = "mavachLabel";
            mavachLabel.Size = new System.Drawing.Size(47, 13);
            mavachLabel.TabIndex = 1;
            mavachLabel.Text = "Mã vạch";
            // 
            // hodemLabel
            // 
            hodemLabel.AutoSize = true;
            hodemLabel.Location = new System.Drawing.Point(25, 90);
            hodemLabel.Name = "hodemLabel";
            hodemLabel.Size = new System.Drawing.Size(43, 13);
            hodemLabel.TabIndex = 3;
            hodemLabel.Text = "Họ đệm";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(307, 90);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(25, 13);
            tenLabel.TabIndex = 5;
            tenLabel.Text = "Tên";
            // 
            // tenThuonggoiLabel
            // 
            tenThuonggoiLabel.AutoSize = true;
            tenThuonggoiLabel.Location = new System.Drawing.Point(25, 127);
            tenThuonggoiLabel.Name = "tenThuonggoiLabel";
            tenThuonggoiLabel.Size = new System.Drawing.Size(80, 13);
            tenThuonggoiLabel.TabIndex = 7;
            tenThuonggoiLabel.Text = "Tên thường gọi";
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(25, 162);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(54, 13);
            ngaysinhLabel.TabIndex = 9;
            ngaysinhLabel.Text = "Ngày sinh";
            // 
            // nhomTreIdLabel
            // 
            nhomTreIdLabel.AutoSize = true;
            nhomTreIdLabel.Location = new System.Drawing.Point(25, 19);
            nhomTreIdLabel.Name = "nhomTreIdLabel";
            nhomTreIdLabel.Size = new System.Drawing.Size(51, 13);
            nhomTreIdLabel.TabIndex = 13;
            nhomTreIdLabel.Text = "Nhóm trẻ";
            // 
            // quanhuyenIdLabel
            // 
            quanhuyenIdLabel.AutoSize = true;
            quanhuyenIdLabel.Location = new System.Drawing.Point(307, 230);
            quanhuyenIdLabel.Name = "quanhuyenIdLabel";
            quanhuyenIdLabel.Size = new System.Drawing.Size(74, 13);
            quanhuyenIdLabel.TabIndex = 15;
            quanhuyenIdLabel.Text = "Quận / Huyện";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(25, 304);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(42, 13);
            ghichuLabel.TabIndex = 17;
            ghichuLabel.Text = "Ghi chú";
            // 
            // dantocIdLabel
            // 
            dantocIdLabel.AutoSize = true;
            dantocIdLabel.Location = new System.Drawing.Point(25, 267);
            dantocIdLabel.Name = "dantocIdLabel";
            dantocIdLabel.Size = new System.Drawing.Size(44, 13);
            dantocIdLabel.TabIndex = 19;
            dantocIdLabel.Text = "Dân tộc";
            // 
            // tongiaoIdLabel
            // 
            tongiaoIdLabel.AutoSize = true;
            tongiaoIdLabel.Location = new System.Drawing.Point(309, 267);
            tongiaoIdLabel.Name = "tongiaoIdLabel";
            tongiaoIdLabel.Size = new System.Drawing.Size(48, 13);
            tongiaoIdLabel.TabIndex = 21;
            tongiaoIdLabel.Text = "Tôn giáo";
            // 
            // conhocLabel
            // 
            conhocLabel.AutoSize = true;
            conhocLabel.Location = new System.Drawing.Point(26, 357);
            conhocLabel.Name = "conhocLabel";
            conhocLabel.Size = new System.Drawing.Size(46, 13);
            conhocLabel.TabIndex = 23;
            conhocLabel.Text = "Còn học";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(309, 127);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(45, 13);
            gioitinhLabel.TabIndex = 26;
            gioitinhLabel.Text = "Giới tính";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(25, 196);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(39, 13);
            diachiLabel.TabIndex = 30;
            diachiLabel.Text = "Địa chỉ";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treModelGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1024, 461);
            this.splitContainerControl1.SplitterPosition = 371;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treModelGridControl
            // 
            this.treModelGridControl.DataSource = this.treModelBindingSource;
            this.treModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treModelGridControl.Location = new System.Drawing.Point(0, 49);
            this.treModelGridControl.MainView = this.gridView1;
            this.treModelGridControl.Name = "treModelGridControl";
            this.treModelGridControl.Size = new System.Drawing.Size(371, 412);
            this.treModelGridControl.TabIndex = 1;
            this.treModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // treModelBindingSource
            // 
            this.treModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.TreModel);
            this.treModelBindingSource.PositionChanged += new System.EventHandler(this.treModelBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMavach,
            this.colHodem,
            this.colTen,
            this.colTenThuonggoi,
            this.colState});
            this.gridView1.GridControl = this.treModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colMavach
            // 
            this.colMavach.Caption = "Mã vạch";
            this.colMavach.FieldName = "Mavach";
            this.colMavach.Name = "colMavach";
            this.colMavach.Visible = true;
            this.colMavach.VisibleIndex = 1;
            // 
            // colHodem
            // 
            this.colHodem.Caption = "Họ đệm";
            this.colHodem.FieldName = "Hodem";
            this.colHodem.Name = "colHodem";
            this.colHodem.Visible = true;
            this.colHodem.VisibleIndex = 2;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 3;
            // 
            // colTenThuonggoi
            // 
            this.colTenThuonggoi.Caption = "Tên thường gọi";
            this.colTenThuonggoi.FieldName = "TenThuonggoi";
            this.colTenThuonggoi.Name = "colTenThuonggoi";
            this.colTenThuonggoi.Visible = true;
            this.colTenThuonggoi.VisibleIndex = 4;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.ConhoccheckEdit);
            this.panelControl1.Controls.Add(this.NhomtrecomboBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(371, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nhóm trẻ";
            // 
            // ConhoccheckEdit
            // 
            this.ConhoccheckEdit.EditValue = true;
            this.ConhoccheckEdit.Location = new System.Drawing.Point(249, 15);
            this.ConhoccheckEdit.Name = "ConhoccheckEdit";
            this.ConhoccheckEdit.Properties.Caption = "Còn học";
            this.ConhoccheckEdit.Size = new System.Drawing.Size(75, 19);
            this.ConhoccheckEdit.TabIndex = 1;
            this.ConhoccheckEdit.CheckStateChanged += new System.EventHandler(this.ConhoccheckEdit_CheckStateChanged);
            // 
            // NhomtrecomboBox
            // 
            this.NhomtrecomboBox.DataSource = this.nhomTreModelBindingSource;
            this.NhomtrecomboBox.DisplayMember = "TenNhom";
            this.NhomtrecomboBox.FormattingEnabled = true;
            this.NhomtrecomboBox.Location = new System.Drawing.Point(76, 14);
            this.NhomtrecomboBox.Name = "NhomtrecomboBox";
            this.NhomtrecomboBox.Size = new System.Drawing.Size(145, 21);
            this.NhomtrecomboBox.TabIndex = 0;
            this.NhomtrecomboBox.ValueMember = "NhomTreId";
            this.NhomtrecomboBox.SelectedValueChanged += new System.EventHandler(this.NhomtrecomboBox_SelectedValueChanged);
            // 
            // nhomTreModelBindingSource
            // 
            this.nhomTreModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.NhomTreModel);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(648, 461);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(diachiLabel);
            this.xtraTabPage1.Controls.Add(this.diachiTextEdit);
            this.xtraTabPage1.Controls.Add(this.barCodeControl);
            this.xtraTabPage1.Controls.Add(this.imagePictureEdit);
            this.xtraTabPage1.Controls.Add(gioitinhLabel);
            this.xtraTabPage1.Controls.Add(this.gioitinhRadioGroup);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(conhocLabel);
            this.xtraTabPage1.Controls.Add(this.conhocCheckEdit1);
            this.xtraTabPage1.Controls.Add(tongiaoIdLabel);
            this.xtraTabPage1.Controls.Add(dantocIdLabel);
            this.xtraTabPage1.Controls.Add(ghichuLabel);
            this.xtraTabPage1.Controls.Add(quanhuyenIdLabel);
            this.xtraTabPage1.Controls.Add(nhomTreIdLabel);
            this.xtraTabPage1.Controls.Add(ngaysinhLabel);
            this.xtraTabPage1.Controls.Add(this.ngaysinhDateEdit);
            this.xtraTabPage1.Controls.Add(tenThuonggoiLabel);
            this.xtraTabPage1.Controls.Add(this.tenThuonggoiTextEdit);
            this.xtraTabPage1.Controls.Add(tenLabel);
            this.xtraTabPage1.Controls.Add(this.tenTextEdit);
            this.xtraTabPage1.Controls.Add(hodemLabel);
            this.xtraTabPage1.Controls.Add(this.hodemTextEdit);
            this.xtraTabPage1.Controls.Add(mavachLabel);
            this.xtraTabPage1.Controls.Add(this.mavachTextEdit);
            this.xtraTabPage1.Controls.Add(this.panelControl2);
            this.xtraTabPage1.Controls.Add(this.quanhuyenIdTextEdit);
            this.xtraTabPage1.Controls.Add(this.dantocIdTextEdit);
            this.xtraTabPage1.Controls.Add(this.nhomTreIdTextEdit);
            this.xtraTabPage1.Controls.Add(this.tongiaoIdTextEdit);
            this.xtraTabPage1.Controls.Add(this.ghichuTextEdit);
            this.xtraTabPage1.Controls.Add(this.TinhthanhLookUpEdit);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(642, 433);
            this.xtraTabPage1.Text = "Thông tin";
            // 
            // diachiTextEdit
            // 
            this.diachiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Diachi", true));
            this.diachiTextEdit.Location = new System.Drawing.Point(113, 193);
            this.diachiTextEdit.Name = "diachiTextEdit";
            this.diachiTextEdit.Size = new System.Drawing.Size(374, 20);
            this.diachiTextEdit.TabIndex = 31;
            // 
            // barCodeControl
            // 
            this.barCodeControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treModelBindingSource, "Mavach", true));
            this.barCodeControl.Location = new System.Drawing.Point(312, 16);
            this.barCodeControl.Name = "barCodeControl";
            this.barCodeControl.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl.Size = new System.Drawing.Size(315, 54);
            code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto;
            this.barCodeControl.Symbology = code128Generator1;
            this.barCodeControl.TabIndex = 29;
            // 
            // imagePictureEdit
            // 
            this.imagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Image", true));
            this.imagePictureEdit.Location = new System.Drawing.Point(527, 86);
            this.imagePictureEdit.Name = "imagePictureEdit";
            this.imagePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.imagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imagePictureEdit.Size = new System.Drawing.Size(100, 128);
            this.imagePictureEdit.TabIndex = 28;
            // 
            // gioitinhRadioGroup
            // 
            this.gioitinhRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Gioitinh", true));
            this.gioitinhRadioGroup.Location = new System.Drawing.Point(361, 124);
            this.gioitinhRadioGroup.Name = "gioitinhRadioGroup";
            this.gioitinhRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Nữ")});
            this.gioitinhRadioGroup.Size = new System.Drawing.Size(126, 20);
            this.gioitinhRadioGroup.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 230);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Tỉnh / Thành";
            // 
            // conhocCheckEdit1
            // 
            this.conhocCheckEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Conhoc", true));
            this.conhocCheckEdit1.Location = new System.Drawing.Point(111, 355);
            this.conhocCheckEdit1.Name = "conhocCheckEdit1";
            this.conhocCheckEdit1.Properties.Caption = "";
            this.conhocCheckEdit1.Size = new System.Drawing.Size(75, 19);
            this.conhocCheckEdit1.TabIndex = 24;
            // 
            // ngaysinhDateEdit
            // 
            this.ngaysinhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Ngaysinh", true));
            this.ngaysinhDateEdit.EditValue = null;
            this.ngaysinhDateEdit.Location = new System.Drawing.Point(113, 159);
            this.ngaysinhDateEdit.Name = "ngaysinhDateEdit";
            this.ngaysinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinhDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ngaysinhDateEdit.Size = new System.Drawing.Size(100, 20);
            this.ngaysinhDateEdit.TabIndex = 10;
            // 
            // tenThuonggoiTextEdit
            // 
            this.tenThuonggoiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "TenThuonggoi", true));
            this.tenThuonggoiTextEdit.Location = new System.Drawing.Point(113, 124);
            this.tenThuonggoiTextEdit.Name = "tenThuonggoiTextEdit";
            this.tenThuonggoiTextEdit.Size = new System.Drawing.Size(177, 20);
            this.tenThuonggoiTextEdit.TabIndex = 5;
            // 
            // tenTextEdit
            // 
            this.tenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Ten", true));
            this.tenTextEdit.Location = new System.Drawing.Point(361, 83);
            this.tenTextEdit.Name = "tenTextEdit";
            this.tenTextEdit.Size = new System.Drawing.Size(126, 20);
            this.tenTextEdit.TabIndex = 4;
            // 
            // hodemTextEdit
            // 
            this.hodemTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Hodem", true));
            this.hodemTextEdit.Location = new System.Drawing.Point(113, 87);
            this.hodemTextEdit.Name = "hodemTextEdit";
            this.hodemTextEdit.Size = new System.Drawing.Size(177, 20);
            this.hodemTextEdit.TabIndex = 2;
            // 
            // mavachTextEdit
            // 
            this.mavachTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Mavach", true));
            this.mavachTextEdit.Location = new System.Drawing.Point(113, 50);
            this.mavachTextEdit.Name = "mavachTextEdit";
            this.mavachTextEdit.Size = new System.Drawing.Size(177, 20);
            this.mavachTextEdit.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.ExcelButton);
            this.panelControl2.Controls.Add(this.PrintAllButton);
            this.panelControl2.Controls.Add(this.PrintButton);
            this.panelControl2.Controls.Add(this.AddButton);
            this.panelControl2.Controls.Add(this.DeleteButton);
            this.panelControl2.Controls.Add(this.SaveButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 384);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(642, 49);
            this.panelControl2.TabIndex = 0;
            // 
            // ExcelButton
            // 
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.Location = new System.Drawing.Point(140, 15);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(84, 23);
            this.ExcelButton.TabIndex = 2;
            this.ExcelButton.Text = "Xuất Excel";
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // PrintAllButton
            // 
            this.PrintAllButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintAllButton.Image")));
            this.PrintAllButton.Location = new System.Drawing.Point(10, 15);
            this.PrintAllButton.Name = "PrintAllButton";
            this.PrintAllButton.Size = new System.Drawing.Size(118, 23);
            this.PrintAllButton.TabIndex = 2;
            this.PrintAllButton.Text = "In Danh sách Trẻ";
            this.PrintAllButton.Click += new System.EventHandler(this.PrintAllButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.Location = new System.Drawing.Point(235, 15);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(131, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "In biểu mẫu đăng ký";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(382, 15);
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
            this.DeleteButton.Location = new System.Drawing.Point(466, 15);
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
            this.SaveButton.Location = new System.Drawing.Point(552, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // quanhuyenIdTextEdit
            // 
            this.quanhuyenIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "QuanhuyenId", true));
            this.quanhuyenIdTextEdit.Location = new System.Drawing.Point(393, 226);
            this.quanhuyenIdTextEdit.Name = "quanhuyenIdTextEdit";
            this.quanhuyenIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quanhuyenIdTextEdit.Properties.DataSource = this.quanhuyenModelBindingSource;
            this.quanhuyenIdTextEdit.Properties.DisplayMember = "TenQuanhuyen";
            this.quanhuyenIdTextEdit.Properties.NullText = "";
            this.quanhuyenIdTextEdit.Properties.ValueMember = "QuanhuyenId";
            this.quanhuyenIdTextEdit.Properties.View = this.searchLookUpEdit2View;
            this.quanhuyenIdTextEdit.Size = new System.Drawing.Size(234, 20);
            this.quanhuyenIdTextEdit.TabIndex = 16;
            // 
            // quanhuyenModelBindingSource
            // 
            this.quanhuyenModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.QuanhuyenModel);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenQuanhuyen});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colTenQuanhuyen
            // 
            this.colTenQuanhuyen.Caption = "Quận/Huyện";
            this.colTenQuanhuyen.FieldName = "TenQuanhuyen";
            this.colTenQuanhuyen.Name = "colTenQuanhuyen";
            this.colTenQuanhuyen.Visible = true;
            this.colTenQuanhuyen.VisibleIndex = 0;
            // 
            // dantocIdTextEdit
            // 
            this.dantocIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "DantocId", true));
            this.dantocIdTextEdit.Location = new System.Drawing.Point(113, 264);
            this.dantocIdTextEdit.Name = "dantocIdTextEdit";
            this.dantocIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dantocIdTextEdit.Properties.DataSource = this.dantocModelBindingSource;
            this.dantocIdTextEdit.Properties.DisplayMember = "TenDantoc";
            this.dantocIdTextEdit.Properties.NullText = "";
            this.dantocIdTextEdit.Properties.ValueMember = "DantocId";
            this.dantocIdTextEdit.Properties.View = this.gridView2;
            this.dantocIdTextEdit.Size = new System.Drawing.Size(177, 20);
            this.dantocIdTextEdit.TabIndex = 20;
            // 
            // dantocModelBindingSource
            // 
            this.dantocModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.DantocModel);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDantoc});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colTenDantoc
            // 
            this.colTenDantoc.Caption = "Dân tộc";
            this.colTenDantoc.FieldName = "TenDantoc";
            this.colTenDantoc.Name = "colTenDantoc";
            this.colTenDantoc.Visible = true;
            this.colTenDantoc.VisibleIndex = 0;
            // 
            // nhomTreIdTextEdit
            // 
            this.nhomTreIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "NhomTreId", true));
            this.nhomTreIdTextEdit.Location = new System.Drawing.Point(113, 16);
            this.nhomTreIdTextEdit.Name = "nhomTreIdTextEdit";
            this.nhomTreIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nhomTreIdTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhom", "Nhóm trẻ")});
            this.nhomTreIdTextEdit.Properties.DataSource = this.NhomtreInfobindingSource;
            this.nhomTreIdTextEdit.Properties.DisplayMember = "TenNhom";
            this.nhomTreIdTextEdit.Properties.NullText = "";
            this.nhomTreIdTextEdit.Properties.ValueMember = "NhomTreId";
            this.nhomTreIdTextEdit.Size = new System.Drawing.Size(177, 20);
            this.nhomTreIdTextEdit.TabIndex = 0;
            // 
            // NhomtreInfobindingSource
            // 
            this.NhomtreInfobindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.NhomTreModel);
            // 
            // tongiaoIdTextEdit
            // 
            this.tongiaoIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "TongiaoId", true));
            this.tongiaoIdTextEdit.Location = new System.Drawing.Point(393, 264);
            this.tongiaoIdTextEdit.Name = "tongiaoIdTextEdit";
            this.tongiaoIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tongiaoIdTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTongiao", "Tôn giáo")});
            this.tongiaoIdTextEdit.Properties.DataSource = this.tongiaoModelBindingSource;
            this.tongiaoIdTextEdit.Properties.DisplayMember = "TenTongiao";
            this.tongiaoIdTextEdit.Properties.NullText = "";
            this.tongiaoIdTextEdit.Properties.PopupSizeable = false;
            this.tongiaoIdTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.tongiaoIdTextEdit.Properties.ValueMember = "TongiaoId";
            this.tongiaoIdTextEdit.Size = new System.Drawing.Size(234, 20);
            this.tongiaoIdTextEdit.TabIndex = 22;
            // 
            // tongiaoModelBindingSource
            // 
            this.tongiaoModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.TongiaoModel);
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(113, 301);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(514, 35);
            this.ghichuTextEdit.TabIndex = 18;
            // 
            // TinhthanhLookUpEdit
            // 
            this.TinhthanhLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.treModelBindingSource, "TinhthanhId", true));
            this.TinhthanhLookUpEdit.Location = new System.Drawing.Point(113, 226);
            this.TinhthanhLookUpEdit.Name = "TinhthanhLookUpEdit";
            this.TinhthanhLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TinhthanhLookUpEdit.Properties.DataSource = this.tinhthanhModelBindingSource;
            this.TinhthanhLookUpEdit.Properties.DisplayMember = "TenTinh";
            this.TinhthanhLookUpEdit.Properties.NullText = "";
            this.TinhthanhLookUpEdit.Properties.ValueMember = "TinhthanhId";
            this.TinhthanhLookUpEdit.Properties.View = this.searchLookUpEdit1View;
            this.TinhthanhLookUpEdit.Size = new System.Drawing.Size(177, 20);
            this.TinhthanhLookUpEdit.TabIndex = 30;
            this.TinhthanhLookUpEdit.EditValueChanged += new System.EventHandler(this.TinhthanhLookUpEdit_EditValueChanged);
            // 
            // tinhthanhModelBindingSource
            // 
            this.tinhthanhModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.TinhthanhModel);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTinh,
            this.colTenTinh});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMaTinh
            // 
            this.colMaTinh.Caption = "Mã Tỉnh";
            this.colMaTinh.FieldName = "MaTinh";
            this.colMaTinh.Name = "colMaTinh";
            this.colMaTinh.Visible = true;
            this.colMaTinh.VisibleIndex = 0;
            // 
            // colTenTinh
            // 
            this.colTenTinh.Caption = "Tên Tỉnh";
            this.colTenTinh.FieldName = "TenTinh";
            this.colTenTinh.Name = "colTenTinh";
            this.colTenTinh.Visible = true;
            this.colTenTinh.VisibleIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.thannhanModelGridControl);
            this.xtraTabPage2.Controls.Add(this.panelControl4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(642, 433);
            this.xtraTabPage2.Text = "Thân nhân";
            // 
            // thannhanModelGridControl
            // 
            this.thannhanModelGridControl.DataSource = this.thannhanModelBindingSource;
            this.thannhanModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thannhanModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.thannhanModelGridControl.MainView = this.gridView4;
            this.thannhanModelGridControl.Name = "thannhanModelGridControl";
            this.thannhanModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemCheckEdit});
            this.thannhanModelGridControl.Size = new System.Drawing.Size(642, 384);
            this.thannhanModelGridControl.TabIndex = 1;
            this.thannhanModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // thannhanModelBindingSource
            // 
            this.thannhanModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ThannhanModel);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuanhe,
            this.colHoten,
            this.colNamsinh,
            this.colSoDT,
            this.colNghenghiep,
            this.colDiachi,
            this.colLaDaidienChinh,
            this.colState2});
            this.gridView4.GridControl = this.thannhanModelGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colQuanhe
            // 
            this.colQuanhe.Caption = "Có mối quan hệ";
            this.colQuanhe.FieldName = "Quanhe";
            this.colQuanhe.Name = "colQuanhe";
            this.colQuanhe.Visible = true;
            this.colQuanhe.VisibleIndex = 0;
            // 
            // colHoten
            // 
            this.colHoten.Caption = "Họ tên";
            this.colHoten.FieldName = "Hoten";
            this.colHoten.Name = "colHoten";
            this.colHoten.Visible = true;
            this.colHoten.VisibleIndex = 1;
            // 
            // colNamsinh
            // 
            this.colNamsinh.Caption = "Năm sinh";
            this.colNamsinh.FieldName = "Namsinh";
            this.colNamsinh.Name = "colNamsinh";
            this.colNamsinh.Visible = true;
            this.colNamsinh.VisibleIndex = 3;
            // 
            // colSoDT
            // 
            this.colSoDT.Caption = "Số ĐT";
            this.colSoDT.FieldName = "SoDT";
            this.colSoDT.Name = "colSoDT";
            this.colSoDT.Visible = true;
            this.colSoDT.VisibleIndex = 4;
            // 
            // colNghenghiep
            // 
            this.colNghenghiep.Caption = "Nghề nghiệp";
            this.colNghenghiep.FieldName = "Nghenghiep";
            this.colNghenghiep.Name = "colNghenghiep";
            this.colNghenghiep.Visible = true;
            this.colNghenghiep.VisibleIndex = 5;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 6;
            // 
            // colLaDaidienChinh
            // 
            this.colLaDaidienChinh.Caption = "Là đại diện chính";
            this.colLaDaidienChinh.ColumnEdit = this.ItemCheckEdit;
            this.colLaDaidienChinh.FieldName = "LaDaidienChinh";
            this.colLaDaidienChinh.Name = "colLaDaidienChinh";
            this.colLaDaidienChinh.Visible = true;
            this.colLaDaidienChinh.VisibleIndex = 2;
            // 
            // ItemCheckEdit
            // 
            this.ItemCheckEdit.AutoHeight = false;
            this.ItemCheckEdit.Name = "ItemCheckEdit";
            // 
            // colState2
            // 
            this.colState2.FieldName = "State";
            this.colState2.Name = "colState2";
            this.colState2.OptionsColumn.ReadOnly = true;
            this.colState2.Visible = true;
            this.colState2.VisibleIndex = 7;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.AddThannhanButton);
            this.panelControl4.Controls.Add(this.DeleteThannhanButton);
            this.panelControl4.Controls.Add(this.SaveThannhanButton);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 384);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(642, 49);
            this.panelControl4.TabIndex = 0;
            // 
            // AddThannhanButton
            // 
            this.AddThannhanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddThannhanButton.Image = ((System.Drawing.Image)(resources.GetObject("AddThannhanButton.Image")));
            this.AddThannhanButton.Location = new System.Drawing.Point(319, 14);
            this.AddThannhanButton.Name = "AddThannhanButton";
            this.AddThannhanButton.Size = new System.Drawing.Size(122, 23);
            this.AddThannhanButton.TabIndex = 0;
            this.AddThannhanButton.Text = "Thêm Thân nhân";
            this.AddThannhanButton.Click += new System.EventHandler(this.AddThannhanButton_Click);
            // 
            // DeleteThannhanButton
            // 
            this.DeleteThannhanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteThannhanButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteThannhanButton.Image")));
            this.DeleteThannhanButton.Location = new System.Drawing.Point(458, 14);
            this.DeleteThannhanButton.Name = "DeleteThannhanButton";
            this.DeleteThannhanButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteThannhanButton.TabIndex = 0;
            this.DeleteThannhanButton.Text = "Xóa";
            this.DeleteThannhanButton.Click += new System.EventHandler(this.DeleteThannhanButton_Click);
            // 
            // SaveThannhanButton
            // 
            this.SaveThannhanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveThannhanButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveThannhanButton.Image")));
            this.SaveThannhanButton.Location = new System.Drawing.Point(552, 14);
            this.SaveThannhanButton.Name = "SaveThannhanButton";
            this.SaveThannhanButton.Size = new System.Drawing.Size(75, 23);
            this.SaveThannhanButton.TabIndex = 0;
            this.SaveThannhanButton.Text = "Lưu lại";
            this.SaveThannhanButton.Click += new System.EventHandler(this.SaveThannhanButton_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.dongiaHocphiModelGridControl);
            this.xtraTabPage3.Controls.Add(this.panelControl3);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(642, 433);
            this.xtraTabPage3.Text = "Đơn giá Học phí";
            // 
            // dongiaHocphiModelGridControl
            // 
            this.dongiaHocphiModelGridControl.DataSource = this.dongiaHocphiModelBindingSource;
            this.dongiaHocphiModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dongiaHocphiModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.dongiaHocphiModelGridControl.MainView = this.gridView3;
            this.dongiaHocphiModelGridControl.Name = "dongiaHocphiModelGridControl";
            this.dongiaHocphiModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DongiaCheckEdit});
            this.dongiaHocphiModelGridControl.Size = new System.Drawing.Size(642, 382);
            this.dongiaHocphiModelGridControl.TabIndex = 1;
            this.dongiaHocphiModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // dongiaHocphiModelBindingSource
            // 
            this.dongiaHocphiModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.DongiaHocphiModel);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSotien,
            this.colNgayApdung,
            this.colSudung,
            this.colGhichu,
            this.colState1});
            this.gridView3.GridControl = this.dongiaHocphiModelGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colSotien
            // 
            this.colSotien.AppearanceCell.Options.UseTextOptions = true;
            this.colSotien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSotien.Caption = "Đơn giá Học phí";
            this.colSotien.DisplayFormat.FormatString = "#,#";
            this.colSotien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSotien.FieldName = "Sotien";
            this.colSotien.Name = "colSotien";
            this.colSotien.Visible = true;
            this.colSotien.VisibleIndex = 0;
            // 
            // colNgayApdung
            // 
            this.colNgayApdung.Caption = "Ngày áp dụng";
            this.colNgayApdung.FieldName = "NgayApdung";
            this.colNgayApdung.Name = "colNgayApdung";
            this.colNgayApdung.Visible = true;
            this.colNgayApdung.VisibleIndex = 1;
            // 
            // colSudung
            // 
            this.colSudung.Caption = "Sử dụng";
            this.colSudung.ColumnEdit = this.DongiaCheckEdit;
            this.colSudung.FieldName = "Sudung";
            this.colSudung.Name = "colSudung";
            this.colSudung.Visible = true;
            this.colSudung.VisibleIndex = 2;
            // 
            // DongiaCheckEdit
            // 
            this.DongiaCheckEdit.AutoHeight = false;
            this.DongiaCheckEdit.Name = "DongiaCheckEdit";
            this.DongiaCheckEdit.CheckedChanged += new System.EventHandler(this.DongiaCheckEdit_CheckedChanged);
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 3;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.AddDongiaButton);
            this.panelControl3.Controls.Add(this.DeleteDongiaButton);
            this.panelControl3.Controls.Add(this.SaveDongiaButton);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 382);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(642, 51);
            this.panelControl3.TabIndex = 0;
            // 
            // AddDongiaButton
            // 
            this.AddDongiaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDongiaButton.Image = ((System.Drawing.Image)(resources.GetObject("AddDongiaButton.Image")));
            this.AddDongiaButton.Location = new System.Drawing.Point(314, 15);
            this.AddDongiaButton.Name = "AddDongiaButton";
            this.AddDongiaButton.Size = new System.Drawing.Size(116, 23);
            this.AddDongiaButton.TabIndex = 0;
            this.AddDongiaButton.Text = "Thêm Đơn giá mới";
            this.AddDongiaButton.Click += new System.EventHandler(this.AddDongiaButton_Click);
            // 
            // DeleteDongiaButton
            // 
            this.DeleteDongiaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteDongiaButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDongiaButton.Image")));
            this.DeleteDongiaButton.Location = new System.Drawing.Point(455, 15);
            this.DeleteDongiaButton.Name = "DeleteDongiaButton";
            this.DeleteDongiaButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteDongiaButton.TabIndex = 0;
            this.DeleteDongiaButton.Text = "Xóa";
            this.DeleteDongiaButton.Click += new System.EventHandler(this.DeleteDongiaButton_Click);
            // 
            // SaveDongiaButton
            // 
            this.SaveDongiaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveDongiaButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveDongiaButton.Image")));
            this.SaveDongiaButton.Location = new System.Drawing.Point(552, 15);
            this.SaveDongiaButton.Name = "SaveDongiaButton";
            this.SaveDongiaButton.Size = new System.Drawing.Size(75, 23);
            this.SaveDongiaButton.TabIndex = 0;
            this.SaveDongiaButton.Text = "Lưu lại";
            this.SaveDongiaButton.Click += new System.EventHandler(this.SaveDongiaButton_Click);
            // 
            // TreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 461);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "TreForm";
            this.Text = "QUẢN  LÝ TRẺ";
            this.Load += new System.EventHandler(this.TreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConhoccheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTreModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diachiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioitinhRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conhocCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenThuonggoiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hodemTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavachTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dantocIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dantocModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTreIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomtreInfobindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongiaoIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongiaoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhthanhLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thannhanModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thannhanModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dongiaHocphiModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongiaHocphiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DongiaCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox NhomtrecomboBox;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl treModelGridControl;
        private System.Windows.Forms.BindingSource treModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHodem;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThuonggoi;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ConhoccheckEdit;
        private DevExpress.XtraEditors.RadioGroup gioitinhRadioGroup;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit conhocCheckEdit1;
        private DevExpress.XtraEditors.DateEdit ngaysinhDateEdit;
        private DevExpress.XtraEditors.TextEdit tenThuonggoiTextEdit;
        private DevExpress.XtraEditors.TextEdit tenTextEdit;
        private DevExpress.XtraEditors.TextEdit hodemTextEdit;
        private DevExpress.XtraEditors.TextEdit mavachTextEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit quanhuyenIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit dantocIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LookUpEdit nhomTreIdTextEdit;
        private DevExpress.XtraEditors.LookUpEdit tongiaoIdTextEdit;
        private DevExpress.XtraEditors.PictureEdit imagePictureEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource nhomTreModelBindingSource;
        private System.Windows.Forms.BindingSource tinhthanhModelBindingSource;
        private System.Windows.Forms.BindingSource quanhuyenModelBindingSource;
        private System.Windows.Forms.BindingSource dantocModelBindingSource;
        private System.Windows.Forms.BindingSource tongiaoModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenQuanhuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDantoc;
        private System.Windows.Forms.BindingSource NhomtreInfobindingSource;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton AddDongiaButton;
        private DevExpress.XtraEditors.SimpleButton DeleteDongiaButton;
        private DevExpress.XtraEditors.SimpleButton SaveDongiaButton;
        private DevExpress.XtraGrid.GridControl dongiaHocphiModelGridControl;
        private System.Windows.Forms.BindingSource dongiaHocphiModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colSotien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayApdung;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton AddThannhanButton;
        private DevExpress.XtraEditors.SimpleButton DeleteThannhanButton;
        private DevExpress.XtraEditors.SimpleButton SaveThannhanButton;
        private DevExpress.XtraGrid.GridControl thannhanModelGridControl;
        private System.Windows.Forms.BindingSource thannhanModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanhe;
        private DevExpress.XtraGrid.Columns.GridColumn colHoten;
        private DevExpress.XtraGrid.Columns.GridColumn colNamsinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDT;
        private DevExpress.XtraGrid.Columns.GridColumn colNghenghiep;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colLaDaidienChinh;
        private DevExpress.XtraGrid.Columns.GridColumn colState2;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl;
        private DevExpress.XtraEditors.SearchLookUpEdit TinhthanhLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMavach;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ItemCheckEdit;
        private DevExpress.XtraEditors.SimpleButton PrintButton;
        private DevExpress.XtraEditors.TextEdit diachiTextEdit;
        private DevExpress.XtraEditors.SimpleButton PrintAllButton;
        private DevExpress.XtraEditors.SimpleButton ExcelButton;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colSudung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit DongiaCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
    }
}