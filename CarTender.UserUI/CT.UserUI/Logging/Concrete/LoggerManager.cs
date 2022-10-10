using CT.UserUI.Logging.Abstract;
using NLog;

namespace CT.UserUI.Logging.Concrete
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetLogger("dbtest");
        public void LogDebug(string message) => logger.Debug(message);
        public void LogError(string message) => logger.Error(message);
        public void LogInfo(string message) => logger.Info(message);
        public void LogWarn(string message) => logger.Warn(message);
    }
}