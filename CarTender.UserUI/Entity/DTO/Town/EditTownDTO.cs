using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.Town
{
    public class EditTownDTO
    {
        [DisplayName("İlçe Adı")]
        public string Name { get; set; }

        [DisplayName("Şehir")]
        public List<string> Cities { get; set; }
    }
}
