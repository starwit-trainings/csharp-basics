using System.Text;
using Microsoft.Extensions.Logging;

namespace FileExample;

public class FileExample
{
    readonly ILogger logger;

    string content = "";

    public static void Main(string[] args)
    {
        Console.WriteLine("Program started");
        var f = new FileExample();
        f.LoadDataFromFile();
        f.WriteToFile();
        f.DirectoryAndFiles();
    }

    public FileExample()
    {
        logger = SetupLogging();
        logger.LogInformation("Started Program");
    }

    public void LoadDataFromFile()
    {
        // figure out, where am I running
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        logger.LogInformation("my execution directory {dir}", directory);
        string path = "..\\..\\..\\" + "data" + Path.DirectorySeparatorChar + "bundesliga_clubs.csv";

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

    private void DirectoryAndFiles()
    {
        string[] files = Directory.GetFiles(".");
        foreach (var fileEntry in files)
        {
            logger.LogInformation("{}", fileEntry);
        }
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
