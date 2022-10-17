using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.Expertise
{
    public class EditExpertiseDTO
    {
        [DisplayName("Ekspertiz Adı")]
        public string ExpertiseName { get; set; }

        [DisplayName("Şehir")]
        public List<string> City { get; set; }

        [DisplayName("İlçe")]
        public List<string> Town { get; set; }

        [DisplayName("Mahalle")]
        public List<string> Address { get; set; }

        [DisplayName("Enlem Derecesi")]
        public decimal Latitude { get; set; }

        [DisplayName("Boylam Derecesi")]
        public decimal Longitude { get; set; }
    }
}
