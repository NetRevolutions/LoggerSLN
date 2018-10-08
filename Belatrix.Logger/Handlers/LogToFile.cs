using Belatrix.Logger.Entities;
using Belatrix.Logger.Enum;
using System;
using System.Configuration;

namespace Belatrix.Logger.Handlers
{
    public class LogToFile : AbstractLogger
    {
        public override void LogMessage(LoggerEntity logger)
        {
            string filePath = ConfigurationManager.AppSettings["LogFileDirectory"].ToString()
                    + @"\LogFile" + DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss") + ".txt";            

            if (!System.IO.File.Exists(filePath))
            {
                switch (logger.Level)
                {
                    case Level.MESSAGE:
                        System.IO.File.WriteAllText(filePath,
                        String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                    case Level.WARNING:
                        System.IO.File.WriteAllText(filePath,
                        String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                    case Level.ERROR:
                        System.IO.File.WriteAllText(filePath,
                        String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                }
            }
            else
            {
                switch (logger.Level)
                {
                    case Level.MESSAGE:                        
                        System.IO.File.AppendAllText(filePath,
                        String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                    case Level.WARNING:
                        System.IO.File.AppendAllText(filePath,
                        String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                    case Level.ERROR:
                        System.IO.File.AppendAllText(filePath,
                        String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                }
            }
                        
        }
    }
}
