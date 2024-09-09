using entities;
using Microsoft.Extensions.Logging;

namespace ooconcepts
{
    public class Program
    {
        readonly ILogger logger;
        readonly ClubEntity ce;
        
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
            ce = new ClubEntity(1,"Test",1);
        }

        public void Start()
        {
            ce.Name = "1. FC Union Berlin";
            logger.LogInformation("Program started");
            logger.LogDebug("Club information: {club}", ce.ToString());
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


