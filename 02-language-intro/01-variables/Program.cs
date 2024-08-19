
Console.WriteLine("This project demonstrate, what kind of simple data types one can store with C#");
Console.WriteLine("Let's start with numbers");

int anInteger = 25;
Console.WriteLine("Integer type: " + anInteger);

anInteger = int.MaxValue;
Console.WriteLine("Playing with max values: " + anInteger + " vs " + (anInteger + 1));

byte unsignedByte = 255; 
sbyte signedByte = -127;
Console.WriteLine("Byte types: " + unsignedByte + " " + signedByte);

Console.WriteLine("Exploring signed numeric values");
unsignedByte = byte.MinValue;
Console.WriteLine(byte.MinValue);
// what happens, if we try to subtract from that value?

Console.WriteLine("Now to floating point values");
double myDouble = 1.75;
float myFloat = 105.346F;
Console.WriteLine("Floating point types: " + myDouble + " " + myFloat);

myDouble = double.MaxValue;
Console.WriteLine("Max value for double: " + myDouble + " vs " + (myDouble + 1));

// text
string name = "Bob";
string name2 = "Alice";
Console.WriteLine("Some strings: " + name + " and " + name2);

char aCharacter = name[0];
Console.WriteLine("Single characters are also possible " + aCharacter);
Console.WriteLine("Let's check char values:");
aCharacter = char.MaxValue;
Console.WriteLine(aCharacter);
aCharacter = '\u0AFF';
Console.WriteLine(aCharacter);

// misc
bool isBoolean = true;
Console.WriteLine("Let's try boolean values " + isBoolean);
isBoolean = false;
Console.WriteLine("Let's change boolean values " + isBoolean);