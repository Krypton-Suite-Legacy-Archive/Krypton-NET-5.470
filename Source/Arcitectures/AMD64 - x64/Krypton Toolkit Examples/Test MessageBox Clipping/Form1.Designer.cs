namespace Test_MessageBox_Clipping
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnLongTitleNoOwner = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLongContents = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLongTitle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnStackTrace = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCarriageReturns = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSingleLines = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonOffice2010Black = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonSparkleOrange = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonOffice2010Blue = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonOffice2010Silver = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonOffice2013 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonOffice2013White = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonSparklePurple = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonSparkleBlue = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonCustom = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonSystem = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonOffice2003 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonOffice2007Black = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonOffice2007Silver = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonOffice2007Blue = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPaletteCustom = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnLongContentsNoOwner = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnLongContentsNoOwner);
            this.kryptonPanel1.Controls.Add(this.btnLongTitleNoOwner);
            this.kryptonPanel1.Controls.Add(this.btnLongContents);
            this.kryptonPanel1.Controls.Add(this.btnLongTitle);
            this.kryptonPanel1.Controls.Add(this.btnStackTrace);
            this.kryptonPanel1.Controls.Add(this.btnCarriageReturns);
            this.kryptonPanel1.Controls.Add(this.btnSingleLines);
            this.kryptonPanel1.Controls.Add(this.kryptonGroup1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(711, 471);
            this.kryptonPanel1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.kryptonPanel1, "sadsdafdffg");
            // 
            // btnLongTitleNoOwner
            // 
            this.btnLongTitleNoOwner.Location = new System.Drawing.Point(147, 58);
            this.btnLongTitleNoOwner.Name = "btnLongTitleNoOwner";
            this.btnLongTitleNoOwner.Size = new System.Drawing.Size(190, 25);
            this.btnLongTitleNoOwner.TabIndex = 7;
            this.btnLongTitleNoOwner.Values.Text = "Long Title - No Owner";
            this.btnLongTitleNoOwner.Click += new System.EventHandler(this.btnLongTitleNoOwner_Click);
            // 
            // btnLongContents
            // 
            this.btnLongContents.Location = new System.Drawing.Point(13, 103);
            this.btnLongContents.Name = "btnLongContents";
            this.btnLongContents.Size = new System.Drawing.Size(121, 25);
            this.btnLongContents.TabIndex = 6;
            this.btnLongContents.Values.Text = "Long Contents";
            this.btnLongContents.Click += new System.EventHandler(this.btnLongContents_Click);
            // 
            // btnLongTitle
            // 
            this.btnLongTitle.Location = new System.Drawing.Point(13, 58);
            this.btnLongTitle.Name = "btnLongTitle";
            this.btnLongTitle.Size = new System.Drawing.Size(121, 25);
            this.btnLongTitle.TabIndex = 5;
            this.btnLongTitle.Values.Text = "Long Title";
            this.btnLongTitle.Click += new System.EventHandler(this.btnLongTitle_Click);
            // 
            // btnStackTrace
            // 
            this.btnStackTrace.Location = new System.Drawing.Point(295, 12);
            this.btnStackTrace.Name = "btnStackTrace";
            this.btnStackTrace.Size = new System.Drawing.Size(219, 25);
            this.btnStackTrace.TabIndex = 4;
            this.btnStackTrace.Values.Text = "Exception Stack Trace";
            this.btnStackTrace.Click += new System.EventHandler(this.btnStackTrace_Click);
            // 
            // btnCarriageReturns
            // 
            this.btnCarriageReturns.Location = new System.Drawing.Point(142, 13);
            this.btnCarriageReturns.Name = "btnCarriageReturns";
            this.btnCarriageReturns.Size = new System.Drawing.Size(133, 25);
            this.btnCarriageReturns.TabIndex = 3;
            this.btnCarriageReturns.Values.Text = "Carriage Returns";
            this.btnCarriageReturns.Click += new System.EventHandler(this.btnCarriageReturns_Click);
            // 
            // btnSingleLines
            // 
            this.btnSingleLines.Location = new System.Drawing.Point(13, 13);
            this.btnSingleLines.Name = "btnSingleLines";
            this.btnSingleLines.Size = new System.Drawing.Size(121, 25);
            this.btnSingleLines.TabIndex = 2;
            this.btnSingleLines.Values.Text = "Single Lines";
            this.btnSingleLines.Click += new System.EventHandler(this.btnSingleLines_Click);
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonGroup1.Location = new System.Drawing.Point(0, 384);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2010Black);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonSparkleOrange);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2010Blue);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2010Silver);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2013);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2013White);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonSparklePurple);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonSparkleBlue);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonCustom);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonSystem);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2003);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2007Black);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2007Silver);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonOffice2007Blue);
            this.kryptonGroup1.Size = new System.Drawing.Size(711, 87);
            this.kryptonGroup1.TabIndex = 1;
            // 
            // kryptonOffice2010Black
            // 
            this.kryptonOffice2010Black.Location = new System.Drawing.Point(7, 60);
            this.kryptonOffice2010Black.Name = "kryptonOffice2010Black";
            this.kryptonOffice2010Black.Size = new System.Drawing.Size(125, 20);
            this.kryptonOffice2010Black.TabIndex = 2;
            this.kryptonOffice2010Black.Values.Text = "Office 2010 - Black";
            this.kryptonOffice2010Black.CheckedChanged += new System.EventHandler(this.kryptonOffice2010Black_CheckedChanged);
            // 
            // kryptonSparkleOrange
            // 
            this.kryptonSparkleOrange.Location = new System.Drawing.Point(294, 35);
            this.kryptonSparkleOrange.Name = "kryptonSparkleOrange";
            this.kryptonSparkleOrange.Size = new System.Drawing.Size(115, 20);
            this.kryptonSparkleOrange.TabIndex = 7;
            this.kryptonSparkleOrange.Values.Text = "Sparkle - Orange";
            this.kryptonSparkleOrange.CheckedChanged += new System.EventHandler(this.kryptonSparkleOrange_CheckedChanged);
            // 
            // kryptonOffice2010Blue
            // 
            this.kryptonOffice2010Blue.Checked = true;
            this.kryptonOffice2010Blue.Location = new System.Drawing.Point(7, 10);
            this.kryptonOffice2010Blue.Name = "kryptonOffice2010Blue";
            this.kryptonOffice2010Blue.Size = new System.Drawing.Size(120, 20);
            this.kryptonOffice2010Blue.TabIndex = 0;
            this.kryptonOffice2010Blue.Values.Text = "Office 2010 - Blue";
            // 
            // kryptonOffice2010Silver
            // 
            this.kryptonOffice2010Silver.Location = new System.Drawing.Point(7, 35);
            this.kryptonOffice2010Silver.Name = "kryptonOffice2010Silver";
            this.kryptonOffice2010Silver.Size = new System.Drawing.Size(126, 20);
            this.kryptonOffice2010Silver.TabIndex = 1;
            this.kryptonOffice2010Silver.Values.Text = "Office 2010 - Silver";
            this.kryptonOffice2010Silver.CheckedChanged += new System.EventHandler(this.kryptonOffice2010Silver_CheckedChanged);
            // 
            // kryptonOffice2013
            // 
            this.kryptonOffice2013.Location = new System.Drawing.Point(531, 10);
            this.kryptonOffice2013.Name = "kryptonOffice2013";
            this.kryptonOffice2013.Size = new System.Drawing.Size(85, 20);
            this.kryptonOffice2013.TabIndex = 21;
            this.kryptonOffice2013.Values.Text = "Office 2013";
            this.kryptonOffice2013.CheckedChanged += new System.EventHandler(this.kryptonOffice2013_CheckedChanged);
            // 
            // kryptonOffice2013White
            // 
            this.kryptonOffice2013White.Location = new System.Drawing.Point(531, 35);
            this.kryptonOffice2013White.Name = "kryptonOffice2013White";
            this.kryptonOffice2013White.Size = new System.Drawing.Size(129, 20);
            this.kryptonOffice2013White.TabIndex = 22;
            this.kryptonOffice2013White.Values.Text = "Office 2013 - White";
            this.kryptonOffice2013White.CheckedChanged += new System.EventHandler(this.kryptonOffice2013White_CheckedChanged);
            // 
            // kryptonSparklePurple
            // 
            this.kryptonSparklePurple.Location = new System.Drawing.Point(294, 60);
            this.kryptonSparklePurple.Name = "kryptonSparklePurple";
            this.kryptonSparklePurple.Size = new System.Drawing.Size(109, 20);
            this.kryptonSparklePurple.TabIndex = 8;
            this.kryptonSparklePurple.Values.Text = "Sparkle - Purple";
            this.kryptonSparklePurple.CheckedChanged += new System.EventHandler(this.kryptonSparklePurple_CheckedChanged);
            // 
            // kryptonSparkleBlue
            // 
            this.kryptonSparkleBlue.Location = new System.Drawing.Point(294, 10);
            this.kryptonSparkleBlue.Name = "kryptonSparkleBlue";
            this.kryptonSparkleBlue.Size = new System.Drawing.Size(98, 20);
            this.kryptonSparkleBlue.TabIndex = 6;
            this.kryptonSparkleBlue.Values.Text = "Sparkle - Blue";
            this.kryptonSparkleBlue.CheckedChanged += new System.EventHandler(this.kryptonSparkleBlue_CheckedChanged);
            // 
            // kryptonCustom
            // 
            this.kryptonCustom.Location = new System.Drawing.Point(428, 60);
            this.kryptonCustom.Name = "kryptonCustom";
            this.kryptonCustom.Size = new System.Drawing.Size(64, 20);
            this.kryptonCustom.TabIndex = 11;
            this.kryptonCustom.Values.Text = "Custom";
            this.kryptonCustom.CheckedChanged += new System.EventHandler(this.kryptonCustom_CheckedChanged);
            // 
            // kryptonSystem
            // 
            this.kryptonSystem.Location = new System.Drawing.Point(428, 35);
            this.kryptonSystem.Name = "kryptonSystem";
            this.kryptonSystem.Size = new System.Drawing.Size(62, 20);
            this.kryptonSystem.TabIndex = 10;
            this.kryptonSystem.Values.Text = "System";
            this.kryptonSystem.CheckedChanged += new System.EventHandler(this.kryptonSystem_CheckedChanged);
            // 
            // kryptonOffice2003
            // 
            this.kryptonOffice2003.Location = new System.Drawing.Point(428, 10);
            this.kryptonOffice2003.Name = "kryptonOffice2003";
            this.kryptonOffice2003.Size = new System.Drawing.Size(85, 20);
            this.kryptonOffice2003.TabIndex = 9;
            this.kryptonOffice2003.Values.Text = "Office 2003";
            this.kryptonOffice2003.CheckedChanged += new System.EventHandler(this.kryptonOffice2003_CheckedChanged);
            // 
            // kryptonOffice2007Black
            // 
            this.kryptonOffice2007Black.Location = new System.Drawing.Point(141, 60);
            this.kryptonOffice2007Black.Name = "kryptonOffice2007Black";
            this.kryptonOffice2007Black.Size = new System.Drawing.Size(125, 20);
            this.kryptonOffice2007Black.TabIndex = 5;
            this.kryptonOffice2007Black.Values.Text = "Office 2007 - Black";
            this.kryptonOffice2007Black.CheckedChanged += new System.EventHandler(this.kryptonOffice2007Black_CheckedChanged);
            // 
            // kryptonOffice2007Silver
            // 
            this.kryptonOffice2007Silver.Location = new System.Drawing.Point(141, 35);
            this.kryptonOffice2007Silver.Name = "kryptonOffice2007Silver";
            this.kryptonOffice2007Silver.Size = new System.Drawing.Size(126, 20);
            this.kryptonOffice2007Silver.TabIndex = 4;
            this.kryptonOffice2007Silver.Values.Text = "Office 2007 - Silver";
            this.kryptonOffice2007Silver.CheckedChanged += new System.EventHandler(this.kryptonOffice2007Silver_CheckedChanged);
            // 
            // kryptonOffice2007Blue
            // 
            this.kryptonOffice2007Blue.Location = new System.Drawing.Point(141, 10);
            this.kryptonOffice2007Blue.Name = "kryptonOffice2007Blue";
            this.kryptonOffice2007Blue.Size = new System.Drawing.Size(120, 20);
            this.kryptonOffice2007Blue.TabIndex = 3;
            this.kryptonOffice2007Blue.Values.Text = "Office 2007 - Blue";
            this.kryptonOffice2007Blue.CheckedChanged += new System.EventHandler(this.kryptonOffice2007Blue_CheckedChanged);
            // 
            // kryptonPaletteCustom
            // 
            this.kryptonPaletteCustom.AllowFormChrome = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Padding = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 3;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 2;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = new System.Windows.Forms.Padding(5, 5, 1, 1);
            this.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 9;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Width = 3;
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.HeaderGroup.StateCommon.OverlayHeaders = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.HeaderGroup.StateCommon.PrimaryHeaderPadding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.HeaderGroup.StateCommon.SecondaryHeaderPadding = new System.Windows.Forms.Padding(3);
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 7;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.AdjacentGap = 2;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(213)))), ((int)(((byte)(194)))));
            this.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.CheckBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.CheckPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.CheckSelectedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Grip.GripDark = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(133)))), ((int)(((byte)(215)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Grip.GripLight = System.Drawing.Color.Transparent;
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemText = System.Drawing.Color.White;
            this.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Separator.SeparatorDark = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.Separator.SeparatorLight = System.Drawing.Color.Transparent;
            this.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripBorder = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(144)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripText = System.Drawing.Color.WhiteSmoke;
            this.kryptonPaletteCustom.ToolMenuStatus.UseRoundedEdges = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            // 
            // btnLongContentsNoOwner
            // 
            this.btnLongContentsNoOwner.Location = new System.Drawing.Point(147, 103);
            this.btnLongContentsNoOwner.Name = "btnLongContentsNoOwner";
            this.btnLongContentsNoOwner.Size = new System.Drawing.Size(190, 25);
            this.btnLongContentsNoOwner.TabIndex = 8;
            this.btnLongContentsNoOwner.Values.Text = "Long Contents - No Owner";
            this.btnLongContentsNoOwner.Click += new System.EventHandler(this.btnLongContentsNoOwner_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "sadsf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 471);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Test MessageBox Clipping - Normal Followed by Krypton";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2010Black;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonSparkleOrange;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2010Blue;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2010Silver;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2013;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2013White;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonSparklePurple;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonSparkleBlue;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonCustom;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonSystem;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2003;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2007Black;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2007Silver;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonOffice2007Blue;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteCustom;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSingleLines;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCarriageReturns;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStackTrace;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLongContents;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLongTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLongTitleNoOwner;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLongContentsNoOwner;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

