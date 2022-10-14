using System.ComponentModel;

namespace Entity.DTO.Brand
{
    public class AddBrandDTO
    {
        [DisplayName("Marka Adı")]
        public string Name { get; set; }
    }
}
