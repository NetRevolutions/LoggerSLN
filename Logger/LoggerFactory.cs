using Logger.Enum;
using Logger.Handlers;

namespace Logger
{
    public class LoggerFactory
    {
        public ILogger GetLogger(ObjectType objectType)
        {
            ILogger logger;

            switch(objectType)
            {
                case ObjectType.CONSOLE:
                    logger = new LogToConsole();
                    break;
                case ObjectType.FILE:
                    logger = new LogToFile();
                    break;
                case ObjectType.DATABASE:
                    logger = new LogToDB();
                    break;
                default:
                    logger = new LogToFile();
                    break;
            }

            return logger;
        }
    }
}
