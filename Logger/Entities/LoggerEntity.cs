using Logger.Enum;

namespace Logger.Entities
{
    public class LoggerEntity
    {
        public string Message { get; set; }
        public Level Level { get; set; }
               
        public bool IsValid()
        {
            return (this.Message != null) && (!string.IsNullOrEmpty(Message));
        }
    }
}
