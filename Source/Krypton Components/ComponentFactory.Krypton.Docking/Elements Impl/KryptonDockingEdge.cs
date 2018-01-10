// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace ComponentFactory.Krypton.Docking
{
    /// <summary>
    /// Provides docking functionality for a specific edge of a control.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public class KryptonDockingEdge : DockingElementClosedCollection
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonDockingEdge class.
        /// </summary>
        /// <param name="name">Initial name of the element.</param>
        /// <param name="control">Reference to control that is being managed.</param>
        /// <param name="edge">Docking edge being managed.</param>
        public KryptonDockingEdge(string name, Control control, DockingEdge edge)
            : base(name)
        {
            Control = control ?? throw new ArgumentNullException("control");
            Edge = edge;

            // Auto create elements for handling standard docked content and auto hidden content
            InternalAdd(new KryptonDockingEdgeAutoHidden("AutoHidden", control, edge));
            InternalAdd(new KryptonDockingEdgeDocked("Docked", control, edge));
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the control this element is managing.
        /// </summary>
        public Control Control { get; }

        /// <summary>
        /// Gets the docking edge this element is managing.
        /// </summary>
        public DockingEdge Edge { get; }

        #endregion

        #region Protected
        /// <summary>
        /// Gets the xml element name to use when saving.
        /// </summary>
        protected override string XmlElementName => "DE";

        #endregion
    }
}
