using System.Diagnostics;
using System.IO;

namespace KryptonToolkitUpdater.Classes
{
    public class Utilities
    {
        #region Constructor
        public Utilities()
        {

        }
        #endregion

        #region Methods
        public bool ExploreFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            filePath = Path.GetFullPath(filePath);

            Process.Start("explorer.exe", $"/select,\"{ filePath }\"");

            return true;
        }
        #endregion
    }
}