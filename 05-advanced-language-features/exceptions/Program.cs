using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.Extensions.Logging;

namespace exceptions
{
    public class Program
    {
        readonly ILogger logger;

        public static void Main(string[] args)
        {
            var p = new Program();
            p.InputExceptionExample();
            p.FileExceptionExample();
            p.NetworkExceptionExample();
        }

        Program()
        {
            logger = SetupLogging();

            System.Console.WriteLine("Starting Program");
            //logger.LogInformation("Program initialized");

        }

        public void InputExceptionExample()
        {
            try
            {
                Console.WriteLine("Please provide your age: ");
                string? input = Console.ReadLine();
                int age = Convert.ToInt32(input);
                Console.WriteLine("You were born " + age + " years ago");
            } catch(FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input was not a number! Reason: " + ex.Message);
                Console.ResetColor();
            }
        }

        public void FileExceptionExample()
        {
            string path = @"test.txt";

            try
            {
                FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                logger.LogDebug("File found, try to access");
                while (fs.Read(b,0,b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
                logger.LogDebug("finished reading file");
            } catch (FileNotFoundException ex)
            {
                logger.LogError("File not found. Details: {ex}", ex.Message);
            }
        }
        
        public  void NetworkExceptionExample()
        {
            string uri = "http://nonexistinguri.likeforreal.de";
            var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
            client.BaseAddress = new Uri(uri);
            try
            {
                HttpResponseMessage response = client.GetAsync("").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Result: " + result);
            } catch(Exception ex)
            {
                logger.LogError("HTTP call didn't work. But at least program is not crashing. Problem details: {}",ex.Message);
                
                if(ex is HttpRequestException)
                {
                    logger.LogDebug("HttpRequestException");
                }
                if(ex is SocketException)
                {
                    logger.LogDebug("SocketException");
                }
                if(ex is AggregateException)
                {
                    logger.LogDebug("AggregateException");
                }                
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
