namespace CarTender.Core.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }
        public DataResult(T data, bool success, string message, int statusCode) : base(success, message, statusCode)
        {
            Data = data;
        }
    }
}
