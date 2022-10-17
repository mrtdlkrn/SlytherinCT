using System.ComponentModel;
using System;

namespace Entity.DTO.CarBuyerInformation
{
    public class EditCarBuyerInformationDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Alıcı Email")]
        public string BuyerMail { get; set; }

        [DisplayName("Satış Fiyatı")]
        public decimal Price { get; set; }

        [DisplayName("Açıklama")]
        public string Info { get; set; }

        [DisplayName("Ekleyen Mail")]
        public string CreatedBy { get; set; }

        [DisplayName("Kayıt Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
