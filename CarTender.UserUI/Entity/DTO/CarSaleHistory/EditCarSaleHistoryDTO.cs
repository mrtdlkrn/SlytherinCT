using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Entity.DTO.CarSaleHistory
{
    public class EditCarSaleHistoryDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Alıcı Email")]
        public string BuyerMail { get; set; }

        [DisplayName("Satıcı Email")]
        public string SellerMail { get; set; }

        [DisplayName("Satış Fiyatı")]
        public decimal Price { get; set; }

        [DisplayName("Komisyon")]
        public decimal Commission { get; set; }

        [DisplayName("Satış Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
