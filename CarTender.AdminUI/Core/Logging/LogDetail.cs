using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Core.Logging
{
    public class LogDetail
    {
        public DateTime TransactionDate { get; set; }
        public string MethodName { get; set; }
        public object ReturnValue { get; set; }
        public List<LogParameter> LogParameters { get; set; }
    }
}
