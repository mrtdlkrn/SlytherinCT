using System;

namespace CT.Entities.Bid
{
    public class BidStatusHistoryDTO
    {
        public string Information { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public Guid BidID { get; set; }
        public Guid StatuID { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan? Version { get; set; }
    }
}
