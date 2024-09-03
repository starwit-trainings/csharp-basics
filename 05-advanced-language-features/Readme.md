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

## Working with files

## Using INI files

## Dealing with CSV files

## Delegates
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates