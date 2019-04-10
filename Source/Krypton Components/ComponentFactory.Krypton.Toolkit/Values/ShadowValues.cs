// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2019 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    public class ShadowValues : Storage
    {
        #region statics
        private static Padding _defaultMargin = new Padding(-10, -10, 10, 10);
        private double _blurDistance;
        private bool _enableShadows;
        private Padding _margins;
        private Color _colour;
        private bool _hideOnNonActiveForm;

        #endregion

        #region Events
#pragma warning disable 1591
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public event EventHandler EnableShadowsChanged;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public event EventHandler MarginsChanged;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public event EventHandler BlurDistanceChanged;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public event EventHandler<ColorEventArgs> ColourChanged;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public event EventHandler HideOnNonActiveFormChanged;
#pragma warning restore 1591
        #endregion

        #region Identity
        /// <summary>
        /// 
        /// </summary>
        public ShadowValues()
        {
            Reset();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Reset()
        {
            ResetEnableShadows();
            ResetMargins();
            ResetBlurDistance();
            ResetColour();
            ResetHideOnNonActiveForm();
        }
        #endregion Identity

        /// <summary>
        /// </summary>
        [Description("Use this enahanced shadow feature")]
        [DefaultValue(false)]
        public bool EnableShadows
        {
            get => _enableShadows;
            set
            {
                if (_enableShadows != value)
                {
                    _enableShadows = value;
                    EnableShadowsChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private bool ShouldSerializeEnableShadows()
        {
            return !EnableShadows;
        }

        /// <summary>
        /// </summary>
        public void ResetEnableShadows()
        {
            EnableShadows = false;
        }


        /// <summary>
        /// </summary>
        [Description("How far does each side extend for the shadow")]
        public Padding Margins
        {
            get => _margins;
            set
            {
                if (_margins != value)
                {
                    _margins = value;
                    MarginsChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private bool ShouldSerializeMargins()
        {
            return Margins != _defaultMargin;
        }

        /// <summary>
        /// </summary>
        public void ResetMargins()
        {
            Margins = _defaultMargin;
        }


        /// <summary>
        /// </summary>
        [Description("% of each side to start blur +ve or -ve")]
        [DefaultValue(50.0)]
        public double BlurDistance
        {
            get => _blurDistance;
            set
            {
                if (Math.Abs(_blurDistance - value) > 0.001 
                    && -100 < _blurDistance 
                    && _blurDistance < 100
                    )
                {
                    _blurDistance = value;
                    BlurDistanceChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private bool ShouldSerializeBlurDistance()
        {
            return Math.Abs(BlurDistance - 50) > 0.001;
        }

        /// <summary>
        /// </summary>
        public void ResetBlurDistance()
        {
            BlurDistance = 50;
        }


        /// <summary>
        /// </summary>
        [Description("What Colour will be used for the Blur Solid")]
        public Color Colour
        {
            get => _colour;
            set
            {
                if (_colour != value)
                {
                    _colour = value;
                    ColourChanged?.Invoke(this, new ColorEventArgs(_colour));
                }
            }
        }

        private bool ShouldSerializeColour()
        {
            return Colour != SystemColors.ActiveBorder;
        }

        /// <summary>
        /// Resets the PlacementMode property to its default value.
        /// </summary>
        public void ResetColour()
        {
            Colour = SystemColors.ActiveBorder;
        }

        /// <summary>
        /// </summary>
        [Description("Hide the shadow when the form is deactivated")]
        [DefaultValue(false)]
        public bool HideOnNonActiveForm
        {
            get => _hideOnNonActiveForm;
            set
            {
                if (_hideOnNonActiveForm != value)
                {
                    _hideOnNonActiveForm = value;
                    HideOnNonActiveFormChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private bool ShouldSerializeHideOnNonActiveForm()
        {
            return !HideOnNonActiveForm;
        }

        /// <summary>
        /// </summary>
        public void ResetHideOnNonActiveForm()
        {
            HideOnNonActiveForm = false;
        }



        #region Default Values
        /// <summary>
        /// 
        /// </summary>
        public override bool IsDefault => (!ShouldSerializeEnableShadows()
                                            && !ShouldSerializeMargins()
                                            && !ShouldSerializeBlurDistance()
                                            && !ShouldSerializeColour()
                                            && !ShouldSerializeHideOnNonActiveForm()
                                            );
        #endregion Default Values
    }
}
