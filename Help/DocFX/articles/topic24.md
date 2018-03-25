KryptonContextMenuCheckButton

*Figure 1 shows the list of properties exposed by the
KryptonContextMenuCheckButton component.*  
* *

   
* Figure 1 - KryptonContextMenuCheckButton properties* 

**Checked**

A boolean property that determines if the check button should be displayed as
checked.

 

**ExtraText**

Optional extra text that can appear in addition to the main *Text* property.

 

**Image**

Optional image to draw with the text and extra text.

 

**ImageTransparentColor**

If you provide an *Image* then this property is used to specify which image
color to consider transparent.

 

**Text**  
This is the standard text that appears as the check button description.

 

**AutoCheck**  
Should clicking the item cause the checked state to be toggled.

 

**AutoClose**  
Determines if pressing this check button should cause the context menu to be
closed.

 

**Enabled**  
Should the check button be displayed as enabled and allow interaction with the
user. Note that if the *KryptonContextMenu* component has its own *Enabled*
property defined as *False* then the item will be disabled regardless of the
individual menu item *Enabled* state.

 

**KryptonCommand**  
Attached command that is used as a source of state.

 

**Visible**  
Define this as *False* if you do not want the collection of items to be
displayed.

**Tag**  
Use the *Tag* to assign your application specific information with the component
instance. 

**ButtonStyle**  
Drawing style applied to the text, extra text and image content.

**OverrideFocus, StateCommon etc**  
Overrides for changing how the item is drawn in various states.

 

 

Events

**Click**  
Occurs when the user selects the item.

**CheckedChanged**  
Occurs when the value of the *Checked* property changes, usually because the
user clicked the item at runtime.
