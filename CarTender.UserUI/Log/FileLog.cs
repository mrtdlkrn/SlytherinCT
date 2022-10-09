using Newtonsoft.Json;
using System;
using System.IO;

namespace Log
{
    public class FileLog<T> : Logging<T> where T : class
    {
        private readonly string _fileName = "testlogs.txt";

        //public FileLog(string fileName)
        //{
        //    _fileName = fileName;
        //}

        string filePath = "C:\\CTLogs";

        public override void Log(T logData)
        {
            string strJson = JsonConvert.SerializeObject(logData);
            string fullPath = Path.Combine(filePath, _fileName);
            File.AppendAllText(fullPath, strJson + Environment.NewLine);
        }
    }

}
