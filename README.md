# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  The `bug.cs` file shows the incorrect code, while `bugSolution.cs` provides a corrected version.

## Problem

In C#, if you access a class property before assigning a value to it, the property will contain its default value (0 for integers, null for reference types, etc.). This may lead to unexpected results or runtime exceptions depending on the context. 

## Solution

Always initialize properties either in the constructor or before accessing them in methods.