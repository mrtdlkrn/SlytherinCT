using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.CombineDTO.Bid
{
    public class CombineBidOfferDetailDTO
    {
        public Guid BidCarID { get; set; }
        public Guid BidUserOfferID { get; set; }
        public decimal Price { get; set; }
    }
}
