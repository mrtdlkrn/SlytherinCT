using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.Model
{
    public class AddModelDTO
    {
        [DisplayName("Model Adı")]
        public string Name { get; set; }

        [DisplayName("Markalar")]
        public List<string> Brands { get; set; }
    }
}
