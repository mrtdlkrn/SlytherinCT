using System.ComponentModel;

namespace Entity.DTO.Status
{
    public class ListStatusDTO
    {
        [DisplayName("Statü Adı")]
        public string Name { get; set; }

        [DisplayName("Statü Tipi")]
        public string Type { get; set; }
    }
}
