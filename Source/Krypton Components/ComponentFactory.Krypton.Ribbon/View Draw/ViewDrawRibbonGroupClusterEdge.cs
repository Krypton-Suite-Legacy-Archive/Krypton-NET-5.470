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
using System.Windows.Forms;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
	/// <summary>
	/// Draws a border edge but with a lighter inside area.
	/// </summary>
    internal class ViewDrawRibbonGroupClusterEdge : ViewDrawBorderEdge
    {
        #region Instance Fields
        private readonly KryptonRibbon _ribbon;
        private readonly PaletteBorderEdge _palette;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawRibbonGroupClusterEdge class.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon..</param>
        /// <param name="palette">Palette source for drawing details.</param>
        public ViewDrawRibbonGroupClusterEdge(KryptonRibbon ribbon,
                                              PaletteBorderEdge palette)
            : base(palette, Orientation.Vertical)
        {
            Debug.Assert(ribbon != null);
            Debug.Assert(palette != null);

            _ribbon = ribbon;
            _palette = palette;
        }
        #endregion

        #region Paint
        /// <summary>
        /// Perform rendering before child elements are rendered.
        /// </summary>
        /// <param name="context">Rendering context.</param>
        public override void RenderBefore(RenderContext context)
        {
            // Let base class perform standard drawing first
            base.RenderBefore(context);

            Rectangle drawRect = new Rectangle(ClientLocation.X, 
                                               ClientLocation.Y + ClientWidth, 
                                               ClientWidth, 
                                               ClientHeight - (ClientWidth * 2));

            context.Renderer.RenderRibbon.DrawRibbonClusterEdge(_ribbon.RibbonShape, context, drawRect, _palette, State);
        }
        #endregion
    }
}
