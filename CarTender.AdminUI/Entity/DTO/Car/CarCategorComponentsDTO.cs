using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.Car
{
    public class CarCategorComponentsDTO
    {
        [DisplayName("Araç Kategorileri")]
        public List<CarCategoryDTO> CarCategories { get; set; }

        [DisplayName("Kategori Detay")]
        public string CarComponentName { get; set; }
    }
}
