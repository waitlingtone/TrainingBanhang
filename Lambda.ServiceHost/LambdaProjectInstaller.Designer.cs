namespace Lambda.ServiceHost
{
    partial class LambdaProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LambdaServiceHostProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.LambdaServiceHostInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // LambdaServiceHostProcessInstaller
            // 
            this.LambdaServiceHostProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.LambdaServiceHostProcessInstaller.Password = null;
            this.LambdaServiceHostProcessInstaller.Username = null;
            // 
            // LambdaServiceHostInstaller
            // 
            this.LambdaServiceHostInstaller.DelayedAutoStart = true;
            this.LambdaServiceHostInstaller.Description = "Lambda Windows Service Host";
            this.LambdaServiceHostInstaller.DisplayName = "Lambda Windows Service Host";
            this.LambdaServiceHostInstaller.ServiceName = "LambdaServiceHost";
            // 
            // LambdaProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.LambdaServiceHostProcessInstaller,
            this.LambdaServiceHostInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller LambdaServiceHostProcessInstaller;
        private System.ServiceProcess.ServiceInstaller LambdaServiceHostInstaller;
    }
}