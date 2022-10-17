using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.Message
{
    public class AddMessageDTO
    {
        [DisplayName("Kullanıcı Emaili")]
        public string UserEmail { get; set; }

        [DisplayName("Mesaj Başlığı")]
        public List<string> MessageTitle { get; set; }
    }
}
