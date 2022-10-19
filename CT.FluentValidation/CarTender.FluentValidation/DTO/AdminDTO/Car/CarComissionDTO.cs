using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.AdminDTO.Car
{
    public class CarComissionDTO
    {
        public string CarPlate { get; set; }
        public decimal CommissionPrice { get; set; }
        public string Info { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

    }
}
