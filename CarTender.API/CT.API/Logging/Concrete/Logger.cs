using CT.API.Logging.Abstract;

namespace CT.API.Logging.Concrete
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
