using Microsoft.Extensions.Logging;
using entities;

namespace FootballService;

public class FootballManager
{
    readonly ILogger logger;

    private List<ClubEntity> clubs;

    private List<LeagueEntity> leagues;

    public List<ClubEntity> Clubs
    {
        get {return clubs;}
        set {clubs = value;}        
    }
    
    public List<LeagueEntity> Leagues
    {
        get {return leagues;}
        set {leagues = value;}
    }

    public FootballManager()
    {
        logger = SetupLogging();
        clubs = new List<ClubEntity>();
        leagues = new List<LeagueEntity>();
    }

    public void setup()
    {
        System.Console.WriteLine("Starting Program");
        logger.LogInformation("Program initialized");
        
        clubs.Add(new ClubEntity(1, "FC Bayern Muenchen", 1));
        clubs.Add(new ClubEntity(2, "VfL Wolfsburg", 1));
        clubs.Add(new ClubEntity(3, "Borussia Moenchengladbach", 1));
        clubs.Add(new ClubEntity(4, "1. FC Kaiserslautern", 2));

        leagues.Add(new LeagueEntity(1, "1. Bundesliga", new DateTime(1963, 08, 24), "Karl-Heinz Körbel", 602));
        leagues.Add(new LeagueEntity(1, "2. Bundesliga", new DateTime(1974, 02, 08), "Willi Landgraf", 508));
        leagues.Add(new LeagueEntity(1, "3. Bundesliga", new DateTime(2008, 07, 25), "ens Truckenbrod", 209));

    }

    public List<ClubEntity> SortedClubList()
    {
        throw new NotImplementedException("Not implemented.");
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
