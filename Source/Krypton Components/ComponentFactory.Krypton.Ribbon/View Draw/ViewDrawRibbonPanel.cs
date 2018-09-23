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
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
	/// <summary>
	/// Draws the ribbon background panel.
	/// </summary>
    internal class ViewDrawRibbonPanel : ViewDrawPanel
    {
        #region Static Fields

        private const int EDGE_GAP = 1;

        #endregion

        #region Instance Fields
        private readonly KryptonRibbon _ribbon;
        private readonly NeedPaintHandler _paintDelegate;
        private readonly Blend _compBlend;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawRibbonPanel class.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon instance.</param>
        /// <param name="paletteBack">Reference to palette for obtaining background colors.</param>
        /// <param name="paintDelegate">Delegate for generating repaints.</param>
        public ViewDrawRibbonPanel(KryptonRibbon ribbon,
                                   IPaletteBack paletteBack,
                                   NeedPaintHandler paintDelegate)
            : base(paletteBack)
        {
            _ribbon = ribbon;
            _paintDelegate = paintDelegate;

            _compBlend = new Blend
            {
                //_compBlend.Positions = new float[] { 0.0f, 0.4f, 1.0f };
                //_compBlend.Factors = new float[] { 0.0f, 0.87f, 1.0f };
                Positions = new float[] { 0.0f, 0.2f, 0.4f, 0.6f, 0.8f, 1.0f },
                Factors = new float[] { 0.0f, 0.10f, 0.25f, 0.50f, 0.70f, 0.80f }
            };
        }
        #endregion

        #region Paint
        /// <summary>
        /// Perform rendering before child elements are rendered.
        /// </summary>
        /// <param name="context">Rendering context.</param>
        public override void RenderBefore(RenderContext context)
        {
            // If we are rendering using desktop window composition and using the Office 2010 shape 
            // of ribbon then we need to draw the tabs area as part of the window chromw
            if (DrawOnComposition && (_ribbon.RibbonShape == PaletteRibbonShape.Office2010 || _ribbon.RibbonShape == PaletteRibbonShape.Office2013))
            {
                int tabsHeight = _ribbon.TabsArea.ClientHeight;

                // Clip to prevent drawing over the tabs area
                using (Clipping clip = new Clipping(context.Graphics, new Rectangle(ClientLocation.X, ClientLocation.Y + tabsHeight, ClientWidth, ClientHeight - tabsHeight)))
                {
                    base.RenderBefore(context);
                }

                //context.Graphics.DrawRectangle(new Pen(Color.Blue), new Rectangle(ClientLocation.X, ClientLocation.Y, ClientWidth, tabsHeight));
                PaintRectangle(context.Graphics, new Rectangle(ClientLocation.X, ClientLocation.Y, ClientWidth, tabsHeight), true, null);
            }
            else
            {
                base.RenderBefore(context);
            }
        }

        /// <summary>
        /// Paint the provided rectangle.
        /// </summary>
        /// <param name="g">Graphics to use for drawing.</param>
        /// <param name="rect">Rectangle to be drawn.</param>
        /// <param name="edges">True if the edges needs to be drawn.</param>
        /// <param name="sender">Sender of the message..</param>
        public void PaintRectangle(Graphics g, Rectangle rect, bool edges, Control sender)
        {
            // If we are rendering using desktop window composition and using the Office 2010 shape 
            // of ribbon then we need to draw the tabs area as part of the window chrome
            // Not for 2013
            if (DrawOnComposition && (_ribbon.RibbonShape == PaletteRibbonShape.Office2010 || _ribbon.RibbonShape == PaletteRibbonShape.Office2013))
            {
                if (edges)
                {
                    rect.X += EDGE_GAP;
                    rect.Width -= EDGE_GAP * 2;
                }
                else if ((sender != null) && !_ribbon.MinimizedMode)
                {
                    using (ViewDrawRibbonGroupsBorder border = new ViewDrawRibbonGroupsBorder(_ribbon, false, _paintDelegate))
                    {
                        border.ClientRectangle = new Rectangle(-sender.Location.X, rect.Bottom - 1, _ribbon.Width, 10);
                        using (RenderContext context = new RenderContext(_ribbon, g, rect, _ribbon.Renderer))
                        {
                            border.Render(context);
                        }
                    }
                }

                if (_ribbon.RibbonShape == PaletteRibbonShape.Office2010)
                {
                    //Adjust Color of the gradient
                    Color gradientColor = KryptonManager.CurrentGlobalPalette == KryptonManager.PaletteOffice2010Black
                        ? Color.FromArgb(39, 39, 39)
                        : Color.White;

                    using (LinearGradientBrush backBrush = new LinearGradientBrush(new Rectangle(rect.X, rect.Y - 1, rect.Width, rect.Height + 1), Color.Transparent, gradientColor, 90f))
                    {
                        backBrush.Blend = _compBlend;
                        g.FillRectangle(backBrush, new Rectangle(rect.X, rect.Y, rect.Width, rect.Height - 1));
                    }
                }
                else if (_ribbon.RibbonShape == PaletteRibbonShape.Office2013)
                {
                    using (SolidBrush backBrush = new SolidBrush(Color.White))
                    {
                        g.FillRectangle(backBrush, new Rectangle(rect.X, rect.Y, rect.Width, rect.Height - 1));
                    }
                }
            }
        }
        #endregion

        #region Implementation
        private bool DrawOnComposition => _ribbon != null && _ribbon.CaptionArea.DrawCaptionOnComposition;

        #endregion
    }
}
