using System;

namespace CarTender.FluentValidation.DTO.CombineDTO.Bid
{
    public class CombineBidCorporateUserDTO
    {
        public Guid BidID { get; set; }
        public Guid UserID { get; set; }
        public Guid CorporateID { get; set; }
    }
}
