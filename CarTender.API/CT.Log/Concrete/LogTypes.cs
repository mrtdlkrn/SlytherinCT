using CT.Log.Abstract;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Log.Concrete
{ 


    public class NLogger : ILog
    {
        private readonly Logger _logger = LogManager.GetLogger("dblog");
        public string LogType { get; set; }

        public bool CreateLog(string message)
        {
            _logger.Debug(message);
            return true;
        }
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
