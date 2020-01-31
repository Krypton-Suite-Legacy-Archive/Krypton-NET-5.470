using System.Windows.Forms;

namespace KryptonToolkitHub.Classes
{
    public class ExceptionHandler
    {
        #region Constructor
        public ExceptionHandler()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Shows the exception output.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <param name="title">The title.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="exeptionType">Type of the exeption.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <param name="useKryptonMessageBoxes">if set to <c>true</c> [use krypton message boxes].</param>
        public static void ShowExceptionOutput(string content, string title, MessageBoxButtons buttons, MessageBoxIcon exeptionType, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1, bool useKryptonMessageBoxes = true)
        {
            if (useKryptonMessageBoxes)
            {
                switch (exeptionType)
                {
                    case MessageBoxIcon.None:
                        break;
                    case MessageBoxIcon.Hand:
                        break;
                    case MessageBoxIcon.Question:
                        break;
                    case MessageBoxIcon.Exclamation:
                        break;
                    case MessageBoxIcon.Asterisk:
                        break;
                    //case MessageBoxIcon.Stop:
                    //    break;
                    //case MessageBoxIcon.Error:
                    //    break;
                    //case MessageBoxIcon.Warning:
                    //    break;
                    //case MessageBoxIcon.Information:
                    //    break;
                    default:
                        break;
                }
            }
            else
            {
                switch (exeptionType)
                {
                    case MessageBoxIcon.None:
                        break;
                    case MessageBoxIcon.Hand:
                        break;
                    case MessageBoxIcon.Question:
                        break;
                    case MessageBoxIcon.Exclamation:
                        break;
                    case MessageBoxIcon.Asterisk:
                        break;
                    //case MessageBoxIcon.Stop:
                    //    break;
                    //case MessageBoxIcon.Error:
                    //    break;
                    //case MessageBoxIcon.Warning:
                    //    break;
                    //case MessageBoxIcon.Information:
                    //    break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}