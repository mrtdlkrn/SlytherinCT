namespace Entity.DTO.Car
{
    public class AddCarDTO
    {
        public bool IsCorporate { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }

        // todo: price decimal olacak
        public int Price { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string BodyType { get; set; }
        public string Year { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; }
        public string Version { get; set; }
        public int KM { get; set; }
        public string Color { get; set; }
        public string[] Hardwares { get; set; }
        public string PhotoPath1 { get; set; }
        public string PhotoPath2 { get; set; }
        public string PhotoPath3 { get; set; }
        public string PhotoPath4 { get; set; }
        public string PhotoPath5 { get; set; }
        public string Explanation { get; set; }
    }
}
