namespace Core.Logging
{
    //exception durumunda hata mesajının tutulduğu obje
    public class LogDetailWithException : LogDetail
    {
        public string ExceptionMessage { get; set; }
    }
}