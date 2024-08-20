using Microsoft.Extensions.Logging;

using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
ILogger logger = factory.CreateLogger("Program");
logger.LogInformation("Hello World! Logging is {Description}.", "fun");

logSomeMessages();

void logSomeMessages() 
{
    logger.Log(LogLevel.Debug,"A debug messages");
    logger.Log(LogLevel.Information,"An info messages");
}