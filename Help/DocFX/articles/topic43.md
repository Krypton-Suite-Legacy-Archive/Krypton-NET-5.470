KryptonInputBox

The *KryptonInputBox* provides access to a *Krypton* style dialog box that
allows the user to enter a string. It is a replica of the *InputBox* control
that is provided as part of the *Microsoft.VisualBasic* assembly and is
typically used by *VB.NET* developers. By providing a Krypton version of this
dialog it ensures that your whole application has a consistent look and feel
that extends to even the input boxes that appear.

 

**Appearance**

The displayed *KryptonInputBox* derives from the *KryptonForm* base class and so
has the same appearance as other *Krypton* style forms. In order to show the
*Krypton* input box you need to call one of the static methods it exposes called
*Show*. The simplest method takes a single parameter and will show an input box
with the specified prompt text. All the other parameters will be defaulted. Use
one of the other methods if you need greater control window title or default
input string. See Figure 1 for an example of the input box in operation.

 

**String Localization**

The button text will always display in English by default. If you need to
localize the strings to other languages you can do so by placing a
*KryptonManager* component on your main *Form*. Use the properties window and
then expand the *GlobalStrings* property and modify the strings as needed.

   
* *  
*   Figure 1 – Example Appearance*
