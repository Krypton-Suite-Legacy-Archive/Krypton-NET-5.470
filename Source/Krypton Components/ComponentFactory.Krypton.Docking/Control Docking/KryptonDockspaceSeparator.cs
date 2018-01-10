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
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Docking
{
    /// <summary>
    /// Extends the KryptonSeparator so work between dockspace entries on a control edge.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KryptonDockspaceSeparator : KryptonSeparator
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonDockspaceSeparator class.
        /// </summary>
        /// <param name="edge">Docking edge the separator is against.</param>
        /// <param name="opposite">Should the separator be docked against the opposite edge.</param>
        public KryptonDockspaceSeparator(DockingEdge edge, bool opposite)
        {
            // Setup docking specific settings for the separator
            Dock = DockingHelper.DockStyleFromDockEdge(edge, opposite); 
            Orientation = DockingHelper.OrientationFromDockEdge(edge);
            SeparatorStyle = SeparatorStyle.LowProfile;
        }

        /// <summary>
        /// Gets a string representation of the class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "KryptonDockspaceSeparator " + Dock.ToString() + " " + Orientation.ToString();
        }
        #endregion
    }
}
