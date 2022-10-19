using Entity.DTO.CarModificationComponent;
using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.CarModification
{
    public class EditCarModificationDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Modifiye Bileşeni")]
        public List<EditCarModificationComponentDTO> editCarModificationComponentDTOs { get; set; }
    }
}
