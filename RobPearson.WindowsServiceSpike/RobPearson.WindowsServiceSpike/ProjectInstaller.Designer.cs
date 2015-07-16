namespace RobPearson.WindowsServiceSpike
{
    partial class ProjectInstaller
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
            this.spikeServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.spikeServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // spikeServiceProcessInstaller
            // 
            this.spikeServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.spikeServiceProcessInstaller.Password = null;
            this.spikeServiceProcessInstaller.Username = null;
            // 
            // spikeServiceInstaller
            // 
            this.spikeServiceInstaller.Description = "Spike Windows Server";
            this.spikeServiceInstaller.DisplayName = "Rob Pearson Spike Windows Server";
            this.spikeServiceInstaller.ServiceName = "SpikeService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.spikeServiceProcessInstaller,
            this.spikeServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller spikeServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller spikeServiceInstaller;
    }
}