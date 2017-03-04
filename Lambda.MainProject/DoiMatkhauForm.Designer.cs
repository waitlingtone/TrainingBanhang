namespace Lambda.MainProject
{
    partial class DoiMatkhauForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatkhauForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.OldPasstextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NewPasstextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CfNewPasstextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OldPasstextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasstextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CfNewPasstextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 180);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(459, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(361, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Lưu lại";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OldPasstextEdit
            // 
            this.OldPasstextEdit.Location = new System.Drawing.Point(225, 41);
            this.OldPasstextEdit.Name = "OldPasstextEdit";
            this.OldPasstextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPasstextEdit.Properties.Appearance.Options.UseFont = true;
            this.OldPasstextEdit.Properties.UseSystemPasswordChar = true;
            this.OldPasstextEdit.Size = new System.Drawing.Size(185, 26);
            this.OldPasstextEdit.TabIndex = 1;
            // 
            // NewPasstextEdit
            // 
            this.NewPasstextEdit.Location = new System.Drawing.Point(225, 81);
            this.NewPasstextEdit.Name = "NewPasstextEdit";
            this.NewPasstextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasstextEdit.Properties.Appearance.Options.UseFont = true;
            this.NewPasstextEdit.Properties.UseSystemPasswordChar = true;
            this.NewPasstextEdit.Size = new System.Drawing.Size(185, 26);
            this.NewPasstextEdit.TabIndex = 1;
            // 
            // CfNewPasstextEdit
            // 
            this.CfNewPasstextEdit.Location = new System.Drawing.Point(225, 122);
            this.CfNewPasstextEdit.Name = "CfNewPasstextEdit";
            this.CfNewPasstextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CfNewPasstextEdit.Properties.Appearance.Options.UseFont = true;
            this.CfNewPasstextEdit.Properties.UseSystemPasswordChar = true;
            this.CfNewPasstextEdit.Size = new System.Drawing.Size(185, 26);
            this.CfNewPasstextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(34, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mật khẩu cũ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(34, 125);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(167, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Xác nhận mật khẩu mới";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(34, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu mới";
            // 
            // DoiMatkhauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 231);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.CfNewPasstextEdit);
            this.Controls.Add(this.NewPasstextEdit);
            this.Controls.Add(this.OldPasstextEdit);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoiMatkhauForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.DoiMatkhauForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OldPasstextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasstextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CfNewPasstextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.TextEdit OldPasstextEdit;
        private DevExpress.XtraEditors.TextEdit NewPasstextEdit;
        private DevExpress.XtraEditors.TextEdit CfNewPasstextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}