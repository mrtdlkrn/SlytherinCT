using CT.API.Logging.Abstract;

namespace CT.API.Logging.Concrete.Loggers
{
    public class DbLogger : AbstractLogger
    {
        private readonly ILoggerManager _logger;

        public DbLogger(ILoggerManager logger)
        {
            _logger = logger;
        }

        public override void Log(string message)
        {
            _logger.LogInfo(message);
        }
    }
}
