using Entity.DTO.Car;
using System.Collections.Generic;

namespace Entity.DTO.Bid
{
    public class BidListDTO
    {
        public List<ListCarDTO> CarList { get; set; }
        public List<CreateNewBidDTO> CreateNewBid { get; set; }
    }
}
