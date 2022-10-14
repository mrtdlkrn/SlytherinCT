using System;

namespace Entity.DTO
{
    public class BidOfferDetailDTO
    {
        public Guid BidUserOfferID { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan? Version { get; set; }
    }
}
