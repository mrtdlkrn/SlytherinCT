using System.ComponentModel;

namespace Entity.DTO.UserFavoriteCar
{
    public class EditUserFavoriteCarDTO
    {
        [DisplayName("Kullanıcı Email")]
        public string UserEmail { get; set; }

        [DisplayName("Araç Plaka")]
        public string CarPlate { get; set; }
    }
}
