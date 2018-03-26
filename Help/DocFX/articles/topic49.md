KryptonMessageBox

The *KryptonMessageBox* provides access to a *Krypton* style message box that
displays a modal dialog with text, buttons and symbols that inform and instruct
the user. This ensures that your whole application has a consistent look and
feel that extends to even the message boxes that appear.

 

**Appearance**

The displayed *KryptonMessageBox* derives from the *KryptonForm* base class and
so has the same appearance as other *Krypton* style forms. In order to show the
*Krypton* message box you need to call one of the many static methods it exposes
called *Show*. The simplest method takes a single parameter and will show a
message box with the specified message content. All the other parameters will be
defaulted. Use one of the other methods if you need greater control over the
buttons, symbols etc. See Figure 1 for an example of the message box in
operation.

 

**String Localization**

The button text will always display in English by default. If you need to
localize the strings to other languages you can do so by placing a
*KryptonManager* component on your main *Form*. Use the properties window and
then expand the *GlobalStrings* property and modify the strings as needed.

   
* *  
*   Figure 1 – Example Appearance*
