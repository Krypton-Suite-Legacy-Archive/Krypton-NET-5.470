Using IPalette<br><br>Monitoring the global palette
===================================================

By default the *Krypton* controls use the global palette that is specified in
the *KryptonManager* component. In order to ensure your own custom control is
consistent with the rest of the *Krypton* controls you need to also make use the
global palette setting. The following steps will take you through the process of
adding this support.  
  
  
**1) Setting up**  
  
We need to begin by adding a private field to the custom control class that
caches the current global palette setting.

     private IPalette \_palette;  
  
Next we need to modify the constructor by adding the 4 blocks of code as shown
below.  
  
     public MyUserControl()  
     {  
           // (1) To remove flicker we use double buffering for drawing  
           SetStyle(  
                 ControlStyles.AllPaintingInWmPaint \|  
                 ControlStyles.OptimizedDoubleBuffer \|  
                 ControlStyles.ResizeRedraw, true);

           InitializeComponent();

           // (2) Cache the current global palette setting  
           \_palette = KryptonManager.CurrentGlobalPalette;

           // (3) Hook into palette events  
           if (_palette != null)  
              \_palette.PalettePaint += new
EventHandler\<PaletteLayoutEventArgs\>(OnPalettePaint);

           // (4) We want to be notified whenever the global palette changes  
           KryptonManager.GlobalPaletteChanged += new
EventHandler(OnGlobalPaletteChanged);  
     }

 

The first block of code, with (1) in the comment, is used to reduce the flicker
that occurs when re drawing a control.  Setting the *AllPaintingInWmPaint* and
*OptimizedDoubleBuffer* control styles will ensure that all drawing takes place
in an off screen buffer before being bit blitted to the screen.
The *ResizeRedraw* control style is set so that whenever the size of the
control changes the control is automatically invalidated, otherwise you need to
manually override the *OnResize* method and request the invalidate in code.

The second block of code, marked (2), calls a static property on the
*KryptonManager* component in order to recover the current global *IPalette*
interface. Using this property ensures we always get back an *IPalette* without
needing to worry if a built in palette or custom palette has been specified. The
result of the call is cached in our private field \_palette for use when
painting or processing related events.

Now that we have the *IPalette* we use code block (3) to hook into the
*PalettePaint* event that is fired by the palette whenever a palette setting
changes that requires a repaint. This can happen with the built in palettes when
the user alters the display settings or at any time for custom palettes. We will
implement the trivial event handler for this in the section step.  
  
Finally we need block (4) to hook into a static event exposed by the
*KryptonManager* called *GlobalPaletteChanged*. As the name suggest this is
fired whenever the global palette changes. When this happens we need our event
handler to cache the new palette. Step 2 below will implement the actual event
handlers that we just hooked into.

**2) Responding to changes**  
  
Our event handler for code block (3) is trivial, when notified about a change in
the palette settings we just request the control be painted.

     private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)  
     {  
           Invalidate();  
     }

 

Handling a change in global palette requires a few steps. Code block (5) is used
to reverse block (3) from above. Then we update, at block (6), the internal
field for later use. Code (7) establishes a hook into the *PalettePaint* event
of the new palette and finally at (8) we request the control be re painted to
show the change in appearance.

     private void OnGlobalPaletteChanged(object sender, EventArgs e)  
     {  
              // (5) Unhook events from old palette  
           if (_palette != null)  
              _palette.PalettePaint -= new
EventHandler\<PaletteLayoutEventArgs\>(OnPalettePaint);

           // (6) Cache the new IPalette that is the global palette  
           _palette = KryptonManager.CurrentGlobalPalette;  
  
           // (7) Hook into events for the new palette  
           if (_palette != null)  
              _palette.PalettePaint += new
EventHandler\<PaletteLayoutEventArgs\>(OnPalettePaint);

           // (8) Change of palette means we should repaint to show any changes  
           Invalidate();  
     }  
  
  
**3) Tearing down**  
  
To finish the palette monitoring we need to override the *Dispose* method and
unhook our outstanding events. This is because the events exist on static
instances and so our control instance will not be garbage collected until the
static objects themselves are no longer required. In the case of the
*KryptonManager* this will be never and so our custom control instances will
never be garbage collected if we do not unhook the events.  
  
Code block (10) below is used to unhook from the cached palette instance and
block (11) un hooks from the KryptonManager static event.

     protected override void Dispose(bool disposing)  
     {  
           if (disposing)  
           {  
                // (10) Unhook from the palette events  
                if (_palette != null)  
                {  
                    \_palette.PalettePaint -= new
EventHandler\<PaletteLayoutEventArgs\>(OnPalettePaint);  
                    \_palette = null;  
                }

                // (11) Unhook from the static events, otherwise we cannot be
garbage collected  
                KryptonManager.GlobalPaletteChanged -= new
EventHandler(OnGlobalPaletteChanged);  
           }

           base.Dispose(disposing);  
     }

<br>Recovering palette details
==============================

Now that we have a reference to the palette we are going to use we can actually
implement the painting method of the custom control. The actual use of the
*IPalette* itself is very simple as can be seen in the following example.

     protected override void OnPaint(PaintEventArgs e)  
     {  
           if (_palette != null)  
           {  
                // (12) Calculate the palette state to use in calls to IPalette  
                PaletteState state = Enabled ? PaletteState.Normal :
PaletteState.Disabled;

                // (13) Get the background, border and text colors along with
the text font  
                Color backColor =
\_palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, state);  
                Color borderColor =
\_palette.GetBorderColor1(PaletteBorderStyle.ButtonStandalone, state);  
                Color textColor =
\_palette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone,
state);  
                Font textFont =
\_palette.GetContentShortTextFont(PaletteContentStyle.ButtonStandalone, state);

                // Fill the entire background of the control  
                using (SolidBrush backBrush = new SolidBrush(backColor))  
                   e.Graphics.FillRectangle(backBrush, e.ClipRectangle);

                // Draw a single pixel border around the control edge  
                using (Pen borderPen = new Pen(borderColor))  
                   e.Graphics.DrawPath(borderPen, path);

                // Draw control Text at a fixed position  
                using (SolidBrush textBrush = new SolidBrush(textColor))  
                   e.Graphics.DrawString("Click me!", textFont, textBrush, Width
/ 2, Height / 2);  
           }

           base.OnPaint(e);  
     }  
  
Each call to the *IPalette* in order to recover a color, font or other metric
must provide a *PaletteState* enumeration value. This informs the palette of the
appropriate value to return relative to the supplied state. Our control is only
going to provide one of the two basic values, either *PaletteState.Normal* or
*PaletteState.Disabled*. Code block (12) is used to determine which of these to
use.  
  
Block (13) is where we actually recover metrics from the palette. In this case
we want the background color, border color, text color and text font in the
style of a *ButtonStandalone*. You would of course change the provided style
values to whatever is appropriate for your own circumstances. Note that in this
simple example we are only recovering the first color and then using those
colors in the subsequent drawing code. This will result in always drawing solid
colors and will not provide the gradient effect you are familiar with elsewhere
in *Krypton* controls.

By following the steps outlined here you should now be in a position to recover
whatever values you require from the global palette and use them in your custom
drawing code. You are recommended to look at the source code for the *Custom
Control using Palettes* example project that is provided with the library. The
sample shows a slightly more extensive demonstration.
