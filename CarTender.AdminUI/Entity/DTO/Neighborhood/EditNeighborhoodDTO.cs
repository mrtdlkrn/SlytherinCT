using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.Neighborhood
{
    public class EditNeighborhoodDTO
    {
        [DisplayName("Mahalle Adı")]
        public string Name { get; set; }

        [DisplayName("İlçeler")]
        public List<string> Towns { get; set; }
    }
}
