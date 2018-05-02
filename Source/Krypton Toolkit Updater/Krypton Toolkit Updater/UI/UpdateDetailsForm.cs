using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Interfaces;
using System;

namespace KryptonToolkitUpdater.UI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    public partial class UpdateDetailsForm : KryptonForm, IUpdatePackageInformationSettings
    {
        #region Interfaces
        public DateTime UpdatePackageBuildDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatePackageReleaseDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ChangnelogURL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CurrentInstalledVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ServerVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DownloadURL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UpdatePackageFileSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Unused
        public bool BetaFlag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool StartUpdateInstallationUponDownloadCompletion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MD5CheckSum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SHA1CheckSum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SHA256CheckSum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SHA384CheckSum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SHA512CheckSum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RIPEMD160CheckSum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string XMLUpdatePathURL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // End unused
        #endregion

        #region Variables

        #endregion

        /// <summary>
        /// Initialises a new instance of the <see cref="UpdateDetailsForm"/> class.
        /// </summary>
        public UpdateDetailsForm()
        {
            InitializeComponent();
        }

        private void kbtnRemindMeLater_Click(object sender, EventArgs e)
        {
            RemindMeLaterForm remindMeLater = new RemindMeLaterForm();

            remindMeLater.Show();
        }

        private void UpdateDetailsForm_Load(object sender, EventArgs e)
        {
            LoadWindow();
        }

        private void LoadWindow()
        {
            if (ChangnelogURL != string.Empty)
            {
                wbChangelog.Navigate(ChangnelogURL);
            }
        }
    }
}