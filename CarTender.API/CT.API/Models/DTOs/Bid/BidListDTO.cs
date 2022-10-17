using CT.API.Models.DTOs.Car;
using System.Collections.Generic;

namespace Entity.DTO.Bid
{
    public class BidListDTO
    {
        public List<CarDTO> CarList { get; set; }
        public List<CreateNewBidDTO> CreateNewBid { get; set; }
    }
}
