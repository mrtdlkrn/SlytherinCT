using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
