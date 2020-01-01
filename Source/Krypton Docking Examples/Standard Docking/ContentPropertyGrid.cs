// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012 - 2019. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2020. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
//
// *****************************************************************************

using System;
using System.Drawing;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace StandardDocking
{
    public partial class ContentPropertyGrid : UserControl
    {
        public ContentPropertyGrid()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // Unhook from events so this control can be garbage collected
            KryptonManager.GlobalPaletteChanged -= OnGlobalPaletteChanged;

            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void ContentPropertyGrid_Load(object sender, EventArgs e)
        {
            // Hook into global palette changes
            KryptonManager.GlobalPaletteChanged += OnGlobalPaletteChanged;

            // Set correct initial font for the property grid
            OnGlobalPaletteChanged(null, EventArgs.Empty);
        }

        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            // Use the current font from the global palette
            IPalette palette = KryptonManager.CurrentGlobalPalette;
            Font font = palette.GetContentShortTextFont(PaletteContentStyle.LabelNormalControl, PaletteState.Normal);
            propertyGrid1.Font = font;
        }
    }
}
