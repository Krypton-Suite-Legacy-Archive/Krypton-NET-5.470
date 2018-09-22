using Krypton.Toolkit;
using PaletteUpgradeTool.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace PaletteUpgradeTool.UI
{
    public partial class PaletteUpgradeTool : KryptonForm
    {
        #region Variables
        private const int MINIMUM_VERSION_NUMBER = 2, MAXIMUM_VERSION_NUMBER = 17;

        private int _inputVersionNumber;

        private bool _modificationDetected = false;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets the input version number.
        /// </summary>
        /// <value>
        /// The input version number.
        /// </value>
        public int InputVersionNumber
        {
            get
            {
                return _inputVersionNumber;
            }

            set
            {
                _inputVersionNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [modification detected].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [modification detected]; otherwise, <c>false</c>.
        /// </value>
        public bool ModificationDetected
        {
            get
            {
                return _modificationDetected;
            }

            set
            {
                _modificationDetected = value;
            }
        }
        #endregion

        #region Constructors        
        /// <summary>
        /// Initialises a new instance of the <see cref="PaletteUpgradeTool"/> class.
        /// </summary>
        public PaletteUpgradeTool()
        {
            InitializeComponent();

            SetInputVersionNumber(-1);

            UpdateState();
        }
        #endregion

        #region Event Handlers        
        /// <summary>
        /// Handles the Click event of the kbtnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the Click event of the kbtnUpgrade control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnUpgrade_Click(object sender, EventArgs e)
        {
            try
            {
                SetModificationDetected(true);

                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();

                xslCompiledTransform.Load(new XmlTextReader(new StringReader(Resources.v2to6)));

                XslCompiledTransform xslCompiledTransform1 = new XslCompiledTransform();

                xslCompiledTransform1.Load(new XmlTextReader(new StreamReader(Resources.v6to18)));

                StreamReader reader = new StreamReader(krtbInput.Text);

                string end = reader.ReadToEnd();

                reader.Close();

                if (GetInputVersionNumber() < 6)
                {
                    end = TransformXml(xslCompiledTransform, end);
                }
                else if (GetInputVersionNumber() < 18)
                {
                    end = TransformXml(xslCompiledTransform1, end);
                }

                StreamWriter writer = new StreamWriter(krtbOutput.Text);

                writer.WriteLine("<?xml version=\"1.0\"?>");

                writer.Write(end);

                writer.Flush();

                writer.Close();

                object[] text = new object[] { "Input file: ", krtbInput.Text, "\nOutput file: ", krtbOutput.Text, "\n\nUpgrade from version '", _inputVersionNumber, "' to version '", 18.ToString(), "' has succeeded." };

                KryptonMessageBox.Show(string.Concat(text), "Upgrade Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                kbtnExport.Enabled = true;

                kbtnUpgrade.Enabled = false;
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"Error: { exc.Message }", "Upgrade Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        /// <summary>
        /// Handles the Click event of the kbtnExport control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Save Krypton Palette File:";

            saveFileDialog.Filter = "Krypton Palette XML Files (*.xml)|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);

                if (krtbOutput.Text != string.Empty)
                {
                    streamWriter.Write(krtbOutput.Text);

                    streamWriter.Flush();

                    streamWriter.Close();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the kbtnBrowse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string str;

            openFileDialog.Title = "Open a Existing Krypton Palette File:";

            openFileDialog.Filter = "Krypton Palette XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int paletteFileNumber = GetPaletteFileNumber(openFileDialog.FileName);

                if (paletteFileNumber == -1)
                {
                    KryptonMessageBox.Show($"File: '{ openFileDialog.FileName }' does not contain a valid palette definition.", "Select Palette", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (paletteFileNumber < 2)
                {
                    string[] fileName = new string[] { "File '", openFileDialog.FileName, "' contains palette format version '", paletteFileNumber.ToString(), "'.\nPalette upgrade tool can only upgrade version '", 2.ToString(), "' and upwards." };

                    KryptonMessageBox.Show(string.Concat(fileName), "Incompatible Version", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (paletteFileNumber <= 17)
                {
                    krtbInput.Text = openFileDialog.FileName;

                    SetInputVersionNumber(paletteFileNumber);

                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                    str = (fileInfo.Name.IndexOf(fileInfo.Extension) <= 0 ? fileInfo.Name : fileInfo.Name.Substring(0, fileInfo.Name.IndexOf(fileInfo.Extension)));

                    string directoryName = fileInfo.DirectoryName;

                    if (!directoryName.EndsWith("\\"))
                    {
                        directoryName = string.Concat(directoryName, "\\");
                    }

                    KryptonRichTextBox richTextBox = krtbOutput;

                    string[] strArrays = new string[] { directoryName, str, "_v", 18.ToString(), fileInfo.Extension };

                    richTextBox.Text = string.Concat(strArrays);
                }
                else
                {
                    string[] fileName1 = new string[] { "File '", openFileDialog.FileName, "' contains palette format version '", paletteFileNumber.ToString(), "'.\nPalette upgrade tool can only upgrade version '", 17.ToString(), "' and below." };

                    KryptonMessageBox.Show(string.Concat(fileName1), "Incompatible Version", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                UpdateState();
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the krtbOutput control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void krtbOutput_TextChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        /// <summary>
        /// Handles the FormClosing event of the PaletteUpgradeTool control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void PaletteUpgradeTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApplication();
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the InputVersionNumber to the value of value.
        /// </summary>
        /// <param name="value">The desired value of InputVersionNumber.</param>
        private void SetInputVersionNumber(int value)
        {
            InputVersionNumber = value;
        }

        /// <summary>
        /// Returns the value of the InputVersionNumber.
        /// </summary>
        /// <returns>The value of the InputVersionNumber.</returns>
        private int GetInputVersionNumber()
        {
            return InputVersionNumber;
        }

        /// <summary>
        /// Sets the ModificationDetected to the value of value.
        /// </summary>
        /// <param name="value">The desired value of ModificationDetected.</param>
        private void SetModificationDetected(bool value)
        {
            ModificationDetected = value;
        }

        /// <summary>
        /// Returns the value of the ModificationDetected.
        /// </summary>
        /// <returns>The value of the ModificationDetected.</returns>
        private bool GetModificationDetected()
        {
            return ModificationDetected;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Gets the palette file number.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        private int GetPaletteFileNumber(string fileName)
        {
            try
            {
                XPathNavigator xPathNavigator = (new XPathDocument(fileName)).CreateNavigator().SelectSingleNode("KryptonPalette");

                if (xPathNavigator != null)
                {
                    string attribute = xPathNavigator.GetAttribute("Version", string.Empty);

                    if (attribute != null && attribute.Length > 0)
                    {
                        return int.Parse(attribute);
                    }
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"Error: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;
        }

        /// <summary>
        /// Transforms the XML.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="xml">The XML.</param>
        /// <returns></returns>
        private string TransformXml(XslCompiledTransform transform, string xml)
        {
            StringReader reader = new StringReader(xml);

            StringWriter writer = new StringWriter();

            XmlTextReader xmlTextReader = new XmlTextReader(reader);

            XmlTextWriter xmlTextWriter = new XmlTextWriter(writer)
            {
                Formatting = Formatting.Indented,
                Indentation = 4
            };

            transform.Transform(xmlTextReader, xmlTextWriter);

            return writer.ToString();
        }

        /// <summary>
        /// Updates the UI state.
        /// </summary>
        private void UpdateState()
        {
            bool length = krtbInput.Text.Length > 0, flag0 = ValidOutputDirectory(krtbOutput.Text), flag1 = ValidOutputDirectory(krtbOutput.Text), flag2 = (GetInputVersionNumber() < 2 ? false : GetInputVersionNumber() <= 17);

            kbtnUpgrade.Enabled = (!length || !flag0 || !flag1 ? false : flag2);

            if (kbtnUpgrade.Enabled)
            {
                klblStatus.ForeColor = Color.Green;

                int num = 18;

                klblStatus.Text = $"Convert to output version ' { num.ToString() }'.";

                return;
            }

            if (!length)
            {
                klblStatus.Text = "You must select a valid input file.";
            }
            else if (!flag0)
            {
                klblStatus.Text = "Must select a valid output directory.";
            }
            else if (!flag1)
            {
                klblStatus.Text = "Must select a valid output filename.";
            }
            else if (flag2)
            {
                klblStatus.Text = "Must select valid input and output files.";
            }
            else
            {
                klblStatus.Text = "Input file format version cannot be upgraded.";
            }

            klblStatus.ForeColor = Color.Red;
        }

        /// <summary>
        /// Validates the output directory.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        private bool ValidOutputDirectory(string filename)
        {
            try
            {
                if ((new DirectoryInfo((new FileInfo(filename)).DirectoryName)).Exists)
                {
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        /// <summary>
        /// Validates the output filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        private bool ValidOutputFilename(string filename)
        {
            bool flag;
            try
            {
                FileInfo fileInfo = new FileInfo(filename);
                flag = (!fileInfo.Exists || !fileInfo.IsReadOnly ? true : false);
            }
            catch
            {
                return false;
            }
            return flag;
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void ExitApplication()
        {
            if (GetModificationDetected())
            {
                if (KryptonMessageBox.Show("The converted palette file has not been saved. Save now?", "Save Palette File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kbtnExport.PerformClick();
                }
            }
            // App will now close as the close_form called this !
        }
        #endregion
    }
}
