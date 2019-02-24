using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
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
            foreach (string theme in ThemeManager.SupportedThemeArray)
            {
                kcmbThemeCollection.Items.Add(theme);
            }
        }
    }
}
