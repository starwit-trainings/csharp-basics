using System;

/**
 * This example shows the role and usage of operators in C#.
 */

Console.WriteLine("This example shows you, how to use operators in C#");

// let's get again some user data
string? input; //? for C# 8 - careful null checking
Console.WriteLine("Please enter your age: ");
input = Console.ReadLine();
int a = Convert.ToInt32(input); // let's ignore that for the moment - see example 04
Console.WriteLine("Your age is: {0}", a);


Console.WriteLine(a+10);
Console.WriteLine(a-10);
Console.WriteLine(a/10);
Console.WriteLine(10 + a/10);

Console.WriteLine("++a  : {0}", ++a);
Console.WriteLine("a  : {0}", a);
Console.WriteLine("a++  : {0}", a++);
Console.WriteLine("a  : {0}", a);
