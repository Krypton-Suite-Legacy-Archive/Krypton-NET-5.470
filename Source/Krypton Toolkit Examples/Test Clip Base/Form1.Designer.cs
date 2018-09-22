namespace Test_Clip_Base
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
            this.kryptonLabel2 = new  Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new  Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new  Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.LabelStyle =  Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(62, 122);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(129, 14);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Text (¯²·»¿_)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Krypton clipped label follows below this..";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle =  Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(39, 29);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(204, 29);
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Auto Size Text (¯²·»¿_)";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.LabelStyle =  Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(81, 157);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(81, 34);
            this.kryptonLabel3.StateCommon.ShortText.ImageStyle =  Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel3.StateCommon.ShortText.TextH =  Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.ShortText.TextV =  Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.ShortText.Trim =  Krypton.Toolkit.PaletteTextTrim.Character;
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "Text (¯²·»¿_)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private  Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.Label label1;
        private  Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private  Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}

