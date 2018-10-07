using Logger.Entities;

namespace Logger
{
    public interface ILogger
    {
        void Write(LoggerEntity loggerEntity);
    }
}
