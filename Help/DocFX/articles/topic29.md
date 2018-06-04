KryptonContextMenuItem

*Figure 1 shows the list of properties exposed by the KryptonContextMenuItem
component.*  
  
  
* Figure 1 - KryptonContextMenuItem properties*

 

**Checked**

A boolean property that determines if the menu item should be displayed as a
checked item.

 

**CheckState**  
This property has is useful when you need a three state check item. You can
define the property as either *Checked*, *Unchecked* or *Indeterminate* with the
*Checked* and *Indeterminate* both causing the *Checked* property to be defined
as *True*.

  
**ExtraText**

Optional extra text that can appear in addition to the main *Text* property.

 

**Image**

Optional image to draw next to the menu item text.

 

**ImageTransparentColor**

If you provide an *Image* then this property is used to specify which image
color to consider transparent.

 

**ShortcutKeyDisplayString**

When a *ShortcutKeys* property value is provided the short cut key combination
is shown by default to the right hand side of the menu item. However you can use
this property to override that string and force your own display string to be
shown instead.

 

**ShowShortcutKeys**

When a *ShortcutKeys* property value is provided the short cut key combination
is shown by default to the right hand side of the menu item. Use this boolean
property to turn off the display of that key combination or the display of the
*ShortcutKeyDisplayString*.

 

**Text**  
This is the standard text that appears as the menu item description.

  
**AutoClose**  
Determines if pressing this menu item should cause the context menu to be
closed. You might want to set this to *False* if you have an item that when
clicked should toggle the *Checked* state without causing the menu to be closed.

 

**CheckOnClick**  
When defined this will cause the *Checked* state of the item to be toggled
whenever the item is clicked.

 

**Enabled**  
Should the menu item be displayed as enabled and allow interaction with the
user. Note that if the *KryptonContextMenu* component has its own *Enabled*
property defined as *False* then the item will be disabled regardless of the
individual menu item *Enabled* state.

 

**KryptonCommand**  
Attached command that is used as a source of state.

 

**LargeKryptonCommandImage**  
By default the menu item will take the small image from the attached
*KryptonCommand* instance. If you prefer to use the large image instead then set
this property to *True* and it will show that alternate image.

**ShortcutKeys**  
Define the keyboard combination that should invoke this item.

 

**SplitSubMenu**  
If the Items collection is not empty then defining this property will cause the
item to be split into two distinct areas. The left area will act as a
traditional menu item that when clicked will dismiss the context menu and
generate a click event. The right area contains a sub menu indicator and when
clicked causes the sub menu to be shown.

 

**Visible**  
Define this as *False* if you do not want the menu item to be displayed.

 

**Items**  
Collection of child items that when not empty causes a sub menu indicator to be
shown on the right of the menu item. When hovering over the item or when clicked
this would also cause the sub menu to be displayed. If you require the menu item
to still generate a click event when it has a sub menu then you should consider
using the *SplitSubMenu* property.

**Tag**  
Use the *Tag* to assign your application specific information with the component
instance.

**StateDisable, StateNormal, StateChecked & StateHighlight**  
Properties that allow the customization of the item area when displayed in
various different state.

 

Events

**Click**  
Occurs when the user selects the item.

**CheckedChanged**  
Occurs when the value of the *Checked* property changes, usually because the
user clicked the item at runtime.

**CheckStateChanged**  
Occurs when the value of the *CheckState* property changes, usually because the
user clicked the item at runtime.
