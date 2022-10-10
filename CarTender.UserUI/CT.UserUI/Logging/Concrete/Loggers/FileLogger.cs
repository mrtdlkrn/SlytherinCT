using CT.UserUI.Logging.Abstract;
using System;
using System.IO;

namespace CT.UserUI.Logging.Concrete.Loggers
{
    public class FileLogger : AbstractLogger
    {
        private readonly string _fileName;
        public FileLogger(string fileName)
        {
            _fileName = fileName;
        }

        string filePath = "C:\\MyLogs";

        public override void Log(string message)
        {
            //string strJson = JsonConvert.SerializeObject(alinacakLog);
            string fullPath = Path.Combine(filePath, _fileName);
            File.AppendAllText(fullPath, message + Environment.NewLine);
        }
    }
}