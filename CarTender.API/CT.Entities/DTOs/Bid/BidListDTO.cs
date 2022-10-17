using CT.Entities.Car;
using System.Collections.Generic;

namespace CT.Entities.Bid
{
    public class BidListDTO
    {
        public List<CarDTO> CarList { get; set; }
        public List<CreateNewBidDTO> CreateNewBid { get; set; }
    }
}
