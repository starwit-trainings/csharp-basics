# Chapter 02 - C# Language introduction
Learning a programming language is in some aspects similar to learning a foreign language. One need grammar and a minimal list of words, to express anything useful. So this chapter will teach you the basic syntax of C#. Each concept is introduced by a separate example. It is recommended, to open each example in your favourite IDE (e.g. Visual Studio or VSCode).

# Examples
All examples in this chapter are command line programs. So there is no graphical output and focus is on programatic concepts. 

## 01 - Variables and Data, constants
This example introduces a first insight, on how to store data in C# programs. A list of C#'s built-in data can be found [here](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)

### How to execute
On the commandline use this to run program:
```shell
    cd 01-variables
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program
* for each of the numeric values, get the max and min value and print them out 
* now add one to each max value and print the result, subtract one for the min value and print result
* some numeric types are signed - what happens, if you try to subtract one from the min value? Why is this working when using Console.WriteLine
* Observe floating values when adding to max value - any idea, what happens here?
* play with various values for character type - what's the funniest character you can get?
* any idea, how to create to longest possible String?

## 02 - Control Flow
Making decisions is an obvious feature, that a programming language needs. So this example shows you, how to use decisions and loops to structure your software.

### How to execute
On the commandline use this to run program:
```shell
    cd 02-controlflow
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program

## 03 - Operators
Calculating results is another important building block, to write software. How to work with operators is thus the topic of this example.

### How to execute
On the commandline use this to run program:
```shell
    cd 03-operators
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program

## 04 - On type conversion
As C# is a statically typed language, dealing with converting types, is a necessity. For example storing text based user input into to proper variables and converting the various primitive types into each other are common tasks. Another helpful concept are implicit types - in many cases, the C# compiler can infer which type to use.

### How to execute
On the commandline use this to run program:
```shell
    cd 04-type-conversions
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program

## 05 - Working with date and time
It is obvious, that dealing with date and time data is also an important task. If you know the right tools, it is however not a difficult task. This example shows you how to work with date and time data.

### How to execute
On the commandline use this to run program:
```shell
    cd 05-date-and-time
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program

## 06 - Methods, Parameters and structuring your code
At this point it has become clear, that software is composed of a lot of source code. Thus in this example, we will learn how to use methods. It is a first tool to break down larger software into smaller, easier to maintaining components.

### How to execute
On the commandline use this to run program:
```shell
    cd 06-methods-and-params
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program

## 07 - On commenting and documenting your code
Comments and documentation are an essential part of software development. So there are language features, tools and best practices. This example shall give you guidance, when to use comments and how to take advantage of tools in the C# eco-system. 

### How to execute
On the commandline use this to run program:
```shell
    cd 07-documenting-code
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* inspect code and check all comments used