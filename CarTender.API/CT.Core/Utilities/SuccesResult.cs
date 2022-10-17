namespace CarTender.Core.Utilities
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message, int statusCode) : base(true, message, statusCode)
        {
        }
    }
}
