// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
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
        private IDockingElement _dockingElement;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the DockingMultiUpdate class.
        /// </summary>
        /// <param name="dockingElement">Reference to root element of docking hierarchy.</param>
        public DockingMultiUpdate(IDockingElement dockingElement)
        {

            // Inform docking elements that a multi-part update is starting
            _dockingElement = dockingElement ?? throw new ArgumentNullException("dockingElement");
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
