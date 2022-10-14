using System.ComponentModel;

namespace Entity.DTO.Status
{
    public class EditStatusDTO
    {
        [DisplayName("Statü Adı")]
        public string Name { get; set; }
    }
}
