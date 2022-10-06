using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CT.Common.Abstract
{
    public interface ISmtpSettings
    {
        SmtpClient GetSmtpClientInfo();
        string GetSenderMailInfo();
        string GetSenderTitleInfo();
    }
}
