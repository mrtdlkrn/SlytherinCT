using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.AdminDTO.Car
{
    public class CarBuyerInformationDTO
    {
        public string CarPlate { get; set; }
        public string BuyerMail { get; set; }
        public decimal Price { get; set; }
        public string Info { get; set; }
        public string CreatedEmail { get; set; }
    }
}
