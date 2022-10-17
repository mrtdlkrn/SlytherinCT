using CarTender.Business.Abstract;
using CarTender.DataAccess.Abstract;
using CT.Entities.Entities;

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

        public User GetByUserName(string userName)
        {
            return userDAL.Get(x => x.Username == userName);
        }
    }
}
