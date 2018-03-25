KryptonWrapLabel

 

Use the *KryptonWrapLabel* control when you need to functionality of the
standard *Windows.Forms.Label* control but with the text color and font of the
*Krypton* palette system. Unlike the *KryptonLabel* control this
*KryptonWrapLabel* control inherits directly from the standard
*Windows.Forms.Label* class and so it performs the same automatic wrapping of
text onto multiple lines. This is the one circumstance for which this control is
recommended instead of the *KryptonLabel* control. If you need text to span
multiple lines then this is the control to use.

 

**Appearance** 

The *LabelStyle* property is used to define the top level styling required for
the appearance of the *KryptonWrapLabel* control. The four standard values are
*NormalControl*, *TitleControl*, *NormalPanel* and *TitlePanel*. It is important
to understand when to use which style in order to get the correct appearance
when switching to different palettes.  
  
When using a wrap label that is positioned with on a *Control* style background,
such as *ControlClient* or *ControlAlternate*, then you should use the
*NormalControl* or *TitleControl* styles. A good example would be placing wrap
label instances in the client area of a *KryptonHeaderGroup,* as the header
group has a default background style in the client area of *ControlClient*. If
however you are placing wrap label instances onto a *KryptonPanel* then you
should use the *NormalPanel* or *TitlePanel* styles. It is easy to forget to set
the appropriate style because most of the builtin palettes have colors that look
fine on either a *Control* or *Panel* style background. But if you use the
*Office 2007 - Black* palette then it will fail to appear correctly as the
colors are radically different. In that scenario a *NormalControl* on a *Panel*
background would be invisible!

The *NormalControl* and *NormalPanel* styles give a standard text appearance
appropriate for use as a caption for other controls. Alternatively use the
*TitleControl/TitlePanel* settings for use as a section header where the text
needs to be more prominent. There are also custom styles that can be defined via
a *KryptonPalette* for situations where you need to create variations on the
styles already provided. Custom styles are named simply *Custom1*, *Custom2* and
*Custom3*.

 

**Two States** 

Only two possible states of *Disabled* and *Normal* are used by the wrap label
control. In order to customize the appearance use the corresponding
*StateDisabled* and *StateNormal* properties. Note that only three properties
are provided. You can only customize the text color, text font and rendering
hint. These are also the only three values that are inherited from the palette
that defines the default properties. Also note that the background color cannot
be set as the background is always transparent and so shows the background of
the parent control. 

 

To speed up the customization process an extra *StateCommon* property has been
provided. The settings from this are used if no override has been defined for
the state specific entry. Note that the specific state values always take
precedence and so if you define the text font in *StateNormal* and *StateCommon*
then the *StateNormal* value will be used whenever the control is in the
*Normal* state. Only if the *StateNormal* value is not overridden will it look
in *StateCommon*.
