using System;
using System.Collections.Generic;

namespace CT.Entities.DTOs.CarStatusHistory
{
    public class CreateCarStatusHistoryDTO
    {
        public string CarPlate { get; set; }
        public string Info { get; set; }
        public List<string> CarStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
