using CT.API.Logging.Abstract;
using CT.API.Logging.Concrete.Loggers;

namespace CT.API.Logging.Concrete
{    
    public class Creater
    {
        public AbstractLogger FactoryMethod(string type)
        {
            AbstractLogger logger = null;
            switch (type)
            {
                case "database":
                    logger = new DbLogger(new LoggerManager());
                    break;
                case "file":
                    logger = new FileLogger("CT_Logs.txt");
                    break;
            }

            return logger;
        }
    }
}
