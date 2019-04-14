// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2019 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    internal class VisualShadowBase : Form
    {
        #region Instance Fields
        private readonly ShadowValues _shadowValues;
        private readonly VisualOrientation _visualOrientation;
        private readonly IntPtr _ownerHandle;
        private bool _optimisedVisible;
        private Bitmap _shadowClip;
        #endregion

        #region Identity

        /// <summary>
        /// Create a shadow thingy
        /// </summary>
        /// <param name="shadowValues">What value will be used</param>
        /// <param name="visualOrientation">What orientation for the shadow placement</param>
        /// <param name="kryptonForm"></param>
        public VisualShadowBase(ShadowValues shadowValues, VisualOrientation visualOrientation, IntPtr kryptonForm)
        {
            //Form kryptonFormOwner = kryptonForm.Owner;
            //Owner = kryptonFormOwner;
            _shadowValues = shadowValues;
            _visualOrientation = visualOrientation;
            _ownerHandle = kryptonForm;
            // Update form properties so we do not have a border and do not show
            // in the task bar. We draw the background in Magenta and set that as
            // the transparency key so it is a see through window.
            DoubleBuffered = true;
            StartPosition = FormStartPosition.Manual;
            ShowIcon = false;
            ShowInTaskbar = false;
            Enabled = false;
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            FormBorderStyle = FormBorderStyle.None;
            AccessibleRole = AccessibleRole.None;
            //TransparencyKey = Color.Magenta;
            //BackColor = Color.Transparent;
            ClientSize = new Size(2, 2);
            base.Visible = false;

            _shadowClip = new Bitmap(1, 1);
            // Make the default transparent color transparent for myBitmap.
            _shadowClip.MakeTransparent();
        }

        #endregion

        #region Public
        /// <summary>
        /// Show the window without activating it (i.e. do not take focus)
        /// </summary>
        public new bool Visible
        {
            get => _optimisedVisible;
            set
            {
                if (IsHandleCreated
                    && _optimisedVisible != value
                    )
                {
                    _optimisedVisible = value;
                    if (!value)
                    {
                        PI.ShowWindow(Handle, 0);
                    }
                    else
                    {
                        SetZOrder();
                    }
                }
            }
        }

        internal void SetZOrder()
        {
            PI.SetWindowPos(Handle, _ownerHandle /*hWndInsertAfter*/, TargetRect.X, TargetRect.Y, TargetRect.Width,
                TargetRect.Height,
                PI.SetWindowPosFlags.SWP_NOREDRAW |
                PI.SetWindowPosFlags.SWP_NOACTIVATE |
                PI.SetWindowPosFlags.SWP_SHOWWINDOW
            );
        }

        /// <summary>
        /// 
        /// </summary>
        public Rectangle TargetRect { get; private set; }

        #endregion

        #region Protected
        /// <summary>
        /// Gets the creation parameters.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Parent = _ownerHandle;
                cp.ExStyle |= PI.WS_EX_LAYERED | PI.WS_EX_NOACTIVATE | PI.WS_EX_TRANSPARENT | PI.WS_EX_NOPARENTNOTIFY;
                return cp;
            }
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Calculate the new position, but DO NOT Move
        /// </summary>
        /// <param name="clientLocation">screen location of parent</param>
        /// <param name="windowBounds"></param>
        /// <returns>true, if the position has changed</returns>
        /// <remarks>
        /// Move operations have to be done as a single operation to reduce flickering
        /// </remarks>
        public bool CalcPositionShadowForm(Point clientLocation, Rectangle windowBounds)
        {
            Rectangle rect = CalcRectangle(windowBounds);
            rect.Offset(clientLocation);
            rect.Offset(-_shadowValues.Margins.Left, -_shadowValues.Margins.Top);
            if (TargetRect != rect)
            {
                TargetRect = rect;
                return true;
            }

            return false;
        }


        /// <summary>
        /// Also invalidates to perform a redraw
        /// </summary>
        /// <param name="sourceBitmap">This will be a single bitmap that would represent al the shadows</param>
        /// <param name="windowBounds"></param>
        public void ReCalcShadow(Bitmap sourceBitmap, Rectangle windowBounds)
        {
            Rectangle clipRect = CalcRectangle(windowBounds);
            if (clipRect.Width > 0
                && clipRect.Height > 0)
            {
                _shadowClip = sourceBitmap.Clone(clipRect, sourceBitmap.PixelFormat);
            }
            else
            {
                _shadowClip = new Bitmap(1, 1);
                _shadowClip.MakeTransparent();
            }

            UpdateShadowLayer();
        }

        internal void UpdateShadowLayer()
        {
            // The Following is thanks to
            // https://csharp.hotexamples.com/examples/-/NativeMethods.BLENDFUNCTION/-/php-nativemethods.blendfunction-class-examples.html
            // Does this bitmap contain an alpha channel?
            if (_shadowClip.PixelFormat != PixelFormat.Format32bppArgb)
            {
                throw new ApplicationException("The bitmap must be 32bpp with alpha-channel.");
            }

            // Get device contexts
            IntPtr screenDc = PI.GetDC(IntPtr.Zero);
            IntPtr memDc = PI.CreateCompatibleDC(screenDc);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr hOldBitmap = IntPtr.Zero;

            try
            {
                // Get handle to the new bitmap and select it into the current 
                // device context.
                hBitmap = _shadowClip.GetHbitmap(Color.FromArgb(0));
                hOldBitmap = PI.SelectObject(memDc, hBitmap);

                // Set parameters for layered window update.
                PI.SIZE newSize = new PI.SIZE(_shadowClip.Width, _shadowClip.Height);
                PI.POINT sourceLocation = new PI.POINT(0, 0);
                PI.POINT newLocation = new PI.POINT(Left, Top);
                PI.BLENDFUNCTION blend = new PI.BLENDFUNCTION
                {
                    BlendOp = PI.AC_SRC_OVER,
                    BlendFlags = 0,
                    SourceConstantAlpha = (byte)(255 * _shadowValues.Opacity/100.0),
                    AlphaFormat = PI.AC_SRC_ALPHA
                };

                // Update the window.
                PI.UpdateLayeredWindow(
                    Handle, // Handle to the layered window
                    screenDc, // Handle to the screen DC
                    ref newLocation, // New screen position of the layered window
                    ref newSize, // New size of the layered window
                    memDc, // Handle to the layered window surface DC
                    ref sourceLocation, // Location of the layer in the DC
                    0, // Color key of the layered window
                    ref blend, // Transparency of the layered window
                    PI.ULW_ALPHA // Use blend as the blend function
                );
            }
            finally
            {
                // Release device context.
                PI.ReleaseDC(IntPtr.Zero, screenDc);
                if (hBitmap != IntPtr.Zero)
                {
                    PI.SelectObject(memDc, hOldBitmap);
                    PI.DeleteObject(hBitmap);
                }

                PI.DeleteDC(memDc);
            }
        }

        /// <summary>
        /// Q: Why go to this trouble and not just have a "Huge bitmap"
        /// A:memory 4K screen can eat a lot for a 32bit per pixel shader !
        /// </summary>
        /// <param name="windowBounds"></param>
        /// <returns></returns>
        private Rectangle CalcRectangle(Rectangle windowBounds)
        {
            Padding margins = _shadowValues.Margins;
            int maxMargin = new[]
            {
                _shadowValues.Margins.Left, _shadowValues.Margins.Right, _shadowValues.Margins.Top,
                _shadowValues.Margins.Bottom
            }.Max();
            int w = windowBounds.Width + maxMargin * 2;
            int h = windowBounds.Height + maxMargin * 2;
            int top;
            int left;
            int bottom;
            int right;

            switch (_visualOrientation)
            {
                case VisualOrientation.Top:
                    top = 0;
                    left = 0;
                    bottom = maxMargin*2 - margins.Top;
                    right = w;
                    break;
                case VisualOrientation.Left:
                    top = maxMargin*2 - margins.Top;
                    left = 0;
                    bottom = h;
                    right = maxMargin*2 - margins.Left;
                    break;
                case VisualOrientation.Bottom:
                    top = h - maxMargin * 2 - margins.Bottom;
                    left = maxMargin*2 - margins.Left;
                    bottom = h;
                    right = w - maxMargin * 2 - margins.Right;
                    break;
                case VisualOrientation.Right:
                    top = maxMargin*2 - margins.Top;
                    left = w - maxMargin * 2 - margins.Right;
                    bottom = h;
                    right = w;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return Rectangle.FromLTRB(left, top, right, bottom);
        }
        #endregion
    }
}
