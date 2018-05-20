namespace KryptonToolkitUpdater.UI
{
    partial class UpdatePackageDetails
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
            this.kpnlBackdrop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.klblFileName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFileSize = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFileReleaseDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblUpdateType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblImageType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFileVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA384CheckSum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA512CheckSum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA256CheckSum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA1CheckSum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblMD5CheckSum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblRIPEMD160CheckSum = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).BeginInit();
            this.kpnlBackdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBackdrop
            // 
            this.kpnlBackdrop.Controls.Add(this.kryptonNavigator1);
            this.kpnlBackdrop.Controls.Add(this.kbtnCancel);
            this.kpnlBackdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackdrop.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackdrop.Name = "kpnlBackdrop";
            this.kpnlBackdrop.Size = new System.Drawing.Size(1603, 887);
            this.kpnlBackdrop.TabIndex = 0;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Location = new System.Drawing.Point(12, 12);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonNavigator1.SelectedIndex = 1;
            this.kryptonNavigator1.Size = new System.Drawing.Size(1579, 832);
            this.kryptonNavigator1.TabIndex = 14;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.klblFileVersion);
            this.kryptonPage1.Controls.Add(this.klblImageType);
            this.kryptonPage1.Controls.Add(this.klblUpdateType);
            this.kryptonPage1.Controls.Add(this.klblFileReleaseDate);
            this.kryptonPage1.Controls.Add(this.klblFileSize);
            this.kryptonPage1.Controls.Add(this.klblFileName);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1577, 805);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "EC80561E90BB4B0EC6B4DAB4956C6480";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.klblRIPEMD160CheckSum);
            this.kryptonPage2.Controls.Add(this.klblSHA384CheckSum);
            this.kryptonPage2.Controls.Add(this.klblSHA512CheckSum);
            this.kryptonPage2.Controls.Add(this.klblSHA256CheckSum);
            this.kryptonPage2.Controls.Add(this.klblSHA1CheckSum);
            this.kryptonPage2.Controls.Add(this.klblMD5CheckSum);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(1577, 805);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "3E80C57FD341415B5EB72C687FFA5CE2";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(1501, 850);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 13;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // klblFileName
            // 
            this.klblFileName.Location = new System.Drawing.Point(393, 170);
            this.klblFileName.Name = "klblFileName";
            this.klblFileName.Size = new System.Drawing.Size(140, 33);
            this.klblFileName.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileName.TabIndex = 19;
            this.klblFileName.Values.Text = "File name: {0}";
            // 
            // klblFileSize
            // 
            this.klblFileSize.Location = new System.Drawing.Point(393, 219);
            this.klblFileSize.Name = "klblFileSize";
            this.klblFileSize.Size = new System.Drawing.Size(123, 33);
            this.klblFileSize.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileSize.TabIndex = 20;
            this.klblFileSize.Values.Text = "File size: {0}";
            // 
            // klblFileReleaseDate
            // 
            this.klblFileReleaseDate.Location = new System.Drawing.Point(867, 219);
            this.klblFileReleaseDate.Name = "klblFileReleaseDate";
            this.klblFileReleaseDate.Size = new System.Drawing.Size(202, 33);
            this.klblFileReleaseDate.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileReleaseDate.TabIndex = 21;
            this.klblFileReleaseDate.Values.Text = "File release date: {0}";
            // 
            // klblUpdateType
            // 
            this.klblUpdateType.Location = new System.Drawing.Point(393, 274);
            this.klblUpdateType.Name = "klblUpdateType";
            this.klblUpdateType.Size = new System.Drawing.Size(167, 33);
            this.klblUpdateType.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblUpdateType.TabIndex = 22;
            this.klblUpdateType.Values.Text = "Update type: {0}";
            // 
            // klblImageType
            // 
            this.klblImageType.Location = new System.Drawing.Point(393, 384);
            this.klblImageType.Name = "klblImageType";
            this.klblImageType.Size = new System.Drawing.Size(160, 33);
            this.klblImageType.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblImageType.TabIndex = 24;
            this.klblImageType.Values.Text = "Image Type: {0}";
            // 
            // klblFileVersion
            // 
            this.klblFileVersion.Location = new System.Drawing.Point(393, 329);
            this.klblFileVersion.Name = "klblFileVersion";
            this.klblFileVersion.Size = new System.Drawing.Size(156, 33);
            this.klblFileVersion.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileVersion.TabIndex = 25;
            this.klblFileVersion.Values.Text = "File version: {0}";
            // 
            // klblSHA384CheckSum
            // 
            this.klblSHA384CheckSum.Location = new System.Drawing.Point(393, 329);
            this.klblSHA384CheckSum.Name = "klblSHA384CheckSum";
            this.klblSHA384CheckSum.Size = new System.Drawing.Size(129, 33);
            this.klblSHA384CheckSum.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSHA384CheckSum.TabIndex = 30;
            this.klblSHA384CheckSum.Values.Text = "SHA-384 {0}";
            // 
            // klblSHA512CheckSum
            // 
            this.klblSHA512CheckSum.Location = new System.Drawing.Point(393, 384);
            this.klblSHA512CheckSum.Name = "klblSHA512CheckSum";
            this.klblSHA512CheckSum.Size = new System.Drawing.Size(133, 33);
            this.klblSHA512CheckSum.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSHA512CheckSum.TabIndex = 29;
            this.klblSHA512CheckSum.Values.Text = "SHA-512: {0}";
            // 
            // klblSHA256CheckSum
            // 
            this.klblSHA256CheckSum.Location = new System.Drawing.Point(393, 274);
            this.klblSHA256CheckSum.Name = "klblSHA256CheckSum";
            this.klblSHA256CheckSum.Size = new System.Drawing.Size(133, 33);
            this.klblSHA256CheckSum.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSHA256CheckSum.TabIndex = 28;
            this.klblSHA256CheckSum.Values.Text = "SHA-256: {0}";
            // 
            // klblSHA1CheckSum
            // 
            this.klblSHA1CheckSum.Location = new System.Drawing.Point(393, 219);
            this.klblSHA1CheckSum.Name = "klblSHA1CheckSum";
            this.klblSHA1CheckSum.Size = new System.Drawing.Size(110, 33);
            this.klblSHA1CheckSum.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSHA1CheckSum.TabIndex = 27;
            this.klblSHA1CheckSum.Values.Text = "SHA-1: {0}";
            // 
            // klblMD5CheckSum
            // 
            this.klblMD5CheckSum.Location = new System.Drawing.Point(393, 170);
            this.klblMD5CheckSum.Name = "klblMD5CheckSum";
            this.klblMD5CheckSum.Size = new System.Drawing.Size(104, 33);
            this.klblMD5CheckSum.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMD5CheckSum.TabIndex = 26;
            this.klblMD5CheckSum.Values.Text = "MD-5: {0}";
            // 
            // klblRIPEMD160CheckSum
            // 
            this.klblRIPEMD160CheckSum.Location = new System.Drawing.Point(393, 434);
            this.klblRIPEMD160CheckSum.Name = "klblRIPEMD160CheckSum";
            this.klblRIPEMD160CheckSum.Size = new System.Drawing.Size(169, 33);
            this.klblRIPEMD160CheckSum.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRIPEMD160CheckSum.TabIndex = 31;
            this.klblRIPEMD160CheckSum.Values.Text = "RIPEMD-160: {0}";
            // 
            // UpdatePackageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 887);
            this.Controls.Add(this.kpnlBackdrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePackageDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Package Details";
            this.TextExtra = "(Beta)";
            this.Load += new System.EventHandler(this.UpdatePackageDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).EndInit();
            this.kpnlBackdrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.kryptonPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackdrop;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblFileVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblImageType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblUpdateType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblFileReleaseDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblFileSize;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblFileName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA384CheckSum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA512CheckSum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA256CheckSum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA1CheckSum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblMD5CheckSum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblRIPEMD160CheckSum;
    }
}