using System.ComponentModel;

namespace Entity.DTO.UserFavoriteCar
{
    public class AddUserFavoriteCarDTO
    {
        [DisplayName("Kullanıcı Email")]
        public string UserEmail { get; set; }

        [DisplayName("Araç Plakas")]
        public string CarPlate { get; set; }
    }
}
