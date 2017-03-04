namespace TrainingAccounting.Form
{
    partial class TongiaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TongiaoForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddButton = new DevExpress.XtraEditors.SimpleButton();
            this.tongiaoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tongiaoModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTongiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTongiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tongiaoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongiaoModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.DeleteButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Controls.Add(this.AddButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 374);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(745, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(563, 18);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.deleteSmallButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(662, 18);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.Click += new System.EventHandler(this.saveSmallButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(467, 18);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.addSmallButton_Click);
            // 
            // tongiaoModelBindingSource
            // 
            this.tongiaoModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.TongiaoModel);
            // 
            // tongiaoModelGridControl
            // 
            this.tongiaoModelGridControl.DataSource = this.tongiaoModelBindingSource;
            this.tongiaoModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tongiaoModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.tongiaoModelGridControl.MainView = this.gridView1;
            this.tongiaoModelGridControl.Name = "tongiaoModelGridControl";
            this.tongiaoModelGridControl.Size = new System.Drawing.Size(745, 374);
            this.tongiaoModelGridControl.TabIndex = 2;
            this.tongiaoModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTongiao,
            this.colTenTongiao,
            this.colState});
            this.gridView1.GridControl = this.tongiaoModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaTongiao
            // 
            this.colMaTongiao.Caption = "Mã Tôn giáo";
            this.colMaTongiao.FieldName = "MaTongiao";
            this.colMaTongiao.Name = "colMaTongiao";
            this.colMaTongiao.Visible = true;
            this.colMaTongiao.VisibleIndex = 0;
            // 
            // colTenTongiao
            // 
            this.colTenTongiao.Caption = "Tên Tôn giáo";
            this.colTenTongiao.FieldName = "TenTongiao";
            this.colTenTongiao.Name = "colTenTongiao";
            this.colTenTongiao.Visible = true;
            this.colTenTongiao.VisibleIndex = 1;
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
            // TongiaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 427);
            this.Controls.Add(this.tongiaoModelGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "TongiaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TÔN GIÁO";
            this.Load += new System.EventHandler(this.TongiaoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tongiaoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongiaoModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource tongiaoModelBindingSource;
        private DevExpress.XtraGrid.GridControl tongiaoModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTongiao;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTongiao;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton AddButton;
    }
}