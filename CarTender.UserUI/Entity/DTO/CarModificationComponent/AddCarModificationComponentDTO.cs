using System.ComponentModel;

namespace Entity.DTO.CarModificationComponent
{
    public class AddCarModificationComponentDTO
    {
        [DisplayName("Bileşen Adı")]
        public string Name { get; set; }
    }
}
