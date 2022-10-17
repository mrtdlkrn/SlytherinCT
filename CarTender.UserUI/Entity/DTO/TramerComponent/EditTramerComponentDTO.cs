using System;
using System.ComponentModel;

namespace Entity.DTO.TramerComponent
{
    public class EditTramerComponentDTO
    {
        [DisplayName("Bileşen Adı")]
        public string Name { get; set; }

        [DisplayName("Kayıt Eden")]
        public string CreatedBy { get; set; }

        [DisplayName("Kayıt Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
