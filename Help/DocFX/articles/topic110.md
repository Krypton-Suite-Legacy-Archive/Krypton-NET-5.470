Navigator Action Events  
  
Applicable Events:  
        NextAction  
        PreviousAction  
        CloseAction  
        ContextAction

 

**NextAction Event**  
This event is generated when the user presses the *NextAction* button that is
presented for some of the navigator modes. The event is generated in order to
request information about the appropriate action that should be taken by the
mode. By default the value of the *e.Action* event property is assigned from the
*KryptonNavigator.Button.NextButtonAction* control property. You can alter this
event property inside the event handler to modify the action you would like to
take place. Available actions are listed below.

-   *None*  
    The navigator will perform no action. This is useful if you want to
    implement some custom processing for the *NextAction* button. Just assign
    this value to the *e.Action* event property and then perform whatever
    application specific logic you require.

-   *SelectPage*  
    The navigator control will select the next available visible page.

-   *MoveBar*  
    The navigator will scroll the display bar to show the next set of page
    headers. Note this action will have no effect unless the current navigator
    mode is showing a bar with page headers displayed. Even then it will only
    perform a scroll if the bar is not already at the end of the set of page
    headers and so there are more pages headers that can be brought into view.

-   *ModeAppropriateAction*  
    The navigator will use the action most appropriate for the currently
    selected navigator mode. The bar modes will use the MoveBar action and the
    HeaderGroup mode the SelectPage action.

**PreviousAction Event**  
Generated when the user presses the *PreviousAction* button this event is used
to request information about the appropriate action that should be taken by the
mode. Note that the *PreviousAction* button is only presented for some of the
navigator modes. By default the value of the *e.Action* event property is
assigned from the *KryptonNavigator.Button.PreviousButtonAction* control
property. You can alter this event property inside the event handler to modify
the action you would like to take place. Available actions are listed below.

-   *None*  
    The navigator will perform no action. This is useful if you want to
    implement some custom processing for the *PreviousAction* button. Just
    assign this value to the *e.Action* event property and then perform whatever
    application specific logic you require.

-   *SelectPage*  
    The navigator control will select the previous available visible page.

-   *MoveBar*  
    The navigator will scroll the display bar to show the previous set of page
    headers. Note this action will have no effect unless the current navigator
    mode is showing a bar with page headers displayed. Even then it will only
    perform a scroll if the bar is not already at the start of the set of page
    headers and so there are more pages headers that can be brought into view.

-   *ModeAppropriateAction*  
    The navigator will use the action most appropriate for the currently
    selected navigator mode. The bar modes will use the *MoveBar* action and the
    *HeaderGroup* mode the *SelectPage* action.

 

**Close Action Event**  
Pressing the *CloseAction* button generates this event which is used to request
information about the appropriate action that should be taken. Note that the
*CloseAction* button is only presented for some of the navigator modes. By
default the value of the *e.Action* event property is assigned from the
*KryptonNavigator.Button.CloseButtonAction* control property. You can alter this
event property inside the event handler to modify the action you would like to
take place. Available actions are listed below.

-   *None*  
    The navigator will perform no action. This is useful if you want to
    implement some custom processing for the *CloseAction* button. Just assign
    this value to the *e.Action* event property and then perform whatever
    application specific logic you require.

-   *HidePage*  
    The navigator control will set the *KryptonPage.Visible* property of the
    selected page to be *False*. Useful if you need to hide pages so they can be
    made visible again later on.

-   *RemovePage*  
    The navigator will remove the selected page from the
    *KryptonNavigator.Pages* collection. Note that it does not call
    *KryptonPage.Dispose()* method and so the page can be added back to the same
    or a different navigator control in the future.

-   *RemovePageAndDispose*  
    The navigator will perform the *RemovePage* action as above and also call
    the *KryptonPage.Dispose()* method on the page. You should not try and add
    the page back to a navigator in the future as the page has been disposed.

**ContextAction Event**  
This event is used to allow customization of the displayed *KryptonContextMenu*
as well as requesting the action to take for the selected context menu item.
Note that the *ContextAction* button is only presented for some of the navigator
modes.  
  
By default the event will provide a *KryptonContextMenu* instance in the
*e.KryptonContextMenu* event property. There will be a single menu item in the
context menu strip for each page that is allowed to be selected. If you need to
customize the context menu by adding, removing or modifying entries then this is
the appropriate place to do so. If you add extra context menu items then you
need to add event handlers for processing their selection as the navigator
control will ignore them should the user select one.  
  
The *e.Action* event property indicates the action to take if the user selects
one of the auto generated context menu items. By default the value of the
*e.Action* event property is assigned from the
*KryptonNavigator.Button.ContextButtonAction* control property. You can alter
this event property inside the event handler to modify the action you would like
to take place. Available actions are listed below.

-   *None*  
    The navigator will perform no action.

-   *SelectPage*  
    The navigator control will select the page that the user selected from the
    context menu strip.

 
