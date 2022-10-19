using Entity.DTO.CarModificationComponent;
using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.CarModification
{
    public class AddCarModificationDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Modifiye Bileşeni")]
        public List<AddCarModificationComponentDTO> addCarModificationComponentDTOs { get; set; }
    }
}
