/**
 * This example shows how to convert data types in C#.
 */

Console.WriteLine("This example shows you, which options you have, to convert data types in C#");

Console.WriteLine("Converting big numbers to smaller numbers ************************************");
long aBigNumber = long.MaxValue;
int aSmallerNumber = (int) aBigNumber;
Console.WriteLine(aBigNumber + " vs " + aSmallerNumber);

aBigNumber = long.MaxValue/1000;
aSmallerNumber = (int) aBigNumber;
Console.WriteLine(aBigNumber + " vs " + aSmallerNumber);

Console.WriteLine("Converting small numbers to larger numbers ************************************");
aSmallerNumber = int.MaxValue;
aBigNumber = (long) aSmallerNumber;
Console.WriteLine(aBigNumber + " vs " + aSmallerNumber);

aBigNumber = long.MaxValue/1000;
aSmallerNumber = (int) aBigNumber;
Console.WriteLine(aBigNumber + " vs " + aSmallerNumber);

Console.WriteLine("Converting floats ************************************");
double bigFloatingPoint = double.MaxValue;
aBigNumber = (int)bigFloatingPoint;
Console.WriteLine(bigFloatingPoint + " vs " + aBigNumber);

bigFloatingPoint -= double.MaxValue/2;
float smallerFloat = (float) bigFloatingPoint;
Console.WriteLine(bigFloatingPoint + " vs " + smallerFloat);

Console.WriteLine("numbers and strings ************************************");
string numberAsString = "10000";
int number = int.Parse(numberAsString);
Console.WriteLine(number);

numberAsString = "10000.546";
double myDouble = double.Parse(numberAsString);
Console.WriteLine(myDouble);