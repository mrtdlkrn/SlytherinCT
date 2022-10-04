using CarTender.Entities;

namespace CarTender.Business.Abstract
{
    public interface IUserService
    {
        bool Add(User user);
        User GetByUserName(string userName);
    }
}
