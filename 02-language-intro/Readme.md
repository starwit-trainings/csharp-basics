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
* With strings one can do a lot of things - [see docs](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/) for more info
    * Create a string with all escaped characters in doc and observe output
    * Try string formating using curly bracket notation and output an integer within a string
    * Change string "Bob" to "Bobby" using replace function (docs Substrings)
* play with various values for character type - what's the funniest character you can get?
* any idea, how to create to longest possible String?

## 02 - Control Flow
Making decisions is an obvious feature, that a programming language needs. So this example shows you, how to use decisions and loops to structure your software. Langauge features in this example are
* if/else blocks [Hints](https://www.w3schools.com/cs/cs_conditions.php)
* for loop [Hints](https://www.w3schools.com/cs/cs_for_loop.php)
* while loop [Hints](https://www.w3schools.com/cs/cs_while_loop.php)
* switch blocks [Hints](https://www.w3schools.com/cs/cs_switch.php)
* break/continue [Hints](https://www.w3schools.com/cs/cs_break.php)

### How to execute
On the commandline use this to run program:
```shell
    cd 02-controlflow
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program with various inputs
* extend program
    * if statement: 
        * let the user input a number (hint: you have to use `Convert.ToInt32(..)` to get the user input as int)
    * run a for loop as many times as user's age
    * run a while loop as many times as user's age
    * comment politely on user's age
    * check if user's name is in a list of names (choose 3) and give a special output for your choosen names and a generic output for any other name. Implement this task with a switch block
    * C# also offers an [else-if construct](https://www.w3schools.com/cs/cs_conditions_elseif.php). Implement last task with else-if. Which version do like better and why?
* in loops sometimes, execution needs to be skipped or stopped. C# offers [break/continue](https://www.w3schools.com/cs/cs_break.php) statement for this task. 
    * Write a for loop that runs till 100 and breaks, if entered age is reached.
    * Write a while loop that skips when reaching entered age

## 03 - Operators
Calculating results is another important building block, to write software. How to work with operators is thus the topic of this example.

There are more Operators as we cover in this example, if you want to know them all, see official [documentation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/).

### How to execute
On the commandline use this to run program:
```shell
    cd 03-operators
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program with various inputs
* choose two numeric and the two floating point types and create two variables each. Try all arithmetic operators from [here](https://www.w3schools.com/cs/cs_operators.php). 
* try also the == operator for each numeric type combination. Play with various values.
* Consider expression 10 + a/10 - can you control operator precedence?
* create two double variables and set them both to max double value. Now subtract 1 from one of those and use all [comparison operators](https://www.w3schools.com/cs/cs_operators_comparison.php) - can you explain each result?


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
* Run program and observe output
* Look at conversion from double to float - any idea, to explain this behaviour?
* add typ conversions with max/min values for all numeric types in C# and print results
* try to parse a string containing a number into all numeric types in C# and print results
* test two implicit variables for any primitive type in C# and output result


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
* Create four timezones and output dates from utcNow for those timezones.
* Create four DateTimes and add four different work times. Output resulting time.

* There are many options to output format for DateTimes
    * Using [Format](https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings) options - produce at least three different time formats
    * Try all ouput methods from [DateTime documentation](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0)
* Parse dates from string examples, try to create more date strings and parse them.
* add the following code, to list all availabe timezones
    ```c#
        ReadOnlyCollection<TimeZoneInfo> timezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.DisplayName + " " + TimeZoneInfo.ConvertTimeFromUtc(utcNow, timezone));
        }
    ```
    * Observe time zones and try to extract more info from each timezone, see [docs](https://learn.microsoft.com/en-us/dotnet/api/system.timezoneinfo?view=net-8.0)
    * __Bonus Challenge__ use String manipulation methods to extract a numeric value for the time distance to UTC for each timezone.

## 06 - Arrays
Storing more than one value is very helpful for many tasks. This section introduces the most basic datastructure in C# that lets you work with multiple values. Arrays can store all sorts of data and are used everywhere. As they are useful and omnipresent, check [documentation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays) for more info.

### How to execute
On the commandline use this to run program:
```shell
    cd 06-arrays
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program
* create a string array that contains 5 numbers like "10.3" and run through it, parse every value into a double value and add this to a new double array. 
    * **Bonus Challenge**: Generate an array with random numbers. Use [this method](https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0)
* look at the 2-dimensional array - write code, that creates a transposed version of this array (001,010,100).
* Write code, that adds 1 to each element of the original 2D array
* Enhance that code, such that new values are added to a new 2D array
* Now take the two arrays and write code, that compares each element of both arrays. Create output if there are any unequal elements. 
* Use string methods including [split](https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-8.0) to extract values from the data string array. Put id, club name and league name into individual arrays with a proper type. Can you do this with extracting necessary size of new arrays from input data?

## 07 - Methods, Parameters and structuring your code
At this point it has become clear, that software is composed of a lot of source code. Thus in this example, we will learn how to use methods. It is a first tool to break down larger software into smaller, easier to maintaining components.

### How to execute
On the commandline use this to run program:
```shell
    cd 07-methods-and-params
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program and observe output, make sure you understand code
* Change function parameters and observe results
* If you run from CLI, you can provide parameters like so:
    ```shell
    dotnet run param1 param2
    ```
* Change function AFunctionWithParams that its outputs depends on param. Decide how many cases you want to support and if you want to use switch/case or if/else.
* Change function AFunctionWithReturnValue such that it returns the output already written in AFunctionWithParams
* Write a function that takes a string array as parameter and returns a concatenated string of all array elements.
* call that function and use result of ReadData method as input
* write a function, that splits every line of ReadData output into a string array (see last example)
* now write a function, that runs through output of ReadData and returns an array of string arrays with the content of ReadData output.
* Change your program, such that the method from last task is only called, if a parameter _d_ is present.

## 08 - On commenting and documenting your code
Comments and documentation are an essential part of software development. So there are language features, tools and best practices. This example shall give you guidance, when to use comments and how to take advantage of tools in the C# eco-system. See [C# docs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/) for detailed information.

Another important aspect is logging state of your application. Up to this point, we used plain console outputs with no further information. In this example we will use [Microsoft logging](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line).

### How to execute
On the commandline use this to run program:
```shell
    cd 08-documenting-code
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* inspect code and check all comments used
* add proper documentation comments to all methods
* generate docfx as described [here](https://dotnet.github.io/docfx/)
* replace all console outputs by log messages, choose an approriate log level - how do you decide?