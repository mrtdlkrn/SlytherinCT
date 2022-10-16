using CT.API.Logging.Abstract;
using System;
using System.IO;

namespace CT.API.Logging.Concrete.Loggers
{
    public class FileLogger : AbstractLogger
    {
        private readonly string _fileName;
        private string folderPath = @"c:\MyLogs";

        public FileLogger(string fileName)
        {
            _fileName = fileName;

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }                                       
        }        

        public override void Log(string message)
        {
            //string strJson = JsonConvert.SerializeObject(alinacakLog);
            string fullPath = Path.Combine(folderPath, _fileName);
            File.AppendAllText(fullPath, message + " - " + DateTime.Now + Environment.NewLine);
        }
    }
}
