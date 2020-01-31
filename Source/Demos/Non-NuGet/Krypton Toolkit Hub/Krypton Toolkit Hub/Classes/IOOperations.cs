using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KryptonToolkitHub.Classes
{
    public class IOOperations
    {
        #region Variables
        private ArrayList _fileArrayList = new ArrayList(), _trueInstalledFileArrayList = new ArrayList();

        private string[] _installedFileList, _trueInstalledFileList;

        private StringCollection _installedFileListCollection, _trueInstalledFileListCollection;

        private FileInfo _fileInfo;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the file array list.
        /// </summary>
        /// <value>
        /// The file array list.
        /// </value>
        public ArrayList FileArrayList { get { return _fileArrayList; } set { _fileArrayList = value; } }

        /// <summary>
        /// Gets or sets the installed file list.
        /// </summary>
        /// <value>
        /// The installed file list.
        /// </value>
        public string[] InstalledFileList { get { return _installedFileList; } set { _installedFileList = value; } }

        /// <summary>
        /// Gets or sets the true installed file list.
        /// </summary>
        /// <value>
        /// The true installed file list.
        /// </value>
        public string[] TrueInstalledFileList { get { return _trueInstalledFileList; } set { _trueInstalledFileList = value; } }

        /// <summary>
        /// Gets or sets the file information.
        /// </summary>
        /// <value>
        /// The file information.
        /// </value>
        public FileInfo FileInformation { get { return _fileInfo; } set { _fileInfo = value; } }
        #endregion

        #region Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="IOOperations"/> class.
        /// </summary>
        public IOOperations()
        {

        }
        #endregion

        #region Getters and Setters
        /// <summary>
        /// Sets the FileArrayLis0t to the value of values.
        /// </summary>
        /// <param name="values">The value of values.</param>
        public void SetFileArrayList(ArrayList values)
        {
            FileArrayList = values;
        }

        /// <summary>
        /// Gets the FileArrayList value.
        /// </summary>
        /// <returns>The value of values.</returns>
        public ArrayList GetFileArrayList()
        {
            return FileArrayList;
        }

        /// <summary>
        /// Sets the InstalledFileList to the value of values.
        /// </summary>
        /// <param name="values">The value of values.</param>
        public void SetInstalledFileList(string[] values)
        {
            InstalledFileList = values;
        }

        /// <summary>
        /// Gets the InstalledFileList value.
        /// </summary>
        /// <returns>The value of values.</returns>
        public string[] GetInstalledFileList()
        {
            return InstalledFileList;
        }

        /// <summary>
        /// Sets the TrueInstalledFileList to the value of values.
        /// </summary>
        /// <param name="values">The value of values.</param>
        public void SetTrueInstalledFileList(string[] values)
        {
            TrueInstalledFileList = values;
        }

        /// <summary>
        /// Gets the TrueInstalledFileList value.
        /// </summary>
        /// <returns>The value of values.</returns>
        public string[] GetTrueInstalledFileList()
        {
            return TrueInstalledFileList;
        }

        /// <summary>
        /// Sets the FileInformation to the value of file.
        /// </summary>
        /// <param name="file">The value of file.</param>
        public void SetFileInformation(FileInfo file)
        {
            FileInformation = file;
        }

        /// <summary>
        /// Gets the FileInformation value.
        /// </summary>
        /// <returns>The value of file.</returns>
        public FileInfo GetFileInformation()
        {
            return FileInformation;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Creates the file list.
        /// </summary>
        /// <param name="installDirectory">The install directory.</param>
        /// <param name="outputFile">The output file.</param>
        public void CreateFileList(string installDirectory, string outputFile)
        {
            try
            {
                foreach (string files in Directory.GetFiles(installDirectory))
                {
                    _installedFileListCollection = new StringCollection();

                    _installedFileListCollection.Add(files);
                }

                foreach (string file in _installedFileListCollection)
                {
                    if (File.Exists(outputFile))
                    {
                        StreamWriter writer = new StreamWriter(outputFile);

                        writer.WriteLine(file);

                        writer.Flush();

                        writer.Close();

                        writer.Dispose();
                    }
                }
            }
            catch (Exception e)
            {
                KryptonMessageBox.Show($"An error has occurred: { e.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Propagates the installed file list.
        /// </summary>
        /// <param name="fileDatabaseList">The file database list.</param>
        public void PropagateInstalledFileList(string fileDatabaseList)
        {
            try
            {
                if (File.Exists(fileDatabaseList))
                {
                    StreamReader reader = new StreamReader(fileDatabaseList);

                    string contents = reader.ReadToEnd();

                    _installedFileListCollection.Add(contents);
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An error has occurred: { exc.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Parses the file list.
        /// </summary>
        /// <param name="installDirectory">The install directory.</param>
        /// <param name="inputFileDatabaseList">The input file database list.</param>
        /// <returns></returns>
        public bool ParseFileList(string installDirectory, string inputFileDatabaseList)
        {
            bool flag = false;

            try
            {
                if (File.Exists(inputFileDatabaseList))
                {
                    StreamReader reader = new StreamReader(inputFileDatabaseList);

                    _installedFileListCollection.Add(reader.ReadToEnd());
                }

                foreach (string file in Directory.GetFiles(installDirectory))
                {
                    _trueInstalledFileListCollection.Add(file);
                }

                foreach (string item in _trueInstalledFileListCollection)
                {
                    if (_installedFileListCollection.Contains(item))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;

                        KryptonMessageBox.Show($"Error, you are missing:\n { item }\nYou may need to reinstall this application.", "File Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An error has occurred: { exc.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return flag;
        }

        /// <summary>
        /// Gets the file information on.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        public FileInfo GetFileInformationOn(string file)
        {
            return new FileInfo(file);
        }

        /// <summary>
        /// Does the file exist.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public bool DoesFileExist(string filePath)
        {
            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Does the directory exist.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns></returns>
        public bool DoesDirectoryExist(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Creates the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public void CreateFile(string filePath)
        {
            try
            {
                if (!DoesFileExist(filePath))
                {
                    File.Create(filePath);
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An error has occurred: { exc.Message }", "Catastrophic File Creation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Creates the directory.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="useVerbose">if set to <c>true</c> [use verbose].</param>
        public void CreateDirectory(string directoryPath, bool useVerbose = false)
        {
            try
            {
                if (useVerbose)
                {
                    if (!DoesDirectoryExist(directoryPath))
                    {

                    }
                }
                else
                {
                    if (!DoesDirectoryExist(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An error has occurred: { exc.Message }", "Catastrophic Directory Creation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the file version.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public Version GetFileVersion(string fileName)
        {
            Version tempVersion;

            string fileVersion = FileVersionInfo.GetVersionInfo(fileName).ToString();

            tempVersion = Version.Parse(fileVersion);

            return tempVersion;
        }

        /// <summary>
        /// Returns the application executable path.
        /// </summary>
        public void ReturnApplicationExecutablePath()
        {
            KryptonMessageBox.Show($"Application is located in: '{ Application.ExecutablePath }'", $"Debug Information - { DateTime.Today.ToLongDateString() }", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Gets the application executable path.
        /// </summary>
        /// <returns></returns>
        public string GetApplicationExecutablePath()
        {
            return Application.ExecutablePath;
        }

        /// <summary>
        /// Gets the application process executable path.
        /// </summary>
        /// <returns></returns>
        public static string GetApplicationProcessExecutablePath()
        {
            return Application.ExecutablePath;
        }
        #endregion
    }
}