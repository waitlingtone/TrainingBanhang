namespace Lambda.MainProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.usernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DangnhapsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ThoatsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.MatkhautextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatkhautextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // usernameTextEdit
            // 
            this.usernameTextEdit.EditValue = "admin";
            this.usernameTextEdit.Location = new System.Drawing.Point(165, 23);
            this.usernameTextEdit.Name = "usernameTextEdit";
            this.usernameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.usernameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.usernameTextEdit.Size = new System.Drawing.Size(241, 30);
            this.usernameTextEdit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu";
            // 
            // DangnhapsimpleButton
            // 
            this.DangnhapsimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.DangnhapsimpleButton.Appearance.Options.UseFont = true;
            this.DangnhapsimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DangnhapsimpleButton.Location = new System.Drawing.Point(193, 143);
            this.DangnhapsimpleButton.Name = "DangnhapsimpleButton";
            this.DangnhapsimpleButton.Size = new System.Drawing.Size(104, 30);
            this.DangnhapsimpleButton.TabIndex = 7;
            this.DangnhapsimpleButton.Text = "Đăng nhập";
            this.DangnhapsimpleButton.Click += new System.EventHandler(this.DangnhapsimpleButton_Click);
            // 
            // ThoatsimpleButton
            // 
            this.ThoatsimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ThoatsimpleButton.Appearance.Options.UseFont = true;
            this.ThoatsimpleButton.Location = new System.Drawing.Point(323, 143);
            this.ThoatsimpleButton.Name = "ThoatsimpleButton";
            this.ThoatsimpleButton.Size = new System.Drawing.Size(83, 30);
            this.ThoatsimpleButton.TabIndex = 8;
            this.ThoatsimpleButton.Text = "Thoát";
            this.ThoatsimpleButton.Click += new System.EventHandler(this.ThoatsimpleButton_Click);
            // 
            // MatkhautextEdit
            // 
            this.MatkhautextEdit.EditValue = "admin";
            this.MatkhautextEdit.Location = new System.Drawing.Point(165, 69);
            this.MatkhautextEdit.Name = "MatkhautextEdit";
            this.MatkhautextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.MatkhautextEdit.Properties.Appearance.Options.UseFont = true;
            this.MatkhautextEdit.Properties.PasswordChar = '*';
            this.MatkhautextEdit.Properties.UseSystemPasswordChar = true;
            this.MatkhautextEdit.Size = new System.Drawing.Size(241, 30);
            this.MatkhautextEdit.TabIndex = 3;
           // 
            // LoginForm
            // 
            this.AcceptButton = this.DangnhapsimpleButton;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DangnhapsimpleButton;
            this.ClientSize = new System.Drawing.Size(426, 185);
            this.Controls.Add(this.MatkhautextEdit);
            this.Controls.Add(this.ThoatsimpleButton);
            this.Controls.Add(this.DangnhapsimpleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatkhautextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit usernameTextEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton DangnhapsimpleButton;
        private DevExpress.XtraEditors.SimpleButton ThoatsimpleButton;
        private DevExpress.XtraEditors.TextEdit MatkhautextEdit;
    }
}