using CarTender.Business.Abstract;
using CarTender.Core.Security.Hashing;
using CarTender.Core.Security.JWT;
using CT.Entities.Entities;
using System.Collections.Generic;

namespace CarTender.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService userService;
        private readonly ITokenHelper tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper = null)
        {
            this.userService = userService;
            this.tokenHelper = tokenHelper;
        }

        public bool IsUserExist(string username)
        {
            var user = userService.GetByUserName(username);

            if (user == null) return false;
            return true;
        }

        // todo: dto almali
        public User Login(string username, string password)
        {
            var user = userService.GetByUserName(username);

            if (user == null) return null;

            if (!HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)) return null;

            return user;
        }

        // todo: dto almali
        public User Register(User user, string password)
        {
            byte[] passwordSalt;
            byte[] passwordHash;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            userService.Add(user);
            return user;
        }


        public AccessToken CreateToken(User user)
        {
            //var claims = userService.GetClaims(user);
            var claims = new List<OperationClaim>();
            return tokenHelper.CreateToken(user, claims);
        }
    }
}
