using CT.API.Logging.DatabaseNLog.Abstract;

namespace CT.API.Logging.DatabaseNLog.Concrete
{
    public class Logger
    {
        AbstractLogger logger;

        public Logger(AbstractLogger logger)
        {
            this.logger = logger;   
        }

        public void Log(string message)
        {
            logger.Log(message);
        }
    }
}
