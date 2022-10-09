namespace Log
{
    public abstract class Logging<T> where T : class
    {
        public abstract void Log(T logData);
    }
}
