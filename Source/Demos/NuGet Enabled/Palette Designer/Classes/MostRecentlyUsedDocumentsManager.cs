using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace PaletteDesigner.Classes
{
    /// <summary>
    /// Deals with the back-end logic of a most recently used file <see cref="ToolStripMenuItem"/>.
    /// Adapted from (https://www.codeproject.com/Articles/407513/Add-Most-Recently-Used-Files-MRU-List-to-Windows).
    /// </summary>
    public class MostRecentlyUsedDocumentsManager
    {
        #region Private members
        private bool UseConfirmClearListDialogue;

        private string NameOfProgram;

        private string SubKeyName;

        private string filePath;

        private ToolStripMenuItem ParentMenuItem;

        private ToolStripMenuItem ClearListItem;

        private Action<object, EventArgs> OnRecentFileClick;

        private Action<object, EventArgs> OnClearRecentFilesClick;

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath
        {
            get
            {
                return filePath;
            }

            set
            {
                filePath = value;
            }
        }

        /// <summary>
        /// Called when [clear recent files click].
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="evt">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnClearRecentFiles_Click(object obj, EventArgs evt)
        {
            try
            {
                DialogResult result = KryptonMessageBox.Show("You are about to clear your recent files list. Do you want to continue?", "Clear Recent Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ClearRecentFiles();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (OnClearRecentFilesClick != null)
            {
                OnClearRecentFilesClick(obj, evt);
            }
        }

        /// <summary>
        /// Clears the recent files.
        /// </summary>
        private void ClearRecentFiles()
        {
            try
            {
                RegistryKey rK = Registry.CurrentUser.OpenSubKey(SubKeyName, true);

                if (rK == null)
                {
                    return;
                }

                string[] values = rK.GetValueNames();

                foreach (string valueName in values)
                {
                    rK.DeleteValue(valueName, true);
                }

                rK.Close();

                ParentMenuItem.DropDownItems.Clear();

                ParentMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error: { ex.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refreshes the recent files menu.
        /// </summary>
        private void RefreshRecentFilesMenu()
        {
            RegistryKey rK;

            string s;

            ToolStripItem tSI;

            try
            {
                rK = Registry.CurrentUser.OpenSubKey(this.SubKeyName, false);

                if (rK == null)
                {
                    ParentMenuItem.Enabled = false;

                    return;
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error: { ex.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ParentMenuItem.DropDownItems.Clear();

            string[] valueNames = rK.GetValueNames();

            foreach (string valueName in valueNames)
            {
                s = rK.GetValue(valueName, null) as string;

                if (s == null)
                {
                    continue;
                }

                tSI = ParentMenuItem.DropDownItems.Add(s);

                tSI.Click += new EventHandler(OnRecentFileClick);
            }

            if (ParentMenuItem.DropDownItems.Count == 0)
            {
                ParentMenuItem.Enabled = false;

                return;
            }

            ParentMenuItem.DropDownItems.Add("-");

            tSI = ParentMenuItem.DropDownItems.Add("&Clear list");

            tSI.Click += new EventHandler(OnClearRecentFiles_Click);

            ParentMenuItem.Enabled = true;
        }
        #endregion

        #region Public members
        /// <summary>
        /// Adds the recent file.
        /// </summary>
        /// <param name="fileNameWithFullPath">The file name with full path.</param>
        public void AddRecentFile(string fileNameWithFullPath)
        {
            string s;

            try
            {
                RegistryKey rK = Registry.CurrentUser.CreateSubKey(SubKeyName, RegistryKeyPermissionCheck.ReadWriteSubTree);

                for (int i = 0; true; i++)
                {
                    s = rK.GetValue(i.ToString(), null) as string;

                    if (s == null)
                    {
                        rK.SetValue(i.ToString(), fileNameWithFullPath);

                        rK.Close();

                        break;
                    }
                    else if (s == fileNameWithFullPath)
                    {
                        rK.Close();

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error: { ex.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshRecentFilesMenu();
        }


        /// <summary>
        /// Removes the recent file.
        /// </summary>
        /// <param name="fileNameWithFullPath">The file name with full path.</param>
        public void RemoveRecentFile(string fileNameWithFullPath)
        {
            try
            {
                RegistryKey rK = Registry.CurrentUser.OpenSubKey(SubKeyName, true);

                string[] valuesNames = rK.GetValueNames();

                foreach (string valueName in valuesNames)
                {
                    if ((rK.GetValue(valueName, null) as string) == fileNameWithFullPath)
                    {
                        rK.DeleteValue(valueName, true);

                        RefreshRecentFilesMenu();

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            RefreshRecentFilesMenu();
        }
        #endregion

        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="MostRecentlyUsedDocumentsManager"/> class.
        /// </summary>
        /// <param name="parentMenuItem">The parent menu item.</param>
        /// <param name="nameOfProgram">The name of program.</param>
        /// <param name="onRecentFileClick">The on recent file click.</param>
        /// <param name="onClearRecentFilesClick">The on clear recent files click.</param>
        /// <param name="useConfirmClearListDialogue">if set to <c>true</c> [use confirm clear list dialogue].</param>
        /// <exception cref="ArgumentException">Bad argument.</exception>
        public MostRecentlyUsedDocumentsManager(ToolStripMenuItem parentMenuItem, string nameOfProgram, Action<object, EventArgs> onRecentFileClick, Action<object, EventArgs> onClearRecentFilesClick = null, bool useConfirmClearListDialogue = true)
        {
            if (parentMenuItem == null || onRecentFileClick == null || nameOfProgram == null || nameOfProgram.Length == 0 || nameOfProgram.Contains("\\")) throw new ArgumentException("Bad argument.");

            ParentMenuItem = parentMenuItem;

            NameOfProgram = nameOfProgram;

            OnRecentFileClick = onRecentFileClick;

            OnClearRecentFilesClick = onClearRecentFilesClick;

            SubKeyName = string.Format($"Software\\{ NameOfProgram }\\MRU");

            UseConfirmClearListDialogue = useConfirmClearListDialogue;

            RefreshRecentFilesMenu();
        }
        #endregion
    }
}