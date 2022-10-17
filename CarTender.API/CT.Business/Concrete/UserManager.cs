using CarTender.Business.Abstract;
using CarTender.DataAccess.Abstract;
using CT.Entities.Entities;
using System.Collections.Generic;

namespace CarTender.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDAL userDAL;

        public UserManager(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public bool Add(User user)
        {
            return userDAL.Add(user);
        }

        public List<User> GetAll()
        {
            return userDAL.GetAll();
        }

        public User GetByUserName(string userName)
        {
            return userDAL.Get(x => x.Username == userName);
        }

        public bool Update(User user)
        {
            return userDAL.Update(user);
        }
    }
}
