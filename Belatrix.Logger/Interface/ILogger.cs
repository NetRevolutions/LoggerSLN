using Belatrix.Logger.Entities;

namespace Belatrix.Logger
{
    public interface ILogger
    {
        void Write(LoggerEntity loggerEntity);
    }
}
