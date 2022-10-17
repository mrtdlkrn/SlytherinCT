namespace CarTender.Core.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>
    {

        public ErrorDataResult(string message, int statusCode) : base(default, false, message,statusCode)
        {
        }
    }
}
