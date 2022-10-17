using System;

namespace CT.Entities.DTOs.CarSaleHistory
{
    public class ListCarSaleHistoryDTO
    {
        public string CarPlate { get; set; }
        public string SellerName { get; set; }
        public string BuyerName { get; set; }
        public decimal Price { get; set; }
        public decimal Commission { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
