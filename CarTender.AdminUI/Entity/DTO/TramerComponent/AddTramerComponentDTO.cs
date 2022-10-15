using System.ComponentModel;

namespace Entity.DTO.TramerComponent
{
    public class AddTramerComponentDTO
    {
        [DisplayName("Bileşen Adı")]
        public string  Name { get; set; }

        [DisplayName("Kayıt Eden Kişinin Emaili")]
        public string CreatorsEmail { get; set; }
    }
}
