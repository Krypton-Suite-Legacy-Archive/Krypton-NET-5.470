// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Megakraken & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Multiline String Editor Window.
    /// </summary>
    public class MultilineStringEditor : Form
    {
        private bool _saveChanges = true;
        private readonly KryptonTextBox _textBox;
        private readonly KryptonTextBox _owner;

        /// <summary>
        /// Initializes a new instance of the MultilineStringEditor class.
        /// </summary>
        /// <param name="owner"></param>
        public MultilineStringEditor(KryptonTextBox owner)
        {
            SuspendLayout();
            _textBox = new KryptonTextBox {Dock = DockStyle.Fill, Multiline = true};
            _textBox.KeyDown += OnKeyDownTextBox;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 262);
            ControlBox = false;
            Controls.Add(_textBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            _owner = owner;
            ResumeLayout(false);
        }

        /// <summary>
        /// Shows the multiline string editor.
        /// </summary>
        public void ShowEditor()
        {
            Location = _owner.PointToScreen(Point.Empty);
            _textBox.Text = _owner.Text;
            Show();
        }

        /// <summary>
        /// Closes the multiline string editor.
        /// </summary>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            CloseEditor();
        }

        private void CloseEditor()
        {
            if (_saveChanges)
            {
                _owner.Text = _textBox.Text;
            }

            Close();
        }

        private void OnKeyDownTextBox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _saveChanges = false;
                CloseEditor();
            }
        }
    }
}