KryptonCheckSet

 

Use the *KryptonCheckSet* component when you need to group together several
*KryptonCheckButton* instances in order to enforce the rule that only a single
check button is checked at a time. So when the user clicks a check button it
becomes checked and all others in the group are unchecked. Using this component
removes the need to implement the functionality manually using event handlers
attached to each of the check button controls.

 

The *CheckButtons* property is a collection of *KryptonCheckButton* references
that are to be managed by the component. At design time this collection can be
easily edited by using the collection editor that appears when the property
button is pressed.

 

To specify the check button that is currently checked within the set you can use
either the *CheckedButton* or *CheckedIndex* property. At design time you are
recommended to use the *CheckedButton* property as the drop down list it
presents gives the available options making selection easier.

 

*AllowUncheck* can be used to specify if the checked button when clicked becomes
unchecked or is left unchanged. By default the property is *False* and so
clicking the same check button multiple times has effect.

 

Whenever the currently checked button changes the *CheckedButtonChanged* event
is fired so you can hook into the event to perform selection specific actions.
