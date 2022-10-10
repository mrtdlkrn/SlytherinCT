namespace CT.Entities.Mail
{
    public class SmtpSetting
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool UseSSL { get; set; }
    }
}
