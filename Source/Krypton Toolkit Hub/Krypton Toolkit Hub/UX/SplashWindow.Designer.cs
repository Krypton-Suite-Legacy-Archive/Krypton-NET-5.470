namespace KryptonToolkitHub.UX
{
    partial class SplashWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashWindow));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.klblKryptonToolkitHubVersion = new Krypton.Toolkit.KryptonLabel();
            this.klblTitle = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.klblKryptonToolkitHubVersion);
            this.kryptonPanel1.Controls.Add(this.klblTitle);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.pbProgress);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 450);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // klblKryptonToolkitHubVersion
            // 
            this.klblKryptonToolkitHubVersion.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.klblKryptonToolkitHubVersion.Location = new System.Drawing.Point(114, 390);
            this.klblKryptonToolkitHubVersion.Name = "klblKryptonToolkitHubVersion";
            this.klblKryptonToolkitHubVersion.Size = new System.Drawing.Size(594, 30);
            this.klblKryptonToolkitHubVersion.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblKryptonToolkitHubVersion.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.klblKryptonToolkitHubVersion.TabIndex = 31;
            this.klblKryptonToolkitHubVersion.Values.Text = "Peter Wagner (aka Wagnerp) && Simon  Coghlan (aka Smurf-IV)";
            // 
            // klblTitle
            // 
            this.klblTitle.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.klblTitle.Location = new System.Drawing.Point(255, 351);
            this.klblTitle.Name = "klblTitle";
            this.klblTitle.Size = new System.Drawing.Size(311, 33);
            this.klblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTitle.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.klblTitle.TabIndex = 4;
            this.klblTitle.Values.ExtraText = "Beta (Build: {0})";
            this.klblTitle.Values.Text = "Krypton Toolkit Hub";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KryptonToolkitHub.Properties.Resources.Square_Design_256_x_256_New_Green1;
            this.pictureBox1.Location = new System.Drawing.Point(274, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbProgress
            // 
            this.pbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbProgress.Location = new System.Drawing.Point(0, 438);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(800, 12);
            this.pbProgress.TabIndex = 0;
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 250;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // SplashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashWindow_FormClosing);
            this.Load += new System.EventHandler(this.SplashWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel klblTitle;
        private System.Windows.Forms.Timer tmrSplash;
        private Krypton.Toolkit.KryptonLabel klblKryptonToolkitHubVersion;
    }
}