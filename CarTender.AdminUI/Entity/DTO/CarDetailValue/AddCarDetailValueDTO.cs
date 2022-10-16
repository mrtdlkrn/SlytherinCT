using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.CarDetailValue
{
    public class AddCarDetailValueDTO
    {
        [DisplayName("Kategoriler")]
        public List<string> Categories { get; set; }

        [DisplayName("Kategori Bileşeni Adı")]
        public string Name { get; set; }
    }
}
