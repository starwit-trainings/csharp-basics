/**
 * This example shows the role and usage of arrays in C#.
 */

Console.WriteLine("How to use arrays in C#");

Console.WriteLine("String arrays **********************************");
string[] myStrings = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

Console.WriteLine("Using foreach on array");
foreach (var s in myStrings) {
    Console.Write(s + " ");
}

Console.WriteLine("\nUsing for on array");
for (int i = 0; i< myStrings.Length; i++)
{
    Console.Write(myStrings[i] + " ");
}
Console.WriteLine("\nReverse order");
Array.Reverse(myStrings);
foreach (var s in myStrings) {
    Console.Write(s + " ");
}

Console.WriteLine("\nLet's try an empty array");
string[] emptyArray = new string[10];
foreach (var s in emptyArray) {
    Console.Write(s + " ");
}

Console.WriteLine("\nIntegers arrays **********************************");
int[] numberArray = new int[10];
for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = (int)Math.Pow(2,i);
    Console.Write(numberArray[i] + " ");
}

Console.WriteLine("\nAssigning & accessing values");
emptyArray[4] = "Hello World";
string value = emptyArray[4];

Console.WriteLine("Two dimensional arrays **********************************");
int[,] twoDArray = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
Console.WriteLine("2D Array size " + twoDArray.Length);
for (int i = 0; i< twoDArray.GetLength(0); i++) 
{
    for (int k = 0; k < twoDArray.GetLength(1); k++)
    {
        Console.Write(twoDArray[i,k]);
    }
    Console.WriteLine();
}

string[] data = ["1;FC Bayern Muenchen;1",
                "2;VfL Wolfsburg;1",
                "3;Borussia Moenchengladbach;1",
                "4;Bayer Leverkusen;1"];

foreach (var line in data) {
    Console.WriteLine(line);
}