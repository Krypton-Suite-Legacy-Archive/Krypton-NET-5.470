KryptonContextMenuCheckBox

*Figure 1 shows the list of properties exposed by the KryptonContextMenuCheckBox
component.*  
* *

   
* Figure 1 - KryptonContextMenuCheckBox properties*  
  


**Checked**

A boolean property that determines if the check box should be displayed as
checked.

 

**CheckState**  
This property has is useful when you need a three state check box. You can
define the property as either *Checked*, *Unchecked* or *Indeterminate* with the
*Checked* and *Indeterminate* both causing the *Checked* property to be defined
as *True*.

  
**ExtraText**

Optional extra text that can appear in addition to the main *Text* property.

 

**Image**

Optional image to draw with the text and extra text.

 

**ImageTransparentColor**

If you provide an *Image* then this property is used to specify which image
color to consider transparent.

 

**Text**  
This is the standard text that appears as the check box description.

 

**AutoCheck**  
Should clicking the item cause the checked state to be toggled.

 

**AutoClose**  
Determines if pressing this check box should cause the context menu to be
closed.

 

**Enabled**  
Should the check box be displayed as enabled and allow interaction with the
user. Note that if the *KryptonContextMenu* component has its own *Enabled*
property defined as *False* then the item will be disabled regardless of the
individual menu item *Enabled* state.

 

**KryptonCommand**  
Attached command that is used as a source of state.

 

**ThreeState**  
Should clicking the box cycle around three states or just the traditional two of
*Checked* and *Unchecked*.

 

**Visible**  
Define this as *False* if you do not want the collection of items to be
displayed.

**Tag**  
Use the *Tag* to assign your application specific information with the component
instance. 

**Images**  
Set of images to use for drawing the check box instead of the default palette
entries.

**ImageStyle**  
Drawing style applied to the text, extra text and image content.

**OverrideFocus, StateCommon, StateDisabled, StateNormal**  
Overrides for changing how the item is drawn in various states.

 

Events

**Click**  
Occurs when the user selects the item.

**CheckedChanged**  
Occurs when the value of the *Checked* property changes, usually because the
user clicked the item at runtime.

**CheckStateChanged**  
Occurs when the value of the *CheckState* property changes, usually because the
user clicked the item at runtime.
