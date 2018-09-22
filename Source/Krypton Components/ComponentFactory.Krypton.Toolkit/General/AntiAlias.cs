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
using System.Drawing.Drawing2D;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Set the SmoothingMode=AntiAlias until instance disposed.
	/// </summary>
    public class AntiAlias : GlobalId,
                             IDisposable
	{
		#region Instance Fields
        private readonly Graphics _g;
        private readonly SmoothingMode _old;
		#endregion

		#region Identity
        /// <summary>
        /// Initialize a new instance of the UseAntiAlias class.
        /// </summary>
        /// <param name="g">Graphics instance.</param>
        public AntiAlias(Graphics g)
        {
            _g = g;
            _old = _g.SmoothingMode;
            _g.SmoothingMode = SmoothingMode.AntiAlias;
        }

        /// <summary>
        /// Revert the SmoothingMode back to original setting.
        /// </summary>
        public void Dispose()
        {
            if (_g != null)
            {
                try
                {
                    _g.SmoothingMode = _old;
                }
                catch { }
            }
        }
		#endregion
	}

    /// <summary>
    /// Set the SmoothingMode=None until instance disposed.
    /// </summary>
    public class AntiAliasNone : GlobalId,
                                 IDisposable
    {
        #region Instance Fields
        private readonly Graphics _g;
        private readonly SmoothingMode _old;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the AntiAliasNone class.
        /// </summary>
        /// <param name="g">Graphics instance.</param>
        public AntiAliasNone(Graphics g)
        {
            _g = g;
            _old = _g.SmoothingMode;
            _g.SmoothingMode = SmoothingMode.None;
        }

        /// <summary>
        /// Revert the SmoothingMode back to original setting.
        /// </summary>
        public void Dispose()
        {
            if (_g != null)
            {
                try
                {
                    _g.SmoothingMode = _old;
                }
                catch { }
            }
        }
        #endregion
    }
}
