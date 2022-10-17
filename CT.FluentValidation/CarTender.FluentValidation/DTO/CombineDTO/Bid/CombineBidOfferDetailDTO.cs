using System;

namespace CarTender.FluentValidation.DTO.CombineDTO.Bid
{
    public class CombineBidOfferDetailDTO
    {
        public Guid BidCarID { get; set; }
        public Guid BidUserOfferID { get; set; }
        public decimal Price { get; set; }
    }
}
