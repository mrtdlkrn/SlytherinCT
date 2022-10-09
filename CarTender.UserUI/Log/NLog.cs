using Newtonsoft.Json;
using NLog;

namespace Log
{
    public class NLog<T> : Logging<T> where T : class
    {
        private readonly Logger _logger = LogManager.GetLogger("databaseLogger");

        public override void Log(T logData)
        {
            string strJson = JsonConvert.SerializeObject(logData);
            _logger.Info(strJson);
        }
    }
}
