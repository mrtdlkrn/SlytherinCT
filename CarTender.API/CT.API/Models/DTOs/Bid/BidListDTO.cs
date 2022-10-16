using CT.Entities;
using System.Collections.Generic;

namespace Entity.DTO.Bid
{
    public class BidListDTO
    {
        public List<Car> CarList { get; set; }
        public List<CreateNewBidDTO> CreateNewBid { get; set; }
    }
}
