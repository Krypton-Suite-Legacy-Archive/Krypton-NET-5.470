KryptonContextMenuMonthCalendar

*Figure 1 shows the list of properties exposed by the
KryptonContextMenuMonthCalendar component.*  
* *

   
* Figure 1 - KryptonContextMenuMonthCalendar properties* 

 

**CalendarDimensions**

Determines the number of months shown as a grid.

 

**TodayText**

Text used to caption the today's date in the bottom caption area.

 

**AutoClose**  
Determines if pressing a day should cause the context menu to be closed.

 

**CloseOnTodayClicked**  
Determines if pressing the today button should cause the context menu to be
closed.

 

**Enabled**  
Should the month calendar be displayed as enabled and allow interaction with the
user. Note that if the *KryptonContextMenu* component has its own *Enabled*
property defined as *False* then the item will be disabled regardless of the
individual menu item *Enabled* state.

 

**FirstDayOfWeek**  
Specify which day of week is used as the first displayed column within the
month.

 

**MaxDate, MinDate**  
Place limits on the displayed and selectable date range by using these two
properties.

 

**MaxSelectionCount**  
Number of days that can be selected as a range. Use a value of 1 to allow only a
single day to be selected.

 

**ScrollChange**  
How many months to move forward and backward when the user clicks the
next/previous buttons in the top caption.

 

**SelectionRange, SelectionStart, SelectionEnd**  
Set these properties to define the current selection range and get these values
to find the new range when the context menu has been dismissed.

 

**ShowToday, ShowTodayCircle**  
Determines if today's date is displayed in the bottom caption of the control and
if the day that represents today's date has a highlighted border (circle).

 

**ShowWeekNumbers**  
When defined this property will show week numbers in the row header of each
displayed week of values.

 

**TodayDate**  
Defaults to the current date when the control is created but can be set to
define any date as the today date.

**Visible**  
Define this as *False* if you do not want the element to be displayed.  
  
**Tag**  
Use the *Tag* to assign your application specific information with the component
instance.   
  
**AnnuallyBoldedDates, MonthlyBoldedDates, BoldedDates**  
Use these collections to specify which dates should be displayed in a bold
state.  
  
**DayOfWeekStyle, DayStyle, HeaderStyle**  
Properties used to define the palette styles used to draw various elements of
the control.  
  
**OverrideFocus, OverrideBolded, OverrideToday**  
**StateCommon, StateDisabled, StateNormal, StateTracking, StatePressed**  
**StateCheckedNormal, StateCheckedTracking, StateCheckedPressed**  
Overrides for changing how the month elements are drawn in various states.

 

Events

**DateChanged**  
Occurs when any of the date properties is changed.  
  
**SelectionStartChanged**  
Occurs when the *SelectionStart* property changes.  
  
**SelectionEndChanged**  
Occurs when the *SelectionEnd* property changes.
