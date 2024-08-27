using entities;
using Microsoft.Extensions.Logging;

namespace ooconcepts
{
    public class Program
    {
        readonly ILogger logger;
        ClubEntity ce;
        public static void Main(string[] args)
        {
            var p = new Program();
            p.Start();
        }

        Program()
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
            logger = factory.CreateLogger("Program"); 
            System.Console.WriteLine("gdfgdfg");
            logger.LogInformation("Program initialized");
            ce = new ClubEntity(1,"sdfsdf",1);
        }

        public void Start()
        {
            logger.LogInformation("Program started");
            logger.LogDebug(ce.ToString());
        }
    }
}


