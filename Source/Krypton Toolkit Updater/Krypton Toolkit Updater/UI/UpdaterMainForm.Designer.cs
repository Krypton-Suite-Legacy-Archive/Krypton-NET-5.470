namespace KryptonToolkitUpdater.UI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Krypton.Toolkit.KryptonForm" />
    partial class UpdaterMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterMainForm));
            this.kMan = new Krypton.Toolkit.KryptonManager(this.components);
            this.kpnlBackground = new Krypton.Toolkit.KryptonPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.klblCurrentStatus = new Krypton.Toolkit.KryptonLabel();
            this.kbtnOptions = new Krypton.Toolkit.KryptonButton();
            this.kbtnCheckForUpdates = new Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new Krypton.Toolkit.KryptonButton();
            this.kllHelp = new Krypton.Toolkit.KryptonLinkLabel();
            this.niKryptonToolkitUpdateUtility = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbtnDownloadUpdate = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            this.ctxNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.kbtnCheckForUpdates);
            this.kpnlBackground.Controls.Add(this.kbtnDownloadUpdate);
            this.kpnlBackground.Controls.Add(this.progressBar1);
            this.kpnlBackground.Controls.Add(this.klblCurrentStatus);
            this.kpnlBackground.Controls.Add(this.kbtnOptions);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Controls.Add(this.kllHelp);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(800, 166);
            this.kpnlBackground.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(772, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // klblCurrentStatus
            // 
            this.klblCurrentStatus.Location = new System.Drawing.Point(12, 12);
            this.klblCurrentStatus.Name = "klblCurrentStatus";
            this.klblCurrentStatus.Size = new System.Drawing.Size(418, 30);
            this.klblCurrentStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentStatus.TabIndex = 4;
            this.klblCurrentStatus.Values.Text = "Welcome, to begin click \'Check for Updates\'";
            // 
            // kbtnOptions
            // 
            this.kbtnOptions.Location = new System.Drawing.Point(435, 126);
            this.kbtnOptions.Name = "kbtnOptions";
            this.kbtnOptions.Size = new System.Drawing.Size(90, 25);
            this.kbtnOptions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOptions.TabIndex = 3;
            this.kbtnOptions.Values.Text = "&Options";
            this.kbtnOptions.Click += new System.EventHandler(this.kbtnOptions_Click);
            // 
            // kbtnCheckForUpdates
            // 
            this.kbtnCheckForUpdates.Location = new System.Drawing.Point(531, 126);
            this.kbtnCheckForUpdates.Name = "kbtnCheckForUpdates";
            this.kbtnCheckForUpdates.Size = new System.Drawing.Size(161, 25);
            this.kbtnCheckForUpdates.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCheckForUpdates.TabIndex = 2;
            this.kbtnCheckForUpdates.Values.Text = "Check for &Updates";
            this.kbtnCheckForUpdates.Click += new System.EventHandler(this.kbtnCheckForUpdates_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(698, 126);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 1;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kllHelp
            // 
            this.kllHelp.Location = new System.Drawing.Point(12, 125);
            this.kllHelp.Name = "kllHelp";
            this.kllHelp.Size = new System.Drawing.Size(104, 26);
            this.kllHelp.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllHelp.TabIndex = 0;
            this.kllHelp.Values.Text = "What is this?";
            this.kllHelp.LinkClicked += new System.EventHandler(this.kllHelp_LinkClicked);
            // 
            // niKryptonToolkitUpdateUtility
            // 
            this.niKryptonToolkitUpdateUtility.ContextMenuStrip = this.ctxNotifyIcon;
            this.niKryptonToolkitUpdateUtility.Icon = ((System.Drawing.Icon)(resources.GetObject("niKryptonToolkitUpdateUtility.Icon")));
            this.niKryptonToolkitUpdateUtility.Text = "Krypton Toolkit Update Utility";
            this.niKryptonToolkitUpdateUtility.Visible = true;
            // 
            // ctxNotifyIcon
            // 
            this.ctxNotifyIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateNowToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openUtilityToolStripMenuItem,
            this.toolStripMenuItem2,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.quitToolStripMenuItem});
            this.ctxNotifyIcon.Name = "ctxNotifyIcon";
            this.ctxNotifyIcon.Size = new System.Drawing.Size(172, 110);
            // 
            // updateNowToolStripMenuItem
            // 
            this.updateNowToolStripMenuItem.Name = "updateNowToolStripMenuItem";
            this.updateNowToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.updateNowToolStripMenuItem.Text = "U&pdate Now";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // openUtilityToolStripMenuItem
            // 
            this.openUtilityToolStripMenuItem.Name = "openUtilityToolStripMenuItem";
            this.openUtilityToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openUtilityToolStripMenuItem.Text = "Open &Utility";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for &Updates";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(168, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            // 
            // kbtnDownloadUpdate
            // 
            this.kbtnDownloadUpdate.Location = new System.Drawing.Point(531, 126);
            this.kbtnDownloadUpdate.Name = "kbtnDownloadUpdate";
            this.kbtnDownloadUpdate.Size = new System.Drawing.Size(161, 25);
            this.kbtnDownloadUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDownloadUpdate.TabIndex = 6;
            this.kbtnDownloadUpdate.Values.Text = "D&ownload Update";
            this.kbtnDownloadUpdate.Click += new System.EventHandler(this.kbtnDownloadUpdate_Click);
            // 
            // UpdaterMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 166);
            this.Controls.Add(this.kpnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdaterMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check for Krypton Toolkit Updates";
            this.TextExtra = "(Beta)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdaterMainForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdaterMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            this.ctxNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonManager kMan;
        private Krypton.Toolkit.KryptonPanel kpnlBackground;
        private Krypton.Toolkit.KryptonButton kbtnOptions;
        private Krypton.Toolkit.KryptonButton kbtnCheckForUpdates;
        private Krypton.Toolkit.KryptonButton kbtnCancel;
        private Krypton.Toolkit.KryptonLinkLabel kllHelp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Krypton.Toolkit.KryptonLabel klblCurrentStatus;
        private System.Windows.Forms.NotifyIcon niKryptonToolkitUpdateUtility;
        private System.Windows.Forms.ContextMenuStrip ctxNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem updateNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openUtilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private Krypton.Toolkit.KryptonButton kbtnDownloadUpdate;
    }
}