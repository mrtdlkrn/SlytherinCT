using System;
using System.ComponentModel;

namespace Entity.DTO.TramerComponent
{
    public class ListTramerComponentDTO
    {
        [DisplayName("Bileşen Adı")]
        public string ComponentName { get; set; }

        [DisplayName("Ekleyen")]
        public string CreatedBy { get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
