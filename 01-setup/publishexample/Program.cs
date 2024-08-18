using System.Runtime.InteropServices;


Console.WriteLine("This application is running as a standalone package. Now let's try to find out, which operating system, we are running on.");
var windows = OSPlatform.Windows;
var linux = OSPlatform.Linux;
var macos = OSPlatform.OSX;
var bsd = OSPlatform.FreeBSD;

if(RuntimeInformation.IsOSPlatform(windows)) 
{
    Console.WriteLine("I am running on Windows");
}

if(RuntimeInformation.IsOSPlatform(linux)) 
{
    Console.WriteLine("I am running on Linux");
}

if(RuntimeInformation.IsOSPlatform(macos)) 
{
    Console.WriteLine("I am running on MacOS");
}

if(RuntimeInformation.IsOSPlatform(bsd)) 
{
    Console.WriteLine("I am running on Free BSD");
}