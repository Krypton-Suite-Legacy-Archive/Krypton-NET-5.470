namespace TestApp
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
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues5 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues7 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues8 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues9 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnApplyTheme = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klbThemes = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kdbThemeCollection = new ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown();
            this.kcmbThemeCollection = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonCheckedListBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbThemeCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 450);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnApplyTheme);
            this.kryptonPanel2.Controls.Add(this.klbThemes);
            this.kryptonPanel2.Controls.Add(this.kdbThemeCollection);
            this.kryptonPanel2.Controls.Add(this.kcmbThemeCollection);
            this.kryptonPanel2.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonCheckedListBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonBorderEdge1);
            this.kryptonPanel2.Controls.Add(this.kryptonButton2);
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(800, 450);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // kbtnApplyTheme
            // 
            this.kbtnApplyTheme.Enabled = false;
            this.kbtnApplyTheme.Location = new System.Drawing.Point(526, 241);
            this.kbtnApplyTheme.Name = "kbtnApplyTheme";
            this.kbtnApplyTheme.Size = new System.Drawing.Size(227, 91);
            this.kbtnApplyTheme.TabIndex = 11;
            this.kbtnApplyTheme.ToolTipValues.Description = "Applies the user selected theme";
            this.kbtnApplyTheme.ToolTipValues.EnableToolTips = true;
            this.kbtnApplyTheme.ToolTipValues.Heading = "Apply Theme";
            this.kbtnApplyTheme.ToolTipValues.Image = global::TestApp.Properties.Resources.Square_Design_32_x_32_New_Green;
            popupPositionValues1.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues1.PlacementTarget = null;
            this.kbtnApplyTheme.ToolTipValues.ToolTipPosition = popupPositionValues1;
            this.kbtnApplyTheme.Values.Text = "Apply Theme";
            this.kbtnApplyTheme.Click += new System.EventHandler(this.kbtnApplyTheme_Click);
            // 
            // klbThemes
            // 
            this.klbThemes.Location = new System.Drawing.Point(526, 51);
            this.klbThemes.Name = "klbThemes";
            this.klbThemes.Size = new System.Drawing.Size(227, 184);
            this.klbThemes.TabIndex = 9;
            this.klbThemes.ToolTipValues.EnableToolTips = true;
            popupPositionValues2.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues2.PlacementTarget = null;
            this.klbThemes.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.klbThemes.SelectedIndexChanged += new System.EventHandler(this.klbThemes_SelectedIndexChanged);
            // 
            // kdbThemeCollection
            // 
            this.kdbThemeCollection.Location = new System.Drawing.Point(526, 22);
            this.kdbThemeCollection.Name = "kdbThemeCollection";
            this.kdbThemeCollection.Size = new System.Drawing.Size(227, 22);
            this.kdbThemeCollection.TabIndex = 8;
            this.kdbThemeCollection.ToolTipValues.EnableToolTips = true;
            popupPositionValues3.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues3.PlacementTarget = null;
            this.kdbThemeCollection.ToolTipValues.ToolTipPosition = popupPositionValues3;
            this.kdbThemeCollection.SelectedItemChanged += new System.EventHandler(this.kdbThemeCollection_SelectedItemChanged);
            // 
            // kcmbThemeCollection
            // 
            this.kcmbThemeCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbThemeCollection.DropDownWidth = 305;
            this.kcmbThemeCollection.Location = new System.Drawing.Point(214, 21);
            this.kcmbThemeCollection.Name = "kcmbThemeCollection";
            this.kcmbThemeCollection.Size = new System.Drawing.Size(305, 21);
            this.kcmbThemeCollection.TabIndex = 6;
            this.kcmbThemeCollection.ToolTipValues.EnableToolTips = true;
            popupPositionValues4.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues4.PlacementTarget = null;
            this.kcmbThemeCollection.ToolTipValues.ToolTipPosition = popupPositionValues4;
            this.kcmbThemeCollection.SelectedIndexChanged += new System.EventHandler(this.kcmbThemeCollection_SelectedIndexChanged);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(25, 59);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox1.TabIndex = 4;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            this.kryptonTextBox1.ToolTipValues.Description = "Please type carefully -> Right";
            this.kryptonTextBox1.ToolTipValues.EnableToolTips = true;
            this.kryptonTextBox1.ToolTipValues.Heading = "This Text will explode";
            popupPositionValues5.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Right;
            popupPositionValues5.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues5.PlacementTarget = null;
            this.kryptonTextBox1.ToolTipValues.ToolTipPosition = popupPositionValues5;
            // 
            // kryptonCheckedListBox1
            // 
            this.kryptonCheckedListBox1.Location = new System.Drawing.Point(25, 21);
            this.kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            this.kryptonCheckedListBox1.Size = new System.Drawing.Size(120, 31);
            this.kryptonCheckedListBox1.TabIndex = 3;
            this.kryptonCheckedListBox1.ToolTipValues.Description = "Description\r\nof\r\nTool\r\ntip\r\nMadness";
            this.kryptonCheckedListBox1.ToolTipValues.EnableToolTips = true;
            this.kryptonCheckedListBox1.ToolTipValues.Heading = "Checked List Box";
            popupPositionValues6.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Center;
            popupPositionValues6.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues6.PlacementTarget = null;
            this.kryptonCheckedListBox1.ToolTipValues.ToolTipPosition = popupPositionValues6;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(25, 13);
            this.kryptonBorderEdge1.MinimumSize = new System.Drawing.Size(0, 3);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(50, 3);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.ToolTipValues.Description = "Because you can.. -> Bottom";
            this.kryptonBorderEdge1.ToolTipValues.EnableToolTips = true;
            this.kryptonBorderEdge1.ToolTipValues.Heading = "Why";
            popupPositionValues7.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues7.PlacementTarget = null;
            this.kryptonBorderEdge1.ToolTipValues.ToolTipPosition = popupPositionValues7;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(174, 241);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(143, 91);
            this.kryptonButton2.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonButton2.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonButton2.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.ToolTipValues.Description = "Description -> Top";
            this.kryptonButton2.ToolTipValues.EnableToolTips = true;
            popupPositionValues8.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Top;
            popupPositionValues8.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues8.PlacementTarget = null;
            this.kryptonButton2.ToolTipValues.ToolTipPosition = popupPositionValues8;
            this.kryptonButton2.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.KeyTip;
            this.kryptonButton2.Values.Text = "Test Movement of\r\ntooltip to other \r\ncontrol";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(25, 241);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(143, 91);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.ToolTipValues.Description = "Description -> Left";
            this.kryptonButton1.ToolTipValues.EnableToolTips = true;
            popupPositionValues9.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Left;
            popupPositionValues9.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues9.PlacementTarget = null;
            this.kryptonButton1.ToolTipValues.ToolTipPosition = popupPositionValues9;
            this.kryptonButton1.Values.Text = "Ribbon Test";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
            this.buttonSpecAny1.Text = "Test Tooltip";
            this.buttonSpecAny1.ToolTipBody = "Tool Tip Body Description";
            this.buttonSpecAny1.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.buttonSpecAny1.ToolTipTitle = "Title";
            this.buttonSpecAny1.UniqueName = "8D0C7B51F6A946484D932C2A06451172";
            // 
            // Form1
            // 
            this.AllowButtonSpecToolTips = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbThemeCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbThemeCollection;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox klbThemes;
        private ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown kdbThemeCollection;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnApplyTheme;
    }
}

