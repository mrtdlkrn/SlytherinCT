using System;

namespace CT.Entities.Car
{
    public class ListCarDTO
    {
        //todo : Guid id aktife çekilecek. Mert(Yani Ben) şimdilik böyle yaptım. 
        //public Guid CarID { get; set; }
        public string Plate { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public bool IsCorporate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string CarDetailValueName { get; set; }
        public string Name { get; set; }
    }
}
