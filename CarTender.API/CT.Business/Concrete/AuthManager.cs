using CarTender.Business.Abstract;
using CarTender.Core.Security.Hashing;
using CarTender.Core.Security.JWT;
using CarTender.Core.Utilities;
using CT.Entities.Entities;
using System.Collections.Generic;

namespace CarTender.Business.Concrete
{
    // todo: hata kodları düzeltilecek

    public class AuthManager : IAuthService
    {
        private readonly IUserService userService;
        private readonly ITokenHelper tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper = null)
        {
            this.userService = userService;
            this.tokenHelper = tokenHelper;
        }

        // todo: dto almali
        public IDataResult<AccessToken> Login(string username, string password)
        {
            // geçici olarak yazıldı silinecek
            string tempUsername = "slytherin@gmail.com";
            string tempPassword = "Sly.1234";

            if (username != tempUsername || password != tempPassword)
            {
                return new ErrorDataResult<AccessToken>("Kullanıcı bilgileri hatalı.",404);
            }

            return new SuccessDataResult<AccessToken>(CreateToken(new User()), "Token oluşturuldu.", 200);

            // dapper eklenince açılacak.

            //var result = userService.Get(u => u.Email == email);

            //if (!result.Success) return new ErrorDataResult<AccessToken>(result.Message,404);

            //if (!HashingHelper.VerifyPasswordHash(password, result.Data.PasswordHash, result.Data.PasswordSalt)) return new ErrorDataResult<AccessToken>("Kullanıcı adı veya şifre hatalı.",404);

            //return new SuccessDataResult<AccessToken>(CreateToken(result.Data),"Token oluşturuldu.",200);
        }

        // todo: dto almali
        public IResult Register(User user, string password)
        {
            var userCheckResult = userService.GetByUserName(user.Username);

            if (userCheckResult.Success) return new ErrorResult(userCheckResult.Message, userCheckResult.StatusCode);

            byte[] passwordSalt;
            byte[] passwordHash;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            var userAddResult = userService.Add(user);

            if (userAddResult.Success) return new SuccessResult(userAddResult.Message, userAddResult.StatusCode);
            return new ErrorResult(userAddResult.Message, userAddResult.StatusCode);
        }

        public AccessToken CreateToken(User user)
        {
            //var claims = userService.GetClaims(user);
            var claims = new List<OperationClaim>();
            return tokenHelper.CreateToken(user, claims);
        }
    }
}
