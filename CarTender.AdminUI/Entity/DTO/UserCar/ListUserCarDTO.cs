using System.ComponentModel;

namespace Entity.DTO.UserCar
{
    public class ListUserCarDTO
    {
        [DisplayName("Kullanıcı Emaili")]
        public string UserEmail { get; set; }

        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }
    }
}
