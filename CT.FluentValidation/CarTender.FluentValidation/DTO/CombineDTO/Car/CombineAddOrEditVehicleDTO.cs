using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.CombineDTO.Car
{
    public class CombineAddOrEditVehicleDTO
    {
        public string PersonalCorporate { get; set; }
        public string CompanyName { get; set; }
        public string Statu { get; set; }
        public int VehiclePrice { get; set; }
        public CombineAddOrEditVehicleDetailDTO CombineAddOrEditVehicleDetailDTO { get; set; }
        public int KM { get; set; }
        public string PhotoPath1 { get; set; }
        public string PhotoPath2 { get; set; }
        public string PhotoPath3 { get; set; }
        public string PhotoPath4 { get; set; }
        public string PhotoPath5 { get; set; }
        public string Explanation { get; set; }
    }
}
