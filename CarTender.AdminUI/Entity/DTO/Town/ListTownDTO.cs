using System.ComponentModel;

namespace Entity.DTO.Town
{
    public class ListTownDTO
    {
        [DisplayName("İlçe Adı")]
        public string Name { get; set; }

        [DisplayName("İl Adı")]
        public string CityName { get; set; }
    }
}
