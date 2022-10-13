using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.CombineDTO.Bid
{
    public class CombineBidUserOfferDTO
    {
        public Guid BidCorporateUserID { get; set; }
        public decimal Price { get; set; }
    }
}
