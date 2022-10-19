using System;

namespace CT.Entities.DTOs.CarSaleHistory
{
    public class UpdateCarSaleHistoryDTO
    {
        public string CarPlate { get; set; }
        public string BuyerMail { get; set; }
        public string SellerMail { get; set; }
        public decimal Price { get; set; }
        public decimal Commission { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
