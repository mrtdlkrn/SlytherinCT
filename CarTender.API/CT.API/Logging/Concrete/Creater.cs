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
                    return new DbLogger(new LoggerManager());
                case "file":
                    return new FileLogger("CT_API_Logs.txt");
            }
            return new DbLogger(new LoggerManager());
        }
    }
}
