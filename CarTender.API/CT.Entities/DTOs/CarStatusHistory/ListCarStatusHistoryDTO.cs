using System;

namespace CT.Entities.DTOs.CarStatusHistory
{
    public class ListCarStatusHistoryDTO
    {
        public string CarPlate { get; set; }
        public string Status { get; set; }
        public string Info { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate{ get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDate { get; set; }
    }
}
