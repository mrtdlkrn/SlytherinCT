using System.Collections.Generic;

namespace CT.Entities.Mail
{
    public class MailInfo
    {
        public string Domain { get; set; }
        public string Token { get; set; }
        public List<string> DestinationEmails { get; set; }
        public List<string> CCDestinationEmails { get; set; }     //This is be informed emails
        public List<string> BCCDestinationEmails { get; set; }    //This is be hidden informed emails
        public string Topic { get; set; }
        public string Context { get; set; }
        public List<string> Attachements { get; set; }
    }
}
