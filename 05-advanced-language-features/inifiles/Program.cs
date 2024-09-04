using System.ComponentModel;
using Microsoft.Extensions.Configuration.Ini;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace IniExample;

public class IniExample
{
    readonly ILogger logger;

    public static void Main(string[] args)
    {
        var f = new IniExample();
    }    


    public IniExample()
    {
        Console.WriteLine("Program started");
        logger = SetupLogging();
        logger.LogInformation("Started Program");
        string iniPath = "test.ini";
        PhysicalFileProvider fProvider = new PhysicalFileProvider(Path.GetFullPath("."));
        IniConfigurationSource iniConfig = new IniConfigurationSource { Path = iniPath, Optional = true, FileProvider = fProvider };
        IniConfigurationProvider iniProvider = new IniConfigurationProvider(iniConfig);
        iniProvider.Load();

        iniProvider.TryGet("global:key1", out string? key1);
        logger.LogInformation("Value of key1 {}",key1);
    }


    private static ILogger SetupLogging()
    {
        var factory = LoggerFactory.Create(builder => builder
                                .AddSimpleConsole((options =>
                                {
                                    options.IncludeScopes = true;
                                    options.SingleLine = true;
                                    options.TimestampFormat = "HH:mm:ss.fff ";
                                }))
                                .AddDebug()
                                .SetMinimumLevel(LogLevel.Debug));
        return factory.CreateLogger("Program");
    }
}
