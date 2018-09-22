﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2018, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Displays an input box for the user.
    /// </summary>
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(KryptonInputBox), "ToolboxBitmaps.KryptonInputBox.bmp")]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KryptonInputBox : KryptonForm
    {
        #region Static Fields

        private const int GAP = 10;

        #endregion

        #region Instance Fields
        private readonly string _prompt;
        private readonly string _caption;
        private readonly string _defaultResponse;
        private KryptonPanel _panelMessage;
        private KryptonWrapLabel _labelPrompt;
        private KryptonTextBox _textBoxResponse;
        private KryptonButton _buttonOK;
        private KryptonButton _buttonCancel;
        #endregion

        #region Identity
        private KryptonInputBox(string prompt, 
                                string caption,
                                string defaultResposne)
        {
            // Store incoming values
            _prompt = prompt;
            _caption = caption;
            _defaultResponse = defaultResposne;

            // Create the form contents
            InitializeComponent();

            // Update contents to match requirements
            UpdateText();
            UpdateButtons();

            // Finally calculate and set form sizing
            UpdateSizing();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Public
        /// <summary>
        /// Displays an input box with the provided prompt.
        /// </summary>
        /// <param name="prompt">The text to display as an input prompt.</param>
        /// <returns>Input string.</returns>
        public static string Show(string prompt)
        {
            return InternalShow(null, prompt, string.Empty, string.Empty);
        }

        /// <summary>
        /// Displays an input box in front of the specified object and with the provided prompt.
        /// </summary>
        /// <param name="owner">Owner of the modal dialog box.</param>
        /// <param name="prompt">The text to display as an input prompt.</param>
        /// <returns>Input string.</returns>
        public static string Show(IWin32Window owner, string prompt)
        {
            return InternalShow(owner, prompt, string.Empty, string.Empty);
        }

        /// <summary>
        /// Displays an input box with provided prompt and caption.
        /// </summary>
        /// <param name="prompt">The text to display as an input prompt.</param>
        /// <param name="caption">The text to display in the title bar of the input box.</param>
        /// <returns>Input string.</returns>
        public static string Show(string prompt, string caption)
        {
            return InternalShow(null, prompt, caption, string.Empty);
        }

        /// <summary>
        /// Displays an input box in front of the specified object and with the provided prompt and caption.
        /// </summary>
        /// <param name="owner">Owner of the modal dialog box.</param>
        /// <param name="prompt">The text to display as an input prompt.</param>
        /// <param name="caption">The text to display in the title bar of the input box.</param>
        /// <returns>Input string.</returns>
        public static string Show(IWin32Window owner, string prompt, string caption)
        {
            return InternalShow(owner, prompt, caption, string.Empty);
        }

        /// <summary>
        /// Displays an input box with provided prompt and caption and defaulted response string.
        /// </summary>
        /// <param name="prompt">The text to display as an input prompt.</param>
        /// <param name="caption">The text to display in the title bar of the input box.</param>
        /// <param name="defaultResponse">Default response text..</param>
        /// <returns>Input string.</returns>
        public static string Show(string prompt, string caption, string defaultResponse)
        {
            return InternalShow(null, prompt, caption, defaultResponse);
        }
        
        /// <summary>
        /// DDisplays an input box in front of the specified object and with the provided prompt and caption and defaulted response string.
        /// </summary>
        /// <param name="owner">Owner of the modal dialog box.</param>
        /// <param name="prompt">The text to display as an input prompt.</param>
        /// <param name="caption">The text to display in the title bar of the input box.</param>
        /// <param name="defaultResponse">Default response text..</param>
        /// <returns>Input string.</returns>
        public static string Show(IWin32Window owner, string prompt, string caption, string defaultResponse)
        {
            return InternalShow(owner, prompt, caption, defaultResponse);
        }
        #endregion

        #region Implementation
        private static string InternalShow(IWin32Window owner,
                                           string prompt, 
                                           string caption,
                                           string defaultResponse)
        {
            // If do not have an owner passed in then get the active window and use that instead
            IWin32Window showOwner = owner ?? FromHandle(PI.GetActiveWindow());

            // Show input box window as a modal dialog and then dispose of it afterwards
            using (KryptonInputBox ib = new KryptonInputBox(prompt, caption, defaultResponse))
            {
                ib.StartPosition = showOwner == null ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;

                return ib.ShowDialog(showOwner) == DialogResult.OK ? ib.InputResponse : string.Empty;
            }
        }

        internal string InputResponse => _textBoxResponse.Text;

        private void UpdateText()
        {
            Text = _caption;
            _labelPrompt.Text = _prompt;
            _textBoxResponse.Text = _defaultResponse;
        }

        private void UpdateButtons()
        {
            _buttonOK.Text = KryptonManager.Strings.OK;
            _buttonCancel.Text = KryptonManager.Strings.Cancel;
        }

        private void UpdateSizing()
        {
            Size buttonSize = UpdateButtonSizing();
            Size promptSize = UpdatePromptSizing();
            Size responseSize = UpdateResponseSizing();
            ClientSize = new Size(_buttonCancel.Right + GAP, _textBoxResponse.Bottom + GAP);
        }

        private Size UpdatePromptSizing()
        {
            // Update size of the message label but with a maximum width
            using (Graphics g = CreateGraphics())
            {
                // Find size of the label when it has a maximum length of 250, this tells us the height
                // required to fully show the label with the prompt.
                _labelPrompt.UpdateFont();
                Size messageSize = g.MeasureString(_prompt, _labelPrompt.Font, 250).ToSize();

                // Work out DPI adjustment factor
                float factorX = g.DpiX > 96 ? ((1.0f * g.DpiX) / 96) : 1.0f;
                float factorY = g.DpiY > 96 ? ((1.0f * g.DpiY) / 96) : 1.0f;
                messageSize.Width = (int)(messageSize.Width * factorX);
                messageSize.Height = (int)(messageSize.Height * factorY);
                
                _labelPrompt.Location = new Point(GAP, GAP);
                _labelPrompt.Size = new Size(255, Math.Max(messageSize.Height, _buttonCancel.Bottom - _buttonOK.Top));

                return new Size(_labelPrompt.Right, _labelPrompt.Bottom);
            }
        }

        private Size UpdateButtonSizing()
        {
            Size buttonOKSize = _buttonOK.GetPreferredSize(Size.Empty);
            Size buttonCancelSize = _buttonCancel.GetPreferredSize(Size.Empty);

            // Make both buttons the size of the largest one
            Size largestButton = new Size(Math.Max(buttonOKSize.Width, buttonCancelSize.Width), Math.Max(buttonOKSize.Height, buttonCancelSize.Height));
            _buttonOK.Size = largestButton;
            _buttonCancel.Size = largestButton;

            // Position the buttons relative to the top left of the owning panel
            _buttonOK.Location = new Point(_panelMessage.Right - _buttonOK.Width - GAP, GAP);
            _buttonCancel.Location = new Point(_panelMessage.Right - _buttonCancel.Width - GAP, _buttonOK.Bottom + (GAP / 2));

            // We need enough space for the buttons and gaps on either size
            return new Size(_buttonOK.Left + GAP, _buttonCancel.Bottom + GAP);
        }

        private Size UpdateResponseSizing()
        {
            // Position the reponse text box below the prompt
            _textBoxResponse.Location = new Point(GAP, _labelPrompt.Bottom + GAP);
            _textBoxResponse.Width = _buttonOK.Right - _textBoxResponse.Left;
            return _textBoxResponse.Size;
        }

        private void button_keyDown(object sender, KeyEventArgs e)
        {
            // Escape key kills the dialog if we allow it to be closed
            if ((e.KeyCode == Keys.Escape) && ControlBox)
            {
                Close();
            }
        }

        private void InitializeComponent()
        {
            _panelMessage = new KryptonPanel();
            _textBoxResponse = new KryptonTextBox();
            _labelPrompt = new KryptonWrapLabel();
            _buttonCancel = new KryptonButton();
            _buttonOK = new KryptonButton();
            ((ISupportInitialize)(_panelMessage)).BeginInit();
            _panelMessage.SuspendLayout();
            SuspendLayout();
            // 
            // _panelMessage
            // 
            _panelMessage.Controls.Add(_textBoxResponse);
            _panelMessage.Controls.Add(_labelPrompt);
            _panelMessage.Controls.Add(_buttonCancel);
            _panelMessage.Controls.Add(_buttonOK);
            _panelMessage.Dock = DockStyle.Fill;
            _panelMessage.Location = new Point(0, 0);
            _panelMessage.Name = "_panelMessage";
            _panelMessage.Size = new Size(357, 118);
            _panelMessage.TabIndex = 0;
            // 
            // _textBoxResponse
            // 
            _textBoxResponse.Location = new Point(12, 86);
            _textBoxResponse.Name = "_textBoxResponse";
            _textBoxResponse.Size = new Size(333, 20);
            _textBoxResponse.TabIndex = 0;
            // 
            // _labelPrompt
            // 
            _labelPrompt.AutoSize = false;
            _labelPrompt.Font = new Font("Segoe UI", 9F);
            _labelPrompt.ForeColor = Color.FromArgb(30, 57, 91);
            _labelPrompt.LabelStyle = LabelStyle.NormalPanel;
            _labelPrompt.Location = new Point(12, 12);
            _labelPrompt.Margin = new Padding(0);
            _labelPrompt.Name = "_labelPrompt";
            _labelPrompt.Size = new Size(78, 15);
            _labelPrompt.Text = "Prompt";
            // 
            // _buttonCancel
            // 
            _buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _buttonCancel.AutoSize = true;
            _buttonCancel.DialogResult = DialogResult.Cancel;
            _buttonCancel.Location = new Point(295, 43);
            _buttonCancel.Margin = new Padding(0);
            _buttonCancel.MinimumSize = new Size(50, 26);
            _buttonCancel.Name = "_buttonCancel";
            _buttonCancel.Size = new Size(50, 26);
            _buttonCancel.TabIndex = 2;
            _buttonCancel.Values.Text = "Cancel";
            _buttonCancel.KeyDown += button_keyDown;
            // 
            // _buttonOK
            // 
            _buttonOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _buttonOK.AutoSize = true;
            _buttonOK.DialogResult = DialogResult.OK;
            _buttonOK.Location = new Point(295, 12);
            _buttonOK.Margin = new Padding(0);
            _buttonOK.MinimumSize = new Size(50, 26);
            _buttonOK.Name = "_buttonOK";
            _buttonOK.Size = new Size(50, 26);
            _buttonOK.TabIndex = 1;
            _buttonOK.Values.Text = "OK";
            _buttonOK.KeyDown += button_keyDown;
            // 
            // KryptonInputBox
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 118);
            Controls.Add(_panelMessage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KryptonInputBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            ((ISupportInitialize)(_panelMessage)).EndInit();
            _panelMessage.ResumeLayout(false);
            _panelMessage.PerformLayout();
            ResumeLayout(false);

        }
        #endregion
    }
}
