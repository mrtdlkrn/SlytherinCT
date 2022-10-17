using System.ComponentModel;

namespace Entity.DTO.CarModificationComponent
{
    public class EditCarModificationComponentDTO
    {
        [DisplayName("Bileşen Adı")]
        public string Name { get; set; }
    }
}
