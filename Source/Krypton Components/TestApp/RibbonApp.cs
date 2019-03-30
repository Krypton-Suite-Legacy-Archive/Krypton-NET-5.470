using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;
using System;

namespace TestApp
{
    public class RibbonApp : KryptonForm
    {
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kgbtnDropShadowOn;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kgbtnDropShadowOff;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox krgcmbThemeChooser;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupDomainUpDown krgdThemeSelector;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbApplyTheme;
        private KryptonPanel kryptonPanel1;
        private KryptonPanel kryptonPanel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private KryptonManager kryptonManager1;
        private System.ComponentModel.IContainer components;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kgbtnDropShadowOn = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kgbtnDropShadowOff = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgcmbThemeChooser = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox();
            this.krgdThemeSelector = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupDomainUpDown();
            this.krgbApplyTheme = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = true;
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1347, 115);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup2});
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kgbtnDropShadowOn,
            this.kgbtnDropShadowOff});
            // 
            // kgbtnDropShadowOn
            // 
            this.kgbtnDropShadowOn.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.kgbtnDropShadowOn.TextLine1 = "Turn Drop Shadow";
            this.kgbtnDropShadowOn.TextLine2 = "On";
            this.kgbtnDropShadowOn.Click += new System.EventHandler(this.kgbtnDropShadowOn_Click);
            // 
            // kgbtnDropShadowOff
            // 
            this.kgbtnDropShadowOff.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.kgbtnDropShadowOff.TextLine1 = "Turn Drop Shadow";
            this.kgbtnDropShadowOff.TextLine2 = "Off";
            this.kgbtnDropShadowOff.Click += new System.EventHandler(this.kgbtnDropShadowOff_Click);
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgcmbThemeChooser,
            this.krgdThemeSelector,
            this.krgbApplyTheme});
            // 
            // krgcmbThemeChooser
            // 
            this.krgcmbThemeChooser.DropDownWidth = 121;
            this.krgcmbThemeChooser.FormattingEnabled = false;
            this.krgcmbThemeChooser.ItemHeight = 15;
            this.krgcmbThemeChooser.Text = "";
            // 
            // krgdThemeSelector
            // 
            this.krgdThemeSelector.Text = "";
            // 
            // krgbApplyTheme
            // 
            this.krgbApplyTheme.TextLine1 = "Apply";
            this.krgbApplyTheme.TextLine2 = "Theme";
            this.krgbApplyTheme.Click += new System.EventHandler(this.krgbApplyTheme_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1347, 555);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.statusStrip1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 648);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1347, 22);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1347, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // RibbonApp
            // 
            this.ClientSize = new System.Drawing.Size(1347, 670);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "RibbonApp";
            this.TextExtra = "Test";
            this.UseDropShadow = false;
            this.Load += new System.EventHandler(this.RibbonApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public RibbonApp()
        {
            InitializeComponent();
        }

        private void kgbtnDropShadowOn_Click(object sender, EventArgs e)
        {
            kgbtnDropShadowOff.Checked = false;

            UpdateDropShadowDraw(true);
        }

        private void kgbtnDropShadowOff_Click(object sender, EventArgs e)
        {
            kgbtnDropShadowOn.Checked = false;

            UpdateDropShadowDraw(false);
        }

        private void RibbonApp_Load(object sender, EventArgs e)
        {
            RibbonThemeManager.PropagateThemeSelector(krgcmbThemeChooser);

            RibbonThemeManager.PropagateThemeSelector(krgdThemeSelector);
        }

        private void krgbApplyTheme_Click(object sender, EventArgs e)
        {
            if (krgcmbThemeChooser.Text != string.Empty)
            {
                RibbonThemeManager.SetTheme(krgcmbThemeChooser.Text, kryptonManager1);
            }

            if (krgdThemeSelector.Text != string.Empty)
            {
                RibbonThemeManager.SetTheme(krgdThemeSelector.Text, kryptonManager1);
            }
        }
    }
}