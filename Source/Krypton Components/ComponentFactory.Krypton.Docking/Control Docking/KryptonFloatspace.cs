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

namespace ComponentFactory.Krypton.Docking
{
    /// <summary>
    /// Extends the KryptonWorkspace to work within the docking floating window.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KryptonFloatspace : KryptonSpace
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonFloatspace class.
        /// </summary>
        public KryptonFloatspace()
            : base("Floating")
        {
        }

        /// <summary>
        /// Gets a string representation of the class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "KryptonFloatspace " + Dock.ToString();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets a value indicating if docking specific pin actions should be applied.
        /// </summary>
        protected override bool ApplyDockingPinAction => false;

        #endregion
    }
}
