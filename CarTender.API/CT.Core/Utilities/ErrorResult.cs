namespace CarTender.Core.Utilities
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message,int statusCode) : base(false, message,statusCode)
        {
        }
    }
}
