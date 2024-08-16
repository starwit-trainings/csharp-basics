# Setup & Building Apps
This section contains first examples and shall guide you, how to build and run C# apps. All of these example are meant to be run from the command line of your favourite operating system. However you will find equivalent functionalities in most IDEs like Visual Studio or Visual Studio Code.

# Examples

## Hello World
No programming course can be complete without a hello world program. So here it is with C#. It is as short (and un-useful) as it can get. Just run the following commands:
```shell
    cd HelloWorld
    dotnet run 
```

## Publish Example
Runnin software with developer tools or from your IDE may be nice, but productive software needs to shipped. Thus it is necessary to create shippable packages. This example has no actual functionality, but will demonstrate, how you can package your solution.

As usual running the solution. works like this:

```shell
    cd publishexample
    dotnet run 
```

If you want to create a single executable file, use the following command:
```shell
    cd publishexample
    dotnet publish -c Release --self-contained true -p:PublishSingleFile=true
```
The publish command offers a lot of options and you can read more on those in the [dotnet documentation](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-publish)

In this example it also worth looking into csproj file. There a custom target is defined, which will delete some generated files/folders. It serves as an example, how to add custom jobs to .Nets build system and to run them with respect to the operating system.