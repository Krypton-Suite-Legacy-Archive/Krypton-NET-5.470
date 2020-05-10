namespace ButtonSpecPlayground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxExample = new System.Windows.Forms.GroupBox();
            this.groupBoxButtonSpecs = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.groupBoxPrimary = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxSecondary = new System.Windows.Forms.GroupBox();
            this.checkOffice2007Black = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkOffice365White = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkOffice2010White = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkOffice2010Black = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkOffice365Black = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkSystem = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkSparkle = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.check2010Blue = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonButtonBottomS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonTopS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonRightS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonLeftS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonBottomP = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonTopP = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonRightP = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonLeftP = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonCheckSet1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.btnInvert = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.groupBoxProperties.SuspendLayout();
            this.groupBoxExample.SuspendLayout();
            this.groupBoxButtonSpecs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPrimary.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSecondary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.propertyGrid);
            this.groupBoxProperties.Location = new System.Drawing.Point(285, 12);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(294, 436);
            this.groupBoxProperties.TabIndex = 2;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties for Selected ButtonSpec";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 19);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(282, 411);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(504, 483);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxExample
            // 
            this.groupBoxExample.Controls.Add(this.kryptonHeaderGroup1);
            this.groupBoxExample.Location = new System.Drawing.Point(12, 12);
            this.groupBoxExample.Name = "groupBoxExample";
            this.groupBoxExample.Size = new System.Drawing.Size(267, 198);
            this.groupBoxExample.TabIndex = 0;
            this.groupBoxExample.TabStop = false;
            this.groupBoxExample.Text = "Example HeaderGroup";
            // 
            // groupBoxButtonSpecs
            // 
            this.groupBoxButtonSpecs.Controls.Add(this.kryptonButtonAdd);
            this.groupBoxButtonSpecs.Controls.Add(this.kryptonButtonClear);
            this.groupBoxButtonSpecs.Controls.Add(this.kryptonButtonRemove);
            this.groupBoxButtonSpecs.Location = new System.Drawing.Point(12, 216);
            this.groupBoxButtonSpecs.Name = "groupBoxButtonSpecs";
            this.groupBoxButtonSpecs.Size = new System.Drawing.Size(85, 154);
            this.groupBoxButtonSpecs.TabIndex = 1;
            this.groupBoxButtonSpecs.TabStop = false;
            this.groupBoxButtonSpecs.Text = "ButtonSpec";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelInstructions);
            this.groupBox1.Location = new System.Drawing.Point(11, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Location = new System.Drawing.Point(8, 20);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(250, 50);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Use the Add/Remove buttons to create/delete ButtonSpec instances.  Click the butt" +
    "on in order to display its properties in the property window.";
            // 
            // groupBoxPrimary
            // 
            this.groupBoxPrimary.Controls.Add(this.kryptonButtonBottomP);
            this.groupBoxPrimary.Controls.Add(this.groupBox2);
            this.groupBoxPrimary.Controls.Add(this.kryptonButtonTopP);
            this.groupBoxPrimary.Controls.Add(this.kryptonButtonRightP);
            this.groupBoxPrimary.Controls.Add(this.kryptonButtonLeftP);
            this.groupBoxPrimary.Location = new System.Drawing.Point(103, 216);
            this.groupBoxPrimary.Name = "groupBoxPrimary";
            this.groupBoxPrimary.Size = new System.Drawing.Size(85, 154);
            this.groupBoxPrimary.TabIndex = 3;
            this.groupBoxPrimary.TabStop = false;
            this.groupBoxPrimary.Text = "Primary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonButton1);
            this.groupBox2.Controls.Add(this.kryptonButton2);
            this.groupBox2.Controls.Add(this.kryptonButton3);
            this.groupBox2.Location = new System.Drawing.Point(96, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primary";
            // 
            // groupBoxSecondary
            // 
            this.groupBoxSecondary.Controls.Add(this.kryptonButtonBottomS);
            this.groupBoxSecondary.Controls.Add(this.kryptonButtonTopS);
            this.groupBoxSecondary.Controls.Add(this.kryptonButtonRightS);
            this.groupBoxSecondary.Controls.Add(this.kryptonButtonLeftS);
            this.groupBoxSecondary.Location = new System.Drawing.Point(194, 216);
            this.groupBoxSecondary.Name = "groupBoxSecondary";
            this.groupBoxSecondary.Size = new System.Drawing.Size(85, 154);
            this.groupBoxSecondary.TabIndex = 5;
            this.groupBoxSecondary.TabStop = false;
            this.groupBoxSecondary.Text = "Secondary";
            // 
            // checkOffice2007Black
            // 
            this.checkOffice2007Black.AutoSize = true;
            this.checkOffice2007Black.Location = new System.Drawing.Point(369, 483);
            this.checkOffice2007Black.Name = "checkOffice2007Black";
            this.checkOffice2007Black.Size = new System.Drawing.Size(113, 25);
            this.checkOffice2007Black.TabIndex = 13;
            this.checkOffice2007Black.Values.Text = "Office 2007 - Black";
            // 
            // checkOffice365White
            // 
            this.checkOffice365White.AutoSize = true;
            this.checkOffice365White.Location = new System.Drawing.Point(250, 483);
            this.checkOffice365White.Name = "checkOffice365White";
            this.checkOffice365White.Size = new System.Drawing.Size(113, 25);
            this.checkOffice365White.TabIndex = 12;
            this.checkOffice365White.Values.Text = "Office 365 - White";
            // 
            // checkOffice2010White
            // 
            this.checkOffice2010White.AutoSize = true;
            this.checkOffice2010White.Location = new System.Drawing.Point(131, 483);
            this.checkOffice2010White.Name = "checkOffice2010White";
            this.checkOffice2010White.Size = new System.Drawing.Size(117, 25);
            this.checkOffice2010White.TabIndex = 11;
            this.checkOffice2010White.Values.Text = "Office 2010 - White";
            // 
            // checkOffice2010Black
            // 
            this.checkOffice2010Black.AutoSize = true;
            this.checkOffice2010Black.Location = new System.Drawing.Point(12, 483);
            this.checkOffice2010Black.Name = "checkOffice2010Black";
            this.checkOffice2010Black.Size = new System.Drawing.Size(113, 25);
            this.checkOffice2010Black.TabIndex = 10;
            this.checkOffice2010Black.Values.Text = "Office 2010 - Black";
            // 
            // checkOffice365Black
            // 
            this.checkOffice365Black.AutoSize = true;
            this.checkOffice365Black.Location = new System.Drawing.Point(369, 452);
            this.checkOffice365Black.Name = "checkOffice365Black";
            this.checkOffice365Black.Size = new System.Drawing.Size(113, 25);
            this.checkOffice365Black.TabIndex = 9;
            this.checkOffice365Black.Values.Text = "Office 365 - Black";
            // 
            // checkSystem
            // 
            this.checkSystem.AutoSize = true;
            this.checkSystem.Checked = true;
            this.checkSystem.Location = new System.Drawing.Point(250, 452);
            this.checkSystem.Name = "checkSystem";
            this.checkSystem.Size = new System.Drawing.Size(113, 25);
            this.checkSystem.TabIndex = 8;
            this.checkSystem.Values.Text = "System";
            // 
            // checkSparkle
            // 
            this.checkSparkle.AutoSize = true;
            this.checkSparkle.Location = new System.Drawing.Point(131, 452);
            this.checkSparkle.Name = "checkSparkle";
            this.checkSparkle.Size = new System.Drawing.Size(113, 25);
            this.checkSparkle.TabIndex = 7;
            this.checkSparkle.Values.Text = "Sparkle - Orange";
            // 
            // check2010Blue
            // 
            this.check2010Blue.AutoSize = true;
            this.check2010Blue.Location = new System.Drawing.Point(12, 452);
            this.check2010Blue.Name = "check2010Blue";
            this.check2010Blue.Size = new System.Drawing.Size(113, 25);
            this.check2010Blue.TabIndex = 6;
            this.check2010Blue.Values.Text = "Office 2010 - Blue";
            // 
            // kryptonButtonBottomS
            // 
            this.kryptonButtonBottomS.AutoSize = true;
            this.kryptonButtonBottomS.Location = new System.Drawing.Point(11, 118);
            this.kryptonButtonBottomS.Name = "kryptonButtonBottomS";
            this.kryptonButtonBottomS.Size = new System.Drawing.Size(64, 27);
            this.kryptonButtonBottomS.TabIndex = 6;
            this.kryptonButtonBottomS.Values.Text = "Bottom";
            this.kryptonButtonBottomS.Click += new System.EventHandler(this.kryptonButtonBottomS_Click);
            // 
            // kryptonButtonTopS
            // 
            this.kryptonButtonTopS.AutoSize = true;
            this.kryptonButtonTopS.Location = new System.Drawing.Point(10, 25);
            this.kryptonButtonTopS.Name = "kryptonButtonTopS";
            this.kryptonButtonTopS.Size = new System.Drawing.Size(65, 27);
            this.kryptonButtonTopS.TabIndex = 0;
            this.kryptonButtonTopS.Values.Text = "Top";
            this.kryptonButtonTopS.Click += new System.EventHandler(this.kryptonButtonTopS_Click);
            // 
            // kryptonButtonRightS
            // 
            this.kryptonButtonRightS.AutoSize = true;
            this.kryptonButtonRightS.Location = new System.Drawing.Point(11, 87);
            this.kryptonButtonRightS.Name = "kryptonButtonRightS";
            this.kryptonButtonRightS.Size = new System.Drawing.Size(64, 27);
            this.kryptonButtonRightS.TabIndex = 2;
            this.kryptonButtonRightS.Values.Text = "Right";
            this.kryptonButtonRightS.Click += new System.EventHandler(this.kryptonButtonRightS_Click);
            // 
            // kryptonButtonLeftS
            // 
            this.kryptonButtonLeftS.AutoSize = true;
            this.kryptonButtonLeftS.Location = new System.Drawing.Point(11, 56);
            this.kryptonButtonLeftS.Name = "kryptonButtonLeftS";
            this.kryptonButtonLeftS.Size = new System.Drawing.Size(64, 27);
            this.kryptonButtonLeftS.TabIndex = 1;
            this.kryptonButtonLeftS.Values.Text = "Left";
            this.kryptonButtonLeftS.Click += new System.EventHandler(this.kryptonButtonLeftS_Click);
            // 
            // kryptonButtonBottomP
            // 
            this.kryptonButtonBottomP.AutoSize = true;
            this.kryptonButtonBottomP.Location = new System.Drawing.Point(11, 118);
            this.kryptonButtonBottomP.Name = "kryptonButtonBottomP";
            this.kryptonButtonBottomP.Size = new System.Drawing.Size(64, 27);
            this.kryptonButtonBottomP.TabIndex = 5;
            this.kryptonButtonBottomP.Values.Text = "Bottom";
            this.kryptonButtonBottomP.Click += new System.EventHandler(this.kryptonButtonBottomP_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AutoSize = true;
            this.kryptonButton1.Location = new System.Drawing.Point(10, 28);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(65, 27);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Top";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.AutoSize = true;
            this.kryptonButton2.Enabled = false;
            this.kryptonButton2.Location = new System.Drawing.Point(11, 90);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(64, 27);
            this.kryptonButton2.TabIndex = 2;
            this.kryptonButton2.Values.Text = "Right";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.AutoSize = true;
            this.kryptonButton3.Enabled = false;
            this.kryptonButton3.Location = new System.Drawing.Point(11, 59);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(64, 27);
            this.kryptonButton3.TabIndex = 1;
            this.kryptonButton3.Values.Text = "Left";
            // 
            // kryptonButtonTopP
            // 
            this.kryptonButtonTopP.AutoSize = true;
            this.kryptonButtonTopP.Location = new System.Drawing.Point(10, 25);
            this.kryptonButtonTopP.Name = "kryptonButtonTopP";
            this.kryptonButtonTopP.Size = new System.Drawing.Size(65, 27);
            this.kryptonButtonTopP.TabIndex = 0;
            this.kryptonButtonTopP.Values.Text = "Top";
            this.kryptonButtonTopP.Click += new System.EventHandler(this.kryptonButtonTopP_Click);
            // 
            // kryptonButtonRightP
            // 
            this.kryptonButtonRightP.AutoSize = true;
            this.kryptonButtonRightP.Location = new System.Drawing.Point(11, 87);
            this.kryptonButtonRightP.Name = "kryptonButtonRightP";
            this.kryptonButtonRightP.Size = new System.Drawing.Size(64, 27);
            this.kryptonButtonRightP.TabIndex = 2;
            this.kryptonButtonRightP.Values.Text = "Right";
            this.kryptonButtonRightP.Click += new System.EventHandler(this.kryptonButtonRightP_Click);
            // 
            // kryptonButtonLeftP
            // 
            this.kryptonButtonLeftP.AutoSize = true;
            this.kryptonButtonLeftP.Location = new System.Drawing.Point(11, 56);
            this.kryptonButtonLeftP.Name = "kryptonButtonLeftP";
            this.kryptonButtonLeftP.Size = new System.Drawing.Size(64, 27);
            this.kryptonButtonLeftP.TabIndex = 1;
            this.kryptonButtonLeftP.Values.Text = "Left";
            this.kryptonButtonLeftP.Click += new System.EventHandler(this.kryptonButtonLeftP_Click);
            // 
            // kryptonButtonAdd
            // 
            this.kryptonButtonAdd.AutoSize = true;
            this.kryptonButtonAdd.Location = new System.Drawing.Point(10, 25);
            this.kryptonButtonAdd.Name = "kryptonButtonAdd";
            this.kryptonButtonAdd.Size = new System.Drawing.Size(65, 27);
            this.kryptonButtonAdd.TabIndex = 0;
            this.kryptonButtonAdd.Values.Text = "Add";
            this.kryptonButtonAdd.Click += new System.EventHandler(this.kryptonButtonAdd_Click);
            // 
            // kryptonButtonClear
            // 
            this.kryptonButtonClear.AutoSize = true;
            this.kryptonButtonClear.Enabled = false;
            this.kryptonButtonClear.Location = new System.Drawing.Point(11, 87);
            this.kryptonButtonClear.Name = "kryptonButtonClear";
            this.kryptonButtonClear.Size = new System.Drawing.Size(64, 27);
            this.kryptonButtonClear.TabIndex = 2;
            this.kryptonButtonClear.Values.Text = "Clear";
            this.kryptonButtonClear.Click += new System.EventHandler(this.kryptonButtonClear_Click);
            // 
            // kryptonButtonRemove
            // 
            this.kryptonButtonRemove.AutoSize = true;
            this.kryptonButtonRemove.Enabled = false;
            this.kryptonButtonRemove.Location = new System.Drawing.Point(11, 56);
            this.kryptonButtonRemove.Name = "kryptonButtonRemove";
            this.kryptonButtonRemove.Size = new System.Drawing.Size(64, 27);
            this.kryptonButtonRemove.TabIndex = 1;
            this.kryptonButtonRemove.Values.Text = "Remove";
            this.kryptonButtonRemove.Click += new System.EventHandler(this.kryptonButtonRemove_Click);
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(11, 23);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(246, 165);
            this.kryptonHeaderGroup1.TabIndex = 0;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonCheckSet1
            // 
            this.kryptonCheckSet1.CheckButtons.Add(this.check2010Blue);
            this.kryptonCheckSet1.CheckButtons.Add(this.checkSparkle);
            this.kryptonCheckSet1.CheckButtons.Add(this.checkSystem);
            this.kryptonCheckSet1.CheckButtons.Add(this.checkOffice365Black);
            this.kryptonCheckSet1.CheckButtons.Add(this.checkOffice2007Black);
            this.kryptonCheckSet1.CheckButtons.Add(this.checkOffice365White);
            this.kryptonCheckSet1.CheckButtons.Add(this.checkOffice2010White);
            this.kryptonCheckSet1.CheckButtons.Add(this.checkOffice2010Black);
            this.kryptonCheckSet1.CheckedButton = this.checkSystem;
            this.kryptonCheckSet1.CheckedButtonChanged += new System.EventHandler(this.kryptonCheckSet1_CheckedButtonChanged);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(489, 452);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(90, 25);
            this.btnInvert.TabIndex = 14;
            this.btnInvert.Values.Text = "Invert";
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 516);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.checkOffice2007Black);
            this.Controls.Add(this.checkOffice365White);
            this.Controls.Add(this.checkOffice2010White);
            this.Controls.Add(this.checkOffice2010Black);
            this.Controls.Add(this.checkOffice365Black);
            this.Controls.Add(this.checkSystem);
            this.Controls.Add(this.checkSparkle);
            this.Controls.Add(this.check2010Blue);
            this.Controls.Add(this.groupBoxSecondary);
            this.Controls.Add(this.groupBoxPrimary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxButtonSpecs);
            this.Controls.Add(this.groupBoxExample);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxProperties);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ButtonSpec Playground";
            this.groupBoxProperties.ResumeLayout(false);
            this.groupBoxExample.ResumeLayout(false);
            this.groupBoxButtonSpecs.ResumeLayout(false);
            this.groupBoxButtonSpecs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPrimary.ResumeLayout(false);
            this.groupBoxPrimary.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSecondary.ResumeLayout(false);
            this.groupBoxSecondary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button buttonClose;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonRemove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonClear;
        private System.Windows.Forms.GroupBox groupBoxExample;
        private System.Windows.Forms.GroupBox groupBoxButtonSpecs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.GroupBox groupBoxPrimary;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonTopP;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonRightP;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonLeftP;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonBottomP;
        private System.Windows.Forms.GroupBox groupBoxSecondary;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonBottomS;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonTopS;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonRightS;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonLeftS;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton check2010Blue;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkSparkle;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkSystem;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkOffice365Black;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkOffice2007Black;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkOffice365White;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkOffice2010White;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkOffice2010Black;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnInvert;
    }
}

