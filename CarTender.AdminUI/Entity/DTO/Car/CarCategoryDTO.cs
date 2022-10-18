using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.Car
{
    public class CarCategoryDTO
    {
        [DisplayName("Kategori Adı")]
        public string CategoryName { get; set; }
    }
}
