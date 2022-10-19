using System;

namespace CarTender.Core.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}
