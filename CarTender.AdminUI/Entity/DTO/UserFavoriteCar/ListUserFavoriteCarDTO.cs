using System.ComponentModel;

namespace Entity.DTO.UserFavoriteCar
{
    public class ListUserFavoriteCarDTO
    {
        [DisplayName("Kullanıcı Email")]
        public string UserEmail { get; set; }

        [DisplayName("Kullanıcı İsim Soyisim")]
        public string UserNameSurname { get; set; }
        
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Araç Markası")]
        public string CarModel { get; set; }

        [DisplayName("Araç Modeli")]
        public string CarBrand { get; set; }

        [DisplayName("Araç Fiyatı")]
        public int CarPrice { get; set; }
    }
}
