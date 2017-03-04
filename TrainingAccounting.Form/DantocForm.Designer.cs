namespace TrainingAccounting.Form
{
    partial class DantocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DantocForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.dantocModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dantocModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDantoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDantoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dantocModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dantocModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 421);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(818, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(727, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 29);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.saveSmallButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(633, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 29);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.deleteSmallButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(541, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 29);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.addSmallButton_Click);
            // 
            // dantocModelBindingSource
            // 
            this.dantocModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.DantocModel);
            // 
            // dantocModelGridControl
            // 
            this.dantocModelGridControl.DataSource = this.dantocModelBindingSource;
            this.dantocModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dantocModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.dantocModelGridControl.MainView = this.gridView1;
            this.dantocModelGridControl.Name = "dantocModelGridControl";
            this.dantocModelGridControl.Size = new System.Drawing.Size(818, 421);
            this.dantocModelGridControl.TabIndex = 2;
            this.dantocModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDantoc,
            this.colTenDantoc,
            this.colState});
            this.gridView1.GridControl = this.dantocModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaDantoc
            // 
            this.colMaDantoc.Caption = "Mã Dân tộc";
            this.colMaDantoc.FieldName = "MaDantoc";
            this.colMaDantoc.Name = "colMaDantoc";
            this.colMaDantoc.Visible = true;
            this.colMaDantoc.VisibleIndex = 0;
            // 
            // colTenDantoc
            // 
            this.colTenDantoc.Caption = "Tên Dân tộc";
            this.colTenDantoc.FieldName = "TenDantoc";
            this.colTenDantoc.Name = "colTenDantoc";
            this.colTenDantoc.Visible = true;
            this.colTenDantoc.VisibleIndex = 1;
            // 
            // colState
            // 
            this.colState.Caption = "Trạng thái";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            // 
            // DantocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 477);
            this.Controls.Add(this.dantocModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "DantocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DÂN TỘC";
            this.Load += new System.EventHandler(this.DantocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dantocModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dantocModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource dantocModelBindingSource;
        private DevExpress.XtraGrid.GridControl dantocModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDantoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDantoc;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton AddButton;
    }
}