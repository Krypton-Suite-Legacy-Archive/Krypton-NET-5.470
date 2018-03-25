Using IRenderer<br><br>Monitoring the global palette
====================================================

In order to get access to a renderer you need to begin with a palette. The
recommended way of getting an *IRenderer* reference is to call the
*GetReference()* method on the *IPalette* interface. Therefore your custom
control should begin by monitoring the global palette so that you can access the
associated renderer appropriate for that global palette. You should follow the
steps outlined in the [Using IPalette](topic135.md) article in order to add
ability.

<br>IRenderer Basics
====================

In order to use the methods exposed by the *IRenderer* we need take a few basic
setup steps. In particular we need to create four helper objects that are then
used in your interaction with the renderer instance. To begin you should add the
following fields to your custom control class.  
  
     private PaletteRedirect \_paletteRedirect;  
     private PaletteBackInheritRedirect \_paletteBack;  
     private PaletteBorderInheritRedirect \_paletteBorder;  
     private PaletteContentInheritRedirect \_paletteContent;  
     private IDisposable \_mementoBack;  
  
Now update your constructor in order to create the four instances in the
following manner.  
  
     public MyUserControl()  
     {  
          // ...your other constructor code...  
  
          // (1) Create redirection object to the base palette  
          \_paletteRedirect = new PaletteRedirect(_palette);  
  
          // (2) Create accessor objects for the back, border and content  
          \_paletteBack = new PaletteBackInheritRedirect(_paletteRedirect);  
          \_paletteBorder = new PaletteBorderInheritRedirect(_paletteRedirect);  
          \_paletteContent = new
PaletteContentInheritRedirect(_paletteRedirect);  
     }

In our previous article [Using IPalette](topic135.md) you could see how
palette values were directly recovered from the *IPalette* interface. However
the renderer does not interact directly with *IPalette* but instead with a set
of more specific interfaces such as *IPaletteBack*, *IPaletteBorder*
and *IPaletteContent*. Code block (1) creates a helper object that exposes these
specific interfaces and redirects the *IPaletteBack,
IPaletteBorder, IPaletteContent* calls into *IPalette* requests.    
  
We then use block (2) to create helper objects for each of the specific
interfaces. These are the actual objects you will pass into the renderer
requests. They each have a *Style* property that allows you to specify the
drawing style you require and all calls into the helper object will
automatically be passed on with the style requested. You can see how this works
in the code below. The following code is the template you should use in your
drawing code.  
  
     protected override void OnPaint(PaintEventArgs e)  
     {  
          if (_palette != null)  
          {  
               // (3) Get the renderer associated with this palette  
               IRenderer renderer = \_palette.GetRenderer();  
  
               // (4) Create the rendering context that is passed into all
renderer calls  
               using (RenderContext renderContext = new RenderContext(this,
e.Graphics, e.ClipRectangle, renderer))  
               {  
                    // (5) Set style required when rendering  
                    \_paletteBack.Style = PaletteBackStyle.ButtonStandalone;  
                    \_paletteBorder.Style = PaletteBorderStyle.ButtonStandalone;  
                    \_paletteContent.Style =
PaletteContentStyle.ButtonStandalone;

                    // (6) ...perform renderer operations...  
               }  
          }  
     }

 

Code block (3) is used to grab the renderer that is associated with the palette
we are using. We do not cache the renderer reference as we have already cached
and tracked the global palette, so we only need to request the renderer when it
is needed. Block (4) is used to create an instance of the *RenderContext* type
that is passed into all renderer calls. We use this object in order to package
up common values and so reduce the number of parameters passed into each
renderer call.  
  
In order to specify the drawing styles that should be used when recovering
palette values we use block (5). In our example we are setting these values in
every call to the *OnPaint* call as an illustration. In your own application you
might prefer to set these values just once in the constructor because you know
the style values are not going to change. On the other hand you might need to
alter the style settings between renderer calls in order to draw different
styles of elements within your custom control.  
  
Finally comment (6) shows the placeholder location where you would insert your
rendering calls. The following sections of the article give details of how to
make use of the background, border and content abilities of the renderer.

<br>Drawing a Background
========================

To draw a background we use the *IPalette.RenderStandardBack.DrawBack* call. The
following code provides you will a example usage.

     // (7) Do we need to draw the background?  
     if (_paletteBack.GetBackDraw(PaletteState.Normal) == InheritBool.True)  
     {  
          using (GraphicsPath path = new GraphicsPath())  
          {  
               // (8) Add entire control client area to drawing path  
               path.AddRectangle(ClientRectangle);

               // (9) Perform drawing of the background clipped to the path  
               \_mementoBack =
renderer.RenderStandardBack.DrawBack(renderContext,  
                                                                                            
ClientRectangle,  
                                                                                            
path,  
                                                                                            
\_paletteBack,  
                                                                                            
VisualOrientation.Top,   
                                                                                            
PaletteState.Normal,  
                                                                                            
\_mementoBack);   
          }  
     }

First we test to ensure that the palette specifies that the background is
allowed to be drawn for the state we are requesting, as can be seen in code
block (7). In this and all other examples in the article we provide the fixed
*PaletteState.Normal* enumeration value. You should however provide the
appropriate state for your control. Even the simplest control will need to
provide one of two possible values, *PaletteState.Normal* when enabled and
PaletteState.Disabled otherwise. If you need to provide more extensive feedback
then you should consider supplying *PaletteState.Tracking* when the house is
over the rendering element and *PaletteState.Pressed* when the mouse is also
pressed down.  
  
Code block (8) completes the process of creating a *GraphicsPath* that is used
to clip the area of background drawn. In our case we want to draw the entire
client area of the control and so set the path to the *ClientRectangle*, but you
could create any path you like in order render complex shapes.  
  
Finally block (9) performs the actual rendering operation. The second parameter
is the rectangle you would like to be drawn and the third parameter a path used
to clip the drawing operation. The second to last parameter is the palette state
that you should ensure is the same as the call in block (7). The last parameter
provides a memento object that is also assigned to as the result of the call.
This technique allows performance improvements in the renderer as it allows the
renderer to create caching objects and have them supplied again on subsequent
calls.

<br>Drawing a Border
====================

Once you know how to draw a background the border drawing is trivial. Here is
the code.

     // (10) Do we need to draw the border?  
     if (_paletteBorder.GetBorderDraw(PaletteState.Normal) == InheritBool.True)  
     {  
          // (11) Draw the border inside the provided rectangle area  
          renderer.RenderStandardBorder.DrawBorder(renderContext,   
                                                                     ClientRectangle,   
                                                                     _paletteBorder,   
                                                                     VisualOrientation.Top,   
                                                                     PaletteState.Normal);  
     }

As with drawing the background we being with block (10) which tests to ensure we
need to draw the border at all. If we do then we just need to make the call to
the *IRenderer.RenderStandardBorder.DrawBorder* with a set of simple parameters,
as seen in code block (11). The second parameter is the rectangle that specifies
the outside of the border drawing area, the border itself will be drawn to fit
completely within this rectangle.

 

Drawing a Background/Border Pair
================================

In many cases you will be drawing a background and border for the same visual
element. So if you control is drawing a button element in the client area then
you would want to draw the button area background followed by the button area
border. You might think this is achieved by performing the above two sections of
code for the same rectangle area. In practice this is not quite the case because
of a feature with borders.  
  
It is possible for a border to have rounded corners and so we cannot just draw
the background as a rectangle, if we did that then the background would be drawn
outside the rounded corners. In order to prevent this we use a slightly modified
version of the background drawing code presented above.   
  
     // Do we need to draw the background?  
     if (_paletteBack.GetBackDraw(PaletteState.Normal) == InheritBool.True)  
     {  
          // (12) Get the background path to use for clipping the drawing  
          using (GraphicsPath path =
renderer.RenderStandardBorder.GetBackPath(renderContext,  
                                                                                                           ClientRectangle,  
                                                                                                           _paletteBorder,  
                                                                                                           VisualOrientation.Top,  
                                                                                                           PaletteState.Normal))  
          {  
               // Perform drawing of the background clipped to the path  
               \_mementoBack =
renderer.RenderStandardBack.DrawBack(renderContext,  
                                                                                            
ClientRectangle,  
                                                                                            
path,  
                                                                                            
\_paletteBack,  
                                                                                            
VisualOrientation.Top,   
                                                                                            
PaletteState.Normal,  
                                                                                             _mementoBack);  
          }  
     }

If you look at code block (8) from the previous drawing code then you will note
that the clipping path for the background is specified by using a rectangle.
Instead we use block (12) above to create a clipping path that is a description
of the border. This prevents the background being drawn outside of the border.
It uses a call to the *IRenderer.RenderStandardBorder.GetBackPath* to get the
clipping path.

<br>Drawing a Content
=====================

All *Content* consists of providing three values, two text strings and an image.
In order to provide these values to the renderer an interface is used called
*IContentValues*. You can implement this interface in any way that is
appropriate for your usage but in our example we will choose the simplest option
and implement it on the custom control itself. If you choose to do that same
then you first of all need to add it to the class definition in the following
way.

     public class MyUserControl : UserControl, IContentValues  
  
Next the actual interface methods need to be implemented, our examples just
returns some simple fixed values.

     public Image GetImage(PaletteState state)  
     {  
          return null;  
     }

     public Color GetImageTransparentColor(PaletteState state)  
     {  
          return Color.Empty;  
     }

     public string GetLongText()  
     {  
          return "Click me!";  
     }

     public string GetShortText()  
     {  
          return string.Empty;  
     }

Unlike the background and border rendering we need to override the control
layout event *OnLayout*. We do this so that the renderer can calculate
the position and visibility of the content values and cache the results for when
painting later. A control will usually be painted much more often than it is
layed out and so caching the results of the layout event gives better
performance than doing the calculations during every paint cycle.  
  
In order to cache the results of the *OnLayout* we need to add a new field to
the control as follows.  
  
     private IDisposable_mementoContent;

 

The actual *OnLayout* method is very similar to the way that the *OnPaint*
works, recovering the *IRenderer* instance and then creating a context object
that is passed into each of the renderer calls. The following implementation
caches the result of laying out the content.    
  
     protected override void OnLayout(LayoutEventArgs e)  
     {  
          if (_palette != null)  
          {  
               // Get the renderer associated with this palette  
               IRenderer renderer = \_palette.GetRenderer();

               // Create a layout context used to allow the renderer to perform
layout  
               using (ViewLayoutContext viewContext = new
ViewLayoutContext(this, renderer))  
               {  
                    // (13) Cleaup resources by disposing of old memento
instance  
                    if (_memento != null)  
                        \_memento.Dispose();  
  
                    // (14) Ask the renderer to work out how the Content values
will be layed out   
                    // and return a memento object that we cache for use when
performing painting  
                    \_mementoContent =
renderer.RenderStandardContent.LayoutContent(viewContext,   
                                                                                                                
ClientRectangle,   
                                                                                                                
\_paletteContent,   
                                                                                                                
this,   
                                                                                                                
VisualOrientation.Top,   
                                                                                                                
false,   
                                                                                                                
PaletteState.Normal);  
               }  
          }

          base.OnLayout(e);  
     }

 

Block (13) disposes of any existing memento instance to ensure that any
resources that are held by the memento are correctly released.  
  
Block (14) is the actual call to the renderer and parameter four provides the
reference to the *IContentValues* interface that provides the content values. As
the interface is implemented by the custom control in our example the reference
is the *this* variable. As with all the other calls to the renderer you need to
provide the appropriate palette state in place of the *PaletteState.Normal*
constant in the examples.  
  
Finally the actual *OnPaint* code needed to draw the content is presented.  
  
     // Do we need to draw the content?  
     if (_paletteContent.GetContentDraw(PaletteState.Normal) ==
InheritBool.True)  
     {  
          // Draw content using the memento cached from OnLayout  
          renderer.RenderStandardContent.DrawContent(renderContext,   
                                                                         ClientRectangle,   
                                                                         _paletteContent,   
                                                                        
\_memento,   
                                                                         VisualOrientation.Top,   
                                                                         false,   
                                                                        
PaletteState.Normal);  
     }

As always the code checks that the content needs to be drawn all given the
provided palette state.  
  
Using the above information and examples it should be possible to experiment and
draw whatever elements you need in your custom control in order to leverage the
functionality provided in the toolkit as well as remaining faithful to the
global palette settings. You should refer to the *Custom Control using
Renderers* example project for a working example of the renderer code in action.
