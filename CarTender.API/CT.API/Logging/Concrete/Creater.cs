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
                    return logger = new DbLogger(new LoggerManager());
                case "file":
                    return logger = new FileLogger("CT_Logs.txt");
            }
            return logger = new DbLogger(new LoggerManager());
        }
    }
}
