using System;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace TestMessageBoxClipping
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            KryptonMessageBox.Show("Test without an owner,\nand before KyptonManager has Loaded", null);
            KryptonMessageBox.Show((string)null, "Test without no Text");
            Application.Run(new Form1());
        }
    }
}
