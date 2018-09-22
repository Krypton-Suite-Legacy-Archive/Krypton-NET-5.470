namespace SystemThemedForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSpecAny1 = new  Krypton.Toolkit.ButtonSpecAny();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.ExtraText = "ExtraButton";
            this.buttonSpecAny1.Style =  Krypton.Toolkit.PaletteButtonStyle.Inherit;
            this.buttonSpecAny1.Text = "Button";
            this.buttonSpecAny1.ToolTipStyle =  Krypton.Toolkit.LabelStyle.ToolTip;
            this.buttonSpecAny1.Type =  Krypton.Toolkit.PaletteButtonSpecStyle.Next;
            this.buttonSpecAny1.UniqueName = "16A6E91058454CD77C97174C1594D930";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Switch to \"System- Professional\" Theme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Switch to \"Office 2007 - Silver\" Theme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Switch to \"Office2003- Professional\" Theme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(284, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "SystemColors.InactiveCaption";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(284, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "SystemColors.ActiveCaption";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(284, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "SystemColors.GradientActiveCaption";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(284, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "SystemColors.GradientInactiveCaption";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 191);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(284, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "SystemColors.WindowFrame";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonSpecs.AddRange(new  Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.ClientSize = new System.Drawing.Size(606, 260);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.PaletteMode =  Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.StateCommon.OverlayHeaders =  Krypton.Toolkit.InheritBool.True;
            this.Text = "Test \"SystemThemed\" TitleBar Extras ->";
            this.TextExtra = "ExtraText Here";
            this.ResumeLayout(false);

        }

        #endregion

        private  Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

