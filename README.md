# Krypton-NET-4.7

## 2017-10-17 Commits are:
* An update to Component factory's KryptonToolkit to support the .NET 4.7 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.7 Target framework
* Add designer dll to test apps to allow visual design and testing without GAC'ing
* [end]

## 2017-11-04 Toolkit solution only:
* Add braces to if statements
* Use explicit types instead of "vars"
* Object initialization can be simplified
* Delegate invocation can be simplified.
* Use pattern matching 
  - Adjust some logic to test bool before cast
  - Use of switch if necessary
* Variable declaration can be inlined
* Null check can be simplified
  - null-propogating code
* Local Variable can be const (And rename to upper case to follow the rest of the codebase.)
* ﻿Join declaration and assignment


## 2017-11-12 am Toolkit solution changes:
* Change Get Set functions to be inlined
* Merge Sequential Checks
* Clarify precedence with brackets
* [end]

## 2017-11-12 pm Toolkit solution changes:
* Work out why clipping is the default for "DrawText" 
  - Applies to buttons, lLabels, Form Titles
  - Create test project - has theme selection, for type testing
* Remove Severity	Code	Description	Project	File	Line	Suppression State


