using CT.Entities.Entities;
using System.Collections.Generic;

namespace CarTender.Business.Abstract
{
    public interface IUserService
    {
        bool Add(User user);

        List<User> GetAll();

        User GetByUserName(string userName);

        bool Update(User user);
    }
}
