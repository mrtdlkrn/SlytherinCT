using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class BidUserOfferDTO
    {
        public Guid BidCorporateUserID { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan? Version { get; set; }
    }
}
