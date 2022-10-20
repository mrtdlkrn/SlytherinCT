namespace CT.Entities.DTOs.Advert
{
    public class UpdateAdvertDTO
    {
        public string CarPlate { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public decimal Price { get; set; }
        public decimal PreliminaryPrice { get; set; }
    }
}
