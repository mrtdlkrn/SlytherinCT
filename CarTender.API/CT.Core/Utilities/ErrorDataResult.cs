namespace CarTender.Core.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>
    {

        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
    }
}
