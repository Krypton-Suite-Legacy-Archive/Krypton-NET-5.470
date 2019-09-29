using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Windows.Forms;

namespace KryptonExplorer.Classes
{
    internal class ApplicationHelper
    {
        public ApplicationHelper()
        {

        }

        private static bool DoesFileExist(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string NoFileFound() => "UNKNOWN DATA";

        public static void PopulateAboutInformation(KryptonLabel toolkit, KryptonLabel docking, KryptonLabel navigator, KryptonLabel ribbon, KryptonLabel workspace)
        {
            string toolkitPath = Path.GetFullPath(Application.ExecutablePath + "\\Krypton Toolkit.dll"), dockingPath = Path.GetFullPath(Application.ExecutablePath + "\\Krypton Docking.dll"), navigatorPath = Path.GetFullPath(Application.ExecutablePath + "\\Krypton Navigator.dll"), ribbonPath = Path.GetFullPath(Application.ExecutablePath + "\\Krypton Ribbon.dll"), workspacePath = Path.GetFullPath(Application.ExecutablePath + "\\Krypton Workspace.dll");

            if (DoesFileExist(toolkitPath))
            {
                toolkit.Text = $"Toolkit Version: { AssemblyHelper.GetFileVersionInformation(toolkitPath).FileVersion }";
            }
            else
            {
                toolkit.Text = $"Toolkit Version: { NoFileFound() }";
            }

            if (DoesFileExist(dockingPath))
            {
                docking.Text = $"Docking Version: { AssemblyHelper.GetFileVersionInformation(dockingPath).FileVersion }";
            }
            else
            {
                docking.Text = $"Docking Version: { NoFileFound() }";
            }

            if (DoesFileExist(navigatorPath))
            {
                navigator.Text = $"Navigator Version: { AssemblyHelper.GetFileVersionInformation(navigatorPath).FileVersion }";
            }
            else
            {
                navigator.Text = $"Navigator Version: { NoFileFound() }";
            }
        }
    }
}