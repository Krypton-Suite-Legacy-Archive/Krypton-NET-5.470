using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit.Rendering
{
    [Flags]
    internal enum ShadowEdges
    {
        None = 0,
        Left = 1,
        Top = 2,
        Right = 4,
        Bottom = 8,
        BottomRight = Bottom | Right, // 0x0000000C
        TopLeft = Top | Left, // 0x00000003
        All = TopLeft | BottomRight, // 0x0000000F
    }

    internal sealed class RenderFormShadow: IDisposable
    {
        private const int WM_SHOWSHADOW = 14613;
        private const int DWM_TRANSITION_DELAY = 275;
        private const int SHADOW_OPACITY0 = 50;
        private const int SHADOW_OPACITY1 = 70;
        private const int SHADOW_OPACITY2 = 100;
        private const int SHADOW_OPACITY3 = 140;
        private const int SHADOW_OPACITY4 = 170;
        private const int SHADOW_OPACITY_MAX = 255;
        private const int TOP_MARGIN = 8;
        private const int BOTTOM_MARGIN = 4;
        private const int FRAME_LEFT = 12;
        private const int FRAME_TOP = 12;
        private const int FRAME_RIGHT = 12;
        private const int FRAME_BOTTOM = 12;
        private const int SMALL_SHADOW_OFFSET = 6;
        private System.Timers.Timer _dwmTimer;
        private Control _window;
        //private IShadowRenderer _renderer;
        private Rectangle _bounds;
        private Rectangle _rectL;
        private Rectangle _rectT;
        private Rectangle _rectR;
        private Rectangle _rectB;
        private ShadowEdge _shadowL;
        private ShadowEdge _shadowT;
        private ShadowEdge _shadowR;
        private ShadowEdge _shadowB;
        private ShadowEdges _edges;
        private IntPtr _ownerHandle;
        private Padding _margins;
        private bool _parentLoaded;
        private bool _animate;
        private bool _extended;
        private bool _created;
        private bool _moved;
        private bool _sized;
        private bool _enabled;
        private bool _disposed;
        private int _opacity;
        private int _sizeState;

        public RenderFormShadow(Control parent)
        {
            this._window = parent;
            this._edges = ShadowEdges.All;
            this._margins = Padding.Empty;
            this._bounds = Rectangle.Empty;
            this._dwmTimer = new System.Timers.Timer();
            this._dwmTimer.Elapsed += new ElapsedEventHandler(this.Timer_Elapsed);
            this._dwmTimer.Interval = DWM_TRANSITION_DELAY;
            this._dwmTimer.AutoReset = false;
        }

        ~RenderFormShadow()
        {
            this.Dispose(false);
        }

        public event EventHandler HandleDestroyed;

        public void Extend(bool activate)
        {
            this._ownerHandle = IntPtr.Zero;
            if (this._window is Form control)
            {
                if (!control.TopLevel)
                    return;
                if (!control.RecreatingHandle)
                {
                    control.Load += new EventHandler(this.Form_Load);
                }
                else
                {
                    if (control.IsDisposed)
                        return;
                    this._ownerHandle = this.GetOwnerHandle(control);
                    if (this._extended)
                        return;
                    this.CreateShadowFrame(this._ownerHandle);
                    this._extended = true;
                }
            }
            else
            {
                this._ownerHandle = PI.GetParent(this._window.Handle);
                if (this._extended)
                    return;
                this.CreateShadowFrame(this._ownerHandle);
                this._extended = true;
            }
        }
        
        public void Refresh()
        {
            this.UpdateShadowVisibility(this._enabled);
        }

        //public object Renderer
        //{
        //    get
        //    {
        //        return (object)this._renderer;
        //    }
        //    set
        //    {
        //        this._renderer = (IShadowRenderer)value;
        //    }
        //}

        public bool IsToolStrip
        {
            get
            {
                return false;
            }
        }

        public bool IsForm
        {
            get
            {
                return false;
            }
        }

        public bool IsHandleCreated
        {
            get
            {
                return this._created;
            }
        }

        public bool IsDisposed
        {
            get
            {
                return this._disposed;
            }
        }

        public Control Control
        {
            get
            {
                return this._window;
            }
        }

        public IntPtr Handle
        {
            get
            {
                return IntPtr.Zero;
            }
        }

        public bool DesignMode
        {
            get
            {
                return false;
            }
            set
            {
            }
        }

        public bool IsExtended
        {
            get
            {
                return this._extended;
            }
        }

        public bool IsCompositeControl
        {
            get
            {
                return false;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize((object)this);
        }

        internal void Dispose(bool disposing)
        {
            if (!disposing || this._disposed)
                return;
            if (!this._parentLoaded)
            {
                if (this._window is Form control)
                    control.Load -= new EventHandler(this.Form_Load);
            }
            if (this._extended)
            {
                if (this._shadowL != null)
                    this._shadowL.Dispose();
                if (this._shadowT != null)
                    this._shadowT.Dispose();
                if (this._shadowR != null)
                    this._shadowR.Dispose();
                if (this._shadowB != null)
                    this._shadowB.Dispose();
            }
            if (this._dwmTimer != null)
                this._dwmTimer.Dispose();
            this._window = null;
            this._shadowL = (ShadowEdge)null;
            this._shadowT = (ShadowEdge)null;
            this._shadowR = (ShadowEdge)null;
            this._shadowB = (ShadowEdge)null;
            this._dwmTimer = (System.Timers.Timer)null;
            //this._renderer = null;
            this._ownerHandle = IntPtr.Zero;
            this._extended = false;
            this._disposed = true;
        }

        internal void OnParentMessage(ref System.Windows.Forms.Message m)
        {
            if (!this._enabled || !this._extended)
                return;
            switch (m.Msg)
            {
                case PI.WM_SIZE:
                    this.WmSize(ref m);
                    break;
                case PI.WM_SHOWWINDOW:
                    this.WmShowWindow(ref m);
                    break;
                case PI.WM_WINDOWPOSCHANGING:
                    this.WmWindowPosChanging(ref m);
                    break;
                case PI.WM_WINDOWPOSCHANGED:
                    this.WmWindowPosChanged(ref m);
                    break;
                case WM_SHOWSHADOW:
                    this.SmShowShadow(ref m);
                    break;
            }
        }

        internal void OnParentMessage(ref PI.MSG m)
        {
            System.Windows.Forms.Message m1 = System.Windows.Forms.Message.Create(m.hwnd, m.message, m.wParam, m.lParam);
            if (!this._enabled || !this._extended)
                return;
            switch (m.message)
            {
                case PI.WM_SIZE:
                    this.WmSize(ref m1);
                    break;
                case PI.WM_SHOWWINDOW:
                    this.WmShowWindow(ref m1);
                    break;
                case PI.WM_WINDOWPOSCHANGING:
                    this.WmWindowPosChanging(ref m1);
                    break;
                case PI.WM_WINDOWPOSCHANGED:
                    this.WmWindowPosChanged(ref m1);
                    break;
            }
        }

        private void WmShowWindow(ref System.Windows.Forms.Message m)
        {
            if (m.WParam.ToInt32() != 0)
            {
                Rectangle windowBounds = CommonHelper.RealClientRectangle(m.HWnd);
                this.PerformLayout(windowBounds);
                uint windowLongInt = PI.GetWindowLong(m.HWnd, -16);
                this._sizeState = (windowLongInt & 16777216) == 0 ? ((windowLongInt & 536870912) == 0 ? 0 : 1) : 2;
                if (this._sizeState != 0)
                    return;
                if (this._animate)
                {
                    this._opacity = 0;
                    this._dwmTimer.Start();
                }
                else
                    this._opacity = (int)byte.MaxValue;
                this.UpdateLayeredWindow(windowBounds);
                this.UpdateShadowBounds(m.HWnd, PI.DeferWindowPosCommands.SWP_NOACTIVATE | PI.DeferWindowPosCommands.SWP_NOREDRAW | PI.DeferWindowPosCommands.SWP_SHOWWINDOW );
            }
            else
                this.ShowShadowWindow(0);
        }

        private void SmShowShadow(ref System.Windows.Forms.Message m)
        {
            this._opacity = m.WParam.ToInt32();
            this.UpdateLayeredWindow(CommonHelper.RealClientRectangle(m.HWnd));
        }

        private void WmSize(ref System.Windows.Forms.Message m)
        {
            int num = m.WParam.ToInt32();
            switch (num)
            {
                case 0:
                    if (this._sizeState == 2)
                    {
                        this._opacity = (int)byte.MaxValue;
                        this.UpdateLayeredWindow(CommonHelper.RealClientRectangle(m.HWnd));
                        this.UpdateShadowZOrder(m.HWnd, PI.DeferWindowPosCommands.SWP_NOSIZE |
                            PI.DeferWindowPosCommands.SWP_NOMOVE |
                            PI.DeferWindowPosCommands.SWP_NOACTIVATE |
                            PI.DeferWindowPosCommands.SWP_SHOWWINDOW);
                        break;
                    }
                    if (this._sizeState == 1)
                    {
                        if (this._animate)
                        {
                            this._opacity = 0;
                            this._dwmTimer.Start();
                        }
                        else
                            this._opacity = (int)byte.MaxValue;
                        this.UpdateLayeredWindow(CommonHelper.RealClientRectangle(m.HWnd));
                        this.UpdateShadowZOrder(m.HWnd, PI.DeferWindowPosCommands.SWP_NOSIZE |
                                                        PI.DeferWindowPosCommands.SWP_NOMOVE |
                                                        PI.DeferWindowPosCommands.SWP_NOACTIVATE |
                                                        PI.DeferWindowPosCommands.SWP_SHOWWINDOW);
                        break;
                    }
                    break;
                case 1:
                    if (this._animate)
                        this._opacity = 0;
                    this.ShowShadowWindow(0);
                    break;
                case 2:
                    this.ShowShadowWindow(0);
                    break;
            }
            this._sizeState = num;
        }

        private void WmWindowPosChanging(ref System.Windows.Forms.Message m)
        {
            PI.WINDOWPOS windowpos = new PI.WINDOWPOS();
            PI.WINDOWPOS structure = (PI.WINDOWPOS)Marshal.PtrToStructure(m.LParam, typeof(PI.WINDOWPOS));
            Rectangle bounds = new Rectangle(structure.x, structure.y, structure.x + structure.cx, structure.y + structure.cy);
            if (((int)structure.flags & 3) == 3 || ((int)structure.flags & 128) != 0)
                return;
            this.PerformLayout(bounds);
            this._moved = bounds.Location != this._bounds.Location && ((int)structure.flags & 2) == 0;
            this._sized = bounds.Size != this._bounds.Size;
            if (this._moved && !this._sized)
            {
                this.UpdateShadowPosition(IntPtr.Zero, PI.DeferWindowPosCommands.SWP_NOSIZE |
                                                       PI.DeferWindowPosCommands.SWP_NOZORDER |
                                                       PI.DeferWindowPosCommands.SWP_NOREDRAW |
                                                       PI.DeferWindowPosCommands.SWP_NOACTIVATE |
                                                       PI.DeferWindowPosCommands.SWP_NOOWNERZORDER);
            }

            this._bounds = bounds;
        }

        private void WmWindowPosChanged(ref System.Windows.Forms.Message m)
        {
            PI.WINDOWPOS windowpos = new PI.WINDOWPOS();
            PI.WINDOWPOS structure = (PI.WINDOWPOS)Marshal.PtrToStructure(m.LParam, typeof(PI.WINDOWPOS));
            Rectangle bounds = new Rectangle(structure.x, structure.y, structure.x + structure.cx, structure.y + structure.cy);
            if (structure.hwndInsertAfter != IntPtr.Zero && ((int) structure.flags & 3) == 3 &&
                ((int) structure.flags & 4) == 0)
            {
                this.UpdateShadowZOrder(m.HWnd, PI.DeferWindowPosCommands.SWP_NOSIZE |
                    PI.DeferWindowPosCommands.SWP_NOMOVE |
                    PI.DeferWindowPosCommands.SWP_NOREDRAW |
                    PI.DeferWindowPosCommands.SWP_NOACTIVATE);
            }
            else if (!this._moved && this._sized)
            {
                this.PerformLayout(bounds);
                this.UpdateLayeredWindow(bounds);
                this._sized = false;
            }
            else if (this._moved && this._sized)
            {
                this.PerformLayout(bounds);
                this.UpdateLayeredWindow(bounds);
                this.UpdateShadowBounds(IntPtr.Zero, PI.DeferWindowPosCommands.SWP_NOSIZE |
                    PI.DeferWindowPosCommands.SWP_NOMOVE |
                    PI.DeferWindowPosCommands.SWP_NOREDRAW |
                    PI.DeferWindowPosCommands.SWP_NOACTIVATE |
                    PI.DeferWindowPosCommands.SWP_NOCOPYBITS |
                    PI.DeferWindowPosCommands.SWP_NOOWNERZORDER);
                this._moved = false;
                this._sized = false;
            }
            else if (((int)structure.flags & 4096) != 0 && ((int)structure.flags & 1) == 0)
            {
                this.PerformLayout(bounds);
                this.UpdateLayeredWindow(bounds);
            }
            if (((int)structure.flags & 128) == 0)
                return;
            this.ShowShadowWindow(0);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this._window == null || this._window.IsDisposed)
                return;
            this._dwmTimer.Stop();
            PI.PostMessageSafe(this._window.Handle, WM_SHOWSHADOW, new IntPtr(SHADOW_OPACITY0), IntPtr.Zero);
            PI.PostMessageSafe(this._window.Handle, WM_SHOWSHADOW, new IntPtr(SHADOW_OPACITY1), IntPtr.Zero);
            PI.PostMessageSafe(this._window.Handle, WM_SHOWSHADOW, new IntPtr(SHADOW_OPACITY2), IntPtr.Zero);
            PI.PostMessageSafe(this._window.Handle, WM_SHOWSHADOW, new IntPtr(SHADOW_OPACITY3), IntPtr.Zero);
            PI.PostMessageSafe(this._window.Handle, WM_SHOWSHADOW, new IntPtr(SHADOW_OPACITY4), IntPtr.Zero);
            PI.PostMessageSafe(this._window.Handle, WM_SHOWSHADOW, new IntPtr(byte.MaxValue), IntPtr.Zero);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this._parentLoaded = true;
            Form form = (Form)sender;
            form.Load -= new EventHandler(this.Form_Load);
            if (form.IsDisposed)
                return;
            this._ownerHandle = this.GetOwnerHandle(form);
            if (this._extended)
                return;
            this.CreateShadowFrame(this._ownerHandle);
            this._extended = true;
        }

        private IntPtr GetOwnerHandle(Form form)
        {
            IntPtr zero = IntPtr.Zero;
            return form.Owner == null ? PI.GetWindow(form.Handle, PI.GetWindowType.GW_OWNER) : form.Owner.Handle;
        }

        private void CreateShadowFrame(IntPtr owner)
        {
            if (this._shadowL == null)
                this._shadowL = new ShadowEdge(owner);
            if (this._shadowT == null)
                this._shadowT = new ShadowEdge(owner);
            if (this._shadowR == null)
                this._shadowR = new ShadowEdge(owner);
            if (this._shadowB == null)
                this._shadowB = new ShadowEdge(owner);
            this._created = true;
        }

        private void ShowShadowWindow(int showFlags)
        {
            if ((this._edges & ShadowEdges.Left) != ShadowEdges.None)
                PI.ShowWindow(this._shadowL.Handle, showFlags);
            if ((this._edges & ShadowEdges.Top) != ShadowEdges.None)
                PI.ShowWindow(this._shadowT.Handle, showFlags);
            if ((this._edges & ShadowEdges.Right) != ShadowEdges.None)
                PI.ShowWindow(this._shadowR.Handle, showFlags);
            if ((this._edges & ShadowEdges.Bottom) == ShadowEdges.None)
                return;
            PI.ShowWindow(this._shadowB.Handle, showFlags);
        }

        private void UpdateShadowZOrder(IntPtr hWndInsertAfter, PI.DeferWindowPosCommands swpFlags)
        {
            IntPtr hWinPosInfo = PI.BeginDeferWindowPos(4);
            if ((this._edges & ShadowEdges.Left) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowL.Handle, hWndInsertAfter, 0, 0, 0, 0, swpFlags);
            if ((this._edges & ShadowEdges.Top) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowT.Handle, hWndInsertAfter, 0, 0, 0, 0, swpFlags);
            if ((this._edges & ShadowEdges.Right) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowR.Handle, hWndInsertAfter, 0, 0, 0, 0, swpFlags);
            if ((this._edges & ShadowEdges.Bottom) != ShadowEdges.None)
                hWinPosInfo =PI.DeferWindowPos(hWinPosInfo, this._shadowB.Handle, hWndInsertAfter, 0, 0, 0, 0, swpFlags);
            PI.EndDeferWindowPos(hWinPosInfo);
        }

        private void UpdateShadowPosition(IntPtr hWndInsertAfter, PI.DeferWindowPosCommands swpFlags)
        {
            IntPtr hWinPosInfo = PI.BeginDeferWindowPos(4);
            if ((this._edges & ShadowEdges.Left) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowL.Handle, hWndInsertAfter, this._rectL.X, this._rectL.Y, 0, 0, swpFlags);
            if ((this._edges & ShadowEdges.Top) != ShadowEdges.None)
                hWinPosInfo =PI.DeferWindowPos(hWinPosInfo, this._shadowT.Handle, hWndInsertAfter, this._rectT.X, this._rectT.Y, 0, 0, swpFlags);
            if ((this._edges & ShadowEdges.Right) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowR.Handle, hWndInsertAfter, this._rectR.X, this._rectR.Y, 0, 0, swpFlags);
            if ((this._edges & ShadowEdges.Bottom) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowB.Handle, hWndInsertAfter, this._rectB.X, this._rectB.Y, 0, 0, swpFlags);
            PI.EndDeferWindowPos(hWinPosInfo);
        }

        private void UpdateShadowBoundsDirect(IntPtr hWndInsertAfter, PI.SetWindowPosFlags swpFlags)
        {
            if ((this._edges & ShadowEdges.Left) != ShadowEdges.None)
                PI.SetWindowPos(this._shadowL.Handle, hWndInsertAfter, this._rectL.X, this._rectL.Y, this._rectL.Width, this._rectL.Height, swpFlags);
            if ((this._edges & ShadowEdges.Top) != ShadowEdges.None)
                PI.SetWindowPos(this._shadowT.Handle, hWndInsertAfter, this._rectT.X, this._rectT.Y, this._rectT.Width, this._rectT.Height, swpFlags);
            if ((this._edges & ShadowEdges.Right) != ShadowEdges.None)
                PI.SetWindowPos(this._shadowR.Handle, hWndInsertAfter, this._rectR.X, this._rectR.Y, this._rectR.Width, this._rectR.Height, swpFlags);
            if ((this._edges & ShadowEdges.Bottom) == ShadowEdges.None)
                return;
            PI.SetWindowPos(this._shadowB.Handle, hWndInsertAfter, this._rectB.X, this._rectB.Y, this._rectB.Width, this._rectB.Height, swpFlags);
        }

        private void UpdateShadowBounds(IntPtr hWndInsertAfter, PI.DeferWindowPosCommands swpFlags)
        {
            IntPtr hWinPosInfo = PI.BeginDeferWindowPos(4);
            if ((this._edges & ShadowEdges.Left) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowL.Handle, hWndInsertAfter, this._rectL.X, this._rectL.Y, this._rectL.Width, this._rectL.Height, swpFlags);
            if ((this._edges & ShadowEdges.Top) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowT.Handle, hWndInsertAfter, this._rectT.X, this._rectT.Y, this._rectT.Width, this._rectT.Height, swpFlags);
            if ((this._edges & ShadowEdges.Right) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowR.Handle, hWndInsertAfter, this._rectR.X, this._rectR.Y, this._rectR.Width, this._rectR.Height, swpFlags);
            if ((this._edges & ShadowEdges.Bottom) != ShadowEdges.None)
                hWinPosInfo = PI.DeferWindowPos(hWinPosInfo, this._shadowB.Handle, hWndInsertAfter, this._rectB.X, this._rectB.Y, this._rectB.Width, this._rectB.Height, swpFlags);
            PI.EndDeferWindowPos(hWinPosInfo);
        }

        private void PerformLayout(Rectangle bounds)
        {
            bounds.Deflate(this._margins);
            this._rectL = new Rectangle(bounds.Left - FRAME_LEFT, bounds.Top + TOP_MARGIN, bounds.Left + FRAME_LEFT, bounds.Bottom - BOTTOM_MARGIN);
            this._rectT = new Rectangle(bounds.Left - FRAME_LEFT, bounds.Top - FRAME_TOP, bounds.Right + FRAME_RIGHT, bounds.Top + TOP_MARGIN);
            this._rectR = new Rectangle(bounds.Right, bounds.Top + TOP_MARGIN, bounds.Right + FRAME_RIGHT, bounds.Bottom - BOTTOM_MARGIN);
            this._rectB = new Rectangle(bounds.Left - FRAME_LEFT, bounds.Bottom - BOTTOM_MARGIN, bounds.Right + FRAME_RIGHT, bounds.Bottom + FRAME_BOTTOM);
        }

        internal Rectangle GetShadowFrame(Rectangle bounds)
        {
            bounds.Deflate(this._margins);
            return new Rectangle(bounds.Left - FRAME_LEFT, bounds.Top - FRAME_TOP, bounds.Right + FRAME_RIGHT, bounds.Bottom + FRAME_BOTTOM);
        }

        public void CreateControl()
        {
            if (!this._window.IsHandleCreated)
                return;
            WindowStylesHelper windowStyles = new WindowStylesHelper(this._window.Handle);
            //if (this._extended || this._renderer == null || (!windowStyles.Framed || !windowStyles.Restored) || (windowStyles.Child || windowStyles.Popup))
            //    return;
            if ((this._window is Form control))
            {
                this._ownerHandle = this.GetOwnerHandle(control);
                this.CreateShadowFrame(this._ownerHandle);
                this._extended = true;
            }
        }

        internal void UpdateShadowMargins(
          Rectangle bounds,
          IntPtr region,
          ShadowEdges transparentEdges)
        {
            if (transparentEdges == ShadowEdges.All)
            {
                PI.RECT lprc = new PI.RECT();
                PI.GetRgnBox(region, ref lprc);
                if (lprc.left > 0 && lprc.top > 0)
                {
                    this._margins = new Padding(lprc.left, lprc.top, bounds.Right - lprc.right, bounds.Bottom - lprc.bottom);
                    this.Refresh();
                }
                else
                {
                    if ((transparentEdges & ShadowEdges.Bottom) == ShadowEdges.None)
                        return;
                    this._margins = new Padding(0, 0, 0, 3);
                    this.Refresh();
                }
            }
            else if ((transparentEdges & ShadowEdges.Bottom) != ShadowEdges.None)
            {
                this._margins = new Padding(0, 0, 0, 3);
                this.Refresh();
            }
            else
            {
                if (this._margins == Padding.Empty)
                    return;
                this._margins = Padding.Empty;
                this.Refresh();
            }
        }

        public void UpdateShadowVisibility(bool visible)
        {
            if (!this._window.IsHandleCreated)
                return;
            uint windowLongInt = PI.GetWindowLong(this._window.Handle, -16);
            //if (!this._extended || this._renderer == null || (windowLongInt & 553648128) != 0)
            //    return;
            if (!this._enabled || (windowLongInt & 268435456) == 0)
            {
                this.ShowShadowWindow(0);
            }
            else
            {
                Rectangle windowBounds = CommonHelper.RealClientRectangle(this._window.Handle);
                this.PerformLayout(windowBounds);
                this.UpdateLayeredWindow(windowBounds);
                this.UpdateShadowBounds(this._window.Handle, PI.DeferWindowPosCommands.SWP_NOREDRAW |
                    PI.DeferWindowPosCommands.SWP_NOACTIVATE |
                    PI.DeferWindowPosCommands.SWP_SHOWWINDOW);
                if (this._edges == ShadowEdges.All)
                    return;
                if ((this._edges & ShadowEdges.Left) == ShadowEdges.None)
                    PI.ShowWindow(this._shadowL.Handle, 0);
                if ((this._edges & ShadowEdges.Top) == ShadowEdges.None)
                    PI.ShowWindow(this._shadowT.Handle, 0);
                if ((this._edges & ShadowEdges.Right) == ShadowEdges.None)
                    PI.ShowWindow(this._shadowR.Handle, 0);
                if ((this._edges & ShadowEdges.Bottom) != ShadowEdges.None)
                    return;
                PI.ShowWindow(this._shadowB.Handle, 0);
            }
        }

        private void UpdateLayeredWindow(Rectangle bounds)
        {
            bounds.Deflate(this._margins);
            Rectangle bounds1 = new Rectangle(0, 0, bounds.Width + FRAME_LEFT + FRAME_RIGHT, bounds.Height + FRAME_TOP + FRAME_BOTTOM);
            GDISurface surface = new GDISurface(bounds1.Size);// = this._renderer.GetSurface(bounds1.Size);
            if (this._edges == ShadowEdges.BottomRight)
                surface.TranslateTransform(0, SMALL_SHADOW_OFFSET);
            //this._renderer.DrawShadow(surface, bounds1, this.ShadowExtents, FormStates.Normal);
            if ((this._edges & ShadowEdges.Left) != ShadowEdges.None)
                this._shadowL.UpdateLayeredWindow(surface, (Rectangle)this._rectL, new Rectangle(bounds1.Left, bounds1.Top + FRAME_TOP + TOP_MARGIN, bounds1.Left + FRAME_LEFT, bounds1.Bottom - FRAME_BOTTOM - BOTTOM_MARGIN), this._opacity);
            if ((this._edges & ShadowEdges.Top) != ShadowEdges.None)
                this._shadowT.UpdateLayeredWindow(surface, (Rectangle)this._rectT, new Rectangle(bounds1.Left, bounds1.Top, bounds1.Right, bounds1.Top + FRAME_TOP + TOP_MARGIN), this._opacity);
            if ((this._edges & ShadowEdges.Right) != ShadowEdges.None)
                this._shadowR.UpdateLayeredWindow(surface, (Rectangle)this._rectR, new Rectangle(bounds1.Right - FRAME_RIGHT, bounds1.Top + FRAME_TOP + TOP_MARGIN, bounds1.Right, bounds1.Bottom - FRAME_BOTTOM - BOTTOM_MARGIN), this._opacity);
            if ((this._edges & ShadowEdges.Bottom) != ShadowEdges.None)
                this._shadowB.UpdateLayeredWindow(surface, (Rectangle)this._rectB, new Rectangle(bounds1.Left, bounds1.Bottom - FRAME_BOTTOM - BOTTOM_MARGIN, bounds1.Right, bounds1.Bottom), this._opacity);
            if (this._edges != ShadowEdges.BottomRight)
                return;
            surface.TranslateTransform(0, -SMALL_SHADOW_OFFSET);
        }

        public Padding ShadowExtents
        {
            get
            {
                return new Padding(20);
            }
        }

        public Padding FrameMargins
        {
            get
            {
                return this._margins;
            }
            set
            {
                if (!(value != this._margins))
                    return;
                this._margins = value;
            }
        }

        public ShadowEdges Edges
        {
            get
            {
                return this._edges;
            }
            set
            {
                if (value == this._edges)
                    return;
                this._edges = value;
            }
        }

        public bool AnimateShadow
        {
            get
            {
                return this._animate;
            }
            set
            {
                if (value == this._animate)
                    return;
                this._animate = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return this._enabled;
            }
            set
            {
                if (value == this._enabled)
                    return;
                this._enabled = value;
            }
        }

        internal sealed class ShadowEdge : NativeWindow, IDisposable
        {
            private IntPtr _owner;
            private bool _disposed;

            public ShadowEdge(IntPtr owner)
            {
                this._owner = owner;
                this.CreateControl(owner);
            }

            public void Dispose()
            {
                if (this._disposed)
                    return;
                if (this.Handle != IntPtr.Zero)
                    this.DestroyHandle();
                this._disposed = true;
                GC.SuppressFinalize((object)this);
            }

            private void CreateControl(IntPtr parent)
            {
                this.CreateHandle(new CreateParams()
                {
                    ClassStyle = 3,
                    Width = 0,
                    Height = 0,
                    X = 0,
                    Y = 0,
                    Parent = parent,
                    Style = int.MinValue,
                    ExStyle = 524448
                });
            }

            public void UpdateLayeredWindow(
              GDISurface surface,
              Rectangle destination,
              Rectangle source,
              int opacity)
            {
                PI.SIZE psize = new PI.SIZE {cx = source.Width, cy = source.Height};
                PI.POINT pptSrc = new PI.POINT {X = source.X, Y = source.Y};
                PI.POINT pptDst = new PI.POINT {X = destination.X, Y = destination.Y};
                PI.BLENDFUNCTION blendFunction = new PI.BLENDFUNCTION()
                {
                    BlendOp = PI.BLENDFUNCTION.AC_SRC_OVER,
                    BlendFlags = (byte)0,
                    SourceConstantAlpha = (byte)(opacity & (int)byte.MaxValue),
                    AlphaFormat = (byte)1
                };
                PI.UpdateLayeredWindow(this.Handle, IntPtr.Zero, ref pptDst, ref psize, surface.Handle, ref pptSrc, 0, ref blendFunction, 2U);
            }
        }

        [Flags]
        private enum D
        {
            A = 1,
            B = 2,
            C = 4,
            D = 8,
            E = 16, // 0x00000010
            F = 32, // 0x00000020
            G = 64, // 0x00000040
            H = 128, // 0x00000080
            I = 256, // 0x00000100
            J = 512, // 0x00000200
            K = 1024, // 0x00000400
            L = 2048, // 0x00000800
            M = 4096, // 0x00001000
            N = 8192, // 0x00002000
        }

        internal sealed class GDISurface : IDisposable
        {
            private const int ContentTop = 15;
            private const int ContentMiddle = 240;
            private const int ContentBottom = 3840;
            private const int SURFACE_DEFAULT_BPP = 32;
            private const int SURFACE_MAX_WIDTH = 8192;
            private const int SURFACE_MAX_HEIGHT = 8192;
            private GDISurface _tileBuffer;
            private Rectangle _clipRect;
            private Size _bufferSize;
            private Size _sizeSurface;
            private IntPtr _bitmap;
            private IntPtr _memoryDC;
            private IntPtr _bitmapDC;
            private IntPtr _restoreDC;
            private IntPtr _oldBitmap;
            private IntPtr _dibBits;
            private PI.StretchBltMode _oldStretchBlt;
            private bool _disposed;

            public GDISurface()
            {
                this._bufferSize = new Size(1, 1);
                this._bitmapDC = PI.CreateCompatibleDC(IntPtr.Zero);
                if (this._bitmapDC == IntPtr.Zero)
                    throw new Win32Exception(Marshal.GetLastWin32Error(), nameof(GDISurface));
                PI.SetStretchBltMode(this._bitmapDC, PI.StretchBltMode.STRETCH_DELETESCANS);
                this.CreateDIB(this._bufferSize);
            }

            //public GDISurface(int width, int height)
            //  : this(new Size(width, height))
            //{
            //}

            public GDISurface(Size sizeBuffer)
            {
                this._bufferSize = sizeBuffer;
                this._bitmapDC = PI.CreateCompatibleDC(IntPtr.Zero);
                this._tileBuffer = new GDISurface();
                if (this._bitmapDC == IntPtr.Zero)
                    throw new Win32Exception(Marshal.GetLastWin32Error(), nameof(GDISurface));
                PI.SetStretchBltMode(this._bitmapDC, PI.StretchBltMode.STRETCH_DELETESCANS);

                this.CreateDIB(this._bufferSize);
            }

            ~GDISurface()
            {
                this.Dispose(false);
            }

            public void Dispose()
            {
                this.Dispose(true);
                GC.SuppressFinalize((object)this);
            }

            internal void Dispose(bool disposing)
            {
                if (!disposing)
                {
                    PI.SelectObject(this._memoryDC, this._oldBitmap);
                    PI.DeleteObject(this._bitmap);
                    PI.DeleteDC(this._memoryDC);
                    PI.DeleteDC(this._bitmapDC);
                }
                else
                {
                    if (this._disposed)
                        return;
                    PI.SelectObject(this._memoryDC, this._oldBitmap);
                    PI.DeleteObject(this._bitmap);
                    PI.DeleteDC(this._memoryDC);
                    PI.DeleteDC(this._bitmapDC);
                    if (this._tileBuffer != null)
                        this._tileBuffer.Dispose();
                    this._tileBuffer = (GDISurface)null;
                    this._memoryDC = IntPtr.Zero;
                    this._bitmapDC = IntPtr.Zero;
                    this._bitmap = IntPtr.Zero;
                    this._oldBitmap = IntPtr.Zero;
                    this._dibBits = IntPtr.Zero;
                    this._disposed = true;
                }
            }

            //public Graphics CreateGraphics(bool clipGraphics)
            //{
            //    Graphics graphics = Graphics.FromHdc(this._memoryDC);
            //    if (!this._clipRect.IsEmpty && clipGraphics)
            //        graphics.SetClip((Rectangle)this._clipRect);
            //    return graphics;
            //}

            private void CreateDIB(Size sizeBuffer)
            {
                if (this._memoryDC == IntPtr.Zero)
                {
                    this._memoryDC = PI.CreateCompatibleDC(IntPtr.Zero);
                    if (this._memoryDC == IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to create memory device context");
                }
                else if (this._oldBitmap != IntPtr.Zero)
                    PI.SelectObject(this._memoryDC, this._oldBitmap);
                if (this._bitmap != IntPtr.Zero)
                    PI.DeleteObject(this._bitmap);
                if (sizeBuffer.Width <= 0)
                    sizeBuffer.Width = 1;
                if (sizeBuffer.Height <= 0)
                    sizeBuffer.Height = 1;
                if (sizeBuffer.Width > 8192)
                    sizeBuffer.Width = 8192;
                if (sizeBuffer.Height > 8192)
                    sizeBuffer.Height = 8192;
                PI.BITMAPINFO pBmi = new PI.BITMAPINFO()
                {
                        biSize = (uint) Marshal.SizeOf(typeof (PI.BITMAPINFO)),
                        biWidth = sizeBuffer.Width,
                        biHeight = -sizeBuffer.Height,
                        biPlanes = (ushort) 1,
                        biBitCount = (ushort) 32,
                        biCompression = 0U
                    
                };
                this._bitmap = PI.CreateDIBSection(IntPtr.Zero, ref pBmi, 0, out this._dibBits, IntPtr.Zero, 0U);
                if (this._bitmap == IntPtr.Zero)
                {
                    int lastWin32Error = Marshal.GetLastWin32Error();
                    throw new Win32Exception(lastWin32Error, string.Format("Unable to create DIB graphics buffer, Size={0}, Win32Error={1}", (object)sizeBuffer, (object)lastWin32Error));
                }
                this._oldBitmap = PI.SelectObject(this._memoryDC, this._bitmap);
                PI.SetStretchBltMode(this._memoryDC, PI.StretchBltMode.STRETCH_DELETESCANS);
                this._sizeSurface = sizeBuffer;
            }

            //private void CreateDDB(Size sizeBuffer)
            //{
            //    if (this._memoryDC == IntPtr.Zero)
            //    {
            //        this._memoryDC = PI.CreateCompatibleDC(IntPtr.Zero);
            //        if (this._memoryDC == IntPtr.Zero)
            //            throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to create memory device context");
            //    }
            //    else if (this._oldBitmap != IntPtr.Zero)
            //        PI.SelectObject(this._memoryDC, this._oldBitmap);
            //    if (this._bitmap != IntPtr.Zero)
            //        PI.DeleteObject(this._bitmap);
            //    if (sizeBuffer.Width <= 0)
            //        sizeBuffer.Width = 1;
            //    if (sizeBuffer.Height <= 0)
            //        sizeBuffer.Height = 1;
            //    if (sizeBuffer.Width > 8192)
            //        sizeBuffer.Width = 8192;
            //    if (sizeBuffer.Height > 8192)
            //        sizeBuffer.Height = 8192;
            //    this._bitmap = PI.CreateBitmap(sizeBuffer.Width, sizeBuffer.Height, 1, 32, IntPtr.Zero);
            //    if (this._bitmap == IntPtr.Zero)
            //        throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to create DIB graphics buffer");
            //    this._oldBitmap = PI.SelectObject(this._memoryDC, this._bitmap);
            //    PI.SetStretchBltMode(this._memoryDC, PI.StretchBltMode.STRETCH_DELETESCANS);
            //    this._sizeSurface = sizeBuffer;
            //}

            //public Bitmap ToBitmap()
            //{
            //    PI.SelectObject(this._memoryDC, this._oldBitmap);
            //    Bitmap bitmap = Image.FromHbitmap(this._bitmap);
            //    PI.SelectObject(this._memoryDC, this._bitmap);
            //    return bitmap;
            //}

            //public Bitmap ToBitmapARGB()
            //{
            //    PI.SelectObject(this._memoryDC, this._oldBitmap);
            //    PI.BITMAP lpvObject = new PI.BITMAP();
            //    PI.GetObject(this._bitmap, Marshal.SizeOf(typeof(PI.BITMAP)), ref lpvObject);
            //    Bitmap bitmap;
            //    if (lpvObject.bmBitsPixel != (ushort)32)
            //    {
            //        bitmap = Image.FromHbitmap(this._bitmap);
            //    }
            //    else
            //    {
            //        bitmap = new Bitmap(lpvObject.bmWidth, lpvObject.bmHeight, lpvObject.bmWidth * 4, PixelFormat.Format32bppPArgb, lpvObject.bmBits);
            //        bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
            //    }
            //    PI.SelectObject(this._memoryDC, this._bitmap);
            //    return bitmap;
            //}

            //public void Attach(IntPtr dc)
            //{
            //    if (!(dc != this._memoryDC) || !(this._restoreDC == IntPtr.Zero))
            //        return;
            //    this._restoreDC = this._memoryDC;
            //    this._memoryDC = dc;
            //    this._oldStretchBlt = PI.SetStretchBltMode(dc, PI.StretchBltMode.STRETCH_DELETESCANS);
            //}

            //public void Detach(IntPtr dc)
            //{
            //    if (!(dc == this._memoryDC) || !(this._restoreDC != IntPtr.Zero))
            //        return;
            //    this._memoryDC = this._restoreDC;
            //    this._restoreDC = IntPtr.Zero;
            //    PI.SetStretchBltMode(dc, this._oldStretchBlt);
            //}

            //public void ResetDefaults()
            //{
            //    if (this._restoreDC != IntPtr.Zero)
            //    {
            //        this._memoryDC = this._restoreDC;
            //        this._restoreDC = IntPtr.Zero;
            //    }
            //    if (this._oldBitmap != IntPtr.Zero)
            //        PI.SelectObject(this._memoryDC, this._oldBitmap);
            //    if (this._bitmap != IntPtr.Zero)
            //        this._oldBitmap = PI.SelectObject(this._memoryDC, this._bitmap);
            //    PI.SelectClipRgn(this._memoryDC, IntPtr.Zero);
            //    PI.SetStretchBltMode(this._memoryDC, PI.StretchBltMode.STRETCH_DELETESCANS);
            //}

            //public void ResetClip()
            //{
            //    this._clipRect = Rectangle.Empty;
            //    PI.SelectClipRgn(this._memoryDC, IntPtr.Zero);
            //}

            //public void SelectClip(IntPtr hRegion)
            //{
            //    PI.SelectClipRgn(this._memoryDC, hRegion);
            //}

            //public void SelectClip(Rectangle clip)
            //{
            //    this._clipRect = clip;
            //    PI.SelectClipRgn(this._memoryDC, IntPtr.Zero);
            //    PI.IntersectClipRect(this._memoryDC, clip.Left, clip.Top, clip.Right, clip.Bottom);
            //}

            //public void ExcludeClip(Rectangle clip)
            //{
            //    PI.SelectClipRgn(this._memoryDC, IntPtr.Zero);
            //    PI.ExcludeClipRect(this._memoryDC, clip.Left, clip.Top, clip.Right, clip.Bottom);
            //}

            //public void CombineClip(Rectangle clip)
            //{
            //    PI.ExcludeClipRect(this._memoryDC, clip.Left, clip.Top, clip.Right, clip.Bottom);
            //}

            //public void IntersecteClip(Rectangle clip)
            //{
            //    PI.IntersectClipRect(this._memoryDC, clip.Left, clip.Top, clip.Right, clip.Bottom);
            //}

            public void TranslateTransform(int x, int y)
            {
                PI.OffsetViewportOrgEx(this._memoryDC, x, y, out _);
            }

            //public void SetViewPortOrigin(Point origin)
            //{
            //    PI.OffsetViewportOrgEx(this._memoryDC, origin.X, origin.Y, out _);
            //}

            //public uint GetPixel(int x, int y)
            //{
            //    return PI.GetPixel(this._memoryDC, x, y);
            //}

            //public void SetPixel(int x, int y, uint rgb)
            //{
            //    PI.SetPixelV(this._memoryDC, x, y, rgb);
            //}

            //public void DrawRectangle(Rectangle bounds, Color color)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._memoryDC, PI.GetStockObject(PI.StockObjects.DC_PEN));
            //    PI.SetDCPenColor(this._memoryDC, color.ToArgb());
            //    PI.MoveToEx(this._memoryDC, bounds.Left, bounds.Top, IntPtr.Zero);
            //    --bounds.Width;
            //    --bounds.Height;
            //    PI.LineTo(this._memoryDC, bounds.Right, bounds.Top);
            //    PI.LineTo(this._memoryDC, bounds.Right, bounds.Bottom);
            //    PI.LineTo(this._memoryDC, bounds.Left, bounds.Bottom);
            //    PI.LineTo(this._memoryDC, bounds.Left, bounds.Top);
            //    PI.SelectObject(this._memoryDC, hgdiobj);
            //}

            //public void DrawFrame(Rectangle bounds, Color color)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._memoryDC, PI.GetStockObject(PI.StockObjects.DC_PEN));
            //    PI.SetDCPenColor(this._memoryDC, color.ToArgb());
            //    PI.SelectObject(this._memoryDC, PI.GetStockObject(5));
            //    PI.Rectangle(this._memoryDC, bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
            //    PI.SelectObject(this._memoryDC, hgdiobj);
            //}

            //public void DrawFrame(Rectangle bounds, Color borderColor, Color backColor)
            //{
            //    IntPtr hgdiobj1 = PI.SelectObject(this._memoryDC, PI.GetStockObject(PI.StockObjects.DC_PEN));
            //    PI.SetDCPenColor(this._memoryDC, borderColor.ToArgb());
            //    IntPtr hgdiobj2 = PI.SelectObject(this._memoryDC, PI.GetStockObject(PI.StockObjects.DC_BRUSH));
            //    PI.SetDCBrushColor(this._memoryDC, backColor.ToArgb());
            //    PI.Rectangle(this._memoryDC, bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
            //    PI.SelectObject(this._memoryDC, hgdiobj1);
            //    PI.SelectObject(this._memoryDC, hgdiobj2);
            //}

            //public void DrawBorder(Rectangle bounds, Border[] borders, GDIColor[] palette)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._memoryDC, PI.GetStockObject(PI.StockObjects.DC_PEN));
            //    for (int index = 0; index < borders.Length; ++index)
            //    {
            //        GDIColor gdiColor1 = palette[(int)borders[index].Left];
            //        GDIColor gdiColor2 = palette[(int)borders[index].Top];
            //        GDIColor gdiColor3 = palette[(int)borders[index].Right];
            //        GDIColor gdiColor4 = palette[(int)borders[index].Bottom];
            //        RectangleX rectangleX = bounds;
            //        --rectangleX.Width;
            //        --rectangleX.Height;
            //        PI.MoveToEx(this._memoryDC, rectangleX.Left, rectangleX.Bottom, IntPtr.Zero);
            //        PI.SetDCPenColor(this._memoryDC, gdiColor1.Value);
            //        PI.LineTo(this._memoryDC, rectangleX.Left, rectangleX.Top);
            //        if (gdiColor2 != gdiColor1)
            //            PI.SetDCPenColor(this._memoryDC, gdiColor2.Value);
            //        PI.LineTo(this._memoryDC, rectangleX.Right, rectangleX.Top);
            //        if (gdiColor3 != gdiColor2)
            //            PI.SetDCPenColor(this._memoryDC, gdiColor3.Value);
            //        PI.LineTo(this._memoryDC, rectangleX.Right, rectangleX.Bottom);
            //        if (gdiColor4 != gdiColor3)
            //            PI.SetDCPenColor(this._memoryDC, gdiColor4.Value);
            //        PI.LineTo(this._memoryDC, rectangleX.Left, rectangleX.Bottom);
            //        bounds.Inflate(-1, -1);
            //    }
            //    PI.SelectObject(this._memoryDC, hgdiobj);
            //}

            //public void DrawRectangle(RectangleX bounds, int width, GDIColor color)
            //{
            //    for (int index = 0; index < width; ++index)
            //    {
            //        this.DrawRectangle(bounds, color);
            //        bounds.Inflate(-1, -1);
            //    }
            //}

            //public void DrawFocusRectangle(
            //  string text,
            //  RectangleX bounds,
            //  RectangleX layout,
            //  GDIFont font,
            //  uint format,
            //  int margins)
            //{
            //    if (2 * this.GetTextExtent("X", font).Height >= layout.Height + 1)
            //        format |= 32U;
            //    RectangleX rectangleX = this.MeasureText(text, layout, font, format);
            //    if (rectangleX.Left <= bounds.Left)
            //        rectangleX.Left = layout.Left;
            //    if (rectangleX.Top <= bounds.Top)
            //        rectangleX.Top = layout.Top;
            //    if (rectangleX.Right >= bounds.Right)
            //        rectangleX.Right = layout.Right;
            //    if (rectangleX.Bottom >= bounds.Bottom)
            //        rectangleX.Bottom = layout.Bottom;
            //    if (margins > 0)
            //        rectangleX.Inflate(margins);
            //    else
            //        rectangleX.Inflate(1, 0);
            //    PI.RECT lprc = new PI.RECT(rectangleX.Left, rectangleX.Top, rectangleX.Right, rectangleX.Bottom);
            //    PI.DrawFocusRect(this._memoryDC, ref lprc);
            //}

            //public void DrawFocusRectangle(RectangleX bounds)
            //{
            //    PI.RECT lprc = new PI.RECT(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
            //    PI.DrawFocusRect(this._memoryDC, ref lprc);
            //}

            //public void FillRectangle(RectangleX bounds, Color color)
            //{
            //    PI.RECT lprc = new PI.RECT(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
            //    IntPtr solidBrush = PI.CreateSolidBrush(ColorTranslator.ToWin32(color));
            //    PI.FillRect(this._memoryDC, ref lprc, solidBrush);
            //    PI.DeleteObject(solidBrush);
            //}

            //public void FillRectangle(Rectangle bounds, Color color)
            //{
            //    PI.RECT lprc = new PI.RECT
            //        {
            //            left = bounds.Left,
            //            top = bounds.Top,
            //            right = bounds.Right,
            //            bottom = bounds.Bottom

            //        };
            //    IntPtr solidBrush = PI.CreateSolidBrush(color.ToArgb());
            //    PI.FillRect(this._memoryDC, ref lprc, solidBrush);
            //    PI.DeleteObject(solidBrush);
            //}

            //public void FillRectangle(RectangleX bounds, Margins margins, GDIColor color)
            //{
            //    IntPtr solidBrush = PI.CreateSolidBrush(color.Value);
            //    PI.RECT lprc = new PI.RECT(bounds.Left, bounds.Top + margins.Top, bounds.Left + margins.Left, bounds.Bottom - margins.Bottom);
            //    PI.FillRect(this._memoryDC, ref lprc, solidBrush);
            //    lprc = new PI.RECT(bounds.Left, bounds.Top, bounds.Right, bounds.Top + margins.Top);
            //    PI.FillRect(this._memoryDC, ref lprc, solidBrush);
            //    lprc = new PI.RECT(bounds.Right - margins.Right, bounds.Top + margins.Top, bounds.Right, bounds.Bottom - margins.Bottom);
            //    PI.FillRect(this._memoryDC, ref lprc, solidBrush);
            //    lprc = new PI.RECT(bounds.Left, bounds.Bottom - margins.Bottom, bounds.Right, bounds.Bottom);
            //    PI.FillRect(this._memoryDC, ref lprc, solidBrush);
            //    PI.DeleteObject(solidBrush);
            //}

            //public void FillRectangle(Rectangle bounds, Brush brush)
            //{
            //    PI.RECT lprc = new PI.RECT
            //    {
            //        left = bounds.Left,
            //        top = bounds.Top,
            //        right = bounds.Right,
            //        bottom = bounds.Bottom

            //    };
            //    PI.FillRect(this._memoryDC, ref lprc, brush.NativeBrush);
            //}

            //public void FillRegion(IntPtr hRegion, GDIColor color)
            //{
            //    IntPtr solidBrush = PI.CreateSolidBrush(color.Value);
            //    PI.FillRgn(this._memoryDC, hRegion, solidBrush);
            //    PI.DeleteObject(solidBrush);
            //}

            //public void FillRegion(IntPtr hRegion, GDIBrush brush)
            //{
            //    PI.FillRgn(this._memoryDC, hRegion, brush.Handle);
            //}

            //public void FillColor(IntPtr hDC, GDIColor oldColor, GDIColor newColor)
            //{
            //    this.FillRectangle(new RectangleX(this._bufferSize), newColor);
            //    PI.TransparentBlt(this._memoryDC, 0, 0, this._bufferSize.Width, this._bufferSize.Height, hDC, 0, 0, this._bufferSize.Width, this._bufferSize.Height, oldColor.Value);
            //}

            //public void FillColor(IntPtr hDC, RectangleX bounds, GDIColor oldColor, GDIColor newColor)
            //{
            //    this.FillRectangle(bounds, newColor);
            //    PI.TransparentBlt(this._memoryDC, bounds.X, bounds.Y, bounds.Width, bounds.Height, hDC, bounds.X, bounds.Y, bounds.Width, bounds.Height, oldColor.Value);
            //}

            //public void Capture(string imageFile)
            //{
            //    using (Bitmap bitmap = new Bitmap(this._sizeSurface.Width, this._sizeSurface.Height, PixelFormat.Format32bppRgb))
            //    {
            //        using (Graphics graphics = Graphics.FromImage((Image)bitmap))
            //        {
            //            IntPtr hdc = graphics.GetHdc();
            //            this.BitBlt(hdc);
            //            graphics.ReleaseHdc(hdc);
            //            bitmap.Save(imageFile, ImageFormat.Bmp);
            //        }
            //    }
            //}

            //public void DrawIcon(IntPtr handle, int x, int y, int width, int height)
            //{
            //    PI.DrawIconEx(this._memoryDC, x, y, handle, width, height, 0, IntPtr.Zero, 3U);
            //}

            //public void DrawText(
            //  string text,
            //  RectangleX bounds,
            //  GDIFont font,
            //  GDIColor textColor,
            //  uint format)
            //{
            //    PI.SelectObject(this._memoryDC, font.Handle);
            //    PI.SetTextColor(this._memoryDC, textColor.Value);
            //    int nMode = PI.SetBkMode(this._memoryDC, 1);
            //    PI.RECT lpRect1 = new PI.RECT(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
            //    if (((int)format & 32) == 0)
            //    {
            //        PI.RECT lpRect2 = new PI.RECT(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
            //        int num = PI.DrawTextW(this._memoryDC, text, text.Length, ref lpRect2, format | 1024U);
            //        if (((int)format & 4) != 0)
            //        {
            //            lpRect1.left = bounds.Left;
            //            lpRect1.right = bounds.Right;
            //            lpRect1.top = bounds.Height > num ? bounds.Top + (bounds.Height - num) / 2 : bounds.Top;
            //            lpRect1.bottom = bounds.Bottom;
            //        }
            //        else if (((int)format & 8) != 0)
            //        {
            //            lpRect1.left = bounds.Left;
            //            lpRect1.right = bounds.Right;
            //            lpRect1.top = bounds.Height > num ? bounds.Bottom - num : bounds.Top;
            //            lpRect1.bottom = bounds.Bottom;
            //        }
            //        else
            //        {
            //            lpRect1.left = bounds.Left;
            //            lpRect1.right = bounds.Right;
            //            lpRect1.top = bounds.Top;
            //            lpRect1.bottom = bounds.Height > num ? bounds.Top + num : bounds.Bottom;
            //        }
            //    }
            //    PI.DrawTextW(this._memoryDC, text, text.Length, ref lpRect1, format);
            //    PI.SetBkMode(this._memoryDC, nMode);
            //}

            //public RectangleX MeasureText(
            //  string text,
            //  RectangleX bounds,
            //  GDIFont font,
            //  uint format)
            //{
            //    if (font == null)
            //        font = GDIFont.DefaultControlFont;
            //    PI.SelectObject(this._memoryDC, font.Handle);
            //    PI.RECT lpRect = new PI.RECT(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
            //    PI.DrawTextW(this._memoryDC, text, text.Length, ref lpRect, format | 1024U);
            //    RectangleX rectangleX = new RectangleX(lpRect.left, lpRect.top, lpRect.right, lpRect.bottom);
            //    if (((int)format & 1) != 0)
            //        rectangleX.AlignHC(bounds);
            //    else if (((int)format & 2) != 0)
            //        rectangleX.AlignR(bounds);
            //    if (((int)format & 4) != 0)
            //        rectangleX.AlignVC(bounds);
            //    else if (((int)format & 8) != 0)
            //        rectangleX.AlignB(bounds);
            //    return rectangleX;
            //}

            //public Size MeasureText(string text, GDIFont font, uint format)
            //{
            //    if (font == null)
            //        font = GDIFont.DefaultControlFont;
            //    PI.SelectObject(this._memoryDC, font.Handle);
            //    PI.RECT lpRect;
            //    lpRect.left = 0;
            //    lpRect.top = 0;
            //    lpRect.right = (int)ushort.MaxValue;
            //    lpRect.bottom = (int)ushort.MaxValue;
            //    PI.DrawTextW(this._memoryDC, text, text.Length, ref lpRect, format | 1024U);
            //    return new Size(lpRect.right, lpRect.bottom);
            //}

            //public Size GetTextExtent(string text, GDIFont font)
            //{
            //    if (font == null)
            //        font = GDIFont.DefaultControlFont;
            //    PI.SelectObject(this._memoryDC, font.Handle);
            //    PI.SIZE lpSize;
            //    PI.GetTextExtentPoint32W(this._memoryDC, text, text.Length, out lpSize);
            //    return new Size(lpSize.cx, lpSize.cy);
            //}

            //public Size GetFontHeight(GDIFont font)
            //{
            //    if (font == null)
            //        font = GDIFont.DefaultControlFont;
            //    PI.SelectObject(this._memoryDC, font.Handle);
            //    PI.RECT lpRect = new PI.RECT(0, 0, (int)short.MaxValue, (int)short.MaxValue);
            //    PI.DrawTextW(this._memoryDC, "X", 1, ref lpRect, 9232U);
            //    return new Size(lpRect.Width, lpRect.Height);
            //}

            //public void DrawGDIPText(
            //  string text,
            //  RectangleX layout,
            //  ContentAlignment textAlign,
            //  Font font,
            //  Color textColor)
            //{
            //    using (StringFormat format = new StringFormat())
            //    {
            //        int num = (int)textAlign;
            //        if ((num & 15) != 0)
            //            format.LineAlignment = StringAlignment.Near;
            //        else if ((num & 3840) != 0)
            //        {
            //            num >>= 8;
            //            format.LineAlignment = StringAlignment.Far;
            //        }
            //        else
            //        {
            //            num >>= 4;
            //            format.LineAlignment = StringAlignment.Center;
            //        }
            //        switch (num)
            //        {
            //            case 1:
            //                format.Alignment = StringAlignment.Near;
            //                break;
            //            case 2:
            //                format.Alignment = StringAlignment.Center;
            //                break;
            //            case 4:
            //                format.Alignment = StringAlignment.Far;
            //                break;
            //        }
            //        using (SolidBrush solidBrush = new SolidBrush(textColor))
            //        {
            //            using (Graphics graphics = this.CreateGraphics(true))
            //            {
            //                graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            //                graphics.DrawString(text, font, (Brush)solidBrush, (RectangleF)layout, format);
            //            }
            //        }
            //    }
            //}

            //public void BitBlt(IntPtr dc)
            //{
            //    PI.BitBlt(dc, 0, 0, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, 0, 0, 13369376U);
            //}

            //public void BitBlt(IntPtr dc, RectangleX srcRect)
            //{
            //    PI.BitBlt(dc, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, this._memoryDC, srcRect.X, srcRect.Y, 13369376U);
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY)
            //{
            //    PI.BitBlt(dc, dstX, dstY, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, 0, 0, 13369376U);
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY, int srcX, int srcY)
            //{
            //    PI.BitBlt(dc, dstX, dstY, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, srcX, srcY, 13369376U);
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY, RectangleX srcRect)
            //{
            //    PI.BitBlt(dc, dstX, dstY, srcRect.Width, srcRect.Height, this._memoryDC, srcRect.X, srcRect.Y, 13369376U);
            //}

            //public void BitBlt(IntPtr dc, RectangleX dstRect, int srcX, int srcY)
            //{
            //    PI.BitBlt(dc, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._memoryDC, srcX, srcY, 13369376U);
            //}

            //public void BitBlt(IntPtr dc, Margins margin)
            //{
            //    PI.BitBlt(dc, 0, 0, this._bufferSize.Width, margin.Top, this._memoryDC, 0, 0, 13369376U);
            //    PI.BitBlt(dc, 0, this._bufferSize.Height - margin.Bottom, this._bufferSize.Width, margin.Bottom, this._memoryDC, 0, this._bufferSize.Height - margin.Bottom, 13369376U);
            //    PI.BitBlt(dc, 0, margin.Top, margin.Left, this._bufferSize.Height - margin.Height, this._memoryDC, 0, margin.Top, 13369376U);
            //    PI.BitBlt(dc, this._bufferSize.Width - margin.Right, margin.Top, margin.Right, this._bufferSize.Height - margin.Height, this._memoryDC, this._bufferSize.Width - margin.Right, margin.Top, 13369376U);
            //}

            //public void BitBlt(IntPtr dc, RectangleX dstRect, RectangleX srcRect)
            //{
            //    if (dstRect.Size == srcRect.Size)
            //        PI.BitBlt(dc, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._memoryDC, srcRect.X, srcRect.Y, 13369376U);
            //    else
            //        PI.StretchBlt(dc, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._memoryDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, 13369376U);
            //}

            //public void BitBlt(
            //  IntPtr dc,
            //  int dstX,
            //  int dstY,
            //  int nDstWidth,
            //  int nDstHeight,
            //  int srcX,
            //  int srcY,
            //  int nSrcWidth,
            //  int nSrcHeight)
            //{
            //    if (nDstWidth == nSrcWidth && nDstHeight == nSrcHeight)
            //        PI.BitBlt(dc, dstX, dstY, nDstWidth, nDstHeight, this._memoryDC, srcX, srcY, 13369376U);
            //    else
            //        PI.StretchBlt(dc, dstX, dstY, nDstWidth, nDstHeight, this._memoryDC, srcX, srcY, nSrcWidth, nSrcHeight, 13369376U);
            //}

            //public void BitBlt(IntPtr dc, GDIColor transparent)
            //{
            //    PI.TransparentBlt(dc, 0, 0, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, 0, 0, this._bufferSize.Width, this._bufferSize.Height, transparent.Value);
            //}

            //public void BitBlt(IntPtr dc, int opacity)
            //{
            //    PI.AlphaBlend(dc, 0, 0, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, 0, 0, this._bufferSize.Width, this._bufferSize.Height, new PI.BLENDFUNCTION()
            //    {
            //        BlendOp = (byte)0,
            //        BlendFlags = (byte)0,
            //        SourceConstantAlpha = (byte)opacity,
            //        AlphaFormat = (byte)1
            //    });
            //}

            //public void BitBlt(IntPtr dc, RectangleX srcRect, GDIColor transparent)
            //{
            //    PI.TransparentBlt(dc, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, this._memoryDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, transparent.Value);
            //}

            //public void BitBlt(IntPtr dc, RectangleX srcRect, int opacity)
            //{
            //    PI.AlphaBlend(dc, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, this._memoryDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, new PI.BLENDFUNCTION()
            //    {
            //        BlendOp = (byte)0,
            //        BlendFlags = (byte)0,
            //        SourceConstantAlpha = (byte)opacity,
            //        AlphaFormat = (byte)1
            //    });
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY, GDIColor transparent)
            //{
            //    PI.TransparentBlt(dc, dstX, dstY, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, 0, 0, this._bufferSize.Width, this._bufferSize.Height, transparent.Value);
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY, int opacity)
            //{
            //    PI.AlphaBlend(dc, dstX, dstY, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, 0, 0, this._bufferSize.Width, this._bufferSize.Height, new PI.BLENDFUNCTION()
            //    {
            //        BlendOp = (byte)0,
            //        BlendFlags = (byte)0,
            //        SourceConstantAlpha = (byte)opacity,
            //        AlphaFormat = (byte)1
            //    });
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY, int srcX, int srcY, GDIColor transparent)
            //{
            //    PI.TransparentBlt(dc, dstX, dstY, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, srcX, srcY, this._bufferSize.Width, this._bufferSize.Height, transparent.Value);
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY, int srcX, int srcY, int opacity)
            //{
            //    PI.AlphaBlend(dc, dstX, dstY, this._bufferSize.Width, this._bufferSize.Height, this._memoryDC, srcX, srcY, this._bufferSize.Width, this._bufferSize.Height, new PI.BLENDFUNCTION()
            //    {
            //        BlendOp = (byte)0,
            //        BlendFlags = (byte)0,
            //        SourceConstantAlpha = (byte)opacity,
            //        AlphaFormat = (byte)1
            //    });
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY, RectangleX srcRect, GDIColor transparent)
            //{
            //    PI.TransparentBlt(dc, dstX, dstY, srcRect.Width, srcRect.Height, this._memoryDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, transparent.Value);
            //}

            //public void BitBlt(IntPtr dc, int dstX, int dstY, RectangleX srcRect, int opacity)
            //{
            //    PI.AlphaBlend(dc, dstX, dstY, srcRect.Width, srcRect.Height, this._memoryDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, new PI.BLENDFUNCTION()
            //    {
            //        BlendOp = (byte)0,
            //        BlendFlags = (byte)0,
            //        SourceConstantAlpha = (byte)opacity,
            //        AlphaFormat = (byte)1
            //    });
            //}

            //public void BitBlt(IntPtr dc, RectangleX dstRect, int srcX, int srcY, GDIColor transparent)
            //{
            //    PI.TransparentBlt(dc, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._memoryDC, srcX, srcY, dstRect.Width, dstRect.Height, transparent.Value);
            //}

            //public void BitBlt(IntPtr dc, RectangleX dstRect, int srcX, int srcY, int opacity)
            //{
            //    PI.AlphaBlend(dc, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._memoryDC, srcX, srcY, dstRect.Width, dstRect.Height, new PI.BLENDFUNCTION()
            //    {
            //        BlendOp = (byte)0,
            //        BlendFlags = (byte)0,
            //        SourceConstantAlpha = (byte)opacity,
            //        AlphaFormat = (byte)1
            //    });
            //}

            //public void BitBlt(IntPtr dc, RectangleX dstRect, RectangleX srcRect, GDIColor transparent)
            //{
            //    PI.TransparentBlt(dc, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._memoryDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, transparent.Value);
            //}

            //public void BitBlt(IntPtr dc, RectangleX dstRect, RectangleX srcRect, int opacity)
            //{
            //    PI.AlphaBlend(dc, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._memoryDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, new PI.BLENDFUNCTION()
            //    {
            //        BlendOp = (byte)0,
            //        BlendFlags = (byte)0,
            //        SourceConstantAlpha = (byte)opacity,
            //        AlphaFormat = (byte)1
            //    });
            //}

            //public void DrawImage(GDIBitmap image)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.BitBlt(this._memoryDC, 0, 0, image.Width, image.Height, this._bitmapDC, 0, 0, 13369376U);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(GDIBitmap image, RectangleX dstRect, int dstX, int dstY)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.BitBlt(this._memoryDC, dstX, dstY, dstRect.Width, dstRect.Height, this._bitmapDC, dstRect.X, dstRect.Y, 13369376U);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  ContentAlignment alignment)
            //{
            //    RectangleX rectangleX = new RectangleX(srcRect.Width, srcRect.Height);
            //    rectangleX.Align(dstRect, alignment);
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.BitBlt(this._memoryDC, rectangleX.X, rectangleX.Y, rectangleX.Width, rectangleX.Height, this._bitmapDC, srcRect.X, srcRect.Y, 13369376U);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(GDIBitmap image, int dstX, int dstY)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.BitBlt(this._memoryDC, dstX, dstY, image.Width, image.Height, this._bitmapDC, 0, 0, 13369376U);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(GDIBitmap image, int dstX, int dstY, RectangleX srcRect)
            //{
            //    RectangleX rectangleX = new RectangleX(srcRect.Width, srcRect.Height);
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.BitBlt(this._memoryDC, dstX, dstY, rectangleX.Width, rectangleX.Height, this._bitmapDC, srcRect.X, srcRect.Y, 13369376U);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(GDIBitmap image, int opacity)
            //{
            //    PI.BLENDFUNCTION blend = new PI.BLENDFUNCTION();
            //    blend.BlendOp = (byte)0;
            //    blend.BlendFlags = (byte)0;
            //    blend.SourceConstantAlpha = (byte)opacity;
            //    blend.AlphaFormat = (byte)1;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.AlphaBlend(this._memoryDC, 0, 0, image.Width, image.Height, this._bitmapDC, 0, 0, image.Width, image.Height, blend);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(GDIBitmap image, RectangleX dstRect, GDIColor transparent)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.TransparentBlt(this._memoryDC, 0, 0, dstRect.Width, dstRect.Height, this._bitmapDC, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, transparent.Value);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(GDIBitmap image, int dstX, int dstY, int opacity)
            //{
            //    PI.BLENDFUNCTION blend = new PI.BLENDFUNCTION();
            //    blend.BlendOp = (byte)0;
            //    blend.BlendFlags = (byte)0;
            //    blend.SourceConstantAlpha = (byte)opacity;
            //    blend.AlphaFormat = (byte)1;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.AlphaBlend(this._memoryDC, dstX, dstY, image.Width, image.Height, this._bitmapDC, 0, 0, image.Width, image.Height, blend);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(GDIBitmap image, int dstX, int dstY, GDIColor transparent)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.TransparentBlt(this._memoryDC, dstX, dstY, image.Width, image.Height, this._bitmapDC, 0, 0, image.Width, image.Height, transparent.Value);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  ContentAlignment alignment,
            //  int opacity)
            //{
            //    RectangleX rectangleX = new RectangleX(srcRect.Width, srcRect.Height);
            //    rectangleX.Align(dstRect, alignment);
            //    PI.BLENDFUNCTION blend = new PI.BLENDFUNCTION();
            //    blend.BlendOp = (byte)0;
            //    blend.BlendFlags = (byte)0;
            //    blend.SourceConstantAlpha = (byte)opacity;
            //    blend.AlphaFormat = (byte)1;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.AlphaBlend(this._memoryDC, rectangleX.X, rectangleX.Y, rectangleX.Width, rectangleX.Height, this._bitmapDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, blend);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(GDIBitmap image, int dstX, int dstY, RectangleX srcRect, int opacity)
            //{
            //    RectangleX rectangleX = new RectangleX(srcRect.Width, srcRect.Height);
            //    PI.BLENDFUNCTION blend = new PI.BLENDFUNCTION();
            //    blend.BlendOp = (byte)0;
            //    blend.BlendFlags = (byte)0;
            //    blend.SourceConstantAlpha = (byte)opacity;
            //    blend.AlphaFormat = (byte)1;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.AlphaBlend(this._memoryDC, dstX, dstY, rectangleX.Width, rectangleX.Height, this._bitmapDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, blend);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  ContentAlignment alignment,
            //  GDIColor transparent)
            //{
            //    RectangleX rectangleX = new RectangleX(srcRect.Width, srcRect.Height);
            //    rectangleX.Align(dstRect, alignment);
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.TransparentBlt(this._memoryDC, rectangleX.X, rectangleX.Y, rectangleX.Width, rectangleX.Height, this._bitmapDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, transparent.Value);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void DrawImage(
            //  GDIBitmap image,
            //  int dstX,
            //  int dstY,
            //  RectangleX srcRect,
            //  GDIColor transparent)
            //{
            //    RectangleX rectangleX = new RectangleX(srcRect.Width, srcRect.Height);
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.TransparentBlt(this._memoryDC, dstX, dstY, rectangleX.Width, rectangleX.Height, this._bitmapDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, transparent.Value);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void StretchImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  Margins sizing,
            //  bool borderOnly)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    if (sizing.Width > dstRect.Width)
            //    {
            //        double num = (double)dstRect.Width / (double)sizing.Width;
            //        sizing.Left = (int)(num * (double)sizing.Left);
            //        sizing.Right = (int)(num * (double)sizing.Right);
            //    }
            //    if (sizing.Height > dstRect.Height)
            //    {
            //        double num = (double)dstRect.Height / (double)sizing.Height;
            //        sizing.Top = (int)(num * (double)sizing.Top);
            //        sizing.Bottom = (int)(num * (double)sizing.Bottom);
            //    }
            //    int num1 = srcRect.Height - sizing.Height;
            //    int num2 = srcRect.Width - sizing.Width;
            //    if (sizing.Left > 0)
            //        PI.StretchBlt(this._memoryDC, dstRect.Left, dstRect.Top + sizing.Top, sizing.Left, dstRect.Height - sizing.Height, this._bitmapDC, srcRect.Left, srcRect.Top + sizing.Top, sizing.Left, num1 > 0 ? num1 : 1, 13369376U);
            //    if (sizing.Right > 0)
            //        PI.StretchBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top + sizing.Top, sizing.Right, dstRect.Height - sizing.Height, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top + sizing.Top, sizing.Right, num1 > 0 ? num1 : 1, 13369376U);
            //    if (sizing.Bottom > 0)
            //    {
            //        PI.StretchBlt(this._memoryDC, dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom, dstRect.Width - sizing.Width, sizing.Bottom, this._bitmapDC, srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom, num2 > 0 ? num2 : 1, sizing.Bottom, 13369376U);
            //        if (sizing.Left > 0)
            //            PI.BitBlt(this._memoryDC, dstRect.Left, dstRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, this._bitmapDC, srcRect.Left, srcRect.Bottom - sizing.Bottom, 13369376U);
            //        if (sizing.Right > 0)
            //            PI.BitBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Bottom - sizing.Bottom, 13369376U);
            //    }
            //    if (sizing.Top > 0)
            //    {
            //        PI.StretchBlt(this._memoryDC, dstRect.Left + sizing.Left, dstRect.Top, dstRect.Width - sizing.Width, sizing.Top, this._bitmapDC, srcRect.Left + sizing.Left, srcRect.Top, num2 > 0 ? num2 : 1, sizing.Top, 13369376U);
            //        if (sizing.Left > 0)
            //            PI.BitBlt(this._memoryDC, dstRect.Left, dstRect.Top, sizing.Left, sizing.Top, this._bitmapDC, srcRect.Left, srcRect.Top, 13369376U);
            //        if (sizing.Right > 0)
            //            PI.BitBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top, sizing.Right, sizing.Top, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top, 13369376U);
            //    }
            //    if (!borderOnly)
            //    {
            //        srcRect.Deflate(sizing);
            //        if (num2 <= 0)
            //            srcRect.Width = 1;
            //        if (num1 <= 0)
            //            srcRect.Height = 1;
            //        dstRect.Deflate(sizing);
            //        PI.StretchBlt(this._memoryDC, dstRect.Left, dstRect.Top, dstRect.Width, dstRect.Height, this._bitmapDC, srcRect.Left, srcRect.Top, srcRect.Width, srcRect.Height, 13369376U);
            //    }
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void StretchImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  Margins sizing,
            //  GDIColor transparent,
            //  bool borderOnly)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    if (sizing.Width > dstRect.Width)
            //    {
            //        double num = (double)dstRect.Width / (double)sizing.Width;
            //        sizing.Left = (int)(num * (double)sizing.Left);
            //        sizing.Right = (int)(num * (double)sizing.Right);
            //    }
            //    if (sizing.Height > dstRect.Height)
            //    {
            //        double num = (double)dstRect.Height / (double)sizing.Height;
            //        sizing.Top = (int)(num * (double)sizing.Top);
            //        sizing.Bottom = (int)(num * (double)sizing.Bottom);
            //    }
            //    int num1 = srcRect.Height - sizing.Height;
            //    int num2 = srcRect.Width - sizing.Width;
            //    if (sizing.Left > 0)
            //        PI.TransparentBlt(this._memoryDC, dstRect.Left, dstRect.Top + sizing.Top, sizing.Left, dstRect.Height - sizing.Height, this._bitmapDC, srcRect.Left, srcRect.Top + sizing.Top, sizing.Left, num1 > 0 ? num1 : 1, transparent.Value);
            //    if (sizing.Right > 0)
            //        PI.TransparentBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top + sizing.Top, sizing.Right, dstRect.Height - sizing.Height, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top + sizing.Top, sizing.Right, num1 > 0 ? num1 : 1, transparent.Value);
            //    if (sizing.Top > 0)
            //    {
            //        PI.TransparentBlt(this._memoryDC, dstRect.Left + sizing.Left, dstRect.Top, dstRect.Width - sizing.Width, sizing.Top, this._bitmapDC, srcRect.Left + sizing.Left, srcRect.Top, num2 > 0 ? num2 : 1, sizing.Top, transparent.Value);
            //        if (sizing.Left > 0)
            //            PI.TransparentBlt(this._memoryDC, dstRect.Left, dstRect.Top, sizing.Left, sizing.Top, this._bitmapDC, srcRect.Left, srcRect.Top, sizing.Left, sizing.Top, transparent.Value);
            //        if (sizing.Right > 0)
            //            PI.TransparentBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top, sizing.Right, sizing.Top, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top, sizing.Right, sizing.Top, transparent.Value);
            //    }
            //    if (sizing.Bottom > 0)
            //    {
            //        PI.TransparentBlt(this._memoryDC, dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom, dstRect.Width - sizing.Width, sizing.Bottom, this._bitmapDC, srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom, num2 > 0 ? num2 : 1, sizing.Bottom, transparent.Value);
            //        if (sizing.Left > 0)
            //            PI.TransparentBlt(this._memoryDC, dstRect.Left, dstRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, this._bitmapDC, srcRect.Left, srcRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, transparent.Value);
            //        if (sizing.Right > 0)
            //            PI.TransparentBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, transparent.Value);
            //    }
            //    if (!borderOnly)
            //    {
            //        srcRect.Deflate(sizing);
            //        if (num2 <= 0)
            //            srcRect.Width = 1;
            //        if (num1 <= 0)
            //            srcRect.Height = 1;
            //        dstRect.Deflate(sizing);
            //        PI.TransparentBlt(this._memoryDC, dstRect.Left, dstRect.Top, dstRect.Width, dstRect.Height, this._bitmapDC, srcRect.Left, srcRect.Top, srcRect.Width, srcRect.Height, transparent.Value);
            //    }
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void StretchImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  Margins sizing,
            //  int opacity,
            //  bool borderOnly)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.BLENDFUNCTION blend = new PI.BLENDFUNCTION();
            //    blend.BlendOp = (byte)0;
            //    blend.BlendFlags = (byte)0;
            //    blend.SourceConstantAlpha = (byte)opacity;
            //    blend.AlphaFormat = (byte)1;
            //    if (sizing.Width > dstRect.Width)
            //    {
            //        double num = (double)dstRect.Width / (double)sizing.Width;
            //        sizing.Left = (int)(num * (double)sizing.Left);
            //        sizing.Right = (int)(num * (double)sizing.Right);
            //    }
            //    if (sizing.Height > dstRect.Height)
            //    {
            //        double num = (double)dstRect.Height / (double)sizing.Height;
            //        sizing.Top = (int)(num * (double)sizing.Top);
            //        sizing.Bottom = (int)(num * (double)sizing.Bottom);
            //    }
            //    int num1 = srcRect.Height - sizing.Height;
            //    int num2 = srcRect.Width - sizing.Width;
            //    if (sizing.Left > 0)
            //        PI.AlphaBlend(this._memoryDC, dstRect.Left, dstRect.Top + sizing.Top, sizing.Left, dstRect.Height - sizing.Height, this._bitmapDC, srcRect.Left, srcRect.Top + sizing.Top, sizing.Left, num1 > 0 ? num1 : 1, blend);
            //    if (sizing.Right > 0)
            //        PI.AlphaBlend(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top + sizing.Top, sizing.Right, dstRect.Height - sizing.Height, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top + sizing.Top, sizing.Right, num1 > 0 ? num1 : 1, blend);
            //    if (sizing.Top > 0)
            //    {
            //        PI.AlphaBlend(this._memoryDC, dstRect.Left + sizing.Left, dstRect.Top, dstRect.Width - sizing.Width, sizing.Top, this._bitmapDC, srcRect.Left + sizing.Left, srcRect.Top, num2 > 0 ? num2 : 1, sizing.Top, blend);
            //        if (sizing.Left > 0)
            //            PI.AlphaBlend(this._memoryDC, dstRect.Left, dstRect.Top, sizing.Left, sizing.Top, this._bitmapDC, srcRect.Left, srcRect.Top, sizing.Left, sizing.Top, blend);
            //        if (sizing.Right > 0)
            //            PI.AlphaBlend(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top, sizing.Right, sizing.Top, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top, sizing.Right, sizing.Top, blend);
            //    }
            //    if (sizing.Bottom > 0)
            //    {
            //        PI.AlphaBlend(this._memoryDC, dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom, dstRect.Width - sizing.Width, sizing.Bottom, this._bitmapDC, srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom, num2 > 0 ? num2 : 1, sizing.Bottom, blend);
            //        if (sizing.Left > 0)
            //            PI.AlphaBlend(this._memoryDC, dstRect.Left, dstRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, this._bitmapDC, srcRect.Left, srcRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, blend);
            //        if (sizing.Right > 0)
            //            PI.AlphaBlend(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, blend);
            //    }
            //    if (!borderOnly)
            //    {
            //        srcRect.Deflate(sizing);
            //        if (num2 <= 0)
            //            srcRect.Width = 1;
            //        if (num1 <= 0)
            //            srcRect.Height = 1;
            //        dstRect.Deflate(sizing);
            //        PI.AlphaBlend(this._memoryDC, dstRect.Left, dstRect.Top, dstRect.Width, dstRect.Height, this._bitmapDC, srcRect.Left, srcRect.Top, srcRect.Width, srcRect.Height, blend);
            //    }
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void StretchImage(GDIBitmap image, RectangleX dstRect, RectangleX srcRect)
            //{
            //    if (srcRect.Width == 0)
            //        srcRect.Width = 1;
            //    if (srcRect.Height == 0)
            //        srcRect.Height = 1;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.StretchBlt(this._memoryDC, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._bitmapDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, 13369376U);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void StretchImage(GDIBitmap image, RectangleX dstRect, RectangleX srcRect, int opacity)
            //{
            //    PI.BLENDFUNCTION blend = new PI.BLENDFUNCTION();
            //    blend.BlendOp = (byte)0;
            //    blend.BlendFlags = (byte)0;
            //    blend.SourceConstantAlpha = (byte)opacity;
            //    blend.AlphaFormat = (byte)1;
            //    if (srcRect.Width == 0)
            //        srcRect.Width = 1;
            //    if (srcRect.Height == 0)
            //        srcRect.Height = 1;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.AlphaBlend(this._memoryDC, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._bitmapDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, blend);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void StretchImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  GDIColor transparent)
            //{
            //    if (srcRect.Width == 0)
            //        srcRect.Width = 1;
            //    if (srcRect.Height == 0)
            //        srcRect.Height = 1;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    PI.TransparentBlt(this._memoryDC, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, this._bitmapDC, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, transparent.Value);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void TileImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  TileMode tileMode)
            //{
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    this.TileImage(this._bitmapDC, dstRect, srcRect, tileMode);
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void TileImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  Margins sizing,
            //  bool borderOnly)
            //{
            //    RectangleX srcRect1 = RectangleX.Empty;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    if (sizing.Width > dstRect.Width)
            //    {
            //        sizing.Left = dstRect.Width / 2;
            //        sizing.Right = dstRect.Width - sizing.Left;
            //    }
            //    if (sizing.Height > dstRect.Height)
            //    {
            //        sizing.Top = dstRect.Height / 2;
            //        sizing.Bottom = dstRect.Height - sizing.Top;
            //    }
            //    if (sizing.Top > 0)
            //    {
            //        if (sizing.Left > 0)
            //            PI.BitBlt(this._memoryDC, dstRect.Left, dstRect.Top, sizing.Left, sizing.Top, this._bitmapDC, srcRect.Left, srcRect.Top, 13369376U);
            //        if (sizing.Right > 0)
            //            PI.BitBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top, sizing.Right, sizing.Top, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top, 13369376U);
            //        srcRect1 = new RectangleX(srcRect.Left + sizing.Left, srcRect.Top, srcRect.Right - sizing.Right, srcRect.Top + sizing.Top);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left + sizing.Left, dstRect.Top, dstRect.Right - sizing.Right, dstRect.Top + sizing.Top), srcRect1, TileMode.TileX);
            //    }
            //    if (sizing.Bottom > 0)
            //    {
            //        if (sizing.Left > 0)
            //            PI.BitBlt(this._memoryDC, dstRect.Left, dstRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, this._bitmapDC, srcRect.Left, srcRect.Bottom - sizing.Bottom, 13369376U);
            //        if (sizing.Right > 0)
            //            PI.BitBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Bottom - sizing.Bottom, 13369376U);
            //        srcRect1 = new RectangleX(srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom, srcRect.Right - sizing.Right, srcRect.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom, dstRect.Right - sizing.Right, dstRect.Bottom), srcRect1, TileMode.TileX);
            //    }
            //    if (sizing.Left > 0)
            //    {
            //        srcRect1 = new RectangleX(srcRect.Left, srcRect.Top + sizing.Top, srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left, dstRect.Top + sizing.Top, dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom), srcRect1, TileMode.TileY);
            //    }
            //    if (sizing.Right > 0)
            //    {
            //        srcRect1 = new RectangleX(srcRect.Right - sizing.Right, srcRect.Top + sizing.Top, srcRect.Right, srcRect.Bottom - sizing.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Right - sizing.Right, dstRect.Top + sizing.Top, dstRect.Right, dstRect.Bottom - sizing.Bottom), srcRect1, TileMode.TileY);
            //    }
            //    if (!borderOnly)
            //    {
            //        srcRect.Deflate(sizing);
            //        dstRect.Deflate(sizing);
            //        this.TileImage(this._bitmapDC, dstRect, srcRect, TileMode.TileXY);
            //    }
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void TileImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  Margins sizing,
            //  GDIColor transparent,
            //  bool borderOnly)
            //{
            //    RectangleX srcRect1 = RectangleX.Empty;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    if (sizing.Width > dstRect.Width)
            //    {
            //        sizing.Left = dstRect.Width / 2;
            //        sizing.Right = dstRect.Width - sizing.Left;
            //    }
            //    if (sizing.Height > dstRect.Height)
            //    {
            //        sizing.Top = dstRect.Height / 2;
            //        sizing.Bottom = dstRect.Height - sizing.Top;
            //    }
            //    if (sizing.Top > 0)
            //    {
            //        if (sizing.Left > 0)
            //            PI.TransparentBlt(this._memoryDC, dstRect.Left, dstRect.Top, sizing.Left, sizing.Top, this._bitmapDC, srcRect.Left, srcRect.Top, sizing.Left, sizing.Top, transparent.Value);
            //        if (sizing.Right > 0)
            //            PI.TransparentBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top, sizing.Right, sizing.Top, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top, sizing.Right, sizing.Top, transparent.Value);
            //        srcRect1 = new RectangleX(srcRect.Left + sizing.Left, srcRect.Top, srcRect.Right - sizing.Right, srcRect.Top + sizing.Top);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left + sizing.Left, dstRect.Top, dstRect.Right - sizing.Right, dstRect.Top + sizing.Top), srcRect1, TileMode.TileX, transparent);
            //    }
            //    if (sizing.Bottom > 0)
            //    {
            //        if (sizing.Left > 0)
            //            PI.TransparentBlt(this._memoryDC, dstRect.Left, dstRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, this._bitmapDC, srcRect.Left, srcRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, transparent.Value);
            //        if (sizing.Right > 0)
            //            PI.TransparentBlt(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, transparent.Value);
            //        srcRect1 = new RectangleX(srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom, srcRect.Right - sizing.Right, srcRect.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom, dstRect.Right - sizing.Right, dstRect.Bottom), srcRect1, TileMode.TileX, transparent);
            //    }
            //    if (sizing.Left > 0)
            //    {
            //        srcRect1 = new RectangleX(srcRect.Left, srcRect.Top + sizing.Top, srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left, dstRect.Top + sizing.Top, dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom), srcRect1, TileMode.TileY, transparent);
            //    }
            //    if (sizing.Right > 0)
            //    {
            //        srcRect1 = new RectangleX(srcRect.Right - sizing.Right, srcRect.Top + sizing.Top, srcRect.Right, srcRect.Bottom - sizing.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Right - sizing.Right, dstRect.Top + sizing.Top, dstRect.Right, dstRect.Bottom - sizing.Bottom), srcRect1, TileMode.TileY, transparent);
            //    }
            //    if (!borderOnly)
            //    {
            //        srcRect.Deflate(sizing);
            //        dstRect.Deflate(sizing);
            //        this.TileImage(this._bitmapDC, dstRect, srcRect, TileMode.TileXY, transparent);
            //    }
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void TileImage(
            //  GDIBitmap image,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  Margins sizing,
            //  int opacity,
            //  bool borderOnly)
            //{
            //    RectangleX srcRect1 = RectangleX.Empty;
            //    PI.BLENDFUNCTION blend = new PI.BLENDFUNCTION();
            //    blend.BlendOp = (byte)0;
            //    blend.BlendFlags = (byte)0;
            //    blend.SourceConstantAlpha = (byte)opacity;
            //    blend.AlphaFormat = (byte)1;
            //    IntPtr hgdiobj = PI.SelectObject(this._bitmapDC, image.Handle);
            //    if (sizing.Width > dstRect.Width)
            //    {
            //        sizing.Left = dstRect.Width / 2;
            //        sizing.Right = dstRect.Width - sizing.Left;
            //    }
            //    if (sizing.Height > dstRect.Height)
            //    {
            //        sizing.Top = dstRect.Height / 2;
            //        sizing.Bottom = dstRect.Height - sizing.Top;
            //    }
            //    if (sizing.Top > 0)
            //    {
            //        if (sizing.Left > 0)
            //            PI.AlphaBlend(this._memoryDC, dstRect.Left, dstRect.Top, sizing.Left, sizing.Top, this._bitmapDC, srcRect.Left, srcRect.Top, sizing.Left, sizing.Top, blend);
            //        if (sizing.Right > 0)
            //            PI.AlphaBlend(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Top, sizing.Right, sizing.Top, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Top, sizing.Right, sizing.Top, blend);
            //        srcRect1 = new RectangleX(srcRect.Left + sizing.Left, srcRect.Top, srcRect.Right - sizing.Right, srcRect.Top + sizing.Top);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left + sizing.Left, dstRect.Top, dstRect.Right - sizing.Right, dstRect.Top + sizing.Top), srcRect1, TileMode.TileX, opacity);
            //    }
            //    if (sizing.Bottom > 0)
            //    {
            //        if (sizing.Left > 0)
            //            PI.AlphaBlend(this._memoryDC, dstRect.Left, dstRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, this._bitmapDC, srcRect.Left, srcRect.Bottom - sizing.Bottom, sizing.Left, sizing.Bottom, blend);
            //        if (sizing.Right > 0)
            //            PI.AlphaBlend(this._memoryDC, dstRect.Right - sizing.Right, dstRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, this._bitmapDC, srcRect.Right - sizing.Right, srcRect.Bottom - sizing.Bottom, sizing.Right, sizing.Bottom, blend);
            //        srcRect1 = new RectangleX(srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom, srcRect.Right - sizing.Right, srcRect.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom, dstRect.Right - sizing.Right, dstRect.Bottom), srcRect1, TileMode.TileX, opacity);
            //    }
            //    if (sizing.Left > 0)
            //    {
            //        srcRect1 = new RectangleX(srcRect.Left, srcRect.Top + sizing.Top, srcRect.Left + sizing.Left, srcRect.Bottom - sizing.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Left, dstRect.Top + sizing.Top, dstRect.Left + sizing.Left, dstRect.Bottom - sizing.Bottom), srcRect1, TileMode.TileY, opacity);
            //    }
            //    if (sizing.Right > 0)
            //    {
            //        srcRect1 = new RectangleX(srcRect.Right - sizing.Right, srcRect.Top + sizing.Top, srcRect.Right, srcRect.Bottom - sizing.Bottom);
            //        this.TileImage(this._bitmapDC, new RectangleX(dstRect.Right - sizing.Right, dstRect.Top + sizing.Top, dstRect.Right, dstRect.Bottom - sizing.Bottom), srcRect1, TileMode.TileY, opacity);
            //    }
            //    if (!borderOnly)
            //    {
            //        srcRect.Deflate(sizing);
            //        dstRect.Deflate(sizing);
            //        this.TileImage(this._bitmapDC, dstRect, srcRect, TileMode.TileXY, opacity);
            //    }
            //    PI.SelectObject(this._bitmapDC, hgdiobj);
            //}

            //public void TileImage(IntPtr bitmapDC, RectangleX dstRect, RectangleX srcRect, TileMode tile)
            //{
            //    if (srcRect.Width <= 0)
            //        srcRect.Width = 1;
            //    if (srcRect.Height <= 0)
            //        srcRect.Height = 1;
            //    if (dstRect.Width > srcRect.Width || dstRect.Height > srcRect.Height)
            //    {
            //        this._tileBuffer.Size = dstRect.Size;
            //        PointX location = dstRect.Location;
            //        dstRect.Offset(-location.X, -location.Y);
            //        this._tileBuffer.TileImageLog2(bitmapDC, dstRect, srcRect, tile);
            //        this._tileBuffer.BitBlt(this._memoryDC, location.X, location.Y);
            //    }
            //    else
            //        PI.BitBlt(this._memoryDC, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, bitmapDC, srcRect.X, srcRect.Y, 13369376U);
            //}

            //public void TileImage(
            //  IntPtr bitmapDC,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  TileMode tile,
            //  GDIColor transparent)
            //{
            //    if (srcRect.Width <= 0)
            //        srcRect.Width = 1;
            //    if (srcRect.Height <= 0)
            //        srcRect.Height = 1;
            //    if (dstRect.Width > srcRect.Width || dstRect.Height > srcRect.Height)
            //    {
            //        this._tileBuffer.Size = dstRect.Size;
            //        PointX location = dstRect.Location;
            //        dstRect.Offset(-location.X, -location.Y);
            //        this._tileBuffer.TileImageLog2(bitmapDC, dstRect, srcRect, tile);
            //        this._tileBuffer.BitBlt(this._memoryDC, location.X, location.Y, transparent);
            //    }
            //    else
            //        PI.TransparentBlt(this._memoryDC, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, bitmapDC, srcRect.X, srcRect.Y, dstRect.Width, dstRect.Height, transparent.Value);
            //}

            //public void TileImage(
            //  IntPtr bitmapDC,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  TileMode tile,
            //  int opacity)
            //{
            //    if (srcRect.Width <= 0)
            //        srcRect.Width = 1;
            //    if (srcRect.Height <= 0)
            //        srcRect.Height = 1;
            //    if (dstRect.Width > srcRect.Width || dstRect.Height > srcRect.Height)
            //    {
            //        this._tileBuffer.Size = dstRect.Size;
            //        PointX location = dstRect.Location;
            //        dstRect.Offset(-location.X, -location.Y);
            //        this._tileBuffer.TileImageLog2(bitmapDC, dstRect, srcRect, tile);
            //        this._tileBuffer.BitBlt(this._memoryDC, location.X, location.Y, opacity);
            //    }
            //    else
            //        PI.AlphaBlend(this._memoryDC, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, bitmapDC, srcRect.X, srcRect.Y, dstRect.Width, dstRect.Height, new PI.BLENDFUNCTION()
            //        {
            //            BlendOp = (byte)0,
            //            BlendFlags = (byte)0,
            //            SourceConstantAlpha = (byte)opacity,
            //            AlphaFormat = (byte)1
            //        });
            //}

            //public void TileImageLog2(
            //  IntPtr bitmapDC,
            //  RectangleX dstRect,
            //  RectangleX srcRect,
            //  TileMode tile)
            //{
            //    PI.BitBlt(this._memoryDC, dstRect.X, dstRect.Y, Math.Min(dstRect.Width, srcRect.Width), Math.Min(dstRect.Height, srcRect.Height), bitmapDC, srcRect.X, srcRect.Y, 13369376U);
            //    if (tile == TileMode.TileX || tile == TileMode.TileXY)
            //    {
            //        for (int width = srcRect.Width; dstRect.Width > width; width += width)
            //            PI.BitBlt(this._memoryDC, dstRect.X + width, dstRect.Y, Math.Min(dstRect.Width - width, width), srcRect.Height, this._memoryDC, dstRect.X, dstRect.Y, 13369376U);
            //    }
            //    if (tile == TileMode.TileY)
            //    {
            //        for (int height = srcRect.Height; dstRect.Height > height; height += height)
            //            PI.BitBlt(this._memoryDC, dstRect.X, dstRect.Y + height, srcRect.Width, Math.Min(dstRect.Height - height, height), this._memoryDC, dstRect.X, dstRect.Y, 13369376U);
            //    }
            //    if (tile != TileMode.TileXY)
            //        return;
            //    for (int height = srcRect.Height; dstRect.Height > height; height += height)
            //        PI.BitBlt(this._memoryDC, dstRect.X, dstRect.Y + height, dstRect.Width, Math.Min(dstRect.Height - height, height), this._memoryDC, dstRect.X, dstRect.Y, 13369376U);
            //}

            //public Size Size
            //{
            //    get
            //    {
            //        return this._bufferSize;
            //    }
            //    set
            //    {
            //        if (!(value != this._bufferSize))
            //            return;
            //        if (value.Width > 0)
            //            this._bufferSize.Width = value.Width;
            //        if (value.Height > 0)
            //            this._bufferSize.Height = value.Height;
            //        if (this._bufferSize.Width <= this._sizeSurface.Width && this._bufferSize.Height <= this._sizeSurface.Height)
            //            return;
            //        this.CreateDIB(new Size(this._bufferSize.Width > this._sizeSurface.Width ? this._bufferSize.Width : this._sizeSurface.Width, this._bufferSize.Height > this._sizeSurface.Height ? this._bufferSize.Height : this._sizeSurface.Height));
            //    }
            //}

            //public Size VirtualSize
            //{
            //    get
            //    {
            //        return this._sizeSurface;
            //    }
            //}

            //public int Stride
            //{
            //    get
            //    {
            //        return this._sizeSurface.Width * 32 / 8;
            //    }
            //}

            //public int Width
            //{
            //    get
            //    {
            //        return this._bufferSize.Width;
            //    }
            //}

            //public int Height
            //{
            //    get
            //    {
            //        return this._bufferSize.Height;
            //    }
            //}

            //public RectangleX Clip
            //{
            //    get
            //    {
            //        return this._clipRect;
            //    }
            //}

            //public PointX Origin
            //{
            //    get
            //    {
            //        PI.POINT lpPoint = new PI.POINT();
            //        PI.GetViewportOrgEx(this._memoryDC, ref lpPoint);
            //        return new PointX(lpPoint.X, lpPoint.Y);
            //    }
            //}

            public IntPtr Handle
            {
                get
                {
                    return this._memoryDC;
                }
            }

            //public IntPtr Buffer
            //{
            //    get
            //    {
            //        return this._dibBits;
            //    }
            //}

            //public bool IsDisposed
            //{
            //    get
            //    {
            //        return this._disposed;
            //    }
            //}

            //public bool IsEmpty
            //{
            //    get
            //    {
            //        if (!(this._memoryDC == IntPtr.Zero))
            //            return this._bufferSize.IsEmpty;
            //        return true;
            //    }
            //}
        }

    }
}
