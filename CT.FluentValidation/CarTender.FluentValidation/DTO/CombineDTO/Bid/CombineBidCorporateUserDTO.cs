using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.CombineDTO.Bid
{
    public class CombineBidCorporateUserDTO
    {
        public Guid BidID { get; set; }
        public Guid UserID { get; set; }
        public Guid CorporateID { get; set; }
    }
}
