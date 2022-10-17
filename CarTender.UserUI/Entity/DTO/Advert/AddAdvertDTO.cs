using System.ComponentModel;

namespace Entity.DTO.Advert
{
    public class AddAdvertDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("İlan Başlığı")]
        public string Title { get; set; }

        [DisplayName("İlan Açıklaması")]
        public string Info { get; set; }

        [DisplayName("Fiyat")]
        public decimal Price { get; set; }

        [DisplayName("Ön Değerlendirme Fiyatı")]
        public decimal PreliminaryPrice { get; set; }
    }
}
