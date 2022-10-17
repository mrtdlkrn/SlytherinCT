namespace CarTender.Core.Utilities
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //todo : bak
        public SuccessDataResult(T data, string message, int statusCode) : base(data, true, message, statusCode)
        {
        }
    }
}
