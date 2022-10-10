using LogLayer.Abstract;
using System.IO;
using System;

namespace LogLayer.Concrete.Loggers
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
            string fullPath = Path.Combine(filePath, _fileName);
            File.AppendAllText(fullPath, message + Environment.NewLine);
        }
    }
}
