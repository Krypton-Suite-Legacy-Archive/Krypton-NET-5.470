Tutorial – Using Images with Buttons  
  
**Per-State Image Buttons**  
  
By using a set of images for all aspects of the appearance you can customize the
look and feel in any way you need. Figure 1 shows the value properties for a
*KryptonCheckButton* where each of the individual button states has a custom
image. The same technique can be applied to the *KryptonButton* control and a
*ButtonSpec* definition.  
  
  
   *Figure 1 - Using images for each state*  


For the builtin palettes you will find you need to change three other properties
to achieve an image only runtime presentation. First of all you need to prevent
the focus rectangle from being drawn when the button has focus. To do this you
need to alter the *OverrideFocus -\> Content -\> DrawFocus* property to *False*.
Obviously if you still want the focus rectangle to appear then ignore this step.  
  
Next you need to prevent the button background and border from being drawn. As
the entire appearance is represented by the images we do not need a border or
background. To turn off the background set the *StateCommon -\> Back -\> Draw*
property to *False*. For the border set to *False* for the *StateCommon -\>
Border -\> Draw* property.  
  
You are now ready to use the button at runtime, figure 2 shows the appearance
for all the different button states for the figure 1 setup when the background,
border and focus drawing have been turned off.

  
   *Figure 2 - Actual check button display*   
  
  
  
  
**Single Image Buttons**

These buttons should look familiar as they are the default type of button
presented by the *Professional - Office 2003* builtin palette. They consist of
using just a single image that only gets drawn differently in the disabled
state. Instead of the image changing when the mouse tracks over and presses
down, the background and border are altered . Figure 3 shows how you only need
to assign a single image to the properties.

   *Figure 3 - Single image*  
  
You can see in figure 4 how the palette alters the background and border colors
to indicate the button state. The only state that draws the image differently is
the first one, disabled. If you want to alter the background and border then
either create and use a custom palette or alter the control level state
definitions.  
  
  
   *Figure 4 - Single image button*  
  


 

  
**Color Mapped Image Buttons**  
  
Each button state has the ability to remap a single color to a different target
color. You can take advantage of this by assigning a single color image to the
button and then re mapping that single color in each of the button states. This
achieves the advantage of only needing to create and use a single image whilst
still being able to alter the image appearance. Figure 5 shows a single black
cross image assigned to a button.  
  
  
*   Figure 5 - Single color image*  
  
In the mouse tracking mode we want to change the image from black to green.
Figure 6 shows the *StateTracking* property called *ImageColorMap* being set the
*Black* and the *ImageColorTo* property defined as *Green*.  
  
  
   *Figure 6 - StateTracking color re mapping*  
  
By changing the target color for each of the button states you can see the
runtime effect in figure 7 where the background and border drawing have
been turned off but the focus rectangle is left to be drawn as normal.  
  
   
*    Figure 7 - Color mapped button*
