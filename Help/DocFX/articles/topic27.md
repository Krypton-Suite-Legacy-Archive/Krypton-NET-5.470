KryptonContextMenuImageSelect

*Figure 1 shows the list of properties exposed by the
KryptonContextMenuImageSelect component.*  
  


* Figure 1 - KryptonContextMenuImageSelect properties* 

 

**AutoClose**  
Determines if selecting a new image should cause the context menu to be closed.

**ImageIndexEnd**  
**ImageIndexStart**  
Defines the start and end indexes to use from the *ImageList* for display.

**ImageList**  
Source image list instance that provides the images for display.

**LineItems**  
Number of images to display per horizontal line.

**Padding**  
Pixel spacing to provide as an indent before the contained images are shown.

**SelectedIndex**  
Index into the image list that is the currently selected item.

**Visible**  
Define this as *False* if you do not want the item to be displayed.

**Tag**  
Use the *Tag* to assign your application specific information with the component
instance.

**ButtonStyle**  
Style used to draw each of the display images.

 

Events

**SelectedIndexChanged**  
Occurs when the value of the *SelectedIndex* property changes, usually because
the user clicked an image at runtime.

**TrackingImage**  
Generated as the user tracks over different images, can be used to provide
instant feedback to the user about the changes that would occur if that tracking
item were to be selected by the user.
