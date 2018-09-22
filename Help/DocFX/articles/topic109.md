Navigator Selection Events  
  
Applicable Events:  
        Deselecting  
        Selecting  
        Deselected  
        Selected  
        SelectedPageChanged  
  
  
**Standard Event Sequence**  
When a change in selected page is requested the following sequence of events
occur. Note that this sequences occurs when either the user initiates a change
or when you programmatically change selection by altering the *SelectedIndex* or
*SelectedPage* properties of the navigator control. There is never any
difference in the events generated or the ordering of events just because the
source of the change is programmatic compared to user interaction.

-   *Deselecting*  
    Generated for the currently selected page in order to ask if the page is
    allowed to be deselected. This event can be cancelled so if the event
    handler sets the *e.Cancel* value to *True* then the selection change is
    aborted immediately. Use this event to perform page level validation and
    decide if you will allow the page to be deselected.

-   *Selecting*  
    Generated for the page that is to become selected and asks if the page is
    allowed to be selected. This event can be cancelled so if the event handler
    sets the *e.Cancel* value to *True* the the selection change is aborted
    immediately. Use this event to decide if the page is capable of becoming
    selected.

-   *Deselected*  
    Generated for the currently selected page and indicates that it is now
    becoming deselected. This event cannot be cancelled and so you should use
    the event to perform any cleanup actions that are required when the page is
    no longer to be displayed.

-   *Selected*  
    Generated for the page that is to now becoming selected. This event cannot
    be cancelled and so you should perform actions to initialize the new page
    ready for display as the new selection.

-   *SelectedPageChanged*  
    Generated when the value of the *SelectedPage* property is changed to
    reflect the new selection. This event cannot be cancelled and is always the
    last event in the sequence. If you do not need to perform any page specific
    actions such as initialization, cleanup or validation then this is the most
    appropriate event to monitor for selection changes.

You can use the *Basic Events* example that is found in the *Navigator* section
of the *Krypton Explorer* to see the events that are generated during selection
changes. This handy example allows you to add and remove pages to the navigator
and lists the selection events that occur as you click around the pages.  
  
  
  
**First Page Sequence**  
When the first visible page is added the sequence of events differs from that
listed above. There is obviously no existing page that needs to be
deselected and so no need to generate the *Deselecting* and *Deselected* events.
So the generated event sequence becomes the following.

-   *Selecting*  
    Generated for the page that is to become selected. Any attempt to cancel the
    event will be ignored because one of the visible pages must be selected at
    all times. Although the event cannot be cancelled it is still fired so you
    can be sure that the logic inside the handler is always called before the
    page becomes selected.

-   *Selected*  
    Generated for the page just added to the control. This event cannot be
    cancelled and so you should perform actions to initialize the new page ready
    for display as the new selection.

-   *SelectedPageChanged*  
    Generated when the value of the *SelectedPage* property is changed to
    reflect the new selection. This event cannot be cancelled and is always the
    last event in the sequence. If you do not need to perform any page specific
    actions such as initialization, cleanup or validation then this is the most
    appropriate event to monitor for selection changes.

**Last Page Sequence**  
When the last visible page is removed from the navigator only two events are
fired. Once the last page is removed there is no choice left but to set the
selected page to *(null)*. Therefore the only two events fired are as follows.

-   *Deselected*  
    Generated for the currently selected page and indicates that it is now
    becoming deselected. This event cannot be cancelled and so you should use
    the event to perform any cleanup actions that are required when the page is
    no longer to be displayed.

-   *SelectedPageChanged*  
    Generated when the value of the *SelectedPage* property is changed to
    reflect the new selection. This event cannot be cancelled and is always the
    last event in the sequence. If you do not need to perform any page specific
    actions such as initialization, cleanup or validation then this is the most
    appropriate event to monitor for selection changes.

 

**Remove Page Sequence**  
This sequence is applied when removing the selected page and there are one or
more other visible pages still present. With other pages still present one of
them will have to become the new selection but you can use the *Selecting* event
to determine which one it will be. You cannot specify the actual page you would
like to become selected in the any of the generated events, but you can keep
cancelling the *Selecting* event for all the pages except the one you want to
become selected.

There is no *Deselecting* event because the page is being removed from the
*KryptonNavigator.Pages* collection and you cannot prevent the page from being
removed by cancelling the event. Therefore the first event fired is
*Deselected*. This is then followed by firing the *Selecting* event for all the
remaining visible pages. If one of the *Selecting* events is not cancelled then
it becomes the new selection. If all the remaining pages cancel the event then
the control will automatically select the first enabled page that it tested.
When there are no enabled pages remaining then it chooses the first disabled
page that was tested.

-   *Deselected*  
    Generated for the currently selected page and indicates that it is being
    removed and so becoming deselected. This event cannot be cancelled and so
    you should use the event to perform any cleanup actions that are required
    when the page is no longer to be displayed.

-   *Selecting*  
    This event is fired for all remaining visible pages. If the event is not
    cancelled then it becomes the new selection. If all the remaining pages
    cancel the event then the control will automatically select the first
    enabled page that it tested. When there are no enabled pages remaining then
    it chooses the first disabled page that was tested. Note that default value
    of the *e.Cancel* property is *True* if the page is disable and *False* if
    the page is enabled. This ensures that if you do not override the event then
    the default action for the control will be to selected the next available
    enabled page.

-   *Selected*  
    Generated for the page that is to now becoming selected. This event cannot
    be cancelled and so you should perform actions to initialize the new page
    ready for display as the new selection.

-   *SelectedPageChanged*  
    Generated when the value of the *SelectedPage* property is changed to
    reflect the new selection. This event cannot be cancelled and is always the
    last event in the sequence. If you do not need to perform any page specific
    actions such as initialization, cleanup or validation then this is the most
    appropriate event to monitor for selection changes.

  
  
**KryptonPage.Visible Property**  
Just because a page has been added to the navigator does not mean it has to be
displayed. You can use the *KryptonPage.Visible* property and the
*KryptonPage.Hide()* and *KryptonPage.Show()* methods to alter the page
visibility at any time. As far as the active selection and the selection events
are concerned a page that is not visible does not exist.  
  
If you have a single page in the *KryptonNavigator.Pages* collection that is
currently hidden and then you set that page to be visible then the *First Page
Sequence* will occur, because as far as the navigator is concerned this is the
first page that is now capable of being displayed and selected. If you then hide
that page the *Last Page Sequence* will be fired.  
  
So although a page is might be constantly present in the
*KryptonNavigator.Pages* collection you should think of it as only being present
for selection purposes when set to be visible.  
  
  
**KryptonPage.Enabled Property**  
Unlike the visible property the enabled property does not always prevent a page
from becoming selected. Under normal circumstances a disabled page will not
become selected because the user interface will not allow the user to select
that page. But there are circumstances that will cause a disabled page to be
selected.  
  
If the only page displayed is in the disabled state then it will be
selected. Remember that one of the visible pages must be in the selected state.
This can happen when you add just a single page to the navigator that is also
disabled. Alternatively if you remove all pages from the control except a
disabled one then it will become selected. Also if you change the currently
selected page from enabled to disabled then it will retain the selected state.
