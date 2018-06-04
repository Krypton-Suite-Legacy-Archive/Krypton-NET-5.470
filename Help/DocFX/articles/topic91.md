Ribbon Control Events  
  
Applicable Events:  
        ApplicationButtonOpening  
        ApplicationButtonOpened  
        ApplicationButtonClosing  
        ApplicationButtonClosed  
        SelectedContextChanged  
        SelectedTabChanged  
        ShowRibbonContextMenu

        ShowQATCustomizeMenu  
 

**ApplicationButtonOpening**  
Generated when the application button is about to show the application menu.
This event can be cancelled so if you decide to prevent the showing of the
context menu you can simply set the *CancelEventArgs.Cancel* property to *True*
and return from your event handler. Alternatively you can use the event as a
chance to modify the entires that will appear. So you could update the visible
and enabled state of the context menu items or alter the list of recent
documents to reflect recent changes.

**ApplicationButtonOpened**  
Generated when the application menu has been created and displayed to the user. 

**ApplicationButtonClosing**  
Generated when the application menu makes a request to be dismissed. This event
can be cancelled and so you can prevent the menu from being removed. One of the
parameters is a value indicating the reason for the close request. So you can
discover if the request is the result of an item being click, the escape key
being pressed etc. 

**ApplicationButtonClosed**  
Generated once the application menu has been removed from display, you cannot
cancel this event.

**SelectedContextChanged**  
Whenever the value of the *SelectedContext* property on the *Ribbon* changes
this event is generated.

**SelectedTabChanged**  
A change in the *SelectedTab* of the *Ribbon* will generate the
*SelectedTabChanged* event. This can occur because the user has clicked a tab
and so initiated the change in selection. It can also happen if you change a tab
property such as the *Visible* state of the currently selected tab, thus causing
a different tab to become selected instead. Adding and removing tabs can
potentially change the tab selection along with a change in the
*SelectedContext* property.

**ShowRibbonContextMenu**  
When the user right clicks the tabs area of the *Ribbon* this event is
generated. This allows you to modify the contents of the context menu about to
be shown to the user. You might want to add additional entries that are relevant
to your specific application needs.

**ShowQATCustomizeMenu**  
On the right hand side of the quick access toolbar is a small button that is
used to customize the display of the quick access toolbar. Just before this
customization menu is displayed this event is fired. You can cancel the event to
prevent the menu appearing or you can modify the menu contents in order to add
new menu options.
