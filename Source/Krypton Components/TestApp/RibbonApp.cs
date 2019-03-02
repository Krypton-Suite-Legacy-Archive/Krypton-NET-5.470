using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;

        private void InitializeComponent()
        {
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
            this.kryptonRibbonGroupButton1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = true;
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedContext = null;
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
            this.kryptonRibbonGroupButton1});
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
            // RibbonApp
            // 
            this.ClientSize = new System.Drawing.Size(1347, 670);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "RibbonApp";
            this.TextExtra = "Test";
            this.UseDropShadow = false;
            this.Load += new System.EventHandler(this.RibbonApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
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
    }
}