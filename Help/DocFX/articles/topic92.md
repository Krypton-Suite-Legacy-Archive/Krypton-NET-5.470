Ribbon Item Events  
  
Applicable Events:  
        KryptonRibbonGroup.DialogBoxLauncherClick  
        KryptonRibbonGroupButton.Click  
        KryptonRibbonGroupButton.DropDown  
        KryptonRibbonGroupClusterButton.Click  
        KryptonRibbonGroupClusterButton.DropDown  
        KryptonRibbonQATButton.Click  
 

**KryptonRibbonGroup**

**DialogBoxLauncherClick**  
When a *KryptonRibbonGroup* is showing the dialog launcher button, which can be
seen on the bottom right corner of the group title area, the user can press the
button in order to generate the event. The *Ribbon* control performs no other
action when this button is pressed other than to generate the event and so if
you require a dialog box or other user feedback to occur you must implement it
inside the event handler.

 

**KryptonRibbonGroupButton**  
**KryptonRibbonGroupClusterButton**

**Click**  
A *Click* event is generate only for the button types of *Push* and *Check.*

**DropDown**  
A *DropDown* event is generated only for button types of *DropDown* and *Split*.
The event is generated with a *RibbonContextMenuArgs* instance which is used to
provide a reference to the *ContextMenuStrip* associated with the button. Note
that you must associate a *ContextMenuStrip* with the button yourself using
either code or the design time environment, otherwise the value will be null.
You can set the *RibbonContextMenuArgs.Cancel* property to *False* if you would
like to prevent the *Ribbon* from displaying the context menu strip once the
event handler has finished.

 

**KryptonRibbonQATButton**

**Click**  
A *Click* event is generate when the user presses the quick access toolbar
button.
