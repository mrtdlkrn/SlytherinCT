using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class TokenDTO
    {
        public string Token { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}
