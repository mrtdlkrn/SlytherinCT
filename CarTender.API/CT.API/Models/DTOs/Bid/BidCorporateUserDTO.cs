using System;

namespace Entity.DTO.Bid
{
    public class BidCorporateUserDTO
    {
        //todo:modifiedby etkin id date o günün tarihi olacak

        public bool IsActive { get; set; }
        public TimeSpan Version { get; set; }
        public DateTime ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
