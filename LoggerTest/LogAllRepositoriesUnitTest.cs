using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Logger;
using Logger.Entities;
using Logger.Enum;

namespace LoggerTest
{

    [TestClass]
    public class LogAllRepositoriesUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ILogger ConsoleLogger = new LoggerFactory().GetLogger(ObjectType.CONSOLE);
            ILogger FileLogger = new LoggerFactory().GetLogger(ObjectType.FILE);
            ILogger DBLogger = new LoggerFactory().GetLogger(ObjectType.DATABASE);

            LoggerEntity loggerEntity = new LoggerEntity();
            loggerEntity.Level = Level.MESSAGE;
            loggerEntity.Message = "Test Message";

            ConsoleLogger.Write(loggerEntity);
            FileLogger.Write(loggerEntity);
            DBLogger.Write(loggerEntity);

        }
    }
}
