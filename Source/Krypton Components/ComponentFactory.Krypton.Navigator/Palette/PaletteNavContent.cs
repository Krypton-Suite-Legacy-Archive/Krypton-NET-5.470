// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
	/// Implement storage for palette content details.
	/// </summary>
	public class PaletteNavContent : Storage,
								     IPaletteContent
	{
        #region Internal Classes
        private class InternalStorage
        {
            public InheritBool ContentDraw;
            public InheritBool ContentDrawFocus;
            public Padding ContentPadding;
            public int ContentAdjacentGap;

            /// <summary>
            /// Initialize a new instance of the InternalStorage structure.
            /// </summary>
            public InternalStorage()
            {
                // Set to default values
                ContentDraw = InheritBool.Inherit;
                ContentDrawFocus = InheritBool.Inherit;
                ContentPadding = CommonHelper.InheritPadding;
                ContentAdjacentGap = -1;
            }

            /// <summary>
            /// Gets a value indicating if all values are default.
            /// </summary>
            public bool IsDefault => (ContentDraw == InheritBool.Inherit) &&
                                     (ContentDrawFocus == InheritBool.Inherit) &&
                                     ContentPadding.Equals(CommonHelper.InheritPadding) &&
                                     (ContentAdjacentGap == -1);
        }
        #endregion

        #region Instance Fields
        private InternalStorage _storage;
	    private IPaletteContent _inherit;
        #endregion

        #region Identity
		/// <summary>
        /// Initialize a new instance of the PaletteNavContent class.
		/// </summary>
		/// <param name="inherit">Source for inheriting defaulted values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteNavContent(IPaletteContent inherit,
                                 NeedPaintHandler needPaint)
		{
			Debug.Assert(inherit != null);

			// Remember inheritance
			_inherit = inherit;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;
            
            // Create the content storage for sub objects
            Image = new PaletteContentImage(needPaint);
            ShortText = new PaletteNavContentText(needPaint);
            LongText = new PaletteNavContentText(needPaint);
		}
		#endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => ((Image.IsDefault) &&
		                                   (ShortText.IsDefault) &&
		                                   (LongText.IsDefault) &&
		                                   ((_storage == null) || _storage.IsDefault));

	    #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        public void SetInherit(IPaletteContent inherit)
        {
            _inherit = inherit;
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">Palette state to use when populating.</param>
        public void PopulateFromBase(PaletteState state)
        {
            // Get the values and set into storage
            Draw = GetContentDraw(state);
            DrawFocus = GetContentDrawFocus(state);
            Image.ImageH = GetContentImageH(state);
            Image.ImageV = GetContentImageV(state);
            Image.Effect = GetContentImageEffect(state);
            Image.ImageColorMap = GetContentImageColorMap(state);
            Image.ImageColorTo = GetContentImageColorTo(state);
            ShortText.Prefix = GetContentShortTextPrefix(state);
            ShortText.Trim = GetContentShortTextTrim(state);
            ShortText.TextH = GetContentShortTextH(state);
            ShortText.TextV = GetContentShortTextV(state);
            ShortText.MultiLineH = GetContentShortTextMultiLineH(state);
            ShortText.MultiLine = GetContentShortTextMultiLine(state);
            LongText.Prefix = GetContentLongTextPrefix(state);
            LongText.Trim = GetContentLongTextTrim(state);
            LongText.TextH = GetContentLongTextH(state);
            LongText.TextV = GetContentLongTextV(state);
            LongText.MultiLineH = GetContentLongTextMultiLineH(state);
            LongText.MultiLine = GetContentLongTextMultiLine(state);
            Padding = GetContentPadding(state);
            AdjacentGap = GetContentAdjacentGap(state);
        }
        #endregion

		#region Draw
		/// <summary>
		/// Gets a value indicating if content should be drawn.
		/// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
		[Description("Should content be drawn.")]
		[DefaultValue(typeof(InheritBool), "Inherit")]
		[RefreshPropertiesAttribute(RefreshProperties.All)]
		public InheritBool Draw
		{
            get
            {
                if (_storage == null)
                {
                    return InheritBool.Inherit;
                }
                else
                {
                    return _storage.ContentDraw;
                }
            }

			set
			{
                if (_storage != null)
                {
                    if (_storage.ContentDraw != value)
                    {
                        _storage.ContentDraw = value;
                        PerformNeedPaint();
                    }
                }
                else
                {
                    if (value != InheritBool.Inherit)
                    {
                        _storage = new InternalStorage
                        {
                            ContentDraw = value
                        };
                        PerformNeedPaint();
                    }
                }
			}
		}

		/// <summary>
		/// Gets the actual content draw value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>InheritBool value.</returns>
		public InheritBool GetContentDraw(PaletteState state)
		{
			if (Draw != InheritBool.Inherit)
			{
			    return Draw;
			}
			else
			{
			    return _inherit.GetContentDraw(state);
			}
		}
		#endregion

		#region DrawFocus
		/// <summary>
		/// Gets a value indicating if content should be drawn with focus indication.
		/// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
		[Description("Should content be drawn with focus indication..")]
		[DefaultValue(typeof(InheritBool), "Inherit")]
		[RefreshPropertiesAttribute(RefreshProperties.All)]
		public InheritBool DrawFocus
		{
            get
            {
                if (_storage == null)
                {
                    return InheritBool.Inherit;
                }
                else
                {
                    return _storage.ContentDrawFocus;
                }
            }

			set
			{
                if (_storage != null)
                {
                    if (_storage.ContentDrawFocus != value)
                    {
                        _storage.ContentDrawFocus = value;
                        PerformNeedPaint();
                    }
                }
                else
                {
                    if (value != InheritBool.Inherit)
                    {
                        _storage = new InternalStorage
                        {
                            ContentDrawFocus = value
                        };
                        PerformNeedPaint();
                    }
                }
			}
		}

		/// <summary>
		/// Gets the actual content draw with focus value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>InheritBool value.</returns>
		public InheritBool GetContentDrawFocus(PaletteState state)
		{
			if (DrawFocus != InheritBool.Inherit)
			{
			    return DrawFocus;
			}
			else
			{
			    return _inherit.GetContentDrawFocus(state);
			}
		}
		#endregion

		#region Image
		/// <summary>
		/// Gets access to the image palette details.
		/// </summary>
        [KryptonPersist]
        [Category("Visuals")]
		[Description("Overrides for defining image appearance.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public PaletteContentImage Image { get; }

	    private bool ShouldSerializeImage()
		{
			return !Image.IsDefault;
		}

		/// <summary>
		/// Gets the actual content image horizontal alignment value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>RelativeAlignment value.</returns>
		public PaletteRelativeAlign GetContentImageH(PaletteState state)
		{
			if (Image.ImageH != PaletteRelativeAlign.Inherit)
			{
			    return Image.ImageH;
			}
			else
			{
			    return _inherit.GetContentImageH(state);
			}
		}

		/// <summary>
		/// Gets the actual content image vertical alignment value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>RelativeAlignment value.</returns>
		public PaletteRelativeAlign GetContentImageV(PaletteState state)
		{
			if (Image.ImageV != PaletteRelativeAlign.Inherit)
			{
			    return Image.ImageV;
			}
			else
			{
			    return _inherit.GetContentImageV(state);
			}
		}

		/// <summary>
		/// Gets the actual image drawing effect value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>PaletteImageEffect value.</returns>
		public PaletteImageEffect GetContentImageEffect(PaletteState state)
		{
			if (Image.Effect != PaletteImageEffect.Inherit)
			{
			    return Image.Effect;
			}
			else
			{
			    return _inherit.GetContentImageEffect(state);
			}
		}

        /// <summary>
        /// Gets the image color to remap into another color.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetContentImageColorMap(PaletteState state)
        {
            if (Image.ImageColorMap != Color.Empty)
            {
                return Image.ImageColorMap;
            }
            else
            {
                return _inherit.GetContentImageColorMap(state);
            }
        }

        /// <summary>
        /// Gets the color to use in place of the image map color.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetContentImageColorTo(PaletteState state)
        {
            if (Image.ImageColorTo != Color.Empty)
            {
                return Image.ImageColorTo;
            }
            else
            {
                return _inherit.GetContentImageColorTo(state);
            }
        }
        #endregion

		#region ShortText
		/// <summary>
		/// Gets access to the short text palette details.
		/// </summary>
        [KryptonPersist]
        [Category("Visuals")]
		[Description("Overrides for defining short text appearance.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public PaletteNavContentText ShortText { get; }

	    private bool ShouldSerializeShortText()
		{
			return !ShortText.IsDefault;
		}

		/// <summary>
		/// Gets the actual content short text font value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Font value.</returns>
		public Font GetContentShortTextFont(PaletteState state)
		{
			if (ShortText.Font != null)
			{
			    return ShortText.Font;
			}
			else
			{
			    return _inherit.GetContentShortTextFont(state);
			}
		}

        /// <summary>
        /// Gets the font for the short text by generating a new font instance.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Font value.</returns>
        public Font GetContentShortTextNewFont(PaletteState state)
        {
            if (ShortText.Font != null)
            {
                return ShortText.Font;
            }
            else
            {
                return _inherit.GetContentShortTextNewFont(state);
            }
        }

		/// <summary>
		/// Gets the actual text rendering hint for short text.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>PaletteTextHint value.</returns>
		public PaletteTextHint GetContentShortTextHint(PaletteState state)
		{
			if (ShortText.Hint != PaletteTextHint.Inherit)
			{
			    return ShortText.Hint;
			}
			else
			{
			    return _inherit.GetContentShortTextHint(state);
			}
		}

        /// <summary>
        /// Gets the prefix drawing setting for short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteTextPrefix value.</returns>
        public PaletteTextHotkeyPrefix GetContentShortTextPrefix(PaletteState state)
        {
            if (ShortText.Prefix != PaletteTextHotkeyPrefix.Inherit)
            {
                return ShortText.Prefix;
            }
            else
            {
                return _inherit.GetContentShortTextPrefix(state);
            }
        }
        
        /// <summary>
		/// Gets the actual text trimming for the short text.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>PaletteTextTrim value.</returns>
		public PaletteTextTrim GetContentShortTextTrim(PaletteState state)
		{
			if (ShortText.Trim != PaletteTextTrim.Inherit)
			{
			    return ShortText.Trim;
			}
			else
			{
			    return _inherit.GetContentShortTextTrim(state);
			}
		}

		/// <summary>
		/// Gets the actual content short text horizontal alignment value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>RelativeAlignment value.</returns>
		public PaletteRelativeAlign GetContentShortTextH(PaletteState state)
		{
			if (ShortText.TextH != PaletteRelativeAlign.Inherit)
			{
			    return ShortText.TextH;
			}
			else
			{
			    return _inherit.GetContentShortTextH(state);
			}
		}

		/// <summary>
		/// Gets the actual content short text vertical alignment value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>RelativeAlignment value.</returns>
		public PaletteRelativeAlign GetContentShortTextV(PaletteState state)
		{
			if (ShortText.TextV != PaletteRelativeAlign.Inherit)
			{
			    return ShortText.TextV;
			}
			else
			{
			    return _inherit.GetContentShortTextV(state);
			}
		}

		/// <summary>
		/// Gets the actual content short text horizontal multiline alignment value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>RelativeAlignment value.</returns>
		public PaletteRelativeAlign GetContentShortTextMultiLineH(PaletteState state)
		{
			if (ShortText.MultiLineH != PaletteRelativeAlign.Inherit)
			{
			    return ShortText.MultiLineH;
			}
			else
			{
			    return _inherit.GetContentShortTextMultiLineH(state);
			}
		}

		/// <summary>
		/// Gets the flag indicating if multiline text is allowed for short text.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>InheritBool value.</returns>
		public InheritBool GetContentShortTextMultiLine(PaletteState state)
		{
			if (ShortText.MultiLine != InheritBool.Inherit)
			{
			    return ShortText.MultiLine;
			}
			else
			{
			    return _inherit.GetContentShortTextMultiLine(state);
			}
		}

        /// <summary>
        /// Gets the first color for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetContentShortTextColor1(PaletteState state)
        {
            if (ShortText.Color1 != Color.Empty)
            {
                return ShortText.Color1;
            }
            else
            {
                return _inherit.GetContentShortTextColor1(state);
            }
        }

        /// <summary>
        /// Gets the second back color for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetContentShortTextColor2(PaletteState state)
        {
            if (ShortText.Color2 != Color.Empty)
            {
                return ShortText.Color2;
            }
            else
            {
                return _inherit.GetContentShortTextColor2(state);
            }
        }

        /// <summary>
        /// Gets the color drawing style for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color drawing style.</returns>
        public PaletteColorStyle GetContentShortTextColorStyle(PaletteState state)
        {
            if (ShortText.ColorStyle != PaletteColorStyle.Inherit)
            {
                return ShortText.ColorStyle;
            }
            else
            {
                return _inherit.GetContentShortTextColorStyle(state);
            }
        }

        /// <summary>
        /// Gets the color alignment style for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color alignment style.</returns>
        public PaletteRectangleAlign GetContentShortTextColorAlign(PaletteState state)
        {
            if (ShortText.ColorAlign != PaletteRectangleAlign.Inherit)
            {
                return ShortText.ColorAlign;
            }
            else
            {
                return _inherit.GetContentShortTextColorAlign(state);
            }
        }

        /// <summary>
        /// Gets the color angle for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Angle used for color drawing.</returns>
        public float GetContentShortTextColorAngle(PaletteState state)
        {
            if (ShortText.ColorAngle != -1)
            {
                return ShortText.ColorAngle;
            }
            else
            {
                return _inherit.GetContentShortTextColorAngle(state);
            }
        }

        /// <summary>
        /// Gets an image for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Image instance.</returns>
        public Image GetContentShortTextImage(PaletteState state)
        {
            if (ShortText.Image != null)
            {
                return ShortText.Image;
            }
            else
            {
                return _inherit.GetContentShortTextImage(state);
            }
        }

        /// <summary>
        /// Gets the image style for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Image style value.</returns>
        public PaletteImageStyle GetContentShortTextImageStyle(PaletteState state)
        {
            if (ShortText.ImageStyle != PaletteImageStyle.Inherit)
            {
                return ShortText.ImageStyle;
            }
            else
            {
                return _inherit.GetContentShortTextImageStyle(state);
            }
        }

        /// <summary>
        /// Gets the image alignment style for the short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Image alignment style.</returns>
        public PaletteRectangleAlign GetContentShortTextImageAlign(PaletteState state)
        {
            if (ShortText.ImageAlign != PaletteRectangleAlign.Inherit)
            {
                return ShortText.ImageAlign;
            }
            else
            {
                return _inherit.GetContentShortTextImageAlign(state);
            }
        }
        #endregion

		#region LongText
		/// <summary>
		/// Gets access to the long text palette details.
		/// </summary>
        [KryptonPersist]
        [Category("Visuals")]
		[Description("Overrides for defining long text appearance.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public PaletteNavContentText LongText { get; }

	    private bool ShouldSerializeLongText()
		{
			return !LongText.IsDefault;
		}

		/// <summary>
		/// Gets the actual content long text font value.
		/// </summary>
		/// <returns>Font value.</returns>
		/// <param name="state">Palette value should be applicable to this state.</param>
		public Font GetContentLongTextFont(PaletteState state)
		{
			if (LongText.Font != null)
			{
			    return LongText.Font;
			}
			else
			{
			    return _inherit.GetContentLongTextFont(state);
			}
		}

        /// <summary>
        /// Gets the font for the long text by generating a new font instance.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Font value.</returns>
        public Font GetContentLongTextNewFont(PaletteState state)
        {
            if (LongText.Font != null)
            {
                return LongText.Font;
            }
            else
            {
                return _inherit.GetContentLongTextNewFont(state);
            }
        }

		/// <summary>
		/// Gets the actual text rendering hint for long text.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>PaletteTextHint value.</returns>
		public PaletteTextHint GetContentLongTextHint(PaletteState state)
		{
			if (LongText.Hint != PaletteTextHint.Inherit)
			{
			    return LongText.Hint;
			}
			else
			{
			    return _inherit.GetContentLongTextHint(state);
			}
		}

        /// <summary>
        /// Gets the prefix drawing setting for long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteTextPrefix value.</returns>
        public PaletteTextHotkeyPrefix GetContentLongTextPrefix(PaletteState state)
        {
            if (LongText.Prefix != PaletteTextHotkeyPrefix.Inherit)
            {
                return LongText.Prefix;
            }
            else
            {
                return _inherit.GetContentLongTextPrefix(state);
            }
        }
        
        /// <summary>
		/// Gets the actual text trimming for the long text.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>PaletteTextTrim value.</returns>
		public PaletteTextTrim GetContentLongTextTrim(PaletteState state)
		{
			if (LongText.Trim != PaletteTextTrim.Inherit)
			{
			    return LongText.Trim;
			}
			else
			{
			    return _inherit.GetContentLongTextTrim(state);
			}
		}

		/// <summary>
		/// Gets the actual content long text horizontal alignment value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>RelativeAlignment value.</returns>
		public PaletteRelativeAlign GetContentLongTextH(PaletteState state)
		{
			if (LongText.TextH != PaletteRelativeAlign.Inherit)
			{
			    return LongText.TextH;
			}
			else
			{
			    return _inherit.GetContentLongTextH(state);
			}
		}

		/// <summary>
		/// Gets the actual content long text vertical alignment value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>RelativeAlignment value.</returns>
		public PaletteRelativeAlign GetContentLongTextV(PaletteState state)
		{
			if (LongText.TextV != PaletteRelativeAlign.Inherit)
			{
			    return LongText.TextV;
			}
			else
			{
			    return _inherit.GetContentLongTextV(state);
			}
		}

		/// <summary>
		/// Gets the actual content long text horizontal multiline alignment value.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>RelativeAlignment value.</returns>
		public PaletteRelativeAlign GetContentLongTextMultiLineH(PaletteState state)
		{
			if (LongText.MultiLineH != PaletteRelativeAlign.Inherit)
			{
			    return LongText.MultiLineH;
			}
			else
			{
			    return _inherit.GetContentLongTextMultiLineH(state);
			}
		}

		/// <summary>
		/// Gets the flag indicating if multiline text is allowed for long text.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>InheritBool value.</returns>
		public InheritBool GetContentLongTextMultiLine(PaletteState state)
		{
			if (LongText.MultiLine != InheritBool.Inherit)
			{
			    return LongText.MultiLine;
			}
			else
			{
			    return _inherit.GetContentLongTextMultiLine(state);
			}
		}

        /// <summary>
        /// Gets the first color for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetContentLongTextColor1(PaletteState state)
        {
            if (LongText.Color1 != Color.Empty)
            {
                return LongText.Color1;
            }
            else
            {
                return _inherit.GetContentLongTextColor1(state);
            }
        }

        /// <summary>
        /// Gets the second back color for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetContentLongTextColor2(PaletteState state)
        {
            if (LongText.Color2 != Color.Empty)
            {
                return LongText.Color2;
            }
            else
            {
                return _inherit.GetContentLongTextColor2(state);
            }
        }

        /// <summary>
        /// Gets the color drawing style for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color drawing style.</returns>
        public PaletteColorStyle GetContentLongTextColorStyle(PaletteState state)
        {
            if (LongText.ColorStyle != PaletteColorStyle.Inherit)
            {
                return LongText.ColorStyle;
            }
            else
            {
                return _inherit.GetContentLongTextColorStyle(state);
            }
        }

        /// <summary>
        /// Gets the color alignment style for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color alignment style.</returns>
        public PaletteRectangleAlign GetContentLongTextColorAlign(PaletteState state)
        {
            if (LongText.ColorAlign != PaletteRectangleAlign.Inherit)
            {
                return LongText.ColorAlign;
            }
            else
            {
                return _inherit.GetContentLongTextColorAlign(state);
            }
        }

        /// <summary>
        /// Gets the color angle for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Angle used for color drawing.</returns>
        public float GetContentLongTextColorAngle(PaletteState state)
        {
            if (LongText.ColorAngle != -1)
            {
                return LongText.ColorAngle;
            }
            else
            {
                return _inherit.GetContentLongTextColorAngle(state);
            }
        }

        /// <summary>
        /// Gets an image for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Image instance.</returns>
        public Image GetContentLongTextImage(PaletteState state)
        {
            if (LongText.Image != null)
            {
                return LongText.Image;
            }
            else
            {
                return _inherit.GetContentLongTextImage(state);
            }
        }

        /// <summary>
        /// Gets the image style for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Image style value.</returns>
        public PaletteImageStyle GetContentLongTextImageStyle(PaletteState state)
        {
            if (LongText.ImageStyle != PaletteImageStyle.Inherit)
            {
                return LongText.ImageStyle;
            }
            else
            {
                return _inherit.GetContentLongTextImageStyle(state);
            }
        }

        /// <summary>
        /// Gets the image alignment style for the long text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Image alignment style.</returns>
        public PaletteRectangleAlign GetContentLongTextImageAlign(PaletteState state)
        {
            if (LongText.ImageAlign != PaletteRectangleAlign.Inherit)
            {
                return LongText.ImageAlign;
            }
            else
            {
                return _inherit.GetContentLongTextImageAlign(state);
            }
        }
		#endregion

		#region Padding
		/// <summary>
		/// Gets the padding between the border and content drawing.
		/// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
		[Description("Padding between the border and content drawing.")]
		[DefaultValue(typeof(Padding), "-1,-1,-1,-1")]
		[RefreshPropertiesAttribute(RefreshProperties.All)]
		public Padding Padding
		{
            get => _storage?.ContentPadding ?? CommonHelper.InheritPadding;

		    set
			{
                if (_storage != null)
                {
                    if (!value.Equals(_storage.ContentPadding))
                    {
                        _storage.ContentPadding = value;
                        PerformNeedPaint(true);
                    }
                }
                else
                {
                    if (!value.Equals(CommonHelper.InheritPadding))
                    {
                        _storage = new InternalStorage
                        {
                            ContentPadding = value
                        };
                        PerformNeedPaint(true);
                    }
                }
			}
		}

		/// <summary>
		/// Reset the Padding to the default value.
		/// </summary>
		public void ResetPadding()
		{
            Padding = CommonHelper.InheritPadding;
		}

		/// <summary>
		/// Gets the actual padding between the border and content drawing.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Padding value.</returns>
		public Padding GetContentPadding(PaletteState state)
		{
			// Initialize the padding from inherited values
			Padding paddingInherit = _inherit.GetContentPadding(state);
            Padding paddingThis = Padding;

			// Override with specified values
            if (paddingThis.Left != -1)
            {
                paddingInherit.Left = paddingThis.Left;
            }
		    if (paddingThis.Right != -1)
		    {
		        paddingInherit.Right = paddingThis.Right;
		    }
		    if (paddingThis.Top != -1)
		    {
		        paddingInherit.Top = paddingThis.Top;
		    }
		    if (paddingThis.Bottom != -1)
		    {
		        paddingInherit.Bottom = paddingThis.Bottom;
		    }

		    return paddingInherit;
		}
		#endregion

		#region AdjacentGap
		/// <summary>
		/// Gets the padding between adjacent content items.
		/// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
		[Description("Spacing gap between adjacent content items.")]
		[DefaultValue(-1)]
		[RefreshPropertiesAttribute(RefreshProperties.All)]
		public int AdjacentGap
		{
            get => _storage?.ContentAdjacentGap ?? -1;

		    set
			{
                if (_storage != null)
                {
                    if (_storage.ContentAdjacentGap != value)
                    {
                        _storage.ContentAdjacentGap = value;
                        PerformNeedPaint(true);
                    }
                }
                else
                {
                    if (value != -1)
                    {
                        _storage = new InternalStorage
                        {
                            ContentAdjacentGap = value
                        };
                        PerformNeedPaint(true);
                    }
                }
			}
		}

		/// <summary>
		/// Reset the AdjacentGap to the default value.
		/// </summary>
		public void ResetAdjacentGap()
		{
			AdjacentGap = -1;
		}

		/// <summary>
		/// Gets the actual padding between adjacent content items.
		/// </summary>
		/// <param name="state">Palette value should be applicable to this state.</param>
		/// <returns>Integer value.</returns>
		public int GetContentAdjacentGap(PaletteState state)
		{
            if (AdjacentGap != -1)
            {
                return AdjacentGap;
            }
            else
            {
                return _inherit.GetContentAdjacentGap(state);
            }
		}
		#endregion

        #region ContentStyle
        /// <summary>
        /// Gets the style appropriate for this content.
        /// </summary>
        /// <returns>Content style.</returns>
        public PaletteContentStyle GetContentStyle()
        {
            return _inherit.GetContentStyle();
        }
        #endregion
    }
}
