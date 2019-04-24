namespace TestApp
{
    partial class SmallForm
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
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonNumericUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(172, 45);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(80, 66);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.ToolTipValues.EnableToolTips = true;
            this.kryptonButton2.ToolTipValues.Image = null;
            this.kryptonButton2.ToolTipValues.ToolTipPosition.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.MousePoint;
            this.kryptonButton2.Values.Text = "ToolTip Me";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(32, 45);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(80, 66);
            this.kryptonButton3.TabIndex = 2;
            this.kryptonButton3.ToolTipValues.EnableToolTips = true;
            this.kryptonButton3.ToolTipValues.Image = null;
            this.kryptonButton3.Values.Text = "ToolTip Me";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(32, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.ToolTipValues.EnableToolTips = true;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.DecimalPlaces = 99;
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(136, 9);
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.kryptonNumericUpDown1.TabIndex = 4;
            this.kryptonNumericUpDown1.ToolTipValues.EnableToolTips = true;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonButton3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(264, 133);
            this.kryptonPanel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SmallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 133);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "SmallForm";
            this.ShadowValues.BlurDistance = 0D;
            this.ShadowValues.Colour = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShadowValues.EnableShadows = true;
            this.ShadowValues.Opacity = 40D;
            this.Text = "SmallForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}