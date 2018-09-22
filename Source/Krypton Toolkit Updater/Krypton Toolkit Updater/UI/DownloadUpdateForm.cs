using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Classes;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.UI
{
    public partial class DownloadUpdateForm : KryptonForm
    {
        #region Variables
        bool downloadCompleted;

        string downloadURL, downloadLocation;

        WebClient _downloadClient;

        Stopwatch _stopwatch = new Stopwatch();

        Utilities _utilities = new Utilities();
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets a value indicating whether [download completed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [download completed]; otherwise, <c>false</c>.
        /// </value>
        private bool DownloadCompleted
        {
            get
            {
                return downloadCompleted;
            }

            set
            {
                downloadCompleted = value;
            }
        }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        public string DownloadURL
        {
            get
            {
                return downloadURL;
            }

            set
            {
                downloadURL = value;
            }
        }

        /// <summary>
        /// Gets or sets the download location.
        /// </summary>
        /// <value>
        /// The download location.
        /// </value>
        public string DownloadLocation
        {
            get
            {
                return downloadLocation;
            }

            set
            {
                downloadLocation = value;
            }
        }
        #endregion

        /// <summary>
        /// Initialises a new instance of the <see cref="DownloadUpdateForm"/> class.
        /// </summary>
        /// <param name="downloadURL">The download URL.</param>
        /// <param name="downloadLocation">The download location.</param>
        public DownloadUpdateForm(string downloadURL, string downloadLocation)
        {
            InitializeComponent();

            DownloadURL = downloadURL;

            DownloadLocation = downloadLocation;
        }

        private void DownloadUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void kbtnInstallUpdate_Click(object sender, EventArgs e)
        {
            if (GetDownloadCompleted())
            {
                Process.Start(DownloadLocation);

                Application.Exit();
            }
        }

        private void kbtnStop_Click(object sender, EventArgs e)
        {

        }

        #region Methods        
        /// <summary>
        /// Downloads the file.
        /// Adapted from (https://www.fluxbytes.com/csharp/how-to-download-a-file-in-c-progressbar-and-download-speed/)
        /// </summary>
        /// <param name="downloadURL">The download URL.</param>
        /// <param name="downloadLocation">The download location.</param>
        private void DownloadFile(string downloadURL, string downloadLocation)
        {
            using (_downloadClient = new WebClient())
            {
                _downloadClient.DownloadFileCompleted += Completed;

                _downloadClient.DownloadProgressChanged += ProgressChanged;

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = downloadURL.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(downloadURL) : new Uri("http://" + downloadURL);

                // Start the stopwatch which we will be using to calculate the download speed
                _stopwatch.Start();

                try
                {
                    // Download the file
                    _downloadClient.DownloadFile(URL, downloadLocation);
                }
                catch (Exception exc)
                {
                    // Report the error
                    KryptonMessageBox.Show($"Error whilst downloading file: { exc.Message }", "Download Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Progress changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="DownloadProgressChangedEventArgs"/> instance containing the event data.</param>
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to klblCurrentSpeed.
            klblCurrentSpeed.Text = $"Current speed: { (e.BytesReceived / 1024d / _stopwatch.Elapsed.TotalSeconds).ToString("0.00") } KB/s";

            // Update the progressbar percentage only when the value is not the same.
            pbDownloadProgress.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            klblDownloadProgressPercentage.Text = $"{ e.ProgressPercentage.ToString() }%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            klblTotalAmountDownloaded.Text = $"Amount downloaded: { (e.BytesReceived / 1024d / 1024d).ToString("0.00") } MB's of { (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00") } MB's";
        }

        /// <summary>
        /// Handles the LinkClicked event of the kllDownloadingTo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kllDownloadingTo_LinkClicked(object sender, EventArgs e)
        {
            _utilities.ExploreFile(kllDownloadingTo.Text);
        }

        /// <summary>
        /// Fires upon download completion.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="AsyncCompletedEventArgs"/> instance containing the event data.</param>
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            _stopwatch.Reset();

            kbtnInstallUpdate.Enabled = true;

            if (e.Cancelled)
            {
                KryptonMessageBox.Show("Download has been canceled.");
            }
            else
            {
                KryptonMessageBox.Show("Download completed!");

                SetDownloadCompleted(true);
            }
        }
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Sets the DownloadCompleted to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DownloadCompleted.</param>
        private void SetDownloadCompleted(bool value)
        {
            DownloadCompleted = value;
        }

        /// <summary>
        /// Returns the value of the DownloadCompleted.
        /// </summary>
        /// <returns>The value of the DownloadCompleted.</returns>
        private bool GetDownloadCompleted()
        {
            return DownloadCompleted;
        }
        #endregion
    }
}