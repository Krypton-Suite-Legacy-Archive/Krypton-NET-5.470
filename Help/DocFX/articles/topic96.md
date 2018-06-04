Navigator KryptonPage

The *KryptonPage* is the only type that can be added to the
*KryptonNavigator.Pages* collection. It works just like a traditional *Panel* in
that you can drag and drop controls onto it during design time for display when
that page is selected inside the navigator. It does however have extra
properties that allow it to work in conjunction with the navigator to achieve
the look and feel you need.  
  
  
**Text, TextTitle and TextDescription**  
You can see in Figure 1 that the *KryptonPage* has three text properties
beginning with the word *Text* that are typically used to provide various types
of description for the page. The standard *Text* property is intended for giving
the shortest description about the page, the kind of brief text appropriate for
display on a check button. *TextTitle* is for use when you have more space
available and should be used to provide a fuller description of the page. An
appropriate use of this property would be a title for a header. The
*TextDescription* can contain a very long and detailed description of the page.
This would be appropriate for appearing on a status bar.  
  
  
*   Figure 1 - KryptonPage Appearance Properties*  
  
  
**ImageLarge, ImageMedium and ImageSmall**  
Also in Figure 1 you can see that there are three different image properties
beginning with the word *Image*. *ImageSmall* should contain a small image of
16x16 and is appropriate for use inside a check button. Use *ImageMedium* for an
intermediate sized image of 24x24 that would be used on a section header. Last
is the *ImageLarge* that is recommended to be sized at 48x48 and is for uses as
a large icon representation of the page. Note that the 16x16, 24x24 and
48x48 sizes are only recommendations and you can provide any sized image that
you like.  
  
**ToolTipTitle, ToolTipBody, ToolTipImage, ToolTipImageTransparentColor and
ToolTipStyle**  
These properties are used to specify the tool tip details for display when the
user hovers over the page heading. Use the *ToolTipTitle* and *ToolTipBody*
properties to define two text strings for display. To associate an image with
the tool tip you should assign it to *ToolTipImage* and use the
*ToolTipImageTransparentColor* for specifying a color in the image that should
be treated as transparent. For example, many bitmaps will use magenta as a color
for the background area that should become transparent when the bitmap is drawn,
in that case assign *Color.Magenta* to the
*ToolTipImageTransparentColor* property.

The default value for the *ToolTipStyle* is *LabelStyle.ToolTip* and will cause
the image and title text to be shown at the top of the tool tip area and the
body text to be shown below. Alternatively you could change the style to
*LabelStyle.SuperTip* in which case the title text is shown in bold at the top
of the tool tip area, the image in shown below with the title also below and to
the right of the image.

**UniqueName Property**  
As the name suggests, this field allows the developer to assign a unique name to
the page instance. By default each new instance will be assigned a new GUID
generated from the operating system to ensure uniqueness. As these are not easy
to remember it is recommended you alter the property to a more meaningful value
if you intend to make use of the property.  
  
  
**Visual Properties**  
Figure 2 shows the list of properties you can use to override the appearance of
the page itself and other navigator elements. Use these properties if you to
alter the look and feel on a per-page basis. For example, you might decide that
one particular page needs a bright red border to indicate an error condition
with some of the controls contained on the page.

*   Figure 2 - KryptonPage Visual Properties*

Figure 3 shows an example where the appearance of the first page has been
altered so that it shows up in distinct red coloring. All the other pages have
been left with default settings. The left image shows the first page selected
and the right image when the second page is selected.  
  
* *  
*   Figure 3 - Customized Page Visuals*

 

Figure 4 shows an example where a button spec has been added to the first page.
You and can per-page button spec definitions to add extra buttons into any
navigator page.

   
*  Figure 4 - Pages with ButtonSpec definitions*
