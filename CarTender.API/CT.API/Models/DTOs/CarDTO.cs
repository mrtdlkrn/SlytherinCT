using System;

namespace CT.API.Models.DTOs
{
    public class CarDTO
    {
        //todo : Guid id aktife çekilecek. Mert(Yani Ben) şimdilik böyle yaptım. 
        //public Guid CarID { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public bool IsCorporate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }
    }
}
