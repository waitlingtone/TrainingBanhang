namespace TrainingAccounting.Form
{
    partial class ThongtinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongtinForm));
            System.Windows.Forms.Label tenDonviLabel;
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label soDienthoaiLabel;
            System.Windows.Forms.Label textPhieubaoLabel;
            System.Windows.Forms.Label logoLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.tenDonviTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soDienthoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.logoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.diachiTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.textPhieubaoTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.printNameCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.printAddressCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.printPhoneCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.printLogoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.thongtinModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printTextCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            tenDonviLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            soDienthoaiLabel = new System.Windows.Forms.Label();
            textPhieubaoLabel = new System.Windows.Forms.Label();
            logoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenDonviTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDienthoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhieubaoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printNameCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printAddressCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPhoneCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printLogoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printTextCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 427);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(846, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(749, 17);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tenDonviLabel
            // 
            tenDonviLabel.AutoSize = true;
            tenDonviLabel.Location = new System.Drawing.Point(17, 28);
            tenDonviLabel.Name = "tenDonviLabel";
            tenDonviLabel.Size = new System.Drawing.Size(57, 13);
            tenDonviLabel.TabIndex = 2;
            tenDonviLabel.Text = "Tên đơn vị";
            // 
            // tenDonviTextEdit
            // 
            this.tenDonviTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tenDonviTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "TenDonvi", true));
            this.tenDonviTextEdit.Location = new System.Drawing.Point(114, 25);
            this.tenDonviTextEdit.Name = "tenDonviTextEdit";
            this.tenDonviTextEdit.Size = new System.Drawing.Size(625, 20);
            this.tenDonviTextEdit.TabIndex = 3;
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(17, 69);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(39, 13);
            diachiLabel.TabIndex = 3;
            diachiLabel.Text = "Địa chỉ";
            // 
            // soDienthoaiLabel
            // 
            soDienthoaiLabel.AutoSize = true;
            soDienthoaiLabel.Location = new System.Drawing.Point(17, 133);
            soDienthoaiLabel.Name = "soDienthoaiLabel";
            soDienthoaiLabel.Size = new System.Drawing.Size(69, 13);
            soDienthoaiLabel.TabIndex = 5;
            soDienthoaiLabel.Text = "Số điện thoại";
            // 
            // soDienthoaiTextEdit
            // 
            this.soDienthoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "SoDienthoai", true));
            this.soDienthoaiTextEdit.Location = new System.Drawing.Point(114, 130);
            this.soDienthoaiTextEdit.Name = "soDienthoaiTextEdit";
            this.soDienthoaiTextEdit.Size = new System.Drawing.Size(159, 20);
            this.soDienthoaiTextEdit.TabIndex = 6;
            // 
            // textPhieubaoLabel
            // 
            textPhieubaoLabel.AutoSize = true;
            textPhieubaoLabel.Location = new System.Drawing.Point(17, 167);
            textPhieubaoLabel.Name = "textPhieubaoLabel";
            textPhieubaoLabel.Size = new System.Drawing.Size(80, 39);
            textPhieubaoLabel.TabIndex = 7;
            textPhieubaoLabel.Text = "Thông tin lưu ý\r\n trên phiếu báo\r\n học phí";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Location = new System.Drawing.Point(17, 282);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(30, 13);
            logoLabel.TabIndex = 9;
            logoLabel.Text = "Logo";
            // 
            // logoPictureEdit
            // 
            this.logoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "Logo", true));
            this.logoPictureEdit.Location = new System.Drawing.Point(114, 282);
            this.logoPictureEdit.Name = "logoPictureEdit";
            this.logoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.logoPictureEdit.Size = new System.Drawing.Size(137, 123);
            this.logoPictureEdit.TabIndex = 10;
            // 
            // diachiTextEdit
            // 
            this.diachiTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diachiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "Diachi", true));
            this.diachiTextEdit.Location = new System.Drawing.Point(114, 66);
            this.diachiTextEdit.Name = "diachiTextEdit";
            this.diachiTextEdit.Size = new System.Drawing.Size(625, 46);
            this.diachiTextEdit.TabIndex = 4;
            // 
            // textPhieubaoTextEdit
            // 
            this.textPhieubaoTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPhieubaoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "TextPhieubao", true));
            this.textPhieubaoTextEdit.Location = new System.Drawing.Point(114, 165);
            this.textPhieubaoTextEdit.Name = "textPhieubaoTextEdit";
            this.textPhieubaoTextEdit.Size = new System.Drawing.Size(625, 97);
            this.textPhieubaoTextEdit.TabIndex = 8;
            // 
            // printNameCheckEdit
            // 
            this.printNameCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printNameCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "PrintName", true));
            this.printNameCheckEdit.Location = new System.Drawing.Point(761, 25);
            this.printNameCheckEdit.Name = "printNameCheckEdit";
            this.printNameCheckEdit.Properties.Caption = "In tên";
            this.printNameCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.printNameCheckEdit.TabIndex = 12;
            // 
            // printAddressCheckEdit
            // 
            this.printAddressCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printAddressCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "PrintAddress", true));
            this.printAddressCheckEdit.Location = new System.Drawing.Point(761, 63);
            this.printAddressCheckEdit.Name = "printAddressCheckEdit";
            this.printAddressCheckEdit.Properties.Caption = "In địa chỉ";
            this.printAddressCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.printAddressCheckEdit.TabIndex = 13;
            // 
            // printPhoneCheckEdit
            // 
            this.printPhoneCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printPhoneCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "PrintPhone", true));
            this.printPhoneCheckEdit.Location = new System.Drawing.Point(761, 127);
            this.printPhoneCheckEdit.Name = "printPhoneCheckEdit";
            this.printPhoneCheckEdit.Properties.Caption = "In SĐT";
            this.printPhoneCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.printPhoneCheckEdit.TabIndex = 14;
            // 
            // printLogoCheckEdit
            // 
            this.printLogoCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printLogoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "PrintLogo", true));
            this.printLogoCheckEdit.Location = new System.Drawing.Point(761, 280);
            this.printLogoCheckEdit.Name = "printLogoCheckEdit";
            this.printLogoCheckEdit.Properties.Caption = "In Logo";
            this.printLogoCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.printLogoCheckEdit.TabIndex = 15;
            // 
            // thongtinModelBindingSource
            // 
            this.thongtinModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ThongtinModel);
            // 
            // printTextCheckEdit
            // 
            this.printTextCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printTextCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongtinModelBindingSource, "PrintText", true));
            this.printTextCheckEdit.Location = new System.Drawing.Point(761, 164);
            this.printTextCheckEdit.Name = "printTextCheckEdit";
            this.printTextCheckEdit.Properties.Caption = "In lưu ý";
            this.printTextCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.printTextCheckEdit.TabIndex = 16;
            // 
            // ThongtinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 479);
            this.Controls.Add(this.printTextCheckEdit);
            this.Controls.Add(this.printLogoCheckEdit);
            this.Controls.Add(this.printPhoneCheckEdit);
            this.Controls.Add(this.printAddressCheckEdit);
            this.Controls.Add(this.printNameCheckEdit);
            this.Controls.Add(logoLabel);
            this.Controls.Add(this.logoPictureEdit);
            this.Controls.Add(textPhieubaoLabel);
            this.Controls.Add(soDienthoaiLabel);
            this.Controls.Add(this.soDienthoaiTextEdit);
            this.Controls.Add(diachiLabel);
            this.Controls.Add(tenDonviLabel);
            this.Controls.Add(this.tenDonviTextEdit);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.diachiTextEdit);
            this.Controls.Add(this.textPhieubaoTextEdit);
            this.Name = "ThongtinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN IN TRÊN CÁC BÁO CÁO";
            this.Load += new System.EventHandler(this.ThongtinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tenDonviTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDienthoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhieubaoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printNameCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printAddressCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPhoneCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printLogoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printTextCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private System.Windows.Forms.BindingSource thongtinModelBindingSource;
        private DevExpress.XtraEditors.TextEdit tenDonviTextEdit;
        private DevExpress.XtraEditors.TextEdit soDienthoaiTextEdit;
        private DevExpress.XtraEditors.PictureEdit logoPictureEdit;
        private DevExpress.XtraEditors.MemoEdit diachiTextEdit;
        private DevExpress.XtraEditors.MemoEdit textPhieubaoTextEdit;
        private DevExpress.XtraEditors.CheckEdit printNameCheckEdit;
        private DevExpress.XtraEditors.CheckEdit printAddressCheckEdit;
        private DevExpress.XtraEditors.CheckEdit printPhoneCheckEdit;
        private DevExpress.XtraEditors.CheckEdit printLogoCheckEdit;
        private DevExpress.XtraEditors.CheckEdit printTextCheckEdit;
    }
}