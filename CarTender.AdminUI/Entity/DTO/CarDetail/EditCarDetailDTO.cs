using System.ComponentModel;

namespace Entity.DTO.CarDetail
{
    public class EditCarDetailDTO
    {
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
    }
}
