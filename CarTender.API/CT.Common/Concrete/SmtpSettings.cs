using CT.Common.Abstract;
using CT.Entities.Mail;
using System.Net;
using System.Net.Mail;

namespace CT.Common.Concrete
{
    public class SmtpSettings : ISmtpSettings
    {
        private SmtpSetting _smtpSettings;
        private SmtpSetting GetSmtpSettings()
        {
            _smtpSettings = new SmtpSetting();
            _smtpSettings.Host = "smtp.gmail.com";
            _smtpSettings.Port = 587;
            _smtpSettings.UserName = "infocartender@gmail.com";
            _smtpSettings.Password = "paczonwudhcxehdn";
            _smtpSettings.UseSSL = true;
            _smtpSettings.Title = "Araç İhale Bilgilendirme";

            return _smtpSettings;
        }
        public SmtpClient GetSmtpClientInfo()
        {
            SmtpSetting smtpAyar = GetSmtpSettings();
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = smtpAyar.Host;
            smtpClient.Port = smtpAyar.Port;
            smtpClient.EnableSsl = smtpAyar.UseSSL;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(smtpAyar.UserName, smtpAyar.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            return smtpClient;
        }
        public string GetSenderMailInfo()
        {
            return _smtpSettings.UserName;
        }
        public string GetSenderTitleInfo()
        {
            return _smtpSettings.Title;
        }
    }
}
