using LogLayer.Abstract;
using LogLayer.Concrete.Loggers;

namespace LogLayer.Concrete
{
    public enum LoggerTypes
    {
        DbLogger,
        FileLogger
    }
    public class Creater
    {
        public AbstractLogger FactoryMethod(LoggerTypes type)
        {
            AbstractLogger logger = null;

            switch (type)
            {
                case LoggerTypes.DbLogger:
                    logger = new DbLogger();
                    break;
                case LoggerTypes.FileLogger:
                    logger = new FileLogger("CT_Logs.txt");
                    break;
            }

            return logger;
        }
    }
}
