using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.UserDTO.Favorite
{
    public class UserFavoriteDTO
    {
        public Guid UserID { get; set; }
        public Guid CarID { get; set; }
        public bool IsActive { get; set; }
    }
}
