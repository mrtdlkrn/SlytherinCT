using System.ComponentModel;

namespace Entity.DTO.Brand
{
    public class EditBrandDTO
    {
        [DisplayName("Marka Adı")]
        public string Name { get; set; }
    }
}
