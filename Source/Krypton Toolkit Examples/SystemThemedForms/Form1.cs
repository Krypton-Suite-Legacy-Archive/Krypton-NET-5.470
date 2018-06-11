using System;

using ComponentFactory.Krypton.Toolkit;

namespace SystemThemedForms
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            buttonSpecAny1.Click += ButtonSpecAny1_Click;
        }

        private void ButtonSpecAny1_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(this, "FormButton Clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
        }
    }
}
