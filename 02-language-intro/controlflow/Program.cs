using System;

/**
 * This example shows various options to control the flow of a program in C#.
 */
class ControlFlow
{
    static void Main()
    {
        int i = 5;
        if (i > 10)
        {
            Console.WriteLine("Number was larger");
        }
        else
        {
            Console.WriteLine("Number was smaller");
        }

        string? input; //? for C# 8 - careful null checking
        Console.WriteLine("Please enter your age: ");
        input = Console.ReadLine();
        int a = Convert.ToInt32(input);
        Console.WriteLine("Your age is: {0}", a);

        string? name;
        Console.WriteLine("Please enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Your name is: {0}", name);        
    }
}

