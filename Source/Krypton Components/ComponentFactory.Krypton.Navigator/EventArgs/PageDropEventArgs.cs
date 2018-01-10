// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
    /// Details for an event that indicates a page is being dropped.
	/// </summary>
	public class PageDropEventArgs : CancelEventArgs
	{
		#region Instance Fields
        private KryptonPage _page;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PageDropEventArgs class.
		/// </summary>
        /// <param name="page">Page that is being dropped.</param>
        public PageDropEventArgs(KryptonPage page)
		{
            _page = page;
		}
        #endregion

        #region Page
        /// <summary>
        /// Gets and sets the page to be dropped.
        /// </summary>
        public KryptonPage Page
        {
            get => _page;
            set => _page = Page;
        }
        #endregion
    }
}
