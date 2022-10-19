namespace CarTender.FluentValidation.DTO.AdminDTO.Car
{
    public class CarSaleHistoryDTO
    {
        public string CarPlate { get; set; }
        public string BuyerMail { get; set; }
        public string SellerMail { get; set; }
        public decimal CommissionPrice { get; set; }
    }
}
