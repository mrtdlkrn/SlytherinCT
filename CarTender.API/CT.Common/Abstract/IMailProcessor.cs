using CT.Entities.Mail;

namespace CT.Common.Abstract
{
    public interface IMailProcessor
    {
        public void SendMail(MailInfo mailBilgi, ISmtpSettings smtpAyarlayan);
    }
}
