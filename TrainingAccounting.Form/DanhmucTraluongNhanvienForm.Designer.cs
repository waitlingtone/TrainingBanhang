namespace TrainingAccounting.Form
{
    partial class DanhmucTraluongNhanvienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhmucTraluongNhanvienForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.danhmucTraluongNhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhmucTraluongNhanvienModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucTraluongNhanvienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucTraluongNhanvienModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 297);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(598, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(321, 16);
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
            this.DeleteButton.Location = new System.Drawing.Point(419, 16);
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
            this.SaveButton.Location = new System.Drawing.Point(509, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // danhmucTraluongNhanvienModelBindingSource
            // 
            this.danhmucTraluongNhanvienModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.DanhmucTraluongNhanvienModel);
            // 
            // danhmucTraluongNhanvienModelGridControl
            // 
            this.danhmucTraluongNhanvienModelGridControl.DataSource = this.danhmucTraluongNhanvienModelBindingSource;
            this.danhmucTraluongNhanvienModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhmucTraluongNhanvienModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.danhmucTraluongNhanvienModelGridControl.MainView = this.gridView1;
            this.danhmucTraluongNhanvienModelGridControl.Name = "danhmucTraluongNhanvienModelGridControl";
            this.danhmucTraluongNhanvienModelGridControl.Size = new System.Drawing.Size(598, 297);
            this.danhmucTraluongNhanvienModelGridControl.TabIndex = 2;
            this.danhmucTraluongNhanvienModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colSoTien,
            this.colMota,
            this.colTinhLuong,
            this.colIsTru,
            this.colState});
            this.gridView1.GridControl = this.danhmucTraluongNhanvienModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMa, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã (Lương tháng nhập \'L0\')";
            this.colMa.FieldName = "Ma";
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.Caption = "Danh mục";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số tiền";
            this.colSoTien.DisplayFormat.FormatString = "#,#";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 2;
            // 
            // colMota
            // 
            this.colMota.Caption = "Mô tả";
            this.colMota.FieldName = "Mota";
            this.colMota.Name = "colMota";
            this.colMota.Visible = true;
            this.colMota.VisibleIndex = 3;
            // 
            // colTinhLuong
            // 
            this.colTinhLuong.Caption = "Có Tính lương";
            this.colTinhLuong.FieldName = "TinhLuong";
            this.colTinhLuong.Name = "colTinhLuong";
            this.colTinhLuong.Visible = true;
            this.colTinhLuong.VisibleIndex = 4;
            // 
            // colIsTru
            // 
            this.colIsTru.Caption = "Là Khoản trừ";
            this.colIsTru.FieldName = "IsTru";
            this.colIsTru.Name = "colIsTru";
            this.colIsTru.Visible = true;
            this.colIsTru.VisibleIndex = 5;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 6;
            // 
            // DanhmucTraluongNhanvienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 348);
            this.Controls.Add(this.danhmucTraluongNhanvienModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "DanhmucTraluongNhanvienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH MỤC TRẢ LƯƠNG NHÂN VIÊN";
            this.Load += new System.EventHandler(this.DanhmucTraluongNhanvienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhmucTraluongNhanvienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucTraluongNhanvienModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource danhmucTraluongNhanvienModelBindingSource;
        private DevExpress.XtraGrid.GridControl danhmucTraluongNhanvienModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colMota;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTru;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
    }
}