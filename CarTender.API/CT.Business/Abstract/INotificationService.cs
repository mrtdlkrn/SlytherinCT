using CT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CT.Business.Abstract
{
    public interface INotificationService
    {
        public bool SendNotification(Message message);
    }
}
