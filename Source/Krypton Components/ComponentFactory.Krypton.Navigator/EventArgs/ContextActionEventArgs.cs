// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
	/// Details for a context button action event.
	/// </summary>
    public class ContextActionEventArgs : KryptonContextMenuEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the ContextActionEventArgs class.
		/// </summary>
		/// <param name="page">Page effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
        /// <param name="action">Close action to take.</param>
        /// <param name="contextMenu">Prepopulated context menu ready for display.</param>
        public ContextActionEventArgs(KryptonPage page, 
                                      int index, 
                                      ContextButtonAction action,
                                      KryptonContextMenu contextMenu)
            : base(page, index, contextMenu)
		{
            Action = action;
		}
		#endregion

        #region Action
        /// <summary>
		/// Gets and sets the close action to take.
		/// </summary>
        public ContextButtonAction Action { get; set; }

	    #endregion
    }
}
