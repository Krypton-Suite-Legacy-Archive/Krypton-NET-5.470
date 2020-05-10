﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2018 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace PaletteDesigner
{
    public partial class FormChromeTMS : KryptonForm
    {
        #region Identity
        public FormChromeTMS()
        {
            InitializeComponent();
        }
        #endregion

        #region Public
        public ToolStripRenderer OverrideToolStripRenderer
        {
            set
            {
                // Apply the new toolstrip renderer to the design page controls
                tmsMenuStrip.Renderer = value;
                tmsStatusStrip.Renderer = value;
                tmsToolStrip.Renderer = value;
                tmsToolStripContainer.TopToolStripPanel.Renderer = value;
                tmsToolStripContainer.BottomToolStripPanel.Renderer = value;
                tmsToolStripContainer.LeftToolStripPanel.Renderer = value;
                tmsToolStripContainer.RightToolStripPanel.Renderer = value;
                tmsToolStripContainer.ContentPanel.Renderer = value;
            }
        }
        #endregion
    }
}
