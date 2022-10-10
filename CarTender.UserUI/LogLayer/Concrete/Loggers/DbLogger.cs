using LogLayer.Abstract;
using NLog;

namespace LogLayer.Concrete.Loggers
{
    public class DbLogger : AbstractLogger
    {
        private readonly NLog.Logger logger = LogManager.GetLogger("dbtest");
        public override void Log(string message)
        {
            logger.Info(message);
        }
    }
}
