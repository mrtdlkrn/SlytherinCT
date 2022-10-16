using System.ComponentModel;

namespace Entity.DTO.CarDetail
{
    public class AddCarDetailDTO
    {
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
    }
}
