# Chapter 06 - Real World Examples
C# and the .Net runtime can be used to build a large variety of software types. If you made it to this section, you are already familiar with C# as a programming language. So here is a set of examples that shows you which kind of applications, you can build. Note that this list is by no means complete. 

# Examples

## Windows Forms - Football Manager

### Tasks
* Run program
* Copy entity namespace from earlier projects, load data from CSV files, create button for each data list and display them.

## Windows Presentation Foundation (WPF)
With Windows Forms' serious shortcomings in layout and supporting high resolution displays WPF was developed. It is a combination of XML and C# to separate layout/style from application logic. If you have ever build web application, that may sound familiar. If you want to know more, [Wikipedia](https://en.wikipedia.org/wiki/Windows_Presentation_Foundation) is a good starting point.

### Tasks
* Run program
* Copy entity namespace from earlier projects, load data from CSV files, create button for each data list and display them.

## ASP.Net - Web Applications

### Create a simple WebApp
You can create a webapp easily by using `dotnet new webapp` command. That was already done for the code in the directory `FootballManagerWeb`. You can start the WebApp as usual with `dotnet run` and you will find the url to access the app via browser in the console output. 

You can find a [Quickstart](https://learn.microsoft.com/de-de/aspnet/core/getting-started/?view=aspnetcore-8.0) and more a [detailed description](https://learn.microsoft.com/de-de/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio-code) on microsoft pages.

### How to execute
On the commandline use this to run program:
```shell
    cd FootballManagerWeb
    dotnet run
```
Or use the run button in your IDE.

### Tasks
* Run program and open it in Browser
* Go to directory `Pages` and inspect the existing code. Go to [tutorial](https://learn.microsoft.com/de-de/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio-code) and find out, what the different files are for
* change somthing in file `Pages\Index.cshtml` and see result in browser
* In the top-menu of the app ou can see menu item `Clubs`. Here you can write Clubs to a sqllite in-memory database. See [this tutorial](https://learn.microsoft.com/de-de/aspnet/core/tutorials/razor-pages/model?view=aspnetcore-8.0&tabs=visual-studio-code) and find out, how Clubs are written to database.
* add leage to the app and write it to database similiar to clubs.

For informations about sqllite, see [here](https://jasonwatmore.com/post/2022/09/05/net-6-connect-to-sqlite-database-with-entity-framework-core)

## Maui Apps

for maui get dotnet 8.0.4xx:
* download dotnet from here: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
* extract package:
    ```sh
    mkdir -p $HOME/dotnet && tar zxf dotnet-sdk-8.0.401-linux-x64.tar.gz -C $HOME/dotnet
    export DOTNET_ROOT=$HOME/dotnet
    export PATH=$PATH:$HOME/dotnet
    ```
* see tutorial here: https://techcommunity.microsoft.com/t5/educator-developer-blog/net-maui-on-linux-with-visual-studio-code/ba-p/3982195


