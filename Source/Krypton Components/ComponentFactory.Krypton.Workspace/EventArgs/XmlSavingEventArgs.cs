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
using System.Xml;

namespace ComponentFactory.Krypton.Workspace
{
	/// <summary>
	/// Event data for persisting extra data for a workspace.
	/// </summary>
	public class XmlSavingEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the XmlSavingEventArgs class.
		/// </summary>
        /// <param name="workspace">Reference to owning workspace control.</param>
        /// <param name="xmlWriter">Xml writer for persisting custom data.</param>
        public XmlSavingEventArgs(KryptonWorkspace workspace,
                                  XmlWriter xmlWriter)
		{
            Workspace = workspace;
            XmlWriter = xmlWriter;
		}
		#endregion

		#region Public
		/// <summary>
        /// Gets the workspace reference.
		/// </summary>
        public KryptonWorkspace Workspace { get; }

	    /// <summary>
        /// Gets the xml writer.
        /// </summary>
        public XmlWriter XmlWriter { get; }

	    #endregion
	}
}
