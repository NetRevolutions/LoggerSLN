using Logger.Entities;
using Logger.Enum;
using System;
using System.Configuration;

namespace Logger.Handlers
{
    public class LogToFile : AbstractLogger
    {
        public override void LogMessage(LoggerEntity logger)
        {
            if (!System.IO.File.Exists(ConfigurationManager.AppSettings["LogFileDirectory"].ToString()
                    + @"\LogFile" + DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss") + ".txt"))

            {
                switch (logger.Level)
                {
                    case Level.MESSAGE:
                        System.IO.File.WriteAllText(ConfigurationManager.AppSettings["LogFileDirectory"].ToString()
                        + @"\LogFile" + DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss") + ".txt",
                        String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                    case Level.WARNING:
                        System.IO.File.WriteAllText(ConfigurationManager.AppSettings["LogFileDirectory"].ToString()
                        + @"\LogFile" + DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss") + ".txt",
                        String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                    case Level.ERROR:
                        System.IO.File.WriteAllText(ConfigurationManager.AppSettings["LogFileDirectory"].ToString()
                    + @"\LogFile" + DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss") + ".txt",
                    String.Format("Date:{0} - Level:{1} - Message:{2}", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                }
            }
            else
            {
                switch (logger.Level)
                {
                    case Level.MESSAGE:                        
                        System.IO.File.AppendAllText(ConfigurationManager.AppSettings["LogFileDirectory"].ToString()
                        + @"\LogFile" + DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss") + ".txt",
                        String.Format("\r\n Date:{0} - Level:{1} - Message:{2} \r\n", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                    case Level.WARNING:
                        System.IO.File.AppendAllText(ConfigurationManager.AppSettings["LogFileDirectory"].ToString()
                        + @"\LogFile" + DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss") + ".txt",
                        String.Format("\r\n Date:{0} - Level:{1} - Message:{2} \r\n", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                    case Level.ERROR:
                        System.IO.File.AppendAllText(ConfigurationManager.AppSettings["LogFileDirectory"].ToString()
                        + @"\LogFile" + DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss") + ".txt",
                        String.Format("\r\n Date:{0} - Level:{1} - Message:{2} \r\n", DateTime.UtcNow, logger.Level.ToString(), logger.Message));
                        break;
                }
            }
                        
        }
    }
}
