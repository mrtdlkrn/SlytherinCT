using System;

namespace CarTender.FluentValidation.DTO.CombineDTO.Bid
{
    public class CombineBidCarDTO : BaseDTO
    {
        public Guid BidID { get; set; }
        public Guid CarID { get; set; }
        public decimal StartPrice { get; set; }
        public decimal MinimumPrice { get; set; }
    }
}
