using System;

namespace Entity.DTO.Auth
{
    public class TokenDTO
    {
        public string Token { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}
