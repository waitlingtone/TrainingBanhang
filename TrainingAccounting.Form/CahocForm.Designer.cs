namespace TrainingAccounting.Form
{
    partial class CahocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CahocForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cahocModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cahocModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioBatdau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colGioKetthuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cahocModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cahocModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 329);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(720, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(431, 11);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(531, 11);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(633, 11);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cahocModelBindingSource
            // 
            this.cahocModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.CahocModel);
            // 
            // cahocModelGridControl
            // 
            this.cahocModelGridControl.DataSource = this.cahocModelBindingSource;
            this.cahocModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cahocModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.cahocModelGridControl.MainView = this.gridView1;
            this.cahocModelGridControl.Name = "cahocModelGridControl";
            this.cahocModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1});
            this.cahocModelGridControl.Size = new System.Drawing.Size(720, 329);
            this.cahocModelGridControl.TabIndex = 2;
            this.cahocModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCa,
            this.colTenCa,
            this.colGioBatdau,
            this.colGioKetthuc,
            this.colSudung,
            this.colState});
            this.gridView1.GridControl = this.cahocModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaCa
            // 
            this.colMaCa.Caption = "Mã Ca học";
            this.colMaCa.FieldName = "MaCa";
            this.colMaCa.Name = "colMaCa";
            this.colMaCa.Visible = true;
            this.colMaCa.VisibleIndex = 0;
            // 
            // colTenCa
            // 
            this.colTenCa.Caption = "Tên Ca học";
            this.colTenCa.FieldName = "TenCa";
            this.colTenCa.Name = "colTenCa";
            this.colTenCa.Visible = true;
            this.colTenCa.VisibleIndex = 1;
            // 
            // colGioBatdau
            // 
            this.colGioBatdau.Caption = "Giờ Bắt đầu";
            this.colGioBatdau.ColumnEdit = this.repositoryItemTimeEdit1;
            this.colGioBatdau.FieldName = "GioBatdau";
            this.colGioBatdau.Name = "colGioBatdau";
            this.colGioBatdau.Visible = true;
            this.colGioBatdau.VisibleIndex = 2;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // colGioKetthuc
            // 
            this.colGioKetthuc.Caption = "Giờ Kết thúc";
            this.colGioKetthuc.ColumnEdit = this.repositoryItemTimeEdit1;
            this.colGioKetthuc.FieldName = "GioKetthuc";
            this.colGioKetthuc.Name = "colGioKetthuc";
            this.colGioKetthuc.Visible = true;
            this.colGioKetthuc.VisibleIndex = 3;
            // 
            // colSudung
            // 
            this.colSudung.Caption = "Sử dụng";
            this.colSudung.FieldName = "Sudung";
            this.colSudung.Name = "colSudung";
            this.colSudung.Visible = true;
            this.colSudung.VisibleIndex = 4;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            // 
            // CahocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 374);
            this.Controls.Add(this.cahocModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "CahocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CA HỌC";
            this.Load += new System.EventHandler(this.CahocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cahocModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cahocModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource cahocModelBindingSource;
        private DevExpress.XtraGrid.GridControl cahocModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCa;
        private DevExpress.XtraGrid.Columns.GridColumn colGioBatdau;
        private DevExpress.XtraGrid.Columns.GridColumn colGioKetthuc;
        private DevExpress.XtraGrid.Columns.GridColumn colSudung;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
    }
}