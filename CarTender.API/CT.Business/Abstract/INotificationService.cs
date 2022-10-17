using CT.Entities.Entities;

namespace CT.Business.Abstract
{
    public interface INotificationService
    {
        public bool SendNotification(Message message);
    }
}
