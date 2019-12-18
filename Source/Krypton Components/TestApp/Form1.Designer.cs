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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnInputBox = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTreeView1 = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.knumWindowRounding = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonMaskedTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.kryptonNumericUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kcbBracketType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dudThemes = new System.Windows.Forms.DomainUpDown();
            this.cmbThemes = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscThemes = new System.Windows.Forms.ToolStripComboBox();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnLoadTheme = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.kcbBracketType)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbThemeCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office365Blue;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.CustomisedKryptonPaletteFilePath = null;
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
            this.kryptonPanel2.Controls.Add(this.kbtnInputBox);
            this.kryptonPanel2.Controls.Add(this.kryptonTreeView1);
            this.kryptonPanel2.Controls.Add(this.knumWindowRounding);
            this.kryptonPanel2.Controls.Add(this.kryptonMaskedTextBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonNumericUpDown1);
            this.kryptonPanel2.Controls.Add(this.kcbBracketType);
            this.kryptonPanel2.Controls.Add(this.dudThemes);
            this.kryptonPanel2.Controls.Add(this.cmbThemes);
            this.kryptonPanel2.Controls.Add(this.toolStrip1);
            this.kryptonPanel2.Controls.Add(this.kryptonTextBox2);
            this.kryptonPanel2.Controls.Add(this.kryptonButton3);
            this.kryptonPanel2.Controls.Add(this.kbtnLoadTheme);
            this.kryptonPanel2.Controls.Add(this.kryptonNavigator1);
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
            // kbtnInputBox
            // 
            this.kbtnInputBox.Location = new System.Drawing.Point(365, 388);
            this.kbtnInputBox.Name = "kbtnInputBox";
            this.kbtnInputBox.Size = new System.Drawing.Size(90, 25);
            this.kbtnInputBox.TabIndex = 31;
            this.kbtnInputBox.Values.Text = "Input Box";
            this.kbtnInputBox.Click += new System.EventHandler(this.kbtnInputBox_Click);
            // 
            // kryptonTreeView1
            // 
            this.kryptonTreeView1.Location = new System.Drawing.Point(365, 253);
            this.kryptonTreeView1.Name = "kryptonTreeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Node1";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node6";
            treeNode10.Text = "Node6";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Node11";
            treeNode12.Name = "Node12";
            treeNode12.Text = "Node12";
            treeNode13.Name = "Node13";
            treeNode13.Text = "Node13";
            treeNode14.Name = "Node14";
            treeNode14.Text = "Node14";
            treeNode15.Name = "Node10";
            treeNode15.Text = "Node10";
            this.kryptonTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode10,
            treeNode15});
            this.kryptonTreeView1.Size = new System.Drawing.Size(120, 119);
            this.kryptonTreeView1.TabIndex = 29;
            // 
            // knumWindowRounding
            // 
            this.knumWindowRounding.Location = new System.Drawing.Point(580, 297);
            this.knumWindowRounding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.knumWindowRounding.Name = "knumWindowRounding";
            this.knumWindowRounding.Size = new System.Drawing.Size(120, 22);
            this.knumWindowRounding.TabIndex = 27;
            this.knumWindowRounding.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.knumWindowRounding.ValueChanged += new System.EventHandler(this.knumWindowRounding_ValueChanged);
            // 
            // kryptonMaskedTextBox1
            // 
            this.kryptonMaskedTextBox1.Hint = "Testing a masked textbox hint";
            this.kryptonMaskedTextBox1.Location = new System.Drawing.Point(222, 107);
            this.kryptonMaskedTextBox1.Name = "kryptonMaskedTextBox1";
            this.kryptonMaskedTextBox1.Size = new System.Drawing.Size(297, 23);
            this.kryptonMaskedTextBox1.TabIndex = 1;
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.AllowDecimals = true;
            this.kryptonNumericUpDown1.DecimalPlaces = 99;
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(365, 197);
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.kryptonNumericUpDown1.TabIndex = 1;
            // 
            // kcbBracketType
            // 
            this.kcbBracketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbBracketType.DropDownWidth = 121;
            this.kcbBracketType.IntegralHeight = false;
            this.kcbBracketType.Location = new System.Drawing.Point(526, 253);
            this.kcbBracketType.Name = "kcbBracketType";
            this.kcbBracketType.Size = new System.Drawing.Size(121, 21);
            this.kcbBracketType.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcbBracketType.TabIndex = 25;
            this.kcbBracketType.SelectedIndexChanged += new System.EventHandler(this.KcbBracketType_SelectedIndexChanged);
            // 
            // dudThemes
            // 
            this.dudThemes.Location = new System.Drawing.Point(302, 148);
            this.dudThemes.Name = "dudThemes";
            this.dudThemes.Size = new System.Drawing.Size(120, 20);
            this.dudThemes.TabIndex = 23;
            // 
            // cmbThemes
            // 
            this.cmbThemes.FormattingEnabled = true;
            this.cmbThemes.Location = new System.Drawing.Point(174, 148);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(121, 21);
            this.cmbThemes.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscThemes});
            this.toolStrip1.Location = new System.Drawing.Point(25, 148);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(135, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tscThemes
            // 
            this.tscThemes.Name = "tscThemes";
            this.tscThemes.Size = new System.Drawing.Size(121, 25);
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Hint = "watermark / cue / hint";
            this.kryptonTextBox2.Location = new System.Drawing.Point(25, 107);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(191, 23);
            this.kryptonTextBox2.TabIndex = 19;
            this.kryptonTextBox2.ToolTipValues.Description = "";
            this.kryptonTextBox2.ToolTipValues.EnableToolTips = true;
            this.kryptonTextBox2.ToolTipValues.Heading = "Water mark will dissapear once text is entered";
            this.kryptonTextBox2.ToolTipValues.Image = null;
            this.kryptonTextBox2.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(174, 338);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(143, 53);
            this.kryptonButton3.TabIndex = 17;
            this.kryptonButton3.ToolTipValues.Description = "Applies the user selected theme";
            this.kryptonButton3.ToolTipValues.EnableToolTips = true;
            this.kryptonButton3.ToolTipValues.Heading = "Apply Theme";
            this.kryptonButton3.ToolTipValues.Image = global::TestApp.Properties.Resources.Square_Design_32_x_32_New_Green;
            this.kryptonButton3.Values.Text = "Show Small \r\nTooltip Form";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kbtnLoadTheme
            // 
            this.kbtnLoadTheme.Location = new System.Drawing.Point(25, 338);
            this.kbtnLoadTheme.Name = "kbtnLoadTheme";
            this.kbtnLoadTheme.Size = new System.Drawing.Size(143, 53);
            this.kbtnLoadTheme.TabIndex = 15;
            this.kbtnLoadTheme.ToolTipValues.Description = "Applies the user selected theme";
            this.kbtnLoadTheme.ToolTipValues.EnableToolTips = true;
            this.kbtnLoadTheme.ToolTipValues.Heading = "Apply Theme";
            this.kbtnLoadTheme.ToolTipValues.Image = global::TestApp.Properties.Resources.Square_Design_32_x_32_New_Green;
            this.kbtnLoadTheme.Values.Text = "Load Theme";
            this.kbtnLoadTheme.Click += new System.EventHandler(this.kbtnLoadTheme_Click);
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Location = new System.Drawing.Point(580, 338);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(197, 78);
            this.kryptonNavigator1.TabIndex = 13;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(195, 51);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "93558f74a2b4488db9e44dc487858ad7";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "a0d8f6c733234569bbeca42d3d184119";
            // 
            // kbtnApplyTheme
            // 
            this.kbtnApplyTheme.Enabled = false;
            this.kbtnApplyTheme.Location = new System.Drawing.Point(214, 48);
            this.kbtnApplyTheme.Name = "kbtnApplyTheme";
            this.kbtnApplyTheme.Size = new System.Drawing.Size(227, 53);
            this.kbtnApplyTheme.TabIndex = 11;
            this.kbtnApplyTheme.ToolTipValues.Description = "Applies the user selected theme";
            this.kbtnApplyTheme.ToolTipValues.EnableToolTips = true;
            this.kbtnApplyTheme.ToolTipValues.Heading = "Apply Theme";
            this.kbtnApplyTheme.ToolTipValues.Image = global::TestApp.Properties.Resources.Square_Design_32_x_32_New_Green;
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
            this.klbThemes.SelectedIndexChanged += new System.EventHandler(this.klbThemes_SelectedIndexChanged);
            // 
            // kdbThemeCollection
            // 
            this.kdbThemeCollection.Location = new System.Drawing.Point(526, 22);
            this.kdbThemeCollection.Name = "kdbThemeCollection";
            this.kdbThemeCollection.Size = new System.Drawing.Size(227, 22);
            this.kdbThemeCollection.TabIndex = 8;
            this.kdbThemeCollection.ToolTipValues.EnableToolTips = true;
            this.kdbThemeCollection.SelectedItemChanged += new System.EventHandler(this.kdbThemeCollection_SelectedItemChanged);
            // 
            // kcmbThemeCollection
            // 
            this.kcmbThemeCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbThemeCollection.DropDownWidth = 305;
            this.kcmbThemeCollection.IntegralHeight = false;
            this.kcmbThemeCollection.Location = new System.Drawing.Point(214, 21);
            this.kcmbThemeCollection.Name = "kcmbThemeCollection";
            this.kcmbThemeCollection.Size = new System.Drawing.Size(305, 21);
            this.kcmbThemeCollection.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbThemeCollection.TabIndex = 6;
            this.kcmbThemeCollection.ToolTipValues.EnableToolTips = true;
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
            this.kryptonTextBox1.ToolTipValues.ToolTipPosition.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Right;
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
            this.kryptonCheckedListBox1.ToolTipValues.ToolTipPosition.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Center;
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
            this.kryptonButton2.ToolTipValues.ToolTipPosition.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Top;
            this.kryptonButton2.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.KeyTip;
            this.kryptonButton2.Values.Text = "Test Movement of\r\ntooltip to other \r\ncontrol";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(25, 241);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(143, 91);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.ToolTipValues.Description = "Description -> Left";
            this.kryptonButton1.ToolTipValues.EnableToolTips = true;
            this.kryptonButton1.ToolTipValues.ToolTipPosition.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Left;
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
            this.AdministratorText = "Test";
            this.AllowButtonSpecToolTips = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BlurValues.BlurWhenFocusLost = true;
            this.BlurValues.EnableBlur = true;
            this.BracketType = ComponentFactory.Krypton.Toolkit.BracketType.SQUAREBRACKET;
            this.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShadowValues.BlurDistance = 100D;
            this.ShadowValues.Colour = System.Drawing.Color.Maroon;
            this.ShadowValues.EnableShadows = true;
            this.ShadowValues.ExtraWidth = ((sbyte)(-2));
            this.ShadowValues.Opacity = 40D;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbBracketType)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
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
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnLoadTheme;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscThemes;
        private System.Windows.Forms.DomainUpDown dudThemes;
        private System.Windows.Forms.ComboBox cmbThemes;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcbBracketType;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumWindowRounding;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView kryptonTreeView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnInputBox;
    }
}

