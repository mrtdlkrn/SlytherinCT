using System;
using System.Collections.Generic;

namespace Core.Logging
{
    public class LogDetail
    {
        //Loglama yaparken log içeriğinde olması gereken parametreleri belirttiğimiz obje örn: bu işlem ne zaman gerçekleşti,...
        public DateTime TransactionDate { get; set; }
        public string MethodName { get; set; }
        public string UserName { get; set; }
        public List<LogParameter> LogParameters { get; set; }
    }
}
