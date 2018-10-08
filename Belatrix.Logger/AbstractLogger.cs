using Belatrix.Logger.Entities;
using System;

namespace Belatrix.Logger
{
    public abstract class AbstractLogger : ILogger
    {
        public void Write(LoggerEntity loggerEntity)
        {
            if (!loggerEntity.IsValid())
            {
                throw new ArgumentException("Invalid configuration");
            }

            LogMessage(loggerEntity);
        }

        public abstract void LogMessage(LoggerEntity loggerEntity);
    }
}
