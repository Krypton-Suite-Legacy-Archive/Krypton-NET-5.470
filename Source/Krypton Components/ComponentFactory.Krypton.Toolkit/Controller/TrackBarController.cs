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

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Process mouse/keyboard/focus events for a track bar.
	/// </summary>
    public class TrackBarController : GlobalId,
                                      IMouseController,
                                      IKeyController,
                                      ISourceController
	{
		#region Instance Fields
        private readonly ViewDrawTP _drawTB;
        private Timer _repeatTimer;
        private bool _captured;
        private bool _targetHigher;
        private int _targetValue;
        private Point _lastMovePt;
        #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the TrackBarController class.
		/// </summary>
        /// <param name="drawTB">Associated drawing element.</param>
        public TrackBarController(ViewDrawTP drawTB)
		{
            _drawTB = drawTB;
        }
		#endregion

        #region Mouse Notifications
        /// <summary>
		/// Mouse has entered the view.
		/// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        public virtual void MouseEnter(Control c)
		{
		}

		/// <summary>
		/// Mouse has moved inside the view.
		/// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="pt">Mouse position relative to control.</param>
        public virtual void MouseMove(Control c, Point pt)
		{
            if (_captured)
            {
                // Only interested if the mouse is over the track area
                if (_drawTB.ClientRectangle.Contains(pt))
                {
                    // Ignore multiple calls with the same point
                    if (_lastMovePt != pt)
                    {
                        _lastMovePt = pt;

                        // Restart the timer
                        _repeatTimer.Stop();
                        _repeatTimer.Start();

                        // Only use newly calculated target value if in correct direction
                        int newTargetValue = _drawTB.NearestValueFromPoint(pt);
                        int currentValue = _drawTB.ViewDrawTrackBar.Value;
                        if (_targetHigher)
                        {
                            if (newTargetValue > currentValue)
                            {
                                _targetValue = newTargetValue;
                            }
                        }
                        else
                        {
                            if (newTargetValue < currentValue)
                            {
                                _targetValue = newTargetValue;
                            }
                        }

                        OnRepeatTimer(_repeatTimer, EventArgs.Empty);
                    }
                }
            }
		}

		/// <summary>
		/// Mouse button has been pressed in the view.
		/// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="pt">Mouse position relative to control.</param>
		/// <param name="button">Mouse button pressed down.</param>
		/// <returns>True if capturing input; otherwise false.</returns>
        public virtual bool MouseDown(Control c, Point pt, MouseButtons button)
		{
            if (button == MouseButtons.Left)
            {
                // Only interested if the mouse is over the track area
                if (_drawTB.ClientRectangle.Contains(pt))
                {
                    _captured = true;

                    // Target value is nearest value to the mouse positon
                    _targetValue = _drawTB.NearestValueFromPoint(pt);
                    _targetHigher = (_targetValue > _drawTB.ViewDrawTrackBar.Value);
                    OnRepeatTimer(_repeatTimer, EventArgs.Empty);

                    // Use timer to keep moving towards the target value
                    _repeatTimer = new Timer
                    {
                        Interval = SystemInformation.DoubleClickTime
                    };
                    _repeatTimer.Tick += OnRepeatTimer;
                    _repeatTimer.Start();
                }
            }

			return _captured;
		}

		/// <summary>
		/// Mouse button has been released in the view.
		/// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="pt">Mouse position relative to control.</param>
		/// <param name="button">Mouse button released.</param>
        public virtual void MouseUp(Control c, Point pt, MouseButtons button)
		{
            if (_repeatTimer != null)
            {
                _repeatTimer.Stop();
                _repeatTimer.Dispose();
                _repeatTimer = null;
            }

            if (_captured)
            {
                _captured = false;
            }
		}

		/// <summary>
		/// Mouse has left the view.
		/// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="next">Reference to view that is next to have the mouse.</param>
        public virtual void MouseLeave(Control c, ViewBase next)
		{
            if (_repeatTimer != null)
            {
                _repeatTimer.Stop();
                _repeatTimer.Dispose();
                _repeatTimer = null;
            }

            _lastMovePt = Point.Empty;
		}

        /// <summary>
        /// Left mouse button double click.
        /// </summary>
        /// <param name="pt">Mouse position relative to control.</param>
        public virtual void DoubleClick(Point pt)
        {
            // Do nothing
        }

        /// <summary>
        /// Should the left mouse down be ignored when present on a visual form border area.
        /// </summary>
        public virtual bool IgnoreVisualFormLeftButtonDown => false;

	    #endregion

        #region Key Notifications

	    /// <summary>
	    /// Key has been pressed down.
	    /// </summary>
	    /// <param name="c">Reference to the source control instance.</param>
	    /// <param name="e">A KeyEventArgs that contains the event data.</param>
	    /// <exception cref="ArgumentNullException"></exception>
	    public virtual void KeyDown(Control c, KeyEventArgs e)
        {
            Debug.Assert(c != null);
            Debug.Assert(e != null);

            // Validate incoming references
            if (c == null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                    _drawTB.ViewDrawTrackBar.ScrollValue = Math.Max(_drawTB.ViewDrawTrackBar.Minimum,
                        _drawTB.ViewDrawTrackBar.Orientation == Orientation.Horizontal
                            ? Math.Min(_drawTB.ViewDrawTrackBar.Value - _drawTB.ViewDrawTrackBar.SmallChange,
                                _drawTB.ViewDrawTrackBar.Maximum)
                            : Math.Min(_drawTB.ViewDrawTrackBar.Value + _drawTB.ViewDrawTrackBar.SmallChange,
                                _drawTB.ViewDrawTrackBar.Maximum));

                    break;
                case Keys.Right:
                case Keys.Down:
                    _drawTB.ViewDrawTrackBar.ScrollValue = Math.Max(_drawTB.ViewDrawTrackBar.Minimum,
                        _drawTB.ViewDrawTrackBar.Orientation == Orientation.Horizontal
                            ? Math.Min(_drawTB.ViewDrawTrackBar.Value + _drawTB.ViewDrawTrackBar.SmallChange,
                                _drawTB.ViewDrawTrackBar.Maximum)
                            : Math.Min(_drawTB.ViewDrawTrackBar.Value - _drawTB.ViewDrawTrackBar.SmallChange,
                                _drawTB.ViewDrawTrackBar.Maximum));

                    break;
                case Keys.Home:
                    _drawTB.ViewDrawTrackBar.ScrollValue =
                        _drawTB.ViewDrawTrackBar.Orientation == Orientation.Horizontal
                            ? _drawTB.ViewDrawTrackBar.Minimum
                            : _drawTB.ViewDrawTrackBar.Maximum;

                    break;
                case Keys.End:
                    _drawTB.ViewDrawTrackBar.ScrollValue =
                        _drawTB.ViewDrawTrackBar.Orientation == Orientation.Horizontal
                            ? _drawTB.ViewDrawTrackBar.Maximum
                            : _drawTB.ViewDrawTrackBar.Minimum;

                    break;
                case Keys.PageDown:
                    _drawTB.ViewDrawTrackBar.ScrollValue = Math.Max(_drawTB.ViewDrawTrackBar.Minimum,
                        _drawTB.ViewDrawTrackBar.Orientation == Orientation.Horizontal
                            ? Math.Min(_drawTB.ViewDrawTrackBar.Value + _drawTB.ViewDrawTrackBar.LargeChange,
                                _drawTB.ViewDrawTrackBar.Maximum)
                            : Math.Min(_drawTB.ViewDrawTrackBar.Value - _drawTB.ViewDrawTrackBar.LargeChange,
                                _drawTB.ViewDrawTrackBar.Maximum));

                    break;
                case Keys.PageUp:
                    _drawTB.ViewDrawTrackBar.ScrollValue = Math.Max(_drawTB.ViewDrawTrackBar.Minimum,
                        _drawTB.ViewDrawTrackBar.Orientation == Orientation.Horizontal
                            ? Math.Min(_drawTB.ViewDrawTrackBar.Value - _drawTB.ViewDrawTrackBar.LargeChange,
                                _drawTB.ViewDrawTrackBar.Maximum)
                            : Math.Min(_drawTB.ViewDrawTrackBar.Value + _drawTB.ViewDrawTrackBar.LargeChange,
                                _drawTB.ViewDrawTrackBar.Maximum));

                    break;
            }
        }

        /// <summary>
        /// Key has been pressed.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        /// <param name="e">A KeyPressEventArgs that contains the event data.</param>
        public virtual void KeyPress(Control c, KeyPressEventArgs e)
        {
        }

	    /// <summary>
	    /// Key has been released.
	    /// </summary>
	    /// <param name="c">Reference to the source control instance.</param>
	    /// <param name="e">A KeyEventArgs that contains the event data.</param>
	    /// <exception cref="ArgumentNullException"></exception>
	    /// <returns>True if capturing input; otherwise false.</returns>
	    public virtual bool KeyUp(Control c, KeyEventArgs e)
        {
            Debug.Assert(c != null);
            Debug.Assert(e != null);

            // Validate incoming references
            if (c == null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            return _captured;
        }
        #endregion

        #region Source Notifications
        /// <summary>
        /// Source control has lost the focus.
        /// </summary>
        /// <param name="c">Reference to the source control instance.</param>
        public virtual void GotFocus(Control c)
        {
        }

	    /// <summary>
	    /// Source control has lost the focus.
	    /// </summary>
	    /// <param name="c">Reference to the source control instance.</param>
	    /// <exception cref="ArgumentNullException"></exception>
	    public virtual void LostFocus(Control c)
        {
            Debug.Assert(c != null);

            // Validate incoming references
            if (c == null)
            {
                throw new ArgumentNullException(nameof(c));
            }

            // If we are capturing mouse input
            if (_captured)
            {
                // Release the mouse capture
                c.Capture = false;
                _captured = false;

                if (_repeatTimer != null)
                {
                    _repeatTimer.Stop();
                    _repeatTimer.Dispose();
                    _repeatTimer = null;
                }
            }
        }
        #endregion

        #region Implementation
        private void OnRepeatTimer(object sender, EventArgs e)
        {
            int current = _drawTB.ViewDrawTrackBar.Value;
            if (current != _targetValue)
            {
                _drawTB.ViewDrawTrackBar.ScrollValue = current < _targetValue
                    ? Math.Min(_targetValue, current + _drawTB.ViewDrawTrackBar.LargeChange)
                    : Math.Max(_targetValue, current - _drawTB.ViewDrawTrackBar.LargeChange);
            }
        }
        #endregion
    }
}
