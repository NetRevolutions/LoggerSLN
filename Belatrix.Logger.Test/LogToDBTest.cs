using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Belatrix.Logger;
using Belatrix.Logger.Entities;
using Belatrix.Logger.Enum;

namespace Belatrix.Logger.Test
{
    [TestClass]
    public class LogToDBTest
    {
        ILogger logger;

        [TestInitialize]
        public void InitValues()
        {
            logger = new LoggerFactory().GetLogger(ObjectType.DATABASE);
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
        public void LogMessageDBTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity {
                Level = Level.MESSAGE,
                Message = "This is a message to DataBase"
            };

            logger.Write(loggerEntity);
        }

        [TestMethod]
        public void LogWarningDBTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity {
                Level = Level.WARNING,
                Message = "This is a warning to DataBase"
            };

            logger.Write(loggerEntity);
            
        }

        [TestMethod]
        public void LogErrorDBTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity {
                Level = Level.ERROR,
                Message = "This is a error to DataBase"
            };

            logger.Write(loggerEntity);
            
        }
    }
}
