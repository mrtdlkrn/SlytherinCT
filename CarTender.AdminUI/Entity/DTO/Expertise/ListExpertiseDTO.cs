using System.ComponentModel;

namespace Entity.DTO.Expertise
{
    public class ListExpertiseDTO
    {
        [DisplayName("Ekspertiz Adı")]
        public string Name { get; set; }

        [DisplayName("Şehir")]
        public string City { get; set; }

        [DisplayName("İlçe")]
        public string Town { get; set; }

        [DisplayName("Mahalle")]
        public string Neighborhood { get; set; }

        [DisplayName("Enlem")]
        public decimal Latitude { get; set; } // Enlem

        [DisplayName("Boylam")]
        public decimal Longitude { get; set; } // Boylam
    }
}
