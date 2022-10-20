namespace CT.Entities.DTOs.Expertise
{
    public class CreateExpertiseDTO
    {
        public string ExpertiseName { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
