using System;

namespace CT.Entities.DTOs.Commission
{
    public class ListCommissionDTO
    {
        public string CarPlate { get; set; }
        public int CommissionAmount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
