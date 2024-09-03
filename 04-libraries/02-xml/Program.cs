using System.Xml.Serialization;
using entities;
using Microsoft.Extensions.Logging;

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
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(clubs.GetType());
            serializer.Serialize(stringwriter, clubs);
            string xml = stringwriter.ToString();
            logger.LogInformation("Generated JSON {json}", xml);

            // deserialize
            
            string serializedXML = @"<?xml version=""1.0"" encoding=""utf-16""?> 
                    <ArrayOfClubEntity xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">   
                        <ClubEntity>     
                            <ID>1</ID>     
                            <Name>FC Bayern Muenchen</Name>     
                            <League>1</League>   
                        </ClubEntity>   
                        <ClubEntity>     
                            <ID>2</ID>     
                            <Name>VfL Wolfsburg</Name>     
                            <League>1</League>   
                        </ClubEntity>   
                        <ClubEntity>     
                            <ID>3</ID>
                            <Name>Borussia Moenchengladbach</Name>     
                            <League>1</League>   
                        </ClubEntity>   
                        <ClubEntity>
                             <ID>4</ID>     
                             <Name>1. FC Kaiserslautern</Name>     
                             <League>2</League>   
                        </ClubEntity> 
                    </ArrayOfClubEntity>";
            var stringReader = new System.IO.StringReader(serializedXML);
            ClubEntity[] deserializedClubs = serializer.Deserialize(stringReader) as ClubEntity[];
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
