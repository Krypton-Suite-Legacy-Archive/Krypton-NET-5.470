using System;
using System.Drawing;
using  Krypton.Toolkit;

namespace SystemThemedForms
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            buttonSpecAny1.Click += ButtonSpecAny1_Click;
            button4.BackColor = SystemColors.InactiveCaption;
            button5.BackColor = SystemColors.ActiveCaption;
            button6.BackColor = SystemColors.GradientActiveCaption;
            button7.BackColor = SystemColors.GradientInactiveCaption;
            button8.BackColor = SystemColors.WindowFrame;
            //button9.BackColor = SystemColors.ActiveCaption;
            //button10.BackColor = SystemColors.ActiveCaption;
        }

        private void ButtonSpecAny1_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(this, "FormButton Clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PaletteMode =  Krypton.Toolkit.PaletteMode.ProfessionalSystem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.PaletteMode =  Krypton.Toolkit.PaletteMode.Office2007Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.PaletteMode =  Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
        }
    }
}
