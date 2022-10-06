using CT.Common.Abstract;
using CT.Entities.Mail;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CT.Common.Concrete
{
    public class MailProcessor : IMailProcessor
    {
        public void SendMail(MailInfo mailInfo, ISmtpSettings smtpSettings)
        {
            SmtpClient smtpClient = smtpSettings.GetSmtpClientInfo();
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress(smtpSettings.GetSenderMailInfo(), smtpSettings.GetSenderTitleInfo());
            mailInfo.DestinationEmails.ForEach(x => { ePosta.To.Add(x); });
            ePosta.Subject = mailInfo.Topic;
            ePosta.IsBodyHtml = true;
            ePosta.Body = mailInfo.Context;
            ePosta.Attachments.Clear();
            mailInfo.Attachements?.ForEach(x => { ePosta.Attachments.Add(new Attachment(x)); });
            smtpClient.Send(ePosta);
        }
    }
}
