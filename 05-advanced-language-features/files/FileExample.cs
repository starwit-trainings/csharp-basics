using System.Text;
using Microsoft.Extensions.Logging;

namespace FileExample;

public class FileExample
{
    readonly ILogger logger;

    string content = "";

    public static void Main(string[] args)
    {
        var f = new FileExample();
        f.LoadDataFromFile();
        f.WriteToFile();
    }    


    public FileExample()
    {
        logger = SetupLogging();
        logger.LogInformation("Started Program");
    }

    public void LoadDataFromFile()
    {
        Console.WriteLine("Program started");
        string path = @"data" + Path.DirectorySeparatorChar + "bundesliga_clubs.csv";

        try
        {
            IEnumerable<string> lines = File.ReadLines(path);
            content = string.Join(Environment.NewLine, lines);
            logger.LogDebug(content);

            logger.LogDebug("finished reading file");
        } catch (FileNotFoundException ex)
        {
            logger.LogError("File not found. Details: {ex}", ex.Message);
        }        
    }

    public void WriteToFile()
    {
        string outputPath = "output.csv";
        
        StreamWriter outputFile = new StreamWriter(outputPath);
        outputFile.Write(content);
        outputFile.Flush();
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
