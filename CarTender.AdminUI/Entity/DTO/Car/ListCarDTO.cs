using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.DTO.Car
{
    public class ListCarDTO
    {
        //public Guid CarID { get; set; }
        [DisplayName("Plaka")]
        public string Plate { get; set; }

        [DisplayName("Marka")]
        public string CarBrand { get; set; }

        [DisplayName("Model")]
        public string CarModel { get; set; }

        // todo: fiyat decimal olacak.
        [DisplayName("Fiyat")]
        public int Price { get; set; }

        [DisplayName("Bireysel/Kurumsal")]
        public bool IsCorporate { get; set; }

        [DisplayName("Statü")]
        public string Status { get; set; }

        [DisplayName("Kaydeden Kullanıcı")]
        public string CreatedBy { get; set; }

        [DisplayName("Kayıt Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
