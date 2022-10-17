using System.ComponentModel;

namespace Entity.DTO.UserCar
{
    public class AddUserCarDTO
    {
        [DisplayName("Kullanıcı Email")]
        public string UserEmail { get; set; }

        [DisplayName("Araç Plakas")]
        public string CarPlate { get; set; }
    }
}
