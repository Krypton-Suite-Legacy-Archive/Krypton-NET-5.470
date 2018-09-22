namespace KryptonToolkitUpdater.UI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    partial class RemindMeLaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemindMeLaterForm));
            this.kpnlBackdrop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbRemindMeLaterTimeSpan = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnRemindMeLater = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).BeginInit();
            this.kpnlBackdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbRemindMeLaterTimeSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackdrop
            // 
            this.kpnlBackdrop.Controls.Add(this.kryptonLabel2);
            this.kpnlBackdrop.Controls.Add(this.kcmbRemindMeLaterTimeSpan);
            this.kpnlBackdrop.Controls.Add(this.kryptonLabel1);
            this.kpnlBackdrop.Controls.Add(this.kbtnRemindMeLater);
            this.kpnlBackdrop.Controls.Add(this.kbtnCancel);
            this.kpnlBackdrop.Controls.Add(this.pictureBox1);
            this.kpnlBackdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackdrop.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackdrop.Name = "kpnlBackdrop";
            this.kpnlBackdrop.Size = new System.Drawing.Size(800, 450);
            this.kpnlBackdrop.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(275, 241);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(192, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 18;
            this.kryptonLabel2.Values.Text = "Remind me to update in:";
            // 
            // kcmbRemindMeLaterTimeSpan
            // 
            this.kcmbRemindMeLaterTimeSpan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbRemindMeLaterTimeSpan.DropDownWidth = 315;
            this.kcmbRemindMeLaterTimeSpan.Items.AddRange(new object[] {
            "1 Day",
            "1 Week",
            "30 Days"});
            this.kcmbRemindMeLaterTimeSpan.Location = new System.Drawing.Point(473, 241);
            this.kcmbRemindMeLaterTimeSpan.Name = "kcmbRemindMeLaterTimeSpan";
            this.kcmbRemindMeLaterTimeSpan.Size = new System.Drawing.Size(315, 27);
            this.kcmbRemindMeLaterTimeSpan.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbRemindMeLaterTimeSpan.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbRemindMeLaterTimeSpan.TabIndex = 17;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(275, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(124, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // kbtnRemindMeLater
            // 
            this.kbtnRemindMeLater.Location = new System.Drawing.Point(548, 413);
            this.kbtnRemindMeLater.Name = "kbtnRemindMeLater";
            this.kbtnRemindMeLater.Size = new System.Drawing.Size(144, 25);
            this.kbtnRemindMeLater.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemindMeLater.TabIndex = 15;
            this.kbtnRemindMeLater.Values.Text = "&Remind Me Later";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(698, 413);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 14;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KryptonToolkitUpdater.Properties.Resources.clock1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RemindMeLaterForm
            // 
            this.AcceptButton = this.kbtnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kpnlBackdrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemindMeLaterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remind Me Later";
            this.TextExtra = "(Beta)";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).EndInit();
            this.kpnlBackdrop.ResumeLayout(false);
            this.kpnlBackdrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbRemindMeLaterTimeSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackdrop;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnRemindMeLater;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbRemindMeLaterTimeSpan;
    }
}