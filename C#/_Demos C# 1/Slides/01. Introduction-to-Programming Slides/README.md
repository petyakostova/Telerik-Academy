<!-- section start -->
<!-- attr: {  class:'slide-title', showInPresentation: true, hasScriptWrapper: true } -->
# Introduction to Programming
## Creating and Running Your First C# Program
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic00.png" style="top:42%; left:80%; width:20.28%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true"  showInPresentation="true" src="imgs/pic01.png" style="top:65%; left:65%; width:15.87%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic02.png" style="top:10%; left:2%; width:12.87%; z-index:-1" /> -->
<div class="signature">
  <p class="signature-course">C# Fundamentals</p>
  <p class="signature-initiative">Telerik Software Academy</p>
  <a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</div>


<!-- section start -->
<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# Table of Contents
- [What is Computer Programming?](#/programming)
- [Your First C# Program](#/first)
- [What is .NET Framework?](#/netframework)
- [What is Visual Studio?](#/visualstudio)
- [What is MSDN Library?](#/msdn)

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic05.png" style="top:32.52%; left:65%; width:26.45%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation: true, hasScriptWrapper: true } -->
<!-- # What is Computer Programming? -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic06.png" style="top:55%; left:30%; width:40%; border-radius: 15px" /> -->


<!-- attr: { id:'programming',  showInPresentation: true, hasScriptWrapper: true } -->
# <a id="programming"></a>Define: Computer Programming
- **Computer programming**: creating a sequence of instructions to enable the computer to do something
    - Definition by <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic08.png" style="top:33%; left:33%; width:20%; z-index:-1" />

<!-- attr: {showInPresentation: true, hasScriptWrapper:'False' } -->
# Programming Phases
- **Define** a task/problem **= Specification**
- **Plan** your solution **= Design**
  - Find suitable algorithm to solve it
  - Find suitable data structures to use
- **Write** code **= Implementation**
- **Fix** program error (bugs) **= Testing & Debugging**
- **Make** your customer happy **= Deployment**

<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation: true, hasScriptWrapper: true } -->
<!-- # Your First C# Program -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic09.png" style="top:44.96%; left:30%; width:40%;  border-radius: 15px" /> -->

<!-- attr: {  id:'first', showInPresentation: true, hasScriptWrapper: true } -->
# <a id="first"></a>First Look at C# Language
- Sample C# program:

```cs
using System;

class HelloCSharp
{
    static void Main()
    {
        Console.WriteLine("Hello, C#");
    }
}
```

<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# C# Code – How It Works?

```cs
using System;

class HelloCSharp
{
    static void Main()
    {
        Console.WriteLine("Hello, C#");
    }
}
```

<div class="fragment balloon" style="top:12%; left:31%">Include the standard namespace `System`</div>
<div class="fragment balloon" style="top:23%; left:35%">Define a class called `HelloCSharp`</div>
<div class="fragment balloon" style="top:30%; left:61%">Define the `Main()` method – the program entry point</div>
<div class="fragment balloon" style="top:53%; left:24%;width: 50%; text-align: center;">Print a text on the console by calling the method `WriteLine` of the class `Console`</div>


<!-- attr: {showInPresentation: true, hasScriptWrapper: true, style:'font-size: 0.9em;' } -->
# C# Code Should Be Well Formatted

```cs
using System;

class HelloCSharp
{
    static void Main()
    {
        Console.WriteLine("Hello, C#");
    }
}
```

 <ol style="font-size: 0.9em">
  <li class="fragment">The `{` symbol should be alone on a new line</li>
  <li class="fragment">The block after the `{` symbol should be indented by a **TAB**</li>
  <li class="fragment">The `}` symbol should be under the corresponding `{`</li>
  <li class="fragment">Class names should use **PascalCase** and start with a **CAPITAL** letter</li>
</ol>


<!-- attr: { showInPresentation: true, hasScriptWrapper: true, style:'font-size: 42px; top:0 !important' } -->
# Example of Bad Formatting

- Don't do this!

```cs
         using
System
                         ;

    class         HelloCSharp         {
	    static
void       Main(                  )   {   Console   .
       WriteLine    ("Hello, C#"     )  ;Console.
   WriteLine        (               "Hello again"
                    )                         ;}}
```

<div class="fragment balloon" style="top:63%; left:30%; width:35.22%; text-align: center">Such formatting makes the source code unreadable.</div>


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# What is "C#"?
- A programming language
  - A syntax that allow to give instructions to the computer
- C# features:
  - Cutting edge language
  - Extremely powerful
  - Easy to learn
  - Easy to read and understand
  - Object-oriented

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic11.png" style="top:49.27%; left:74.85%; width:28.21%; z-index:-1" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# What You Need to Program?
- Knowledge of a programming language
  - **C#**, **Javascript**, **C++**, **Java**, **Python**, etc
- Task to solve
- Development environment, compilers, SDK
  - For **C#** - **VisualStudio**, **.NET Framework SDK**
- Set of useful standard classes
  - **Microsoft .NET Framework FCL**
- Help documentation
  - **MSDN Library**

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic12.png" style="top:55%; left:75%; width:23.36%; z-index:-1; border-radius: 15px;" /> -->

<!-- attr: {  class:'slide-section demo', showInPresentation: true, hasScriptWrapper: true } -->
<!-- # Your First C# Program -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/01.%20Introduction-to-Programming/demos/00.HelloCSharp)

<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation: true, hasScriptWrapper: true } -->
<!-- # What is .NET Framework? -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic17.png" style="top:55%; left:35%; width:30%; z-index:-1" /> -->


<!-- attr: { id:'netframework',  showInPresentation: true, hasScriptWrapper: true } -->
# <a id="netframework"></a>What is .NET Framework?
- Environment for execution of .NET programs
- Powerful library of classes
- Programming model
- Common execution engine for many programming languages
  - C#
  - F#
  - Visual Basic .NET
  - Managed C++
  - ... and many others

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic18.png" style="top:54.11%; left:63.62%; width:37.98%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper:'False', style:'font-size: 40px' } -->
# Inside .NET Framework
- Building blocks of .NET Framework

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/dot-net-blocks.png" style="top:25%; left:10%; width:80%; z-index:-1" /> -->

<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# CLR – The Heart of .NET Framework
- Common Language Runtime (CLR)
  - Managed execution environment
    - Executes .NET applications
    - Controls the execution process
  - Automatic memory management (garbage collection)
  - Programming languages integration
  - Multiple versions support for assemblies
  - Integrated type safety and security

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic19.png" style="top:30%; left:80%; width:20%; z-index:-1" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper:'False' } -->
# Framework Class Library
- Framework Class Library (FCL)
  - Provides basic functionality to developers:
    - Console applications
    - WPF and Silverlight rich-media applications
    - Windows Forms GUI applications
    - Web applications (dynamic Web sites)
    - Web services, communication and workflow
    - Server & desktop applications
    - Applications for mobile devices


<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation: true, hasScriptWrapper: true } -->
<!-- # What is Visual Studio?
## Compiling, Running and Debugging C# Programs -->

<!-- attr: { id:'visualstudio',  showInPresentation: true, hasScriptWrapper: true } -->
# <a id="visualstudio"></a>Visual Studio
- Visual Studio is an `I`ntegrated `D`evelopment `E`nvironment (IDE)
- Development tool that helps us to: **&nbsp;**
  - Write code
  - Design user interface
  - Compile code
  - Execute / test / debug applications
  - Browse the help
  - Manage project's files

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic20.png" style="top:63.47%; left:73%; width:23%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# Benefits of Visual Studio
- Single tool for:
  - Writing code in many languages (C#, VB, …)
  - Using different technologies (Web, WPF, …)
  - For different platforms (.NET CF, Silverlight, …)
- Full integration of most development activities (coding, compiling, testing, debugging, deployment, version control, ...)
- Very easy to use!

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic20.png" style="top:63.47%; left:73%; width:23%; z-index:-1; border-radius: 15px;" /> -->



<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
<!-- # Visual Studio – Example -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic23.png" style="top:12.34%; left:13.10%; width:70%; z-index:-1" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# Creating New Console Application
`1.` File &rarr; New &rarr; Project ...

`2.` Choose C# console application

`3.` Choose project directory and name

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic24.png" style="top:55%; left:10%; width:40%; z-index:-1" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
<!-- # Creating New Console Application -->
- Visual Studio creates some source code for you
<div class="fragment balloon" style="top:50%; left:3.53%">Namespace not required</div>
<div class="fragment balloon" style="top:60%; left:35%">Class name should be changed</div>
<div class="fragment balloon" style="top:43.72%; left:48.48%">Some usings are not required</div>

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic25.png" style="top:30%; left:10.56%; width:70%; z-index:-1; border" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# Compiling Source Code
- The process of **compiling** includes:
  - Syntactic checks
  - Type safety checks
  - Translation of the source code to lower level language (MSIL)
  - Creating of executable files (assemblies)
- You can start compilation by
  - Using **Build->Build Solution/Project**
  - Pressing **[F6]** or **[Shift+Ctrl+B]**

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic26.png" style="top:59.38%; left:80%; width:19.85%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# Running Programs
- The process of **running** application includes:
  - Compiling (if project not compiled)
  - Starting the application
- You can run application by:
  - Using **Debug->Start** menu
  - By pressing **[F5]** or **[Ctrl+F5]**
  - _Note_: Not all types of projects are startable!

<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# Debugging The Code
- The process of **debugging** application includes:
  - Spotting an error
  - Finding the lines of code that cause the error
  - Fixing the code
  - Testing to check if the error is gone and no errors are introduced
- Iterative and continuous process


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# Debugging in Visual Studio
- Visual Studio has built-in debugger
- It provides:
  - Breakpoints
  - Ability to trace the code execution
  - Ability to inspect variables at runtime

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic31.png" style="top:50.65%; left:19.43%; width:68.96%; z-index:-1" /> -->



<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation: true, hasScriptWrapper: true } -->
<!-- # Visual Studio  Blank Solution
## Creating a Solution Without Projects -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic36.png" style="top:55%; left:30%; width:40%; z-index:-1" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper:'False' } -->
# What Is a Blank Solution?
- A Visual Studio blank solution
  - Solution with no projects in it
    - Projects to be added later
- What is the point?
  - Not making a project just to give proper name
    - And not working in this project


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
<!-- # VS Blank Solution -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic36.png" style="top:12.34%; left:8.27%; width:90.19%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: { id:'msdn', class:'slide-section', showInPresentation: true, hasScriptWrapper: true } -->
# <a id="msdn"></a>What is MSDN Library?

<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
<!-- # What is MSDN Library? -->
- Complete documentation of all classes and their functionality
  - With descriptions of all methods, properties, events, etc.
  - With code examples
- Related articles
- Library of samples
- Use local copy or the Web version at http://msdn.microsoft.com/

<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic41.png" style="top:45%; left:60.05%; width:35%; z-index:-1" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
<!-- # MSDN Library -->
<!-- <img class="slide-image" showInPresentation="true"  showInPresentation="true" src="imgs/pic42.png" style="top:13.22%; left:6.43%; width:80%; z-index:-1" /> -->


<!-- attr: {showInPresentation: true, hasScriptWrapper: true } -->
# How to Use MSDN Library?
- Offline version (obsolete)
  - Use the table of contents
  - Use the alphabetical index
  - Search for phrase or keyword
  - Filter by technology
  - Browse your favorite articles
- Online version
  - Use the built-in search: [F1]

<!-- attr: { class:'slide-section', clashowInPresentation: true, hasScriptWrapper: true } -->
# Introduction to Programming
## Questions?

<!-- attr: { showInPresentation: true, hasScriptWrapper: true} -->
# Free Training @ Telerik Academy

- Fundamentals of C# Programming Track of Courses
    - [csharpfundamentals.telerik.com](csharpfundamentals.telerik.com)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](https://facebook.com/TelerikAcademy)
  - Telerik Academy Learning System
    - [telerikacademy.com](https://telerikacademy.com)
