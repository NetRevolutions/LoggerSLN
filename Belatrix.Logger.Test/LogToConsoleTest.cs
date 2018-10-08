using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Belatrix.Logger;
using Belatrix.Logger.Entities;
using Belatrix.Logger.Enum;

namespace Belatrix.Logger.Test
{
    [TestClass]
    public class LogToConsoleTest
    {
        ILogger logger;

        [TestInitialize]
        public void InitValues()
        {
            logger = new LoggerFactory().GetLogger(ObjectType.CONSOLE);
        }

        [TestMethod]
        public void IsInitializeLoggerTest()
        {
            Assert.IsNotNull(logger);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullMessageTest()
        {
            logger.Write(null);
        }

        [TestMethod]
        public void LogMessageConsoleTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity {
                Level = Level.MESSAGE,
                Message = "This is a message to Console"
            };
          
            logger.Write(loggerEntity);
        }

        [TestMethod]
        public void LogWarningConsoleTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity
            {
                Level = Level.WARNING,
                Message = "This is a warning to Console"
            };

            logger.Write(loggerEntity);            
        }

        [TestMethod]
        public void LogErrorConsoleTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity {
                Level = Level.ERROR,
                Message = "This is a error to Console"
            };

            logger.Write(loggerEntity);
        }        
    }
}
