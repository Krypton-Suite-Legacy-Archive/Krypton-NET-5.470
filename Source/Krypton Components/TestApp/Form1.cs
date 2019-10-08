using ComponentFactory.Krypton.Toolkit;
using System;
using System.Runtime.InteropServices;
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
            // UpdateTitle(GetHasCurrentInstanceGotAdministrativeRights());

            ThemeManager.PropagateThemeSelector(kcmbThemeCollection);

            ThemeManager.PropagateThemeSelector(kdbThemeCollection);

            ThemeManager.PropagateThemeSelector(klbThemes);

            ThemeManager.PropagateThemeSelector(tscThemes);

            ThemeManager.PropagateThemeSelector(cmbThemes);

            ThemeManager.PropagateThemeSelector(dudThemes);

            kcbBracketType.DataSource = Enum.GetValues(typeof(BracketType));

            //foreach (string bracketType in Enum.GetValues(typeof(BracketType)))
            //{
            //    kcbBracketType.Items.Add(bracketType);
            //}
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

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            using (SmallForm smallForm = new SmallForm())
            {
                smallForm.ShowDialog(this);
            }
        }

        private void KcbBracketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBracketType(kcbBracketType.Text);
        }

        private void ChangeBracketType(string bracketType)
        {
            if (bracketType == "CURVEDBRACKET")
            {
                UpdateTitle(GetHasCurrentInstanceGotAdministrativeRights(), BracketType.CURVEDBRACKET);
            }
            else if (bracketType == "CURLYBRACKET")
            {
                UpdateTitle(GetHasCurrentInstanceGotAdministrativeRights(), BracketType.CURVEDBRACKET);
            }
            else if (bracketType == "SQUAREBRACKET")
            {
                UpdateTitle(GetHasCurrentInstanceGotAdministrativeRights(), BracketType.SQUAREBRACKET);
            }
            else if (bracketType == "NOBRACKET")
            {
                UpdateTitle(GetHasCurrentInstanceGotAdministrativeRights(), BracketType.NOBRACKET);
            }
        }

        private void knumWindowRounding_ValueChanged(object sender, EventArgs e)
        {
            CornerRoundingRadius = (int)knumWindowRounding.Value;
        }

        #region WIN32 Calls
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);
        #endregion

        protected override void OnHandleCreated(EventArgs e)
        {
            SetWindowTheme(Handle, "DarkMode_Explorer", null);

            base.OnHandleCreated(e);
        }
    }
}
