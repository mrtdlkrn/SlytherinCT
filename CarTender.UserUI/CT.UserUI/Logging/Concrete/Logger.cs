using CT.UserUI.Logging.Abstract;

namespace CT.UserUI.Logging.Concrete
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