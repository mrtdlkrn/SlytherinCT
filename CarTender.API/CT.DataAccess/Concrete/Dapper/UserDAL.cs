using CarTender.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper.Base;
using CT.DataAccess.Context;
using CT.Entities.Entities;

namespace CarTender.DataAccess.Concrete.Dapper
{
    public class UserDAL : DapperRepository<User, CarTenderDbContext>, IUserDAL
    {
    
    }
}
