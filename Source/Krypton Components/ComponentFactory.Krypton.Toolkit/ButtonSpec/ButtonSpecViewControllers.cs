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

using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Stores a triple of controller references.
    /// </summary>
    public class ButtonSpecViewControllers
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonSpecViewControllers class.
        /// </summary>
        /// <param name="mouseController">Mouse controller.</param>
        /// <param name="sourceController">Source controller.</param>
        /// <param name="keyController">Key controller.</param>
        public ButtonSpecViewControllers(IMouseController mouseController,
                                         ISourceController sourceController,
                                         IKeyController keyController)
        {
            Debug.Assert(mouseController != null);
            Debug.Assert(sourceController != null);
            Debug.Assert(keyController != null);

            MouseController = mouseController;
            SourceController = sourceController;
            KeyController = keyController;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the mouse controller reference.
        /// </summary>
        public IMouseController MouseController { get; }

        /// <summary>
        /// Gets the mouse controller reference.
        /// </summary>
        public ISourceController SourceController { get; }

        /// <summary>
        /// Gets the mouse controller reference.
        /// </summary>
        public IKeyController KeyController { get; }

        #endregion
    }
}
