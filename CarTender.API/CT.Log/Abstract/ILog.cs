using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Log.Abstract
{
    public interface ILog
    {
        public string LogType { get; set; }
        public bool CreateLog();
    }
}
