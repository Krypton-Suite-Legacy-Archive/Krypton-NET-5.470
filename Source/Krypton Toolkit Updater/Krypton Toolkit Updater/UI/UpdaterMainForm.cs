using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.UI
{
    public partial class UpdaterMainForm : KryptonForm
    {
        #region Variables
        bool _checkingForUpdates = false;
        #endregion

        /// <summary>
        /// Initialises a new instance of the <see cref="UpdaterMainForm"/> class.
        /// </summary>
        public UpdaterMainForm()
        {
            InitializeComponent();
        }

        private void kbtnCancel_Click(object sender, System.EventArgs e)
        {

        }

        private void kbtnCheckForUpdates_Click(object sender, System.EventArgs e)
        {

        }

        private void kbtnOptions_Click(object sender, System.EventArgs e)
        {
            UpdaterOptionsForm updaterOptions = new UpdaterOptionsForm();

            updaterOptions.Show();
        }

        private void UpdaterMainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void UpdaterMainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

        }

        #region Methods

        #endregion

        #region Setters and Getters

        #endregion

        private void kllHelp_LinkClicked(object sender, System.EventArgs e)
        {
            KryptonMessageBox.Show("This utility will enable you to check for and download updates for Krypton .NET 4.70.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}