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
    /// Redirect requests for image/text colors to remap.
    /// </summary>
    public class ButtonSpecRemapByContentView : ButtonSpecRemapByContentBase
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonSpecRemapByContentView class.
        /// </summary>
        /// <param name="target">Initial palette target for redirection.</param>
        /// <param name="buttonSpec">Reference to button specification.</param>
        public ButtonSpecRemapByContentView(IPalette target,
                                            ButtonSpec buttonSpec)
            : base(target, buttonSpec)
        {
        }
		#endregion

        #region Foreground
        /// <summary>
        /// Gets and sets the foreground to use for color map redirection.
        /// </summary>
        public ViewDrawContent Foreground { get; set; }

        #endregion

        #region PaletteContent
        /// <summary>
        /// Gets the palette content to use for remapping.
        /// </summary>
        public override IPaletteContent PaletteContent => Foreground?.GetPalette();

        #endregion

        #region PaletteState
        /// <summary>
        /// Gets the state of the remapping area
        /// </summary>
        public override PaletteState PaletteState => Foreground.State;

        #endregion
    }
}
