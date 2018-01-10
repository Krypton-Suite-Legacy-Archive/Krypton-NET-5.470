// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Details for palette layout events.
	/// </summary>
    public class PaletteLayoutEventArgs : NeedLayoutEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PaletteLayoutEventArgs class.
		/// </summary>
        /// <param name="needLayout">Does the layout need regenerating.</param>
        /// <param name="needColorTable">Have the color table values changed?</param>
        public PaletteLayoutEventArgs(bool needLayout,
                                      bool needColorTable)
            : base(needLayout)
		{
            NeedColorTable = needColorTable;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets a value indicating if the color table needs to be reprocessed.
		/// </summary>
        public bool NeedColorTable { get; }

	    #endregion
	}
}
