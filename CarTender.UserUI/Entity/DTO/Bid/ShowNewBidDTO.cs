using Entity.DTO.Car;
using System.Collections.Generic;

namespace Entity.DTO.Bid
{
    public class ShowNewBidDTO
    {
        public List<ListCarDTO> CarList { get; set; }
        public List<BidListDTO> Bids { get; set; }
    }
}
