# Chapter 04 - Using libraries in C#
Libraries are an essential tool to write software. Checking if there is a library offering fitting solutions should be your first impulse, when adding functionality to your software project. 

A great place to look for existing code is [NuGet](https://www.nuget.org/) which offers a great collection of libraries. Please note, that libs are published under various licenses and you should always check if a particular license fits into your software. Another great thing about the C# build system is, that necessary libraries (dependencies) can have further dependencies. This way the dotnet command assembles all necessary code, to build your software.

First task: Browser NuGet catalogue, select a library that you find interesting and check license/dependencies. 

If you have found a library that fits your need, you can it like so to your current project. The dotnet build system will take care of downloading all necessary artifacts.

```shell
dotnet add package Newtonsoft.Json --version 13.0.3
```

# Examples

## 01 Working with JSON

The Javascript object notation or JSON is a wide-spread data exchange format. Small, human readable and flexible - JSON is not without reason successful. In this example, we will learn how to translate both ways between JSON and C#. For this example we will use [this](https://www.nuget.org/packages/Newtonsoft.Json).

### How to execute
On the commandline use this to run program:
```shell
    cd 01-json
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Open NuGet package site and check license/dependencies.
* Run program
* Open 01-json.csproj and study file content, find reference for JSON library we want to use.
* Copy all other class definitions from last chapter, create arrays for each of them and add three object instances. Try to output those arrays as JSON like the club example.
* Look at the deserialized club array. Output it's content.
* Take serialized output from the three other classes and deserialize them like the club example. Output content of created arrays.
* Serialize/Deserialize a single instance of ClubEntity

## 02 Working with XML

The eXtensible markup language or XML is another data format, that is still widely used. Converting data to XML and reading data from XML is a standard task. In this example we will convert our football classes into XML and read data from XML.

### How to execute
On the commandline use this to run program:
```shell
    cd 02-xml
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program
* Copy all other class definitions from last chapter, create arrays for each of them and add three object instances. Try to output those arrays as XML like the club example.
* Look at the deserialized club array. Output it's content.
* Take serialized output from the three other classes and deserialize them like the club example. Output content of created arrays.
* Serialize/Deserialize a single instance of ClubEntity