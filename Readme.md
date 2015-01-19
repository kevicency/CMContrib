# CMContrib
Extensions for the [Caliburn.Micro](http://caliburnmicro.codeplex.com/) MVVM Framework.

## Setup
After cloning the repository, run the *update_packages.ps1* PowerShell-Script in the root folder to get all required NuGet packages.

## Nuget Package
The CMContrib NuGet package is available at the NuGet gallery under the name [Caliburn.Micro-Contrib](http://nuget.org/packages/Caliburn.Micro-Contrib)

## Features

### MVVM Dialogs
Easy way to show dialogs to the user. There are four predefined Dialogs

- Information
- Warning
- Question
- Error
 
For more Information see [Blog post](http://kmees.github.com/blog/2011/06/16/mvvm-dialogs-with-caliburn-dot-micro/).

### IResult Implementation

####SL & WPF:

- *BusyResult* - Locates an implementation of IBusyIndicator by searching the Visual Tree or by injecting it and activates/deactivates it.
- *DialogResult* - Creates a modal DialogWindow for a Dialog, shows it to the user and stroes the response in a Property. Also enables you to automatically cancel the result for a specific answer.
- *OpenChildResult* - Activate a ViewModel in a specific Conductor
- *DelegateResult* - Wraps an arbitrary Action in a Result.

####WPF only:

- *SaveFileResult* - Result wrapper for a SaveFileDialog with fluent configuration
- *OpenFileResult* - Result wrapper for an OpenFileDialog with fluent configuration
- *BrowseFolderResult* - Result wrapper for a BrowseFolderDialog with fluent configuration

### IResult Extensions
CMContrib provides several chainable Extension Methods for IResult

- *Rescue&lt;TException&gt;()* - Decorates the result with an error handler which is executed when an error occurs.
- *WhenChancelled()* - Decorates the result with an handler which is executed when the result is cancelled.
- *AsCoroutine()* - Returns an IEnumerable&lt;IResult&gt; which yields the IResult.
- *OnWorkerThread()* - Executes the Result on a dedicated worker thread and activates the given IBusyIndactor if a message is given.

### Filter
Filters are part of the full Caliburn framework. They are quite useful because they enable AOP for coroutine. Some of them are re-implemented here as Attributes

- *Rescue* - Decorates the coroutine with an error handler which is executed when an error occurs during execution
- *OnWorkerThread* - Delegates the execution of the coroutine to a background thread and activates the IBusyIndicator if a message is given

### Syntax Extensions

- *XamlBinding* - Parses Xaml Bindings ({Binding ...}) in ActionMessages, i.e Message.Attach="DoSomething({Binding Text, ElementName=UserInput})"
- *SpecialValueProperty* - Parses Properties of Special Values in ActionMessages, i.e. Message.Attach="DoSomething($eventargs.Foo)"

### Design Time Support
CMContrib allows you to enable Caliburn's auto binding feature during design time with an Attached Property


## Examples
For every Feature there exists a sample in the Demo projects (SL & WPF).
The Silverlight Demo is also available online [here](http://kmees.github.com/projects/cmcontrib.html)
