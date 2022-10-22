using CarTender.Core.Security.JWT;
using CarTender.Core.Utilities;
using CT.Entities.Entities;

namespace CarTender.Business.Abstract
{
    public interface IAuthService
    {
        IResult Register(User user, string password);
        IDataResult<AccessToken> Login(string email, string password);
        AccessToken CreateToken(User user);
    }
}
