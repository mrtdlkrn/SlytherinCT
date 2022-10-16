using System.ComponentModel;

namespace Entity.DTO.User
{
    public class EditUserDTO
    {
        [DisplayName("İsim")]
        public string Name { get; set; }

        //[DisplayName("Soyisim")]
        //public string Surname { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
