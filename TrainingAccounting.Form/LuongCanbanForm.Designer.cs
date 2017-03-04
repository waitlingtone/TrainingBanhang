namespace TrainingAccounting.Form
{
    partial class LuongCanbanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuongCanbanForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.luongNhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luongNhanvienModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMucluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayApdung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanvienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanvienModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 270);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(571, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(287, 16);
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
            this.DeleteButton.Location = new System.Drawing.Point(381, 16);
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
            this.SaveButton.Location = new System.Drawing.Point(474, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // luongNhanvienModelBindingSource
            // 
            this.luongNhanvienModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.LuongNhanvienModel);
            // 
            // luongNhanvienModelGridControl
            // 
            this.luongNhanvienModelGridControl.DataSource = this.luongNhanvienModelBindingSource;
            this.luongNhanvienModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luongNhanvienModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.luongNhanvienModelGridControl.MainView = this.gridView1;
            this.luongNhanvienModelGridControl.Name = "luongNhanvienModelGridControl";
            this.luongNhanvienModelGridControl.Size = new System.Drawing.Size(571, 270);
            this.luongNhanvienModelGridControl.TabIndex = 2;
            this.luongNhanvienModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMucluong,
            this.colNgayApdung,
            this.colState});
            this.gridView1.GridControl = this.luongNhanvienModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMucluong
            // 
            this.colMucluong.Caption = "Mức lương";
            this.colMucluong.DisplayFormat.FormatString = "#,#";
            this.colMucluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMucluong.FieldName = "Mucluong";
            this.colMucluong.Name = "colMucluong";
            this.colMucluong.Visible = true;
            this.colMucluong.VisibleIndex = 1;
            // 
            // colNgayApdung
            // 
            this.colNgayApdung.Caption = "Ngày Áp dụng";
            this.colNgayApdung.FieldName = "NgayApdung";
            this.colNgayApdung.Name = "colNgayApdung";
            this.colNgayApdung.Visible = true;
            this.colNgayApdung.VisibleIndex = 0;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            // 
            // LuongCanbanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 321);
            this.Controls.Add(this.luongNhanvienModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "LuongCanbanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LƯƠNG CĂN BẢN";
            this.Load += new System.EventHandler(this.LuongCanbanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanvienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanvienModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource luongNhanvienModelBindingSource;
        private DevExpress.XtraGrid.GridControl luongNhanvienModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMucluong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayApdung;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
    }
}