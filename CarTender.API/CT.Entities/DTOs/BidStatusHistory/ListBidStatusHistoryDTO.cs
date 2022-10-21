using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Entities.DTOs.BidStatusHistory
{
    public class ListBidStatusHistoryDTO
    {
        public Guid ID { get; set; }

        public string Information { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }

        public Guid BidID { get; set; }

        public Guid StatuID { get; set; }

        public bool IsActive { get; set; }

    }
}
