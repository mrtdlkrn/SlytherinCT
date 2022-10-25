using CarTender.Core.Utilities;
using CT.Business.Abstract.Base;
using CT.Entities.Entities;

namespace CarTender.Business.Abstract
{
    public interface IUserService : IBaseService<User>
    {
        IDataResult<User> GetByUserName(string userName);
    }
}
