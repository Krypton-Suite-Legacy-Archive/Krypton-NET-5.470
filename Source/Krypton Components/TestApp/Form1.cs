using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            RibbonApp ra = new RibbonApp();

            ra.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThemeManager.PropagateThemeSelector(kcmbThemeCollection);

            ThemeManager.PropagateThemeSelector(kdbThemeCollection);

            ThemeManager.PropagateThemeSelector(klbThemes);
        }

        private void kcmbThemeCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            kbtnApplyTheme.Enabled = true;
        }

        private void kdbThemeCollection_SelectedItemChanged(object sender, EventArgs e)
        {
            kbtnApplyTheme.Enabled = true;
        }

        private void klbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            kbtnApplyTheme.Enabled = true;
        }

        private void kbtnApplyTheme_Click(object sender, EventArgs e)
        {
            if (kcmbThemeCollection.Text != string.Empty)
            {
                ThemeManager.SetTheme(kcmbThemeCollection.Text, kryptonManager1);
            }
            else if (kdbThemeCollection.Text != string.Empty)
            {
                ThemeManager.SetTheme(kdbThemeCollection.Text, kryptonManager1);
            }
            else if (klbThemes.Text != string.Empty)
            {
                ThemeManager.SetTheme(klbThemes.SelectedItem.ToString(), kryptonManager1);
            }

            kbtnApplyTheme.Enabled = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            //KryptonMessageBox.Show(this, "Press the Help Button", "Help From the MessageBox", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
            //    MessageBoxOptions.RightAlign, true);

            KryptonMessageBox.Show(this, "Press the Help Button", "Help From the MessageBox",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, @"..\..\..\..\..\Help\Krypton Toolkit Help.chm", HelpNavigator.KeywordIndex, @"Overview");


        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            KryptonMessageBox.Show(this, $@"At Mouse Position {hlpevent.MousePos}", @"HelpRequested");
        }

        private void kbtnLoadTheme_Click(object sender, EventArgs e)
        {
            kryptonPalette1.Import();

            kryptonManager1.GlobalPalette = kryptonPalette1;

            kryptonManager1.GlobalPaletteMode = PaletteModeManager.Custom;
        }
    }
}
