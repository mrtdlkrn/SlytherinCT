using CT.Common.Abstract;
using CT.Common.Concrete;
using CT.Entities.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Common.Service
{
    public class MailEngine : IMailEngine
    {
        public MailSendResult MailSend(MailInfo mailInfo)
        {
            MailSender mailSender = new MailSender(new MailProcessor(), new SmtpSettings());
            return mailSender.Send(mailInfo);
        }
    }
}
