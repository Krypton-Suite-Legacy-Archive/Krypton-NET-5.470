// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Helper routines for interacting with the Desktop Window Manager.
    /// </summary>
    public class DWM
    {
        #region Static Methods
        /// <summary>
        /// Is composition currently enabled for the deskop.
        /// </summary>
        public static bool IsCompositionEnabled
        {
            get
            {
                // Desktop composition is only available on Vista upwards
                if (Environment.OSVersion.Version.Major < 6)
                {
                    return false;
                }
                else if (Environment.OSVersion.Version.Major < 10)
                {
                    // Ask the desktop window manager is composition is currently enabled
                    bool compositionEnabled = false;
                    PI.DwmIsCompositionEnabled(ref compositionEnabled);
                    return compositionEnabled;
                }
                else //Win 10
                {
                    return UserSystemPreferencesService.IsTransparencyEnabled;
                }
            }
        }

        /// <summary>
        /// Change the distance the frame extends into the client area.
        /// </summary>
        /// <param name="hWnd">Window handle of form.</param>
        /// <param name="padding">Distance for each form edge.</param>
        public static void ExtendFrameIntoClientArea(IntPtr hWnd, Padding padding)
        {
            Debug.Assert(hWnd != null);

            // Cerate structure that contains distances for each edge
            PI.MARGINS margins = new PI.MARGINS
            {
                leftWidth = padding.Left,
                topHeight = padding.Top,
                rightWidth = padding.Right,
                bottomHeight = padding.Bottom
            };

            // Request change from the desktop window manager
            PI.DwmExtendFrameIntoClientArea(hWnd, ref margins);
        }
        #endregion
    }
}
