namespace CT.Entities.DTOs.Expertise
{
    public class ListExpertiseDTO
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Neighborhood { get; set; }
        public decimal Latitude { get; set; } // Enlem
        public decimal Longitude { get; set; } // Boylam
    }
}
