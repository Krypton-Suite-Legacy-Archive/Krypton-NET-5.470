namespace KryptonToolkitUpdater.UI
{
    partial class UpdateDetailsForm
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
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.kpnlBackground = new Krypton.Toolkit.KryptonPanel();
            this.kbtnRemindMeLater = new Krypton.Toolkit.KryptonButton();
            this.kbtnDownloadUpdate = new Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new Krypton.Toolkit.KryptonButton();
            this.wbChangelog = new System.Windows.Forms.WebBrowser();
            this.klblPackageInformation = new Krypton.Toolkit.KryptonLabel();
            this.klblVersionInformation = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.kbtnRemindMeLater);
            this.kpnlBackground.Controls.Add(this.kbtnDownloadUpdate);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Controls.Add(this.wbChangelog);
            this.kpnlBackground.Controls.Add(this.klblPackageInformation);
            this.kpnlBackground.Controls.Add(this.klblVersionInformation);
            this.kpnlBackground.Controls.Add(this.kryptonLabel1);
            this.kpnlBackground.Controls.Add(this.pictureBox1);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(869, 741);
            this.kpnlBackground.TabIndex = 0;
            // 
            // kbtnRemindMeLater
            // 
            this.kbtnRemindMeLater.Location = new System.Drawing.Point(12, 704);
            this.kbtnRemindMeLater.Name = "kbtnRemindMeLater";
            this.kbtnRemindMeLater.Size = new System.Drawing.Size(144, 25);
            this.kbtnRemindMeLater.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemindMeLater.TabIndex = 16;
            this.kbtnRemindMeLater.Values.Text = "&Remind Me Later";
            this.kbtnRemindMeLater.Click += new System.EventHandler(this.kbtnRemindMeLater_Click);
            // 
            // kbtnDownloadUpdate
            // 
            this.kbtnDownloadUpdate.Location = new System.Drawing.Point(594, 704);
            this.kbtnDownloadUpdate.Name = "kbtnDownloadUpdate";
            this.kbtnDownloadUpdate.Size = new System.Drawing.Size(167, 25);
            this.kbtnDownloadUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDownloadUpdate.TabIndex = 7;
            this.kbtnDownloadUpdate.Values.Text = "&Download Update";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(767, 704);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 6;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // wbChangelog
            // 
            this.wbChangelog.Location = new System.Drawing.Point(275, 218);
            this.wbChangelog.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbChangelog.Name = "wbChangelog";
            this.wbChangelog.Size = new System.Drawing.Size(582, 480);
            this.wbChangelog.TabIndex = 5;
            // 
            // klblPackageInformation
            // 
            this.klblPackageInformation.Location = new System.Drawing.Point(275, 168);
            this.klblPackageInformation.Name = "klblPackageInformation";
            this.klblPackageInformation.Size = new System.Drawing.Size(272, 26);
            this.klblPackageInformation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPackageInformation.TabIndex = 4;
            this.klblPackageInformation.Values.Text = "Package size: {0} Release date: {1}";
            // 
            // klblVersionInformation
            // 
            this.klblVersionInformation.Location = new System.Drawing.Point(275, 100);
            this.klblVersionInformation.Name = "klblVersionInformation";
            this.klblVersionInformation.Size = new System.Drawing.Size(285, 26);
            this.klblVersionInformation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblVersionInformation.TabIndex = 3;
            this.klblVersionInformation.Values.Text = "Your version: {0} Server version: {1}";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(275, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(527, 55);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "A new Krypton Toolkit update package is now available. \r\nDownload now?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KryptonToolkitUpdater.Properties.Resources.Download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 741);
            this.Controls.Add(this.kpnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDetailsForm";
            this.Text = "Update Details";
            this.TextExtra = "(Beta)";
            this.Load += new System.EventHandler(this.UpdateDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonPanel kpnlBackground;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser wbChangelog;
        private Krypton.Toolkit.KryptonLabel klblPackageInformation;
        private Krypton.Toolkit.KryptonLabel klblVersionInformation;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kbtnDownloadUpdate;
        private Krypton.Toolkit.KryptonButton kbtnCancel;
        private Krypton.Toolkit.KryptonButton kbtnRemindMeLater;
    }
}