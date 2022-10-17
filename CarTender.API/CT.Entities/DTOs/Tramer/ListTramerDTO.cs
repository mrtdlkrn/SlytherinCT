using System;

namespace CT.Entities.DTOs.Tramer
{
    public class ListTramerDTO
    {
        public string CarPlate { get; set; }
        public int TramerFee { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDate { get; set; }
    }
}
