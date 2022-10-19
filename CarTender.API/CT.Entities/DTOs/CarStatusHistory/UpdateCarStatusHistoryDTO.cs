using System;

namespace CT.Entities.DTOs.CarStatusHistory
{
    public class UpdateCarStatusHistoryDTO
    {
        public string CarPlate { get; set; }
        public string Info { get; set; }
        public string CarStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EditBy { get; set; }
        public DateTime EditedDate { get; set; }
    }
}
