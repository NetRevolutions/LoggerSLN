using Logger.Entities;
using Logger.Enum;
using System;

namespace Logger.Handlers
{
    public class LogToConsole : AbstractLogger
    {
        public override void LogMessage(LoggerEntity logger)
        {
            switch (logger.Level)
            {
                case Level.MESSAGE:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Level.WARNING:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Level.ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;                
            }           

            Console.WriteLine(logger.Message);
        }
    }
}
