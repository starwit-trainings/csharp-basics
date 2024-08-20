using System;

/**
 * This example shows various options to control the flow of a program in C#.
 */

// let's make a decision
int i = 5;
if (i > 10)
{
    Console.WriteLine("Number was larger");
}
else
{
    Console.WriteLine("Number was smaller");
}

// let's do things multiple times
for (int k = 0; k < 10; k++)
{
    Console.WriteLine("Running a for loop, iteration: " + k);
}

i = 9;
while(i >= 0) 
{
    Console.WriteLine("Running a while loop " + i);
    i--;
}

i = 5;

switch (i)
{
    case 1:
        Console.WriteLine("Variable was one");
        break;
    case 5:
        Console.WriteLine("Variable was five");
        break;
    default:
        Console.WriteLine("unmatched case");
        break;
}

string? input; //? for C# 8 - careful null checking
Console.WriteLine("Please enter your age: ");
input = Console.ReadLine();
int a = Convert.ToInt32(input); // let's ignore that for the moment - see example 04
Console.WriteLine("Your age is: {0}", a);

string? name;
Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();
Console.WriteLine("Your name is: {0}", name);     
