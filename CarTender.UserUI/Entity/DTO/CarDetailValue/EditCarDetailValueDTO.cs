using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.CarDetailValue
{
    public class EditCarDetailValueDTO
    {
        [DisplayName("Kategoriler")]
        public List<string> Categories { get; set; }

        [DisplayName("Kategori Bileşeni Adı")]
        public string Name { get; set; }
    }
}
