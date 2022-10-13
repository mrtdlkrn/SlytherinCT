using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.CombineDTO.Car
{
    public class CombineAddOrEditVehicleDetailDTO
    {
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; }
        public string Color { get; set; }
        public string Hardware { get; set; }
        public string Year { get; set; }
        public string Version { get; set; }
    }
}
