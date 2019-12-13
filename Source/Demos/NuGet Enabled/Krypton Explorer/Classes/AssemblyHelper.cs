using System.Diagnostics;

namespace KryptonExplorer.Classes
{
    public class AssemblyHelper
    {
        public AssemblyHelper()
        {

        }

        /// <summary>Gets the file version information.</summary>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <returns></returns>
        public static FileVersionInfo GetFileVersionInformation(string assemblyPath) => FileVersionInfo.GetVersionInfo(assemblyPath);
    }
}