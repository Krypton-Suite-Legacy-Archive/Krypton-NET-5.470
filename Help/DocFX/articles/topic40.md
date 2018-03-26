KryptonGroupBox

 

Use the *KryptonGroupBox* control when you need to group related controls
together and provide a caption. For example, you can use group boxes to
subdivide a form into distinct areas. Moving the group will cause all the
contained controls to also be moved along with it as it acts as a container.
This control is similar to the *KryptonGroup* except it provides a caption as
well as a grouping ability.

**Appearance** 

The *GroupBackStyle* and *GroupBorderStyle* properties are used to define the
level styling required for the background and border areas of the
*KryptonGroupBox* control. The default value of *ControlGroupBox* for both
properties gives an appearance appropriate for grouping together related
controls. The style of the caption is defined by the *CaptionStyle* property and
this default to *CaptionPanel*. By default the *CaptionOverlap* property is
defined as *50%* and so causes the group border to be drawn halfway down the
caption. If you would prefer the caption to be entirely outside of the border
then set this property to *100%*. To place the caption entirely inside the
border you can set the *CaptionOverlap* to *0%*.

 

**Two States** 

Only two possible states of *Disabled* and *Normal* are used by the group box
control. In order to customize the appearance use the corresponding
*StateDisabled* and *StateNormal* properties.

 

To speed up the customization process an extra *StateCommon* property has been
provided. The settings from this are used if no override has been defined for
the state specific entry. Note that the specific state values always take
precedence and so if you define the background color in *StateNormal* and
*StateCommon* then the *StateNormal* value will be used whenever the control is
in the *Normal* state. Only if the *StateNormal* value is not overridden will it
look in *StateCommon*.

 

**Examples of Appearance** 

Figure 1 shows the appearance when *GroupBackStyle* and *GroupBorderStyle* are
both defined as the default *ControlGroupBox*.

 

 

 

*Figure 1 – KryptonGroupBox examples*
