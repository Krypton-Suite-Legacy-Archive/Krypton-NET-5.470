using System;

namespace KryptonToolkitUpdater.Interfaces
{
    public interface IUpdatePackageInformationSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether [beta flag].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [beta flag]; otherwise, <c>false</c>.
        /// </value>
        bool BetaFlag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [start update installation upon download completion].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [start update installation upon download completion]; otherwise, <c>false</c>.
        /// </value>
        bool StartUpdateInstallationUponDownloadCompletion { get; set; }

        /// <summary>
        /// Gets or sets the update package build date.
        /// </summary>
        /// <value>
        /// The update package build date.
        /// </value>
        DateTime UpdatePackageBuildDate { get; set; }

        /// <summary>
        /// Gets or sets the update package release date.
        /// </summary>
        /// <value>
        /// The update package release date.
        /// </value>
        DateTime UpdatePackageReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the changelog URL.
        /// </summary>
        /// <value>
        /// The changelog URL.
        /// </value>
        string ChangelogURL { get; set; }

        /// <summary>
        /// Gets or sets the current installed version.
        /// </summary>
        /// <value>
        /// The current installed version.
        /// </value>
        string CurrentInstalledVersion { get; set; }

        /// <summary>
        /// Gets or sets the server version.
        /// </summary>
        /// <value>
        /// The server version.
        /// </value>
        string ServerVersion { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>
        /// The download URL.
        /// </value>
        string DownloadURL { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        string FileName { get; set; }

        /// <summary>
        /// Gets or sets the MD5 check sum.
        /// </summary>
        /// <value>
        /// The MD5 check sum.
        /// </value>
        string MD5CheckSum { get; set; }

        /// <summary>
        /// Gets or sets the SHA1 check sum.
        /// </summary>
        /// <value>
        /// The SHA1 check sum.
        /// </value>
        string SHA1CheckSum { get; set; }

        /// <summary>
        /// Gets or sets the SHA256 check sum.
        /// </summary>
        /// <value>
        /// The SHA256 check sum.
        /// </value>
        string SHA256CheckSum { get; set; }

        /// <summary>
        /// Gets or sets the SHA384 check sum.
        /// </summary>
        /// <value>
        /// The SHA384 check sum.
        /// </value>
        string SHA384CheckSum { get; set; }

        /// <summary>
        /// Gets or sets the SHA512 check sum.
        /// </summary>
        /// <value>
        /// The SHA512 check sum.
        /// </value>
        string SHA512CheckSum { get; set; }

        /// <summary>
        /// Gets or sets the RIPEMD160 check sum.
        /// </summary>
        /// <value>
        /// The RIPEMD160 check sum.
        /// </value>
        string RIPEMD160CheckSum { get; set; }

        /// <summary>
        /// Gets or sets the XML update path URL.
        /// </summary>
        /// <value>
        /// The XML update path URL.
        /// </value>
        string XMLUpdatePathURL { get; set; }

        /// <summary>
        /// Gets or sets the size of the update package file.
        /// </summary>
        /// <value>
        /// The size of the update package file.
        /// </value>
        int UpdatePackageFileSize { get; set; }
    }
}