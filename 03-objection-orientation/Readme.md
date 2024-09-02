# Chapter 03 - Object oriented development
Objects and classes are the most powerful concept, to model real world ideas. As C# is an object oriented programming language, this features deserves a lot of attention. This chapter is thus will introduce the general conceptas well as the technical mechanisms provided by C#.

## Concepts
OO is based on a bunch of fundamental concepts. This subsection will introduce them (very) briefly. It is highly recommended, that you consult further literature e.g. [Wikipedia](https://en.wikipedia.org/wiki/Object-oriented_programming).

Modeling data can often be easier using graphic representations. Diagrams used in this chapter were created using [DrawIO](https://www.drawio.com/) and it is highly recommended to make yourself familiar with that tool too - it is handy in many situations.

### Classes and objects
The fundamental concept of every object oriented language is the idea of classes and objects. A class is a description of data and behaviour (== methods). So it wraps functions and data into one structure. Once this is defined, one create as many instances of this class as are necessary. Given the example below, once you have defined which data and functions are necessary to describe a sport club, you can create an object of this class for every real world club, that you want to manage.

### Encapsulation
* Information & methods regarding a topic are stored inside an object
* Expose only those parts of code that are necessary
* Thus hiding all internal implementation parts
* Example: As a user, you don't need to know, how an engine works. Yet with the exposed functions (steering wheel, brakes, ...) you can perfectly use a car.

### Abstraction
* This is one of the most powerful modeling concepts in computer science
* Usually it comes in layers
* Core idea is, that underneath an exposed set of functions (aka API), a specific implementation can be exchanged, without breaking the API using code.
* Most prominent example is ISO/OSI model for networking. TCP can be used, regardless of the underlying network technology.
* This concept goes way beyond object orientation and you should study it whenever you look at successful software projects.
* __Note__ This concept makes software 

### Inheritance
* Reuse code (!)
* add small changes to a shared set of data/functions
* Looking at the car example - every car has (at least) four wheels, a number of seats, a color,... its engine can turned on/off, lights can be turned on/off. So this would be data and functions for a base class and now you can create classes for passenger cars, commercial vehicles, busses, ... Each of which extends or modify the base class.
* Software projects usually have a sophisticated hierachy of classes with inheritence. 
* A set of classes can be packed into a library such, that many development projects, use the same data structures.

### Polmorphism
* In inheritence hierachies classes can not only add, but also modify bevahiour. 
* In the car example, each of the inheriting classes could its own function to model acceleration. So every class has the same functionality, it's implementation can be very different.

## On Modeling
Now it is time, to look at a real word example. Let's imagine, we want to build an app, that manages sport events. The following picture shows an example of several classes and the idea of inheritance. The notation used here is called class diagram and is part of the [unified modeling language](https://en.wikipedia.org/wiki/Unified_Modeling_Language).

![Modeling Example](/imgs/OOD-inheritance-simple.png)

Core idea here is, that a football club __is a__ sports club and thus inherits all attributes. Same goes for sailing clubs or any other kind of sports club, on could think of. All of those will have a name, a founding date and a number of members.

The next diagram shows a bunch of clases and their relations amongst each other. General idea is, that larger data structures can be broken into fitting entities like clubs, players,... and then connect them via relations. So a club for example has a number of players and is playing in a certain league.

![Modeling Example](/imgs/OOD-relations-simple.png)

# Examples
For the following examples we will model data for a football league. Our main domain entities will be league, club, player and game. Leagues represents a football league like the first German football leauge (Bundesliga) and clubs are the football clubs, that play in their respective league. 

The following picture shows a model subset from last subsection, that we are going to implement. It is focussing on football clubs and each of the items in this diagram will end up in a piece of code.

![Implementation Example](/imgs/OOD02.png)

Every entity from the football application domain is represented by a class. As we will deal with many instances for every class e.g. there will 18 clubs for the first German football league. So we need a mechanism to tell those instances apart. For this a unique id is used and as this is necessary for all classes, attributes and logic needed are put in an AbstractEntity class from which all others will inherit.

## 01 - OO concepts
This example introduces a first insight, on how to store data in C# programs. A list of C#'s built-in data can be found [here](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)

### How to execute
On the commandline use this to run program:
```shell
    cd 01-ooconcepts
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program
* Create a class for Leagues, Games and Players
* Make sure all class definitions inherit from AbstracEntity
* override getObjectSize method in every class you wrote
* create a ToString method for every class, that outputs all fields enclosed in curly brackets

## 02 - Working with objects and relations


### Tasks
* create three league/club/player/game objects and fill all fields
* for every class create a list and put your instances into that list
* create (nice) output for all instances content
* set relations