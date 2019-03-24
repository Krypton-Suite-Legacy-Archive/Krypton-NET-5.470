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
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// A simple hex-editor form for displaying binary data.
    /// </summary>
    public class ByteViewerForm : KryptonForm
    {
        #region Instance Members
        KryptonByteViewer _byteViewer;
        IContainer components;
        #endregion

        #region Identity
        /// <summary>
        /// Initializes a new instance of the ByteViewerForm class.
        /// </summary>
        public ByteViewerForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Protected Overrides
        /// <summary>
        /// Raises the Load event.
        /// </summary>
        /// <param name="e">
        /// The event arguments.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // We re-use the Tag property as input/output mechanism, so we don't have to create
            // a new interface just for that. Kind of a hack, I know.
            if (Tag is byte[] bytes)
            {
                _byteViewer.SetBytes(bytes);
            }
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Private
        private void OnCheckedButtonChanged(object sender, EventArgs e)
        {
            KryptonCheckSet checkset = (KryptonCheckSet)sender;
            DisplayMode mode;
            switch (checkset.CheckedButton.Text)
            {
                case "ANSI":
                    mode = DisplayMode.Ansi;
                    break;
                case "Hex":
                    mode = DisplayMode.Hexdump;
                    break;
                case "Unicode":
                    mode = DisplayMode.Unicode;
                    break;
                default:
                    mode = DisplayMode.Auto;
                    break;
            }
            // Sets the display mode.
            if (_byteViewer != null && _byteViewer.GetDisplayMode() != mode)
                _byteViewer.SetDisplayMode(mode);
        }

        /// <summary>
        /// Initializes the Form's components.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();

            _byteViewer = new KryptonByteViewer();
            KryptonPanel bottomPanel = new KryptonPanel();
            KryptonPanel topPanel = new KryptonPanel();
            KryptonGroupBox groupBox = new KryptonGroupBox();
            KryptonCheckButton unicodeButton = new KryptonCheckButton();
            KryptonCheckButton hexButton = new KryptonCheckButton();
            KryptonCheckButton ansiButton = new KryptonCheckButton();
            KryptonCheckButton autoButton = new KryptonCheckButton();
            KryptonCheckSet displayModeCheckset = new KryptonCheckSet(components);
            ((ISupportInitialize)(topPanel)).BeginInit();
            topPanel.SuspendLayout();
            ((ISupportInitialize)(groupBox)).BeginInit();
            groupBox.Panel.BeginInit();
            groupBox.Panel.SuspendLayout();
            groupBox.SuspendLayout();
            ((ISupportInitialize)(displayModeCheckset)).BeginInit();
            ((ISupportInitialize)(bottomPanel)).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.AutoSize = true;
            topPanel.Controls.Add(groupBox);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(5);
            topPanel.Size = new System.Drawing.Size(639, 65);
            topPanel.TabIndex = 0;
            // 
            // groupBox
            // 
            groupBox.AutoSize = true;
            groupBox.Location = new System.Drawing.Point(5, 0);
            groupBox.Name = "groupBox";
            // 
            // groupBox.Panel
            // 
            groupBox.Panel.Controls.Add(unicodeButton);
            groupBox.Panel.Controls.Add(hexButton);
            groupBox.Panel.Controls.Add(ansiButton);
            groupBox.Panel.Controls.Add(autoButton);
            groupBox.Size = new System.Drawing.Size(280, 57);
            groupBox.TabIndex = 0;
            groupBox.Values.Heading = @"Display Mode";
            // 
            // unicodeButton
            // 
            unicodeButton.Location = new System.Drawing.Point(210, 3);
            unicodeButton.Name = "unicodeButton";
            unicodeButton.Size = new System.Drawing.Size(63, 25);
            unicodeButton.TabIndex = 3;
            unicodeButton.Values.Text = @"Unicode";
            // 
            // hexButton
            // 
            hexButton.Location = new System.Drawing.Point(141, 3);
            hexButton.Name = "hexButton";
            hexButton.Size = new System.Drawing.Size(63, 25);
            hexButton.TabIndex = 2;
            hexButton.Values.Text = @"Hex";
            // 
            // ansiButton
            // 
            ansiButton.Location = new System.Drawing.Point(72, 3);
            ansiButton.Name = "ansiButton";
            ansiButton.Size = new System.Drawing.Size(63, 25);
            ansiButton.TabIndex = 1;
            ansiButton.Values.Text = @"ANSI";
            // 
            // autoButton
            // 
            autoButton.Checked = true;
            autoButton.Location = new System.Drawing.Point(3, 3);
            autoButton.Name = "autoButton";
            autoButton.Size = new System.Drawing.Size(63, 25);
            autoButton.TabIndex = 0;
            autoButton.Values.Text = @"Auto";
            // 
            // displayModeCheckset
            // 
            displayModeCheckset.CheckButtons.Add(autoButton);
            displayModeCheckset.CheckButtons.Add(ansiButton);
            displayModeCheckset.CheckButtons.Add(hexButton);
            displayModeCheckset.CheckButtons.Add(unicodeButton);
            displayModeCheckset.CheckedButton = autoButton;
            displayModeCheckset.CheckedButtonChanged += OnCheckedButtonChanged;
            // 
            // bottomPanel
            // 
            bottomPanel.Dock = DockStyle.Fill;
            bottomPanel.Location = new System.Drawing.Point(0, 65);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new System.Drawing.Size(639, 401);
            bottomPanel.TabIndex = 1;
            bottomPanel.Controls.Add(_byteViewer);
            //
            // byteViewer
            //
            _byteViewer.Dock = DockStyle.Fill;
            _byteViewer.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(639, 466);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            Name = @"BinaryViewer";
            Text = @"Binary Viewer";
            ((ISupportInitialize)(topPanel)).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            groupBox.Panel.EndInit();
            groupBox.Panel.ResumeLayout(false);
            ((ISupportInitialize)(groupBox)).EndInit();
            groupBox.ResumeLayout(false);
            ((ISupportInitialize)(displayModeCheckset)).EndInit();
            ((ISupportInitialize)(bottomPanel)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
