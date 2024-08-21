
Console.WriteLine("This project demonstrate, what kind of simple data types one can store with C#");
Console.WriteLine("Numbers *****************************");

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

Console.WriteLine("Strings *****************************");
string name = "Bob";
string name2 = "Alice";
Console.WriteLine("Some strings: " + name + " and " + name2);
// find first occurance of character/string
Console.WriteLine(name.IndexOf('o'));
// first substring 
Console.WriteLine(name.Substring(0,2)); // using methods
Console.WriteLine(name[0..2]); // using array notation

string escapedString ="String with special characters \"";
Console.WriteLine(escapedString);

Console.WriteLine("Characters *****************************");
char aCharacter = name[0];
Console.WriteLine("Single characters are also possible " + aCharacter);
Console.WriteLine("Let's check char values:");
aCharacter = char.MaxValue;
Console.WriteLine(aCharacter);
aCharacter = '\u0AFF';
Console.WriteLine(aCharacter);

Console.WriteLine("Misc *****************************");
bool isBoolean = true;
Console.WriteLine("Let's try boolean values " + isBoolean);
isBoolean = false;
Console.WriteLine("Let's change boolean values " + isBoolean);

Console.WriteLine("constants *****************************");
const double growthRate = 0.07;
Console.WriteLine("Constants are simple to use: " + growthRate);

Console.WriteLine("Play with UTF *****************************");
Console.OutputEncoding = System.Text.Encoding.Unicode;

char character = '\u0305';
Console.WriteLine(character);

/* for(int i = 0; i < char.MaxValue/2; i++) {
    char tmp = (char)i;
    System.Console.WriteLine(tmp);
} */