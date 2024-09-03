using Microsoft.Extensions.Logging;
using entities;


namespace exceptions
{
    public class Program
    {
        readonly ILogger logger;

        public static void Main(string[] args)
        {
            var p = new Program();
        }

        Program()
        {
            logger = SetupLogging();

            System.Console.WriteLine("Starting Program");
            logger.LogInformation("Program initialized");

            List<ClubEntity> clubs = new List<ClubEntity>();
            clubs.Add(new ClubEntity(1, "FC Bayern Muenchen", 1));
            clubs.Add(new ClubEntity(2, "VfL Wolfsburg", 1));
            clubs.Add(new ClubEntity(3, "Borussia Moenchengladbach", 1));
            clubs.Add(new ClubEntity(4, "1. FC Kaiserslautern", 2));            

            // run through all elements
            foreach(ClubEntity c in clubs)
            {
                logger.LogInformation(c.ToString());
            }

            logger.LogInformation("Number of elements in list {}", clubs.Count);
            ClubEntity c5 = new ClubEntity(22,"SpVgg Greuther Fuerth",2);
            clubs.Add(c5);
            if(clubs.Contains(c5))
            {
                logger.LogInformation("New club is stored in list");
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
}
