using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;
using System.Xml;

namespace KryptonToolkitUpdater.Classes
{
    public class XMLParser
    {
        #region Variables
        bool _betaFlag = false, _startUpdateInstallationUponDownloadCompletion = false;

        DateTime _updatePackageBuildDate = DateTime.Now, _updatePackageReleaseDate = DateTime.Now;

        string _changelogURL = string.Empty, _currentInstalledVersion = string.Empty, _serverVersion = string.Empty, _downloadURL = string.Empty, _fileName = string.Empty, _md5CheckSum = string.Empty, _sha1CheckSum = string.Empty, _sha256CheckSum = null, _sha384CheckSum = string.Empty, _sha512CheckSum = string.Empty, _ripemd160CheckSum = string.Empty, _virusTotalScanURL = string.Empty, _xmlPathURL = string.Empty;

        int _updatePackageFileSize = 0;

        Uri _uri;

        UpdatePackageInformationSettingsHelper updatePackageInformationSettingsHelper = new UpdatePackageInformationSettingsHelper();
        #endregion

        #region Constructors        
        /// <summary>
        /// Initialises a new instance of the <see cref="XMLParser"/> class.
        /// </summary>
        public XMLParser()
        {

        }

        /// <summary>
        /// Initialises a new instance of the <see cref="XMLParser"/> class.
        /// </summary>
        /// <param name="betaFlag">if set to <c>true</c> [beta flag].</param>
        /// <param name="startUpdateInstallationUponDownloadCompletion">if set to <c>true</c> [start update installation upon download completion].</param>
        /// <param name="updatePackageBuildDate">The update package build date.</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="changelogURL">The changelog URL.</param>
        /// <param name="currentInstalledVersion">The current installed version.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="downloadURL">The download URL.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="md5CheckSum">The MD5 check sum.</param>
        /// <param name="sha1CheckSum">The sha1 check sum.</param>
        /// <param name="sha256CheckSum">The sha256 check sum.</param>
        /// <param name="sha384CheckSum">The sha384 check sum.</param>
        /// <param name="sha512CheckSum">The sha512 check sum.</param>
        /// <param name="ripemd160CheckSum">The ripemd160 check sum.</param>
        /// <param name="virusTotalScanURL">The virus total scan URL.</param>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="updatePackageFileSize">Size of the update package file.</param>
        public XMLParser(bool betaFlag, bool startUpdateInstallationUponDownloadCompletion, DateTime updatePackageBuildDate, DateTime updatePackageReleaseDate, string changelogURL, string currentInstalledVersion, string serverVersion, string downloadURL, string fileName, string md5CheckSum, string sha1CheckSum, string sha256CheckSum, string sha384CheckSum, string sha512CheckSum, string ripemd160CheckSum, string virusTotalScanURL, string xmlFilePath, int updatePackageFileSize)
        {
            _betaFlag = betaFlag;

            _startUpdateInstallationUponDownloadCompletion = startUpdateInstallationUponDownloadCompletion;

            _updatePackageBuildDate = updatePackageBuildDate;

            _updatePackageReleaseDate = updatePackageReleaseDate;

            _changelogURL = changelogURL;

            _currentInstalledVersion = currentInstalledVersion;

            _serverVersion = serverVersion;

            _downloadURL = downloadURL;

            _fileName = fileName;

            _md5CheckSum = md5CheckSum;

            _sha1CheckSum = sha1CheckSum;

            _sha256CheckSum = sha256CheckSum;

            _sha384CheckSum = sha384CheckSum;

            _sha512CheckSum = sha512CheckSum;

            _ripemd160CheckSum = ripemd160CheckSum;

            _virusTotalScanURL = virusTotalScanURL;

            _xmlPathURL = xmlFilePath;

            _updatePackageFileSize = updatePackageFileSize;

            StoreData(_betaFlag, _startUpdateInstallationUponDownloadCompletion, _updatePackageBuildDate, _updatePackageReleaseDate, _changelogURL, _currentInstalledVersion, _serverVersion, _downloadURL, _fileName, _md5CheckSum, _sha1CheckSum, _sha256CheckSum, _sha384CheckSum, _sha512CheckSum, _ripemd160CheckSum, _virusTotalScanURL, _xmlPathURL, _updatePackageFileSize);
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Parses the update file.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="projectIdentification">The project identification.</param>
        /// <returns>A new <see cref="XMLParser"/> object with data.</returns>
        public static XMLParser ParseUpdateFile(Uri xmlFilePath, string projectIdentification)
        {
            // Because we can't access global variables, we need to copy them here
            #region Internal Variables
            bool _betaFlag = false, _startUpdateInstallationUponDownloadCompletion = false;

            DateTime _updatePackageBuildDate = DateTime.Now, _updatePackageReleaseDate = DateTime.Now;

            string _changelogURL = string.Empty, _currentInstalledVersion = string.Empty, _serverVersion = string.Empty, _downloadURL = string.Empty, _fileName = string.Empty, _md5CheckSum = string.Empty, _sha1CheckSum = string.Empty, _sha256CheckSum = null, _sha384CheckSum = string.Empty, _sha512CheckSum = string.Empty, _ripemd160CheckSum = string.Empty, _virusTotalScanURL = string.Empty;

            int _updatePackageFileSize = 0;

            Utilities utilities = new Utilities();
            #endregion

            try
            {
                XmlDocument document = new XmlDocument();

                document.Load(xmlFilePath.AbsoluteUri);

                // The fun starts here!
                XmlNode selectedNode = document.DocumentElement.SelectSingleNode($"//update[@projectIdentification='{ projectIdentification }']");

                // Error checking
                if (selectedNode == null)
                {
                    return null;
                }

                // It's data parsing time!
                // We're going to do it in structural order to avoid confusion.
                _currentInstalledVersion = selectedNode["currentInstalledVersion"].InnerText;

                _serverVersion = selectedNode["serverVersion"].InnerText;

                _fileName = selectedNode["fileName"].InnerText;

                _downloadURL = selectedNode["updatePackageServerURLDownloadLocation"].InnerText;

                _changelogURL = selectedNode["changelogURLLocation"].InnerText;

                _md5CheckSum = selectedNode["md5CheckSum"].InnerText;

                _sha1CheckSum = selectedNode["sha1CheckSum"].InnerText;

                _sha256CheckSum = selectedNode["sha256CheckSum"].InnerText;

                _sha384CheckSum = selectedNode["sha512CheckSum"].InnerText;

                _ripemd160CheckSum = selectedNode["ripemd160CheckSum"].InnerText;

                _updatePackageFileSize = int.Parse(selectedNode["updatePackageFileSize"].InnerText);

                _updatePackageBuildDate = DateTime.Parse(selectedNode["updatePackageBuildDate"].InnerText);

                _updatePackageReleaseDate = DateTime.Parse(selectedNode["updatePackageReleaseDate"].InnerText);

                _betaFlag = bool.Parse(selectedNode["betaFlag"].InnerText);

                _startUpdateInstallationUponDownloadCompletion = bool.Parse(selectedNode["startUpdateInstallationUponDownloadCompletion"].InnerText);

                _virusTotalScanURL = selectedNode["virusTotalScanURL"].InnerText;

                return new XMLParser(_betaFlag, _startUpdateInstallationUponDownloadCompletion, _updatePackageBuildDate, _updatePackageReleaseDate, _changelogURL, _currentInstalledVersion, _serverVersion, _downloadURL, _fileName, _md5CheckSum, _sha1CheckSum, _sha256CheckSum, _sha384CheckSum, _sha512CheckSum, _ripemd160CheckSum, _virusTotalScanURL, xmlFilePath.ToString(), _updatePackageFileSize);
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An error has occurred: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static XMLParser ParseUpdateXMLFile(string updateXMLURL)
        {
            #region Internal Variables
            bool _betaFlag = false, _startUpdateInstallationUponDownloadCompletion = false;

            DateTime _updatePackageBuildDate = DateTime.Now, _updatePackageReleaseDate = DateTime.Now;

            string _changelogURL = string.Empty, _currentInstalledVersion = string.Empty, _serverVersion = string.Empty, _downloadURL = string.Empty, _fileName = string.Empty, _md5CheckSum = string.Empty, _sha1CheckSum = string.Empty, _sha256CheckSum = null, _sha384CheckSum = string.Empty, _sha512CheckSum = string.Empty, _ripemd160CheckSum = string.Empty, _virusTotalScanURL = string.Empty, _projectIdentification = string.Empty;

            int _updatePackageFileSize = 0;

            Utilities utilities = new Utilities();

            #endregion

            try
            {
                if (utilities.ExistsOnServer(new Uri(updateXMLURL)))
                {
                    XmlReader reader = XmlReader.Create(updateXMLURL);

                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Update"))
                        {
                            if (reader.HasAttributes)
                            {
                                _projectIdentification = reader.GetAttribute("projectIdentification");

                                _currentInstalledVersion = reader.GetAttribute("currentInstalledVersion");

                                _serverVersion = reader.GetAttribute("serverVersion");

                                _fileName = reader.GetAttribute("fileName");

                                _downloadURL = reader.GetAttribute("updatePackageServerURLDownloadLocation");

                                _changelogURL = reader.GetAttribute("changelogURLLocation");

                                _md5CheckSum = reader.GetAttribute("md5CheckSum");

                                _sha1CheckSum = reader.GetAttribute("sha1CheckSum");

                                _sha256CheckSum = reader.GetAttribute("sha256CheckSum");

                                _sha384CheckSum = reader.GetAttribute("sha384CheckSum");

                                _sha512CheckSum = reader.GetAttribute("sha512CheckSum");

                                _ripemd160CheckSum = reader.GetAttribute("ripemd160CheckSum");

                                _updatePackageFileSize = int.Parse(reader.GetAttribute("updatePackageFileSize"));

                                _updatePackageBuildDate = DateTime.Parse(reader.GetAttribute("updatePackageBuildDate"));

                                _updatePackageReleaseDate = DateTime.Parse(reader.GetAttribute("updatePackageReleaseDate"));

                                _betaFlag = bool.Parse(reader.GetAttribute("betaFlag"));

                                _startUpdateInstallationUponDownloadCompletion = bool.Parse(reader.GetAttribute("startUpdateInstallationUponDownloadCompletion"));

                                _virusTotalScanURL = reader.GetAttribute("virusTotalScanURL");
                            }
                        }
                    }
                }

                return new XMLParser(_betaFlag, _startUpdateInstallationUponDownloadCompletion, _updatePackageBuildDate, _updatePackageReleaseDate, _changelogURL, _currentInstalledVersion, _serverVersion, _downloadURL, _fileName, _md5CheckSum, _sha1CheckSum, _sha256CheckSum, _sha384CheckSum, _sha512CheckSum, _ripemd160CheckSum, _virusTotalScanURL, updateXMLURL.ToString(), _updatePackageFileSize);
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An error has occurred: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        /// <summary>
        /// Stores the data.
        /// </summary>
        /// <param name="betaFlag">if set to <c>true</c> [beta flag].</param>
        /// <param name="startUpdateInstallationUponDownloadCompletion">if set to <c>true</c> [start update installation upon download completion].</param>
        /// <param name="updatePackageBuildDate">The update package build date.</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="changelogURL">The changelog URL.</param>
        /// <param name="currentInstalledVersion">The current installed version.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="downloadURL">The download URL.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="md5CheckSum">The MD5 check sum.</param>
        /// <param name="sha1CheckSum">The sha1 check sum.</param>
        /// <param name="sha256CheckSum">The sha256 check sum.</param>
        /// <param name="sha384CheckSum">The sha384 check sum.</param>
        /// <param name="sha512CheckSum">The sha512 check sum.</param>
        /// <param name="ripemd160CheckSum">The ripemd160 check sum.</param>
        /// <param name="virusTotalScanURL">The virus total scan URL.</param>
        /// <param name="xmlPathURL">The XML path URL.</param>
        /// <param name="updatePackageFileSize">Size of the update package file.</param>
        private void StoreData(bool betaFlag, bool startUpdateInstallationUponDownloadCompletion, DateTime updatePackageBuildDate, DateTime updatePackageReleaseDate, string changelogURL, string currentInstalledVersion, string serverVersion, string downloadURL, string fileName, string md5CheckSum, string sha1CheckSum, string sha256CheckSum, string sha384CheckSum, string sha512CheckSum, string ripemd160CheckSum, string virusTotalScanURL, string xmlPathURL, int updatePackageFileSize)
        {
            updatePackageInformationSettingsHelper.SetBetaFlag(betaFlag);

            updatePackageInformationSettingsHelper.SetStartUpdateInstallationUponDownloadCompletion(startUpdateInstallationUponDownloadCompletion);

            updatePackageInformationSettingsHelper.SetUpdatePackageBuildDate(updatePackageBuildDate);

            updatePackageInformationSettingsHelper.SetUpdatePackageReleaseDate(updatePackageReleaseDate);

            updatePackageInformationSettingsHelper.SetChangelogURL(changelogURL);

            updatePackageInformationSettingsHelper.SetCurrentInstalledVersion(currentInstalledVersion);

            updatePackageInformationSettingsHelper.SetServerVersion(serverVersion);

            updatePackageInformationSettingsHelper.SetDownloadURL(downloadURL);

            updatePackageInformationSettingsHelper.SetFileName(fileName);

            updatePackageInformationSettingsHelper.SetMD5CheckSum(md5CheckSum);

            updatePackageInformationSettingsHelper.SetSHA1CheckSum(sha1CheckSum);

            updatePackageInformationSettingsHelper.SetSHA256CheckSum(sha256CheckSum);

            updatePackageInformationSettingsHelper.SetSHA384CheckSum(sha384CheckSum);

            updatePackageInformationSettingsHelper.SetSHA512CheckSum(sha512CheckSum);

            updatePackageInformationSettingsHelper.SetRIPEMD160CheckSum(ripemd160CheckSum);

            updatePackageInformationSettingsHelper.SetVirusTotalURL(virusTotalScanURL);

            updatePackageInformationSettingsHelper.SetXMLUpdatePathURL(xmlPathURL);

            updatePackageInformationSettingsHelper.SetUpdatePackageFileSize(updatePackageFileSize);

            updatePackageInformationSettingsHelper.SaveUpdatePackageInformationSettings(false);
        }
        #endregion
    }
}