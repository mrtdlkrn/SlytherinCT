using CT.Log.Abstract;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Log.Concrete
{ 


    public class NLog : ILog
    {
        private readonly Logger _logger;
        public string LogType { get; set; }

        public bool CreateLog()
        {
            return true;
        }
    }
    public class FileLog : ILog
    {
        public string LogType { get ; set ; }

        public bool CreateLog()
        {
            return true;
        }
    }
}
