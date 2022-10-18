using System;

namespace CT.Entities.DTOs.AdvertStatusHistory
{
    public class ListAdvertStatusHistoryDTO
    {
        public string AdvertTitle { get; set; }
        public string AdvertStatus { get; set; }
        public string AdvertInfo { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditDate { get; set; }
    }
}
