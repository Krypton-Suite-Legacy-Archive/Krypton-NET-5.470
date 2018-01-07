# Krypton-NET-4.7

## 2018-01-07 pm changes
* Committed Smurf-IV contributions
* Renamed all projects in solution to the '2017' version to reflect Visual Studio 2017
* Retarget all projects in solution to .NET Framework 4.7 from .NET Framework 2.0
* Rebuilt all binaries to include 2018-01-07 changes

## Commit merges by Smurf-IV

## 2018-01-07 CherryPick Merge from ComponentFactory commit [5463f83](https://github.com/ComponentFactory/Krypton/commit/5463f835bcdbfffbafc9002923e0bea831bed211)
* Message content size adjustment in KryptonTaskDialog

## 2018-01-06 Toolkit solution and Examples II changes:
* Remove "redundant delegate constructors" for callbacks
* Fix "OnClick" routing for 
  - ListBox
  - CheckedListBox
  - TextBox
  - TreeView
* Update the test project to see if click on TextBox's work as expected 
* Set some private fields to "readonly"
* Fix AddToWorkspace in KryptonDockingManager

## 2017-10-17 Commits are:
* An update to Component factory's KryptonToolkit to support the .NET 4.7 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.7 Target framework
* Add designer dll to test apps to allow visual design and testing without GAC'ing

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

## 2017-11-05 Commits:
* Pre-compiled binaries for use in projects


## 2017-11-12 am Toolkit solution changes:
* Change Get Set functions to be inlined
* Merge Sequential Checks
* Clarify precedence with brackets

## 2017-11-12 pm Toolkit solution changes:
* Work out why clipping is the default for "DrawText" 
  - Applies to buttons, lLabels, Form Titles
  - Create test project - has theme selection, for type testing
* Remove Severity Code Description Project File Line Suppression State Warning CS0618 'SecurityAction.RequestMinimum' is obsolete: 'Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.' Basic Events 2015 [Source Path]\Krypton-NET-4.7\Source\Krypton Navigator Examples\Basic Events\Properties\AssemblyInfo.cs 35 Active