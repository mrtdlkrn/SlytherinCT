using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.DTO.Brand
{
    public class AddBrandDTO
    {
        [DisplayName("Marka Adı")]
        [StringLength(25, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
