using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.Car
{
    public class ListCarDTO
    {
        public Guid CarID { get; set; }
        public string CarPlate { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public bool IsCorporate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }
    }
}
