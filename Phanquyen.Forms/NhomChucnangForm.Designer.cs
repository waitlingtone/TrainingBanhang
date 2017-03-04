namespace Phanquyen.Forms
{
    partial class NhomChucnangForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupItemModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupItemModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 268);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(615, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(339, 16);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(434, 16);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(528, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupItemModelBindingSource
            // 
            this.groupItemModelBindingSource.DataSource = typeof(Phanquyen.Model.BusinessObject.GroupItemModel);
            // 
            // groupItemModelGridControl
            // 
            this.groupItemModelGridControl.DataSource = this.groupItemModelBindingSource;
            this.groupItemModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupItemModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.groupItemModelGridControl.MainView = this.gridView1;
            this.groupItemModelGridControl.Name = "groupItemModelGridControl";
            this.groupItemModelGridControl.Size = new System.Drawing.Size(615, 268);
            this.groupItemModelGridControl.TabIndex = 2;
            this.groupItemModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTennhom,
            this.colMota,
            this.colState});
            this.gridView1.GridControl = this.groupItemModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTennhom
            // 
            this.colTennhom.Caption = "Tên nhóm";
            this.colTennhom.FieldName = "Tennhom";
            this.colTennhom.Name = "colTennhom";
            this.colTennhom.Visible = true;
            this.colTennhom.VisibleIndex = 0;
            // 
            // colMota
            // 
            this.colMota.Caption = "Mô tả";
            this.colMota.FieldName = "Mota";
            this.colMota.Name = "colMota";
            this.colMota.Visible = true;
            this.colMota.VisibleIndex = 1;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            // 
            // NhomChucnangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 319);
            this.Controls.Add(this.groupItemModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "NhomChucnangForm";
            this.Text = "NHÓM CHỨC NĂNG";
            this.Load += new System.EventHandler(this.NhomChucnangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupItemModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton AddButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource groupItemModelBindingSource;
        private DevExpress.XtraGrid.GridControl groupItemModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTennhom;
        private DevExpress.XtraGrid.Columns.GridColumn colMota;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
    }
}