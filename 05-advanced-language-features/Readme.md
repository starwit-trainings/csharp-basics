# Chapter 05 - Advanced features of C#
So far we have covered the absolute basics in C# and now it is time, to look into some advanced features. Unlike all earlier chapters, it is up to you, in which order to walk through the examples in this part. It is recomended though to use the order provided here. However if you are interested in a particular topic - examples here have no pre-requisites. 

# Feature Examples

## Exceptions
As a developer you usually need to implement a function. Once that function is working, you need to think about all the things, that can go wrong. As this is a very common pattern, exceptions were invented. 

You already encountered this problem, when reading user input in chapter 2. If you need an integer but a user types in something, that can't be interpreted as a number - what to do? Another example is dealing with files, what if a provided file name does not exist or the file is inaccessible?

The general idea that C# provides is, that you try an operation and if it works, your program can continue as planned. If something goes wrong however, you get feedback, what went wrong and you can write code, that deals with the problem.

### How to execute
On the commandline use this to run program:
```shell
    cd exceptions
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program
* Create file test.txt and observe program behaviour
* Change web address into something existing
* Bonus challenge: Make test.txt inaccessible for your user and run program again

## Unit Tests
Making sure that everything, that worked yesterday, still works today, unit tests are very helpful. So this example is a (very brief) introduction into how to use unit tests in C#. Please see official documentation for [unit tests](https://learn.microsoft.com/en-us/dotnet/core/testing/) for more details. 

### How to execute
On the commandline use this to run program:
```shell
    cd unittests/footballmanager-unittests
    dotnet test
```
Or use the run button in your IDE.

### Tasks
* Run tests and observe results
* Look ad assertions in [unit test](unittests/footballmanager-unittests/FootballService.Tests/UnitTest1.cs) - True vs Equal which one is better? 
* Change expected values and observe output
* Implement [function](unittests/footballmanager-unittests/FootballService/FootballManager.cs) to return a sorted club list and add a unit tests, checking the order of elements.
* Use Intellisense to see more assertion functions.
* Bonus challenge: add sorting functions & unit tests for all FootballManager entities.

## Working with files
Working files needs no introduction - reading & writing from and to files are part of almost every development project. Here you learn, how to read files and write results to files. This example focuses on text files and reading them line by line. As you can imagine, C# offers many additional tools to work with files.

### How to execute
On the commandline use this to run program:
```shell
    cd files
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program
* Add methods to read from the three other CSV files
* Modify write method with checking, if file is empty before writing.
* Bonus challenge: write a method, that parse a line from the club csv and creates a ClubEntity each.

## Using INI files
Though a bit dated, ini files are still in use. Here is an example, how to read values from an ini file.

### How to execute
On the commandline use this to run program:
```shell
    cd inifiles
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program
* output all other values from ini file
* create an additional section with at least two config items and output them

## Dealing with CSV files
Storing data in comma separated value files is a common way to exchange data. This example will show you, how to parse CSV files and turn their content into C# objects.

### How to execute
On the commandline use this to run program:
```shell
    cd csvfiles
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program
* Write a method for each of the other three CSV files and parse them into according lists of C# objects. 
* Bonus challenge: Parse data such, that relations are implemented by C# references/lists.

## Delegates
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates