using CarTender.Core.Utilities;
using CT.Entities.Entities;

namespace CT.Business.Abstract
{
    public interface INotificationService
    {
        IResult SendNotification(Message message);
    }
}
