namespace StandardDocking
{
    partial class ContentDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentDocument));
            this.richTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(5, 5);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(142, 101);
            this.richTextBox.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.richTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | Krypton.Toolkit.PaletteDrawBorders.Left)
                        | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = resources.GetString("richTextBox.Text");
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.richTextBox);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonPanel.Size = new System.Drawing.Size(152, 111);
            this.kryptonPanel.TabIndex = 1;
            // 
            // ContentDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel);
            this.Name = "ContentDocument";
            this.Size = new System.Drawing.Size(152, 111);
            this.Load += new System.EventHandler(this.ContentDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonRichTextBox richTextBox;
        private Krypton.Toolkit.KryptonPanel kryptonPanel;
    }
}
