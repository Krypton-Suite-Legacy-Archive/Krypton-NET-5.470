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

using Krypton.Toolkit;
using Krypton.Navigator;

namespace Krypton.Workspace
{
    /// <summary>
    /// Proxy class for receiving page notifications.
    /// </summary>
    public class CellPageNotify : IDragPageNotify
    {
        #region Instance Fields
        private readonly KryptonWorkspace _workspace;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the CellPageNotify class.
        /// </summary>
        /// <param name="workspace">Reference to owning workspace.</param>
        public CellPageNotify(KryptonWorkspace workspace)
        {
            _workspace = workspace;
        }
        #endregion

        #region Public
        /// <summary>
        /// Occurs when a page drag is about to begin and allows it to be cancelled.
        /// </summary>
        /// <param name="sender">Source of the page drag; should never be null.</param>
        /// <param name="navigator">Navigator instance associated with source; can be null.</param>
        /// <param name="e">Event arguments indicating list of pages being dragged.</param>
        public void PageDragStart(object sender, KryptonNavigator navigator, PageDragCancelEventArgs e)
        {
            _workspace.InternalPageDragStart(sender, navigator, e);
        }

        /// <summary>
        /// Occurs when the mouse moves during the drag operation.
        /// </summary>
        /// <param name="sender">Source of the page drag; can be null.</param>
        /// <param name="e">Event arguments containing the new screen point of the mouse.</param>
        public void PageDragMove(object sender, PointEventArgs e)
        {
            _workspace.InternalPageDragMove(sender as KryptonNavigator, e);
        }

        /// <summary>
        /// Occurs when drag operation completes with pages being dropped.
        /// </summary>
        /// <param name="sender">Source of the page drag; can be null.</param>
        /// <param name="e">Event arguments containing the new screen point of the mouse.</param>
        /// <returns>Drop was performed and the source can perform any removal of pages as required.</returns>
        public bool PageDragEnd(object sender, PointEventArgs e)
        {
            return _workspace.InternalPageDragEnd(sender as KryptonNavigator, e);
        }

        /// <summary>
        /// Occurs when dragging pages has been cancelled.
        /// </summary>
        /// <param name="sender">Source of the page drag; can be null.</param>
        public void PageDragQuit(object sender)
        {
            _workspace.InternalPageDragQuit(sender as KryptonNavigator);
        }
        #endregion
    }
}
