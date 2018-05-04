using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Interfaces;
using System;

namespace KryptonToolkitUpdater.UI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="KryptonForm" />
    public partial class UpdateDetailsForm : KryptonForm, IUpdatePackageInformationSettings
    {
        #region Interfaces
        public DateTime UpdatePackageBuildDate { get; set; }
        public DateTime UpdatePackageReleaseDate { get; set; }
        public string ChangelogURL { get; set; }
        public string CurrentInstalledVersion { get; set; }
        public string ServerVersion { get; set; }
        public string DownloadURL { get; set; }
        public string FileName { get; set; }
        public int UpdatePackageFileSize { get; set; }

        // Unused
        public bool BetaFlag { get; set; }
        public bool StartUpdateInstallationUponDownloadCompletion { get; set; }
        public string MD5CheckSum { get; set; }
        public string SHA1CheckSum { get; set; }
        public string SHA256CheckSum { get; set; }
        public string SHA384CheckSum { get; set; }
        public string SHA512CheckSum { get; set; }
        public string RIPEMD160CheckSum { get; set; }
        public string XMLUpdatePathURL { get; set; }

        // End unused
        #endregion

        #region Variables

        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="UpdateDetailsForm"/> class.
        /// </summary>
        /// <param name="currentVersion">The current version.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="updatePackageSize">Size of the update package.</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="changelogURL">The changelog URL.</param>
        public UpdateDetailsForm(Version currentVersion, Version serverVersion, int updatePackageSize, DateTime updatePackageReleaseDate, string changelogURL)
        {
            InitializeComponent();

            CurrentInstalledVersion = currentVersion.ToString();

            ServerVersion = serverVersion.ToString();

            UpdatePackageFileSize = updatePackageSize;

            UpdatePackageReleaseDate = updatePackageReleaseDate;

            ChangelogURL = changelogURL;

            UpdateUI(CurrentInstalledVersion, ServerVersion, UpdatePackageFileSize, UpdatePackageReleaseDate, ChangelogURL);
        }
        #endregion

        private void kbtnRemindMeLater_Click(object sender, EventArgs e)
        {
            RemindMeLaterForm remindMeLater = new RemindMeLaterForm();

            remindMeLater.Show();
        }

        private void UpdateDetailsForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Updates the UI.
        /// </summary>
        /// <param name="currentInstalledVersion">The current installed version.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="updatePackageFileSize">Size of the update package file.</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="changelogURL">The changelog URL.</param>
        private void UpdateUI(string currentInstalledVersion, string serverVersion, int updatePackageFileSize, DateTime updatePackageReleaseDate, string changelogURL)
        {
            klblVersionInformation.Text = $"Your version: { currentInstalledVersion } Server version: { serverVersion }";

            klblPackageInformation.Text = $"Package size: {0} Release date: { updatePackageReleaseDate.ToString() }";

            wbChangelog.Navigate(new Uri(changelogURL));
        }
    }
}