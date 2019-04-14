// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2019 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Manages the drawing of Shadows
    /// </summary>
    internal class ShadowManager
    {
        #region Instance Fields
        private readonly KryptonForm _kryptonForm;
        private readonly ShadowValues _shadowValues;
        private bool _allowDrawing;
        private VisualShadowBase[] _shadowForms;
        private System.Timers.Timer _dwmTimer;
        #endregion

        #region Identity
        public ShadowManager(KryptonForm kryptonForm, ShadowValues shadowValues)
        {
            _kryptonForm = kryptonForm;
            _shadowValues = shadowValues;
            kryptonForm.Load += KryptonForm_Load;
            kryptonForm.Closing += KryptonFormOnClosing;
            kryptonForm.Move += KryptonFormOnMove;
            kryptonForm.Resize += KryptonForm_Resize;
            kryptonForm.SizeChanged += KryptonFormOnSizeChanged;
            kryptonForm.Shown += KryptonFormOnShown;
            kryptonForm.VisibleChanged += KryptonFormOnVisibleChanged;

            shadowValues.EnableShadowsChanged += ShadowValues_EnableShadowsChanged;
            shadowValues.MarginsChanged += ShadowValues_MarginsChanged;
            shadowValues.BlurDistanceChanged += ShadowValues_BlurDistanceChanged;
            shadowValues.ColourChanged += ShadowValues_ColourChanged;
            shadowValues.HideOnNonActiveFormChanged += ShadowValues_HideOnNonActiveForm;
            shadowValues.OpacityChanged += ShadowValues_OpacityChanged;

            _dwmTimer = new System.Timers.Timer {Interval = 1500, AutoReset = false};
            _dwmTimer.Elapsed += SmellyHackToCopeWithWindowsSpecialFlashingWhenOtherFormIsClicked;

        }

        internal void WndProc(ref Message m)
        {
            if (!_allowDrawing
                || !AllowDrawing
                )
            {
                return;
            }

            switch (m.Msg)
            {
                case PI.WM_SETCURSOR:
                    if ((short)((long)m.LParam & 0xffff) == (-2))
                    {
                        short hiWord = (short)((((long)m.LParam) >> 16) & 0xffff);

                        if ((hiWord == 0x0201
                             || hiWord == 0x0204) 
                            && !_dwmTimer.Enabled)
                        {
                            _dwmTimer.Stop();
                            // Parent form is "Flashing" so reset ZOrder in a moment !
                            _dwmTimer.Start();
                        }
                    }
                    break;
                case PI.WM_WINDOWPOSCHANGED:
                    {
                        PI.WINDOWPOS structure = (PI.WINDOWPOS)Marshal.PtrToStructure(m.LParam, typeof(PI.WINDOWPOS));

                        if (structure.hwndInsertAfter != IntPtr.Zero
                            && structure.flags.HasFlag(PI.SetWindowPosFlags.SWP_NOSIZE | PI.SetWindowPosFlags.SWP_NOMOVE)
                            && !structure.flags.HasFlag(PI.SetWindowPosFlags.SWP_NOZORDER)
                        )
                        {
                            IntPtr hWinPosInfo1 = PI.BeginDeferWindowPos(_shadowForms.Length);

                            foreach (VisualShadowBase shadowForm in _shadowForms)
                            {
                                hWinPosInfo1 = PI.DeferWindowPos(hWinPosInfo1, shadowForm.Handle, m.HWnd, 0, 0, 0, 0,
                                    PI.DeferWindowPosCommands.SWP_NOSIZE |
                                    PI.DeferWindowPosCommands.SWP_NOMOVE |
                                    PI.DeferWindowPosCommands.SWP_NOREDRAW |
                                    PI.DeferWindowPosCommands.SWP_NOACTIVATE);
                            }

                            PI.EndDeferWindowPos(hWinPosInfo1);
                        }
                    }
                    break;
            }
        }

        private void SmellyHackToCopeWithWindowsSpecialFlashingWhenOtherFormIsClicked(object sender, System.Timers.ElapsedEventArgs e)
        {
            _dwmTimer.Stop();
            // The following hack does not appear to work reliably via RDP
            _kryptonForm.Invoke((MethodInvoker) (() =>
            {
                InitialiseShadowForms();
                Form flashForm = new Form
                {
                    Size = new Size(1, 1),
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(-100, -100)
                };
                flashForm.Show(_kryptonForm);
                flashForm.Close();
            }));
        }

        private void KryptonForm_Load(object sender, EventArgs e)
        {
            InitialiseShadowForms();
        }

        #endregion

        private void InitialiseShadowForms()
        {
            _shadowForms = new VisualShadowBase[4];
            for (int i = 0; i < 4; i++)
            {
                _shadowForms[i] = new VisualShadowBase(_shadowValues, (VisualOrientation)i, _kryptonForm.Handle);
                _shadowForms[i].Show();
            }
        }

        private bool AllowDrawing =>
            _allowDrawing
            && _shadowValues.EnableShadows
            && (!_shadowValues.HideOnNonActiveForm || _kryptonForm.WindowActive)
            && _kryptonForm.Visible;

        private void KryptonFormOnClosing(object sender, CancelEventArgs e)
        {
            _allowDrawing = false;
            if (_dwmTimer != null)
            {
                _dwmTimer.Dispose();
            }

            _dwmTimer = null;

            PositionShadowForms(false);
            _kryptonForm.Closing -= KryptonFormOnClosing;
            _kryptonForm.Move -= KryptonFormOnMove;
            _kryptonForm.Resize -= KryptonForm_Resize;
            _kryptonForm.SizeChanged -= KryptonFormOnSizeChanged;
            _kryptonForm.Shown -= KryptonFormOnShown;
            _kryptonForm.VisibleChanged -= KryptonFormOnVisibleChanged;
            foreach (VisualShadowBase shadowForm in _shadowForms)
            {
                shadowForm.Close();
            }

        }

        private void KryptonFormOnVisibleChanged(object sender, EventArgs e)
        {
            PositionShadowForms(false);
        }

        private void KryptonFormOnShown(object sender, EventArgs e)
        {
            _allowDrawing = (LicenseManager.UsageMode != LicenseUsageMode.Designtime);
            SetShadowFormsSizes();
        }

        private void KryptonFormOnSizeChanged(object sender, EventArgs e)
        {
            SetShadowFormsSizes();
        }

        private void KryptonForm_Resize(object sender, EventArgs e)
        {
            SetShadowFormsSizes();
        }

        private void KryptonFormOnMove(object sender, EventArgs e)
        {
            PositionShadowForms(true);
        }

        private void ShadowValues_HideOnNonActiveForm(object sender, EventArgs e)
        {
            PositionShadowForms(false);
        }

        private void ShadowValues_ColourChanged(object sender, ColorEventArgs e)
        {
            ReCalcBrushes();
        }

        private void ShadowValues_BlurDistanceChanged(object sender, EventArgs e)
        {
            ReCalcBrushes();
        }

        private void ShadowValues_OpacityChanged(object sender, EventArgs e)
        {
            ReCalcBrushes();
        }

        private void ShadowValues_MarginsChanged(object sender, EventArgs e)
        {
            SetShadowFormsSizes();
        }

        private void ShadowValues_EnableShadowsChanged(object sender, EventArgs e)
        {
            if (!_allowDrawing)
            {
                // Call before shown is complete
                return;
            }

            foreach (VisualShadowBase shadowForm in _shadowForms)
            {
                shadowForm.Visible = AllowDrawing;
            }
        }


        private void SetShadowFormsSizes()
        {
            PositionShadowForms(false);
            ReCalcBrushes();
        }

        private void ReCalcBrushes()
        {
            if (!AllowDrawing)
            {
                return;
            }

            // calculate the "whole" shadow
            Rectangle clientRectangle = CommonHelper.RealClientRectangle(_kryptonForm.Handle);
            using (Bitmap allShadow = DrawShadowBitmap(clientRectangle))
            {
                foreach (VisualShadowBase shadowForm in _shadowForms)
                {
                    shadowForm.ReCalcShadow(allShadow, clientRectangle);
                }
            }
        }

        /// <summary>
        /// Probably a more efficient way, but this gives the easiest testable visible results
        /// </summary>
        /// <param name="clientRectangle"></param>
        /// <returns></returns>
        private Bitmap DrawShadowBitmap(Rectangle clientRectangle)
        {
            int maxMargin = new[]
            {
                _shadowValues.Margins.Left, _shadowValues.Margins.Right, _shadowValues.Margins.Top,
                _shadowValues.Margins.Bottom
            }.Max();
            int blur = (int)((_shadowValues.BlurDistance / 100.0) * maxMargin);
            int w = clientRectangle.Width + maxMargin * 2;
            int h = clientRectangle.Height + maxMargin * 2;
            int solidW = clientRectangle.Width + blur * 2;
            int solidH = clientRectangle.Height + blur * 2;

            Bitmap bitmap = new Bitmap(w, h);
            bitmap.MakeTransparent();
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // fill background
                //g.FillRectangle(Brushes.Magenta, 0,0,w,h);
                // +1 to fill the gap
                g.FillRectangle(new SolidBrush(_shadowValues.Colour),
                    maxMargin - blur, maxMargin - blur, solidW + 1, solidH + 1);

                if (_shadowValues.BlurDistance > 0)
                {
                    // four dir gradient
                    using (LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(blur, 0),
                        Color.Transparent, _shadowValues.Colour))
                    {
                        // Left
                        g.FillRectangle(brush, 0, blur, blur, solidH);

                        // Top
                        brush.RotateTransform(90);
                        g.FillRectangle(brush, blur, 0, solidW, blur);

                        // Right
                        // make sure pattern is correct
                        brush.ResetTransform();
                        brush.TranslateTransform(w % blur, h % blur);

                        brush.RotateTransform(180);
                        g.FillRectangle(brush, w - blur, blur, blur, solidH);
                        // Bottom
                        brush.RotateTransform(90);
                        g.FillRectangle(brush, blur, h - blur, solidW, blur);
                    }


                    // four corner
                    using (GraphicsPath gp = new GraphicsPath())
                    using (Matrix matrix = new Matrix())
                    {
                        gp.AddEllipse(0, 0, blur * 2, blur * 2);
                        using (PathGradientBrush pgb = new PathGradientBrush(gp)
                        {
                            CenterColor = _shadowValues.Colour,
                            SurroundColors = new[] { Color.Transparent },
                            CenterPoint = new Point(blur, blur)
                        })
                        {
                            // left-Top
                            g.FillPie(pgb, 0, 0, blur * 2, blur * 2, 180, 90);

                            // right-Top
                            matrix.Translate(w - blur * 2, 0);

                            pgb.Transform = matrix;
                            //pgb.Transform.Translate(w-blur*2, 0);
                            g.FillPie(pgb, w - blur * 2, 0, blur * 2, blur * 2, 270, 90);

                            // right-Bottom
                            matrix.Translate(0, h - blur * 2);
                            pgb.Transform = matrix;
                            g.FillPie(pgb, w - blur * 2, h - blur * 2, blur * 2, blur * 2, 0, 90);

                            // left-Bottom
                            matrix.Reset();
                            matrix.Translate(0, h - blur * 2);
                            pgb.Transform = matrix;
                            g.FillPie(pgb, 0, h - blur * 2, blur * 2, blur * 2, 90, 90);
                        }
                    }
                }
            }

            //
            return bitmap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Move operations have to be done as a single operation to reduce flickering
        /// </remarks>
        private void PositionShadowForms(bool moveOnly)
        {
            if (!_allowDrawing)
            {
                // Call before shown is complete
                return;
            }

            void MI()
            {
                foreach (VisualShadowBase shadowForm in _shadowForms)
                {
                    shadowForm.Visible = AllowDrawing;
                }
                if (!AllowDrawing)
                {
                    return;
                }

                IntPtr hWinPosInfo = PI.BeginDeferWindowPos(_shadowForms.Length);

                foreach (VisualShadowBase shadowForm in _shadowForms)
                {
                    if (shadowForm.CalcPositionShadowForm(_kryptonForm.DesktopLocation,
                        CommonHelper.RealClientRectangle(_kryptonForm.Handle)))
                    {
                        Rectangle targetRect = shadowForm.TargetRect;
                        hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, shadowForm.Handle,
                            PI.HWND_NOTOPMOST /*hWndInsertAfter*/,
                            targetRect.X, targetRect.Y, targetRect.Width, targetRect.Height,
                            (moveOnly ? PI.DeferWindowPosCommands.SWP_NOSIZE : 0) |
                            PI.DeferWindowPosCommands.SWP_NOACTIVATE
                            | PI.DeferWindowPosCommands.SWP_NOREDRAW
                            | PI.DeferWindowPosCommands.SWP_SHOWWINDOW
                            | PI.DeferWindowPosCommands.SWP_NOCOPYBITS
                            | PI.DeferWindowPosCommands.SWP_NOOWNERZORDER
                        );
                    }
                }

                PI.EndDeferWindowPos(hWinPosInfo);
            }

            if (_kryptonForm.InvokeRequired)
            {
                _kryptonForm.Invoke((MethodInvoker)MI);
            }
            else
            {
                MI();
            }

        }
    }
}
