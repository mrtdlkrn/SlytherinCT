using System;
using System.ComponentModel;

namespace Entity.DTO.CarSaleHistory
{
    public class ListCarSaleHistoryDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Satıcı")]
        public string SellerName { get; set; }

        [DisplayName("Alıcı")]
        public string BuyerName { get; set; }

        [DisplayName("Fiyat")]
        public decimal Price { get; set; }

        [DisplayName("Komisyon")]
        public decimal Commission { get; set; }

        [DisplayName("Satış Tarihi")]
        public DateTime SaleDate { get; set; }
    }
}
