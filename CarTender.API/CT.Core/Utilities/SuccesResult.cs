namespace CarTender.Core.Utilities
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
        }
    }
}
