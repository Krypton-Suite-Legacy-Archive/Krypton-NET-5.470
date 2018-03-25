Navigator Header Modes  
  
Applicable Modes:  
        HeaderBar - CheckButton - HeaderGroup  
        Stack - CheckButton - HeaderGroup  
        Outlook - Full  
        Outlook - Mini  
        HeaderGroup  
        HeaderGroup - Tab

 

**Header Mode Properties**  
The set of properties associated with Header related modes can be seen in Figure
1 as they appear in the properties window.

  
*   Figure 1 - Header Mode Properties*

**Header Positions**  
The primary, secondary and bar headers can be positioned against any of the form
control edges. To alter the location of the primary header alter the
*HeaderPositionPrimary* to an alternative value such as *Left*, *Right* or
*Bottom*. Use the *HeaderPositionSecondary* property to modify the location of
the secondary header and *HeaderPositionBar* for the bar header. Figure 2 shows
the *HeaderGroup* mode with default settings and Figure 3 with the primary
header on the *Left* and the secondary header on the *Right*.

* *  
*   Figure 2 - Default HeaderGroup appearance*

*   *  
*   Figure 3 - Modified header positions*

 

**Header Styles**  
The header style can be altered using the *HeaderStylePrimary,
HeaderStyleSecondary, HeaderStyleBar* properties. Figure 2 shows the default
appearance with the primary header using the primary header style and the
secondary header the secondary header style. Figure 4 shows an example where the
*HeaderStylePrimary* property has been altered to *Secondary*.

* *  
*   Figure 4 - HeaderStylePrimary = Secondary*

  
**Header Values**  
The *HeaderValuesPrimary* set of properties are used to determine the text and
image to show on the primary header. Likewise the *HeaderValuesSecondary*
property set determines the display for the secondary header. Note that there is
no property for the bar header as the bar header contains per page controls
whose content are determined in the *Bar* set of visual properties.  
  
Each set contains a *Header, Description* and *Image* property that are used to
define the display when there is no page selected. These are useful because when
the navigator does not have any visible pages you will want to define what is
shown on the header. Showing a message to indicate the empty state prevents the
user becoming confused because there is no text displayed at all.  
  
The *MapHeader*, *MapDescription* and *MapImage* properties are used when a page
is selected and determine how to extract values from the selected *KryptonPage*
for display. *MapImage *is used to recover an image from the *KryptonPage*. To
prevent any image from being shown assign the *None* value. To show the
*ImageSmall* form the page assign *Small* to the *MapImage*. More complex
mappings are possible, for example a value of *LargeMediumSmall* indicates that
the *ImageLarge* property of the page should be used unless it is null, in that
case use the *ImageMedium* property instead but if that is also null then use
the *ImageSmall* page property.  
  
Use *MapHeader* to map from the *Text*, *TextTitle*, *TextDescription* and
*TextTooltip* properties of the *KryptonPage* to the main header text. The
default value is *TitleText* indicating that the *TextTitle* property of the
page is used unless it is empty in which case the *Text* property is used. Other
variations exist so you can specify a preference for what text is shown.
*MapDescription* works in the same way but maps to the header description text
and defaults to *None*.

**Header Visibility**  
All the headers can be removed from display. Use the *HeaderVisiblePrimary,
HeaderVisibleSecondary* and *HeaderVisibleBar* boolean properties to change the
visibility. Note that if you remove the primary header that contains the
*Close*, *Context* and other buttons then those buttons will not longer be
accessible to the user.
