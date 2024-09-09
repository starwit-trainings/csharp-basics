using entities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ooconcepts
{
    public class Program
    {
        readonly ILogger logger;

        readonly ClubEntity[] clubs = new ClubEntity[4];

        public static void Main(string[] args)
        {
            var p = new Program();
            p.Start();
        }

        Program()
        {
            logger = SetupLogging();

            System.Console.WriteLine("Starting Program");
            logger.LogInformation("Program initialized");

            logger.LogDebug("Creating Data");

            clubs[0] = new ClubEntity(1, "FC Bayern Muenchen", 1);
            clubs[1] = new ClubEntity(2, "VfL Wolfsburg", 1);
            clubs[2] = new ClubEntity(3, "Borussia Moenchengladbach", 1);
            clubs[3] = new ClubEntity(4, "1. FC Kaiserslautern", 2);
        }

        public void Start()
        {
            // serialize
            string json = JsonConvert.SerializeObject(clubs);
            logger.LogInformation("Generated JSON {json}", json);

            // deserialize
            string serializedJSON = @"[
                    {'Name':'FC Bayern Muenchen','League':1,'ID':1},
                    {'Name':'VfL Wolfsburg','League':1,'ID':2},
                    {'Name':'Borussia Moenchengladbach','League':1,'ID':3},
                    {'Name':'1. FC Kaiserslautern','League':2,'ID':4}]";
            ClubEntity[] deserializedClubs = JsonConvert.DeserializeObject<ClubEntity[]>(serializedJSON);
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
}
