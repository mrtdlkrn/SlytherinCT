namespace CarTender.Core.Utilities
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }

        public int StatusCode { get; }

        public Result(bool success, string message, int statusCode) : this(success)
        {
            Message = message;
            StatusCode = statusCode;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
