using System;
using Belatrix.Logger.Enum;

namespace Belatrix.Logger.Entities
{
    public class LoggerEntity
    {
        public string Message { get; set; }
        public Level Level { get; set; }
               
        public bool IsValid()
        {
            return (this.Message != null) && (!String.IsNullOrEmpty(Message));
        }
    }
}
