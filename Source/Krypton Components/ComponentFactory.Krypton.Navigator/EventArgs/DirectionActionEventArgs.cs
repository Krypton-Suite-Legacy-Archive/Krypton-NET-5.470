// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
	/// Details for a direction button (next/previous) action event.
	/// </summary>
    public class DirectionActionEventArgs : KryptonPageEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DirectionActionEventArgs class.
		/// </summary>
		/// <param name="page">Page effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
        /// <param name="action">Previous/Next action to take.</param>
        public DirectionActionEventArgs(KryptonPage page, 
                                        int index,
                                        DirectionButtonAction action)
			: base(page, index)
		{
            Action = action;
		}
		#endregion

        #region Action
        /// <summary>
		/// Gets and sets the next/previous action to take.
		/// </summary>
        public DirectionButtonAction Action { get; set; }

	    #endregion
	}
}
