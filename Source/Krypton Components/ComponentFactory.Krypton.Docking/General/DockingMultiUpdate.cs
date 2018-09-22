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

namespace ComponentFactory.Krypton.Docking
{
    /// <summary>
    /// Helper class used inside a 'using' statement to notify start and end of a multi-part update.
    /// </summary>
    public class DockingMultiUpdate : IDisposable
    {
        #region Instance Fields
        private readonly IDockingElement _dockingElement;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockingMultiUpdate class.
        /// </summary>
        /// <param name="dockingElement">Reference to root element of docking hierarchy.</param>
        public DockingMultiUpdate(IDockingElement dockingElement)
        {

            // Inform docking elements that a multi-part update is starting
            _dockingElement = dockingElement ?? throw new ArgumentNullException(nameof(dockingElement));
            _dockingElement.PropogateAction(DockingPropogateAction.StartUpdate, (string[])null);
        }

        /// <summary>
        /// Release managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Inform docking elements that a multi-part update has ended
            _dockingElement.PropogateAction(DockingPropogateAction.EndUpdate, (string[])null);
        }
        #endregion
    }
}
