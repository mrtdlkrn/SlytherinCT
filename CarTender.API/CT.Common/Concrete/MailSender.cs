using CT.Common.Abstract;
using CT.Entities.Mail;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Common.Concrete
{
    public class MailSender : IMailSender
    {
        private readonly IMailProcessor _mailProcessor;
        private readonly ISmtpSettings _smtpSettings;
        public MailSender(IMailProcessor mailProcessor, ISmtpSettings smtpSettings)
        {
            _mailProcessor = mailProcessor;
            _smtpSettings = smtpSettings;
        }
        public MailSendResult Send(MailInfo mailInfo)
        {
            MailSendResult mailSendResult = new MailSendResult();
            mailSendResult.Errors = new List<string>();
            try
            {
                _mailProcessor.SendMail(mailInfo, _smtpSettings);
                mailSendResult.Success = true;
                return mailSendResult;
            }
            catch (Exception ex)
            {
                mailSendResult.Errors.Add(ex.Message);
                mailSendResult.Success = false;
                return mailSendResult;
            }
        }        
    }
}
