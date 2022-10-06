using CT.Entities.Mail;

namespace CT.Common.Abstract
{
    public interface IMailSender
    {
        public MailSendResult Send(MailInfo maiInfo);
    }
}
