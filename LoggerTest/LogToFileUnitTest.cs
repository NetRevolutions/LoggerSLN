using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Logger;
using Logger.Entities;
using Logger.Enum;

namespace LoggerTest
{
    [TestClass]
    public class LogToFileUnitTest
    {
        ILogger logger;

        [TestInitialize]
        public void InitValues()
        {
            logger = new LoggerFactory().GetLogger(ObjectType.FILE);
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
        public void LogMessageFileTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity
            {
                Level = Level.MESSAGE,
                Message = "This is a message to File"
            };

            logger.Write(loggerEntity);            
        }

        [TestMethod]
        public void LogWarningFileTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity
            {
                Level = Level.WARNING,
                Message = "This is a warning to File"
            };

            logger.Write(loggerEntity);            
        }

        [TestMethod]
        public void LogErrorFileTest()
        {
            LoggerEntity loggerEntity = new LoggerEntity
            {
                Level = Level.ERROR,
                Message = "This is a error to File"
            };

            logger.Write(loggerEntity);
        }        
    }
}
