namespace KryptonToolkitUpdater.UI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Krypton.Toolkit.KryptonForm" />
    partial class DownloadUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadUpdateForm));
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.kpnlBackground = new Krypton.Toolkit.KryptonPanel();
            this.kbtnInstallUpdate = new Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new Krypton.Toolkit.KryptonButton();
            this.kbtnStop = new Krypton.Toolkit.KryptonButton();
            this.klblTotalAmountDownloaded = new Krypton.Toolkit.KryptonLabel();
            this.klblCurrentSpeed = new Krypton.Toolkit.KryptonLabel();
            this.klblDownloadProgressPercentage = new Krypton.Toolkit.KryptonLabel();
            this.pbDownloadProgress = new System.Windows.Forms.ProgressBar();
            this.kllDownloadingTo = new Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.klblDownloadingFrom = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.kbtnInstallUpdate);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Controls.Add(this.kbtnStop);
            this.kpnlBackground.Controls.Add(this.klblTotalAmountDownloaded);
            this.kpnlBackground.Controls.Add(this.klblCurrentSpeed);
            this.kpnlBackground.Controls.Add(this.klblDownloadProgressPercentage);
            this.kpnlBackground.Controls.Add(this.pbDownloadProgress);
            this.kpnlBackground.Controls.Add(this.kllDownloadingTo);
            this.kpnlBackground.Controls.Add(this.kryptonLabel1);
            this.kpnlBackground.Controls.Add(this.klblDownloadingFrom);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(1083, 241);
            this.kpnlBackground.TabIndex = 0;
            // 
            // kbtnInstallUpdate
            // 
            this.kbtnInstallUpdate.Location = new System.Drawing.Point(836, 206);
            this.kbtnInstallUpdate.Name = "kbtnInstallUpdate";
            this.kbtnInstallUpdate.Size = new System.Drawing.Size(139, 25);
            this.kbtnInstallUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstallUpdate.TabIndex = 13;
            this.kbtnInstallUpdate.Values.Text = "&Install Update";
            this.kbtnInstallUpdate.Click += new System.EventHandler(this.kbtnInstallUpdate_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(981, 206);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 12;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnStop
            // 
            this.kbtnStop.Location = new System.Drawing.Point(981, 206);
            this.kbtnStop.Name = "kbtnStop";
            this.kbtnStop.Size = new System.Drawing.Size(90, 25);
            this.kbtnStop.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStop.TabIndex = 11;
            this.kbtnStop.Values.Text = "S&top";
            this.kbtnStop.Click += new System.EventHandler(this.kbtnStop_Click);
            // 
            // klblTotalAmountDownloaded
            // 
            this.klblTotalAmountDownloaded.Location = new System.Drawing.Point(650, 143);
            this.klblTotalAmountDownloaded.Name = "klblTotalAmountDownloaded";
            this.klblTotalAmountDownloaded.Size = new System.Drawing.Size(254, 26);
            this.klblTotalAmountDownloaded.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalAmountDownloaded.TabIndex = 10;
            this.klblTotalAmountDownloaded.Values.Text = "Amount downloaded: {0} of {1}";
            // 
            // klblCurrentSpeed
            // 
            this.klblCurrentSpeed.Location = new System.Drawing.Point(12, 143);
            this.klblCurrentSpeed.Name = "klblCurrentSpeed";
            this.klblCurrentSpeed.Size = new System.Drawing.Size(151, 26);
            this.klblCurrentSpeed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentSpeed.TabIndex = 9;
            this.klblCurrentSpeed.Values.Text = "Current speed: {0}";
            // 
            // klblDownloadProgressPercentage
            // 
            this.klblDownloadProgressPercentage.Location = new System.Drawing.Point(1016, 101);
            this.klblDownloadProgressPercentage.Name = "klblDownloadProgressPercentage";
            this.klblDownloadProgressPercentage.Size = new System.Drawing.Size(48, 26);
            this.klblDownloadProgressPercentage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloadProgressPercentage.TabIndex = 8;
            this.klblDownloadProgressPercentage.Values.Text = "{0}%";
            // 
            // pbDownloadProgress
            // 
            this.pbDownloadProgress.Location = new System.Drawing.Point(12, 101);
            this.pbDownloadProgress.Name = "pbDownloadProgress";
            this.pbDownloadProgress.Size = new System.Drawing.Size(998, 26);
            this.pbDownloadProgress.TabIndex = 7;
            // 
            // kllDownloadingTo
            // 
            this.kllDownloadingTo.Location = new System.Drawing.Point(159, 44);
            this.kllDownloadingTo.Name = "kllDownloadingTo";
            this.kllDownloadingTo.Size = new System.Drawing.Size(33, 26);
            this.kllDownloadingTo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllDownloadingTo.TabIndex = 6;
            this.kllDownloadingTo.Values.Text = "{0}";
            this.kllDownloadingTo.LinkClicked += new System.EventHandler(this.kllDownloadingTo_LinkClicked);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 44);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(141, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Downloading to:";
            // 
            // klblDownloadingFrom
            // 
            this.klblDownloadingFrom.Location = new System.Drawing.Point(12, 12);
            this.klblDownloadingFrom.Name = "klblDownloadingFrom";
            this.klblDownloadingFrom.Size = new System.Drawing.Size(189, 26);
            this.klblDownloadingFrom.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloadingFrom.TabIndex = 4;
            this.klblDownloadingFrom.Values.Text = "Downloading from: {0}";
            // 
            // DownloadUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 241);
            this.Controls.Add(this.kpnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Update";
            this.TextExtra = "(Beta)";
            this.Load += new System.EventHandler(this.DownloadUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonPanel kpnlBackground;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel klblDownloadingFrom;
        private Krypton.Toolkit.KryptonLabel klblTotalAmountDownloaded;
        private Krypton.Toolkit.KryptonLabel klblCurrentSpeed;
        private Krypton.Toolkit.KryptonLabel klblDownloadProgressPercentage;
        private System.Windows.Forms.ProgressBar pbDownloadProgress;
        private Krypton.Toolkit.KryptonLinkLabel kllDownloadingTo;
        private Krypton.Toolkit.KryptonButton kbtnInstallUpdate;
        private Krypton.Toolkit.KryptonButton kbtnCancel;
        private Krypton.Toolkit.KryptonButton kbtnStop;
    }
}