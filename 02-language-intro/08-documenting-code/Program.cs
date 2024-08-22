using Microsoft.Extensions.Logging;
using System.Text.Json;

/// <summary>
/// This class shall provide examples, how to use API documentation in C# and how to use logging for better output
/// </summary>
public class DocsAndLogging 
{
    static ILogger logger;

    static void Main(String[] args) 
    {
        SetupLogging();
        AFunction();
        AFunctionWithParams("Hello World!");
        string functionResult = AFunctionWithReturnValue("test");
        if(functionResult.Contains("Func"))
        {
            Console.WriteLine("Function delivered expected result");
        }

        Console.WriteLine(AFunctionWithReturnValue("test"));
        Console.WriteLine(RecuringFunction("GNU is not Unix", 10));

        OutputCLIParams(args);
        
        logger.LogInformation("Hello World! Logging is {Description}.", "fun");

        LogSomeMessages();
    }

    static void SetupLogging() {
        var factory = LoggerFactory.Create(builder => builder
                                .AddSimpleConsole((options =>
                                {
                                    options.IncludeScopes = true;
                                    options.SingleLine = true;
                                    options.TimestampFormat = "HH:mm:ss.fff ";                                   
                                }))
                                .AddDebug()
                                .SetMinimumLevel(LogLevel.Debug));
        logger = factory.CreateLogger("Program");        
    }

    static void AFunction()
    {
        Console.WriteLine("AFunction was called");
    }

    static void AFunctionWithParams(string param)
    {
        Console.WriteLine("FunctionWithParams was called " + param);
    }

    static string AFunctionWithReturnValue(string param)
    {
        Console.WriteLine("FunctionWithParams was called " + param);
        return "Function " + param;
    }

    static string RecuringFunction(string param, int stop)
    {
        if(stop > 0) 
        {
            return param.Replace("GNU", RecuringFunction(param, stop - 1));
        } else 
        {
            return param;
        }
    }

    static string[] ReadData()
    {
        return ["1;FC Bayern Muenchen;1",
                "2;VfL Wolfsburg;1",
                "3;Borussia Moenchengladbach;1",
                "4;Bayer Leverkusen;1",
                "5;FC Augsburg;1",
                "6;FC Schalke 04;1",
                "7;Borussia Dortmund;1",
                "8;1899 Hoffenheim;1"];
    }

    /// <summary>
    /// Displays parameters handed over in string array.
    /// </summary>
    /// <param name="args">String array holding parameters</param>
    private static void OutputCLIParams(string[] args)
    {
        Console.WriteLine("Listing all provided parameters");
        foreach (var p in args)
        {
            Console.WriteLine(p);
        }
    }

    /// <summary>
    /// Outputs some log messages.
    /// </summary>
    static void LogSomeMessages() 
    {
        logger.LogDebug("A debug messages");
        logger.Log(LogLevel.Information,"An info messages");
    }       
}