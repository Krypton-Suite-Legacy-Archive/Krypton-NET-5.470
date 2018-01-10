// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
	/// <summary>
	/// Layout area for the application tab.
	/// </summary>
    internal class ViewLayoutRibbonAppTab : ViewLayoutDocker
    {
        #region Instance Fields
        private KryptonRibbon _ribbon;

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutRibbonAppTab class.
		/// </summary>
        /// <param name="ribbon">Owning control instance.</param>
        public ViewLayoutRibbonAppTab(KryptonRibbon ribbon)
        {
            Debug.Assert(ribbon != null);
            _ribbon = ribbon;

            AppTab = new ViewDrawRibbonAppTab(ribbon);

            // Dock it against the appropriate edge
            Add(AppTab, ViewDockStyle.Bottom);
            Add(new ViewLayoutSeparator(1), ViewDockStyle.Left);
        }

		/// <summary>
		/// Obtains t+he String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
            return "ViewLayoutRibbonAppTab:" + Id;
		}
		#endregion

        #region AppTab
        /// <summary>
        /// Gets the view element that represents the button.
        /// </summary>
        public ViewDrawRibbonAppTab AppTab { get; }

        #endregion
    }
}
