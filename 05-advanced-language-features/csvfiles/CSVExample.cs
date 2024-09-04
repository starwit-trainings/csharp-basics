using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using entities;

namespace CSVExample;

public class CSVExample
{
    readonly ILogger logger;

    List<ClubEntity> clubs = new List<ClubEntity>();

    public static void Main(string[] args)
    {
        var f = new CSVExample();
    }    

    public CSVExample()
    {
        Console.WriteLine("Program started");
        logger = SetupLogging();
        logger.LogInformation("Started Program");

        string path = @"data" + Path.DirectorySeparatorChar + "bundesliga_clubs.csv";

        using (TextFieldParser csvParser = new TextFieldParser(path))
        {
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { ";" });
            csvParser.HasFieldsEnclosedInQuotes = true;

            // Skip header
            csvParser.ReadLine();

            while (!csvParser.EndOfData)
            {
                string[] fields = csvParser.ReadFields();
                int id = Convert.ToInt32(fields[0]);
                string name = fields[1];
                int leagueId = Convert.ToInt32(fields[2]);
                ClubEntity c = new ClubEntity(id, name, leagueId);
                clubs.Add(c);
            }
        }

        foreach(ClubEntity c in clubs)
        {
            logger.LogInformation("{}",c.ToString());
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
