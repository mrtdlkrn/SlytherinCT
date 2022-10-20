using System;

namespace CT.Entities.DTOs.Commission
{
    public class UpdateCommissionDTO
    {
        public decimal CommissionPrice { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
