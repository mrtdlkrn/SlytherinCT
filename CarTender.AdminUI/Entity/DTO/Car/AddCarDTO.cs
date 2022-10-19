using System.ComponentModel;

namespace Entity.DTO.Car
{
    public class AddCarDTO
    {
        [DisplayName("Şirket Elemanı mı?")]
        public bool IsCorporate { get; set; }
        
        [DisplayName("Şirket Adı")]
        public string CompanyName { get; set; }
        
        [DisplayName("Statü")]
        public string Status { get; set; }
        
        [DisplayName("Ücret")]
        public decimal Price { get; set; }

        [DisplayName("Araç Marka")]
        public string CarBrand { get; set; }
        
        [DisplayName("Araç Modeli")]
        public string CarModel { get; set; }

        [DisplayName("Gövde Tipi")]
        public string BodyType { get; set; }

        [DisplayName("Yılı")]
        public string Year { get; set; }

        [DisplayName("Yakıt Tipi")]
        public string FuelType { get; set; }

        [DisplayName("Vites Tipi")]
        public string GearType { get; set; }

        [DisplayName("Versiyonu")]
        public string Version { get; set; }

        [DisplayName("Kilometre")]
        public int KM { get; set; }

        [DisplayName("Araç Rengi")]
        public string Color { get; set; }

        [DisplayName("Araç Donanımı")]
        public string[] Hardwares { get; set; }

        [DisplayName("1.Fotoğraf Yolu")]
        public string PhotoPath1 { get; set; }

        [DisplayName("2.Fotoğraf Yolu")]
        public string PhotoPath2 { get; set; }

        [DisplayName("3.Fotoğraf Yolu")]
        public string PhotoPath3 { get; set; }

        [DisplayName("4.Fotoğraf Yolu")]
        public string PhotoPath4 { get; set; }

        [DisplayName("5.Fotoğraf Yolu")]
        public string PhotoPath5 { get; set; }

        [DisplayName("Açıklama")]
        public string Explanation { get; set; }
    }
}
