using CarTender.Core.Security.JWT;
using CarTender.Entities;
namespace CarTender.Business.Abstract
{
    public interface IAuthService
    {
        User Register(User user, string password);
        User Login(string username, string password);
        bool IsUserExist(string username);
        AccessToken CreateToken(User user);
    }
}
