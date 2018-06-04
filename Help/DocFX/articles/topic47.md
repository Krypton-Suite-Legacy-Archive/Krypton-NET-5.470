KryptonManager

 

Use the *KryptonManager* component to modify global settings that affect all the
*Krypton* controls in your application. Note that the global settings affect all
controls and not just those on the same form as the *KryptonManager* instance.

 

**Global Palette** 

Each individual *Krypton* control will by default inherit its display values
from the global palette that is specified by the *KryptonManager*. This makes it
easy to change the global palette and have all *Krypton* controls update their
appearance in one step.

 

*GlobalPaletteMode* is an enumeration that specifies which palette to use as the
global palette. You can either choose one of the built-in palettes such as the
*Professional - Office 2003* or specify use of a custom palette.

*GlobalPalette* should be used when you need to use a *KryptonPalette* instance
instead of one of the built-in palettes. Once you assign a reference to this
property the *GlobalPaletteMode* will automatically be changed to the *Custom*
enumeration value.

 

Note that you are not allowed circular references in the use of palettes. So if
you define the global palette to be a *KryptonPalette* and then try to make the
base palette of the *KryptonPalette* the *Global* value then it will cause an
error. Whenever you alter the global palette or the base palette of a
*KryptonPalette* it will check the inheritance chain to ensure no circular
dependency is created.

**GlobalAllowFormChrome**

When your *Form* derives from the *KryptonForm* base class the caption and
border areas will be custom painted if the associated *Form* palette indicates
it would like custom chrome. For example the *Office 2007* builtin palettes all
request that the form be custom drawn to achieve a consistent look and feel to
that of *Microsoft Office 2007* applications. If you would like to prevent any
of your *KryptonForm* derived windows from having custom chrome then set this
property to *False*. This setting overrides any requirement by a palette or
*KryptonForm* to have custom chrome.

 

**GlobalApplyToolstrips**

In order to ensure your entire application looks consistent the *KryptonManager*
will create and assign a tool strip renderer to your application. Whenever you
change the global palette or the palette has a tool strip related value changed
the tool strip renderer is updated to reflect this. If you prefer to turn off
this feature so that you control the tool strip rendering manually then you just
need to assign *False* to the *GlobalApplyToolstrips* property.

 

**GlobalStrings**

The *KryptonMessageBox* has buttons that use the string values from this
section. If you would like to alter the strings displayed on those buttons then
you can do so by altering the values in this area. If you have set the
*Localization* property on your *Form* to *True* then these values will be
stored on a per-language setting allowing your message box to have different
display strings per language you choose to define.
