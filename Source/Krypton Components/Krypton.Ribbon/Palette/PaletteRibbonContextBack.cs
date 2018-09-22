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

using System.Drawing;
using System.Diagnostics;
using Krypton.Toolkit;

namespace Krypton.Ribbon
{
	/// <summary>
	/// Return inhertied values unless empty in which case return the context color.
	/// </summary>
    public class PaletteRibbonContextBack: IPaletteRibbonBack
    {
        #region Instance Fields
        private readonly KryptonRibbon _ribbon;
        private IPaletteRibbonBack _inherit;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteRibbonContextBack class.
		/// </summary>
        /// <param name="ribbon">Reference to ribbon control.</param>
        public PaletteRibbonContextBack(KryptonRibbon ribbon) 
		{
            Debug.Assert(ribbon != null);
            _ribbon = ribbon;
        }
        #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        public void SetInherit(IPaletteRibbonBack inherit)
        {
            _inherit = inherit;
        }
        #endregion

        #region BackColorStyle
        /// <summary>
        /// Gets the background drawing style for the ribbon item.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public PaletteRibbonColorStyle GetRibbonBackColorStyle(PaletteState state)
        {
            return _inherit.GetRibbonBackColorStyle(state);
        }
        #endregion

        #region BackColor1
        /// <summary>
        /// Gets the first background color for the ribbon item.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetRibbonBackColor1(PaletteState state)
        {
            Color retColor = _inherit.GetRibbonBackColor1(state);

            // If empty then try and recover the context specific color
            if (retColor == Color.Empty)
            {
                retColor = CheckForContextColor(state);
            }

            return retColor;
        }
        #endregion

        #region BackColor2
        /// <summary>
        /// Gets the second background color for the ribbon item.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetRibbonBackColor2(PaletteState state)
        {
            Color retColor = _inherit.GetRibbonBackColor2(state);

            // If empty then try and recover the context specific color
            if (retColor == Color.Empty)
            {
                retColor = CheckForContextColor(state);
            }

            return retColor;
        }
        #endregion

        #region BackColor3
        /// <summary>
        /// Gets the third background color for the ribbon item.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetRibbonBackColor3(PaletteState state)
        {
            Color retColor = _inherit.GetRibbonBackColor3(state);

            // If empty then try and recover the context specific color
            if (retColor == Color.Empty)
            {
                retColor = CheckForContextColor(state);
            }
            else
            {
                if ((state == PaletteState.ContextNormal) ||
                    (state == PaletteState.ContextTracking) ||
                    (state == PaletteState.ContextPressed))
                {
                    // For context drawing we merge the incoming color and the context color
                    Color contextColor = CheckForContextColor(state);
                    return CommonHelper.MergeColors(retColor, 0.5f, contextColor, 0.5f);
                }
            }

            return retColor;
        }
        #endregion

        #region BackColor4
        /// <summary>
        /// Gets the fourth background color for the ribbon item.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetRibbonBackColor4(PaletteState state)
        {
            Color retColor = _inherit.GetRibbonBackColor4(state);

            // If empty then try and recover the context specific color
            if (retColor == Color.Empty)
            {
                retColor = CheckForContextColor(state);
            }

            return retColor;
        }
        #endregion

        #region BackColor5
        /// <summary>
        /// Gets the fifth background color for the ribbon item.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetRibbonBackColor5(PaletteState state)
        {
            Color retColor = _inherit.GetRibbonBackColor5(state);

            // If empty then try and recover the context specific color
            if (retColor == Color.Empty)
            {
                retColor = CheckForContextColor(state);
            }

            return retColor;
        }
        #endregion

        #region Implementation
        private Color CheckForContextColor(PaletteState state)
        {
            // We need an associated ribbon tab
            // Does the ribbon tab have a context setting?
            KryptonRibbonTab selectedTab = _ribbon?.SelectedTab;
            if (!string.IsNullOrEmpty(selectedTab?.ContextName))
            {
                // Find the context definition for this context
                KryptonRibbonContext ribbonContext = _ribbon.RibbonContexts[selectedTab.ContextName];

                // Should always work, but you never know!
                if (ribbonContext != null)
                {
                    return ribbonContext.ContextColor;
                }
            }

            return Color.Empty;
        }
        #endregion
    }
}
