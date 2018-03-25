Custom Control
==============

When writing your own custom controls that are working alongside the *Krypton*
controls you may want to ensure that the look and feel of your custom control
matches that of the *Krypton* components. There are two levels of integration
that you can aim for. The first is to use the same palette of colors, font,
widths and other metrics when drawing and sizing your custom control. This is
the purpose of the [Using IPalette](topic135.md) article. Recovering these
metrics is actually very simple and you can examine the *Custom Control using
Palettes* sample project to see the principle in action.

Alternatively you might want to leverage the same rendering code that the
*Krypton Toolkit* controls use. In this case follow the [Using
IRenderer](topic136.md) article to understand how to render background, border
and content elements within your custom control client area. Although a little
more complicated this technique has the advantage of performing the hard work
for you. You can use the renderer to draw vertical orientated text and elements
with tiled images without the need to write the actual drawing code yourself.
