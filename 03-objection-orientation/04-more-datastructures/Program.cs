using Microsoft.Extensions.Logging;
using entities;


namespace datastructures
{
    public class Program
    {
        readonly ILogger logger;

        public static void Main(string[] args)
        {
            var p = new Program();
            p.workWithDictionaries();
        }

        Program()
        {
            logger = SetupLogging();

            System.Console.WriteLine("Starting Program");
            logger.LogInformation("Program initialized");
        }

        public void workWithDictionaries()
        {
            ClubEntity bayern = new ClubEntity(1, "FC Bayern Muenchen", 1);
            ClubEntity leverkusen = new ClubEntity(4, "Bayer Leverkusen", 1);

            Dictionary<int, ClubEntity> championInfo = new Dictionary<int, ClubEntity>();

            championInfo.Add(2019,bayern);
            championInfo.Add(2020,bayern);
            championInfo.Add(2021,bayern);
            championInfo.Add(2022,bayern);
            championInfo.Add(2023,leverkusen);

            logger.LogInformation("Number of elements dictionary {}", championInfo.Count);

            // get an element 
            ClubEntity champion2019 = championInfo[2019];
            logger.LogInformation("Access to an element {}", champion2019.Name);
            // try if an element exists
            ClubEntity aValue;
            if(championInfo.TryGetValue(2018, out aValue))
            {
                logger.LogInformation("Access to an element {}", aValue.Name);
            } else {
                logger.LogInformation("Couldn't find element");
            }

            // add an element and check if it already exists
            if(!championInfo.ContainsKey(2018))
            {
                championInfo.Add(2018, bayern);
            }

            // gett all elements with keys
            foreach(KeyValuePair<int, ClubEntity> kvp  in championInfo)
            {
                logger.LogInformation("Key {0}, Value {1}", kvp.Key, kvp.Value );
            }

            // get just elements
            Dictionary<int, ClubEntity>.ValueCollection clubs = championInfo.Values;
            foreach(ClubEntity club in clubs)
            {
                logger.LogInformation("{}", club.Name);
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
