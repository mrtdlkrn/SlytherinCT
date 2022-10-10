using CT.Log.Abstract;
using System;

namespace CT.Log.Concrete
{


    public class NLogger 
    {
        //private readonly Logger _logger = LogManager.GetLogger("databaseLogger");
        //public string LogType { get; set; }

        //public bool CreateLog(string message)
        //{
        //    _logger.Debug(message);
        //    return true;
        //}
    }
    public class FileLog : ILog
    {
        public string LogType { get ; set ; }

        public bool CreateLog(string message)
        {
            throw new NotImplementedException();
        }
    }
}
