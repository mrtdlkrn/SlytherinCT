using CT.Entities.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Common.Service
{
    public interface IMailEngine
    {
        public MailSendResult MailSend(MailInfo mailInfo);
    }
}
