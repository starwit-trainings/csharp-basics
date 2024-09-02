using entities;
using Microsoft.Extensions.Logging;

namespace ooconcepts
{
    public class Program
    {
        readonly ILogger logger;

        readonly LeagueEntity[] leagues = new LeagueEntity[3];

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

            clubs[0] = new ClubEntity(1,"FC Bayern Muenchen",1);
            clubs[1] = new ClubEntity(2,"VfL Wolfsburg",1);
            clubs[2] = new ClubEntity(3,"Borussia Moenchengladbach",1);
            clubs[3] = new ClubEntity(4,"1. FC Kaiserslautern",2);

            leagues[0] = new LeagueEntity(1, "1. Bundesliga", new DateTime(1963, 08, 24), "Karl-Heinz Körbel", 602);
            leagues[1] = new LeagueEntity(1, "2. Bundesliga", new DateTime(1974, 02, 08), "Willi Landgraf", 508);
            leagues[2] = new LeagueEntity(1, "3. Bundesliga", new DateTime(2008, 07, 25), "ens Truckenbrod", 209);
        }

        public void Start()
        {
            logger.LogInformation("Program started");
            for(int i = 0; i < clubs.Length; i++)
            {
                logger.LogDebug("Club information: {club}", clubs[i].ToString());
            }

            for(int i = 0; i < leagues.Length; i++ )
            {
                logger.LogDebug("League information: {league}", leagues[i].ToString());
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
