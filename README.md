# Escapist

Escape command line arguments in .NET.

<h1 align="center">
  <br>
  <img width="300" src="https://raw.githubusercontent.com/narkhedegs/Escapist/master/escapist.png">
  <br>
  <br>
</h1>

### Purpose

Escaping command line arguments is fairly complex. Escapist encapsulates this complexity. 

### Requirements

- .NET 4.5 and above

# Installation

Escapist is available at [Nuget](https://www.nuget.org/packages/Escapist/) and can be installed as a package using VisualStudio NuGet package manager or via the NuGet command line:
> Install-Package Escapist

# Usage

```cs
using Narkhedegs;
```
```cs
var escapist = new Escapist();

var arguments = new [] { " ", "hello", @"\hello\12\3\", @"hello world" };

var escapedArguments = escapist.Escape(arguments);
// "" "", hello, \hello\12\3\, "hello world"
```

# To Do

 - Implement escape strategy for mac operating system.
 - Implement escape strategy for unix operating system.

# License

MIT © [narkhedegs](https://github.com/narkhedegs)