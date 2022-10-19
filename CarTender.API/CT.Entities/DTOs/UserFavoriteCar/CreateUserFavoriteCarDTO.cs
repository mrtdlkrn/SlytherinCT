using System.ComponentModel;

namespace CT.Entities.DTOs.UserFavoriteCar
{
    public class CreateUserFavoriteCarDTO
    {
        public string UserEmail { get; set; }
        public string CarPlate { get; set; }
    }
}
