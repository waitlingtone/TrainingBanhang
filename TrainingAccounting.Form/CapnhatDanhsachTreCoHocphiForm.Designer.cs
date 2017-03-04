namespace TrainingAccounting.Form
{
    partial class CapnhatDanhsachTreCoHocphiForm
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhsachButruHocphiGridControl = new DevExpress.XtraGrid.GridControl();
            this.danhsachButruHocphiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenTre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachButruHocphiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachButruHocphiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.SaveButton);
            this.panelControl2.Controls.Add(this.CloseButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 371);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(628, 48);
            this.panelControl2.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(443, 13);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(540, 13);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Đóng";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.danhsachButruHocphiGridControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(628, 364);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Trẻ có phát sinh học phí bù trừ tháng trước, nhưng không đăng ký học th" +
    "áng này";
            // 
            // danhsachButruHocphiGridControl
            // 
            this.danhsachButruHocphiGridControl.DataSource = this.danhsachButruHocphiBindingSource;
            this.danhsachButruHocphiGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhsachButruHocphiGridControl.Location = new System.Drawing.Point(3, 19);
            this.danhsachButruHocphiGridControl.MainView = this.gridView1;
            this.danhsachButruHocphiGridControl.Name = "danhsachButruHocphiGridControl";
            this.danhsachButruHocphiGridControl.Size = new System.Drawing.Size(622, 342);
            this.danhsachButruHocphiGridControl.TabIndex = 0;
            this.danhsachButruHocphiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // danhsachButruHocphiBindingSource
            // 
            this.danhsachButruHocphiBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.DanhsachButruHocphi);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenTre,
            this.colTongtien,
            this.colSelect});
            this.gridView1.GridControl = this.danhsachButruHocphiGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenTre
            // 
            this.colTenTre.Caption = "Họ tên Trẻ";
            this.colTenTre.FieldName = "TenTre";
            this.colTenTre.Name = "colTenTre";
            this.colTenTre.Visible = true;
            this.colTenTre.VisibleIndex = 0;
            // 
            // colTongtien
            // 
            this.colTongtien.Caption = "Tổng tiền";
            this.colTongtien.FieldName = "Tongtien";
            this.colTongtien.Name = "colTongtien";
            this.colTongtien.Visible = true;
            this.colTongtien.VisibleIndex = 1;
            // 
            // colSelect
            // 
            this.colSelect.Caption = "Chọn";
            this.colSelect.FieldName = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 2;
            // 
            // CapnhatDanhsachTreCoHocphiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapnhatDanhsachTreCoHocphiForm";
            this.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẬP NHẬT DANH SÁCH";
            this.Load += new System.EventHandler(this.CapnhatDanhsachTreCoHocphiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachButruHocphiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachButruHocphiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl danhsachButruHocphiGridControl;
        private System.Windows.Forms.BindingSource danhsachButruHocphiBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTre;
        private DevExpress.XtraGrid.Columns.GridColumn colTongtien;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton CloseButton;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;

    }
}