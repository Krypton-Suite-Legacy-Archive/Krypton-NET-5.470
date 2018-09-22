using Krypton.Toolkit;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KryptonToolkitHub.Classes
{
    public class ProcessManager
    {
        #region Variables
        private static string _procesFilePath = string.Empty;
        #endregion

        #region Properties
        public static string ProcessFilePath { get { return _procesFilePath; } set { _procesFilePath = value; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="ProcessManager"/> class.
        /// </summary>
        public ProcessManager()
        {

        }
        #endregion

        #region Methods       
        /// <summary>
        /// Launches the process.
        /// </summary>
        /// <param name="processName">Name of the process.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchProcess(string processName, bool useFullPath = false)
        {
            try
            {
                if (File.Exists(processName))
                {
                    Process.Start(processName);

                    SetProcessFilePath(processName, useFullPath);
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An error has occurred: { exc.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Setters & Getters        
        /// <summary>
        /// Sets the process file path.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void SetProcessFilePath(string value, bool useFullPath = false)
        {
            if (useFullPath)
            {
                ProcessFilePath = Path.GetFullPath(value);
            }
            else
            {
                ProcessFilePath = Path.GetFileName(value);
            }
        }

        /// <summary>
        /// Gets the process file path.
        /// </summary>
        /// <returns></returns>
        public static string GetProcessFilePath()
        {
            if (ProcessFilePath != string.Empty)
            {
                return ProcessFilePath;
            }
            else
            {
                return "NULL STRING";
            }
        }
        #endregion
    }
}