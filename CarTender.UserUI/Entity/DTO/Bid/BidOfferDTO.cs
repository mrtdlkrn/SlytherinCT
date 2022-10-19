using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.Bid
{
    public class BidOfferDTO
    {

        public int UserID { get; set; }
        public int BidCarID { get; set; }
        public decimal OfferAmount { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
