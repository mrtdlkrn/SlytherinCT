using System.ComponentModel;

namespace Entity.DTO.Advert
{
    public class ListAdvertDTO
    {
        [DisplayName("Plaka")]
        public string CarPlate { get; set; }

        [DisplayName("Marka")]
        public string CarBrand { get; set; }

        [DisplayName("Model")]
        public string CarModel { get; set; }

        [DisplayName("İlan Başlığı")]
        public string Title { get; set; }

        [DisplayName("Ön Değerlendirme Fiyatı")]
        public decimal PrePrice { get; set; }

        [DisplayName("Fiyat")]
        public decimal Price { get; set; }

        [DisplayName("Açıklama")]
        public string Info { get; set; }
    }
}
