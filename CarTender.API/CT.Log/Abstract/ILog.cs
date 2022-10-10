namespace CT.Log.Abstract
{
    public interface ILog
    {
        public string LogType { get; set; }
        public bool CreateLog(string message);
    }
}
