namespace TrainingAccounting.Form
{
    partial class BanhangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanhangForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hoadonModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoadonId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaylap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrigia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoHD = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.chitietHoadonModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChitietHoadonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoadonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHanghoaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.hanghoaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietHoadonModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaModelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(982, 440);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hóa đơn";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoadonModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(976, 307);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hoadonModelBindingSource
            // 
            this.hoadonModelBindingSource.PositionChanged += new System.EventHandler(this.hoadonModelBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoadonId1,
            this.colNgaylap,
            this.colTrigia,
            this.colVersion,
            this.colState});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colHoadonId1
            // 
            this.colHoadonId1.Caption = "Mã hóa đơn";
            this.colHoadonId1.FieldName = "HoadonId";
            this.colHoadonId1.Name = "colHoadonId1";
            this.colHoadonId1.Visible = true;
            this.colHoadonId1.VisibleIndex = 0;
            this.colHoadonId1.Width = 108;
            // 
            // colNgaylap
            // 
            this.colNgaylap.Caption = "Ngày lập";
            this.colNgaylap.FieldName = "Ngaylap";
            this.colNgaylap.Name = "colNgaylap";
            this.colNgaylap.Visible = true;
            this.colNgaylap.VisibleIndex = 1;
            this.colNgaylap.Width = 95;
            // 
            // colTrigia
            // 
            this.colTrigia.Caption = "Trị giá";
            this.colTrigia.FieldName = "Trigia";
            this.colTrigia.Name = "colTrigia";
            this.colTrigia.Visible = true;
            this.colTrigia.VisibleIndex = 2;
            this.colTrigia.Width = 94;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 3;
            this.colState.Width = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoHD.Image")));
            this.btnTaoHD.Location = new System.Drawing.Point(74, 33);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(151, 50);
            this.btnTaoHD.TabIndex = 10;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Controls.Add(this.groupBox2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(398, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(584, 440);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi tiết hóa đơn";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.chitietHoadonModelBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 30);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl2.Size = new System.Drawing.Size(578, 307);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // chitietHoadonModelBindingSource
            // 
            this.chitietHoadonModelBindingSource.CurrentItemChanged += new System.EventHandler(this.chitietHoadonModelBindingSource_CurrentItemChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChitietHoadonId,
            this.colHoadonId,
            this.colHanghoaId,
            this.colSoluong,
            this.colDongia,
            this.colThanhtien,
            this.colVersion1,
            this.colState1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colChitietHoadonId
            // 
            this.colChitietHoadonId.FieldName = "ChitietHoadonId";
            this.colChitietHoadonId.Name = "colChitietHoadonId";
            // 
            // colHoadonId
            // 
            this.colHoadonId.Caption = "Mã hóa đơn";
            this.colHoadonId.FieldName = "HoadonId";
            this.colHoadonId.Name = "colHoadonId";
            this.colHoadonId.Visible = true;
            this.colHoadonId.VisibleIndex = 0;
            // 
            // colHanghoaId
            // 
            this.colHanghoaId.Caption = "Tên Hàng hóa";
            this.colHanghoaId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colHanghoaId.FieldName = "HanghoaId";
            this.colHanghoaId.Name = "colHanghoaId";
            this.colHanghoaId.Visible = true;
            this.colHanghoaId.VisibleIndex = 1;
            this.colHanghoaId.Width = 128;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tenhanghoa", "Hàng hóa")});
            this.repositoryItemLookUpEdit1.DataSource = this.hanghoaModelBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Tenhanghoa";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "Chọn hàng hóa";
            this.repositoryItemLookUpEdit1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemLookUpEdit1.ValueMember = "HanghoaId";
            this.repositoryItemLookUpEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEdit1_EditValueChanged);
            // 
            // colSoluong
            // 
            this.colSoluong.Caption = "Số lượng";
            this.colSoluong.FieldName = "Soluong";
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.Visible = true;
            this.colSoluong.VisibleIndex = 3;
            // 
            // colDongia
            // 
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.FieldName = "Dongia";
            this.colDongia.Name = "colDongia";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 2;
            // 
            // colThanhtien
            // 
            this.colThanhtien.Caption = "Thành tiền";
            this.colThanhtien.FieldName = "Thanhtien";
            this.colThanhtien.Name = "colThanhtien";
            this.colThanhtien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanhtien", "SUM={0:0.##}")});
            this.colThanhtien.Visible = true;
            this.colThanhtien.VisibleIndex = 4;
            // 
            // colVersion1
            // 
            this.colVersion1.FieldName = "Version";
            this.colVersion1.Name = "colVersion1";
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(436, 33);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 50);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(62, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 50);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(249, 33);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 50);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // BanhangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 440);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "BanhangForm";
            this.Text = "BanhangForm";
            this.Load += new System.EventHandler(this.BanhangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietHoadonModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaModelBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource hoadonModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHoadonId1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaylap;
        private DevExpress.XtraGrid.Columns.GridColumn colTrigia;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource hanghoaModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource chitietHoadonModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colChitietHoadonId;
        private DevExpress.XtraGrid.Columns.GridColumn colHoadonId;
        private DevExpress.XtraGrid.Columns.GridColumn colHanghoaId;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnTaoHD;
    }
}