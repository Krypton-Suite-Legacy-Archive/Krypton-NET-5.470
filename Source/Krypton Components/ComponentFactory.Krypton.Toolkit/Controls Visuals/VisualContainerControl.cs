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
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
    /// Extend the visual container control base class with the ISupportInitializeNotification interface.
	/// </summary>
	[ToolboxItem(false)]
	[DesignerCategory("code")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    public abstract class VisualContainerControl : VisualContainerControlBase, 
										           ISupportInitializeNotification
	{
		#region Instance Fields

	    #endregion

		#region Events
		/// <summary>
		/// Occurs when the control is initialized.
		/// </summary>
        [Category("Behavior")]
        [Description("Occurs when the control has been fully initialized.")]
        public event EventHandler Initialized;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the VisualContainerControl class.
		/// </summary>
        protected VisualContainerControl()
		{
        }
		#endregion

		#region Public
		/// <summary>
		/// Signals the object that initialization is starting.
		/// </summary>
		public virtual void BeginInit()
		{
            // Remember that fact we are inside a BeginInit/EndInit pair
            IsInitializing = true;

			// No need to layout the view during initialization
			SuspendLayout();
		}

		/// <summary>
		/// Signals the object that initialization is complete.
		/// </summary>
        public virtual void EndInit()
		{
            // We are now initialized
			IsInitialized = true;

            // We are no longer initializing
            IsInitializing = false;

            // Need to recalculate anything relying on the palette
            DirtyPaletteCounter++;

            // We always need a paint and layout
            OnNeedPaint(this, new NeedLayoutEventArgs(true));

			// Should layout once initialization is complete
			ResumeLayout(true);

            // Raise event to show control is now initialized
            OnInitialized(EventArgs.Empty);
		}

		/// <summary>
		/// Gets a value indicating if the control is initialized.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public bool IsInitialized
		{
		    [System.Diagnostics.DebuggerStepThrough]
		    get;
		    private set;
	    }

	    /// <summary>
        /// Gets a value indicating if the control is initialized.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public bool IsInitializing
	    {
	        [System.Diagnostics.DebuggerStepThrough]
	        get;
	        private set;
	    }

	    #endregion

        #region Protected Virtual
        /// <summary>
        /// Raises the Initialized event.
        /// </summary>
        /// <param name="e">An EventArgs containing the event data.</param>
        protected virtual void OnInitialized(EventArgs e)
        {
            Initialized?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
