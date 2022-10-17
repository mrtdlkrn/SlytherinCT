using System;

namespace CarTender.FluentValidation.DTO.UserDTO.Favorite
{
    public class UserFavoriteDTO
    {
        public Guid UserID { get; set; }
        public Guid CarID { get; set; }
        public bool IsActive { get; set; }
    }
}
