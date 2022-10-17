using System.ComponentModel;

namespace Entity.DTO.Neighborhood
{
    public class ListNeighborhoodDTO
    {
        [DisplayName("Mahalle Adı")]
        public string Name { get; set; }

        [DisplayName("İlçe Adı")]
        public string TownName { get; set; }

        [DisplayName("İl Adı")]
        public string CityName { get; set; }
    }
}
