using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class BidListDTO
    {
        public List<CarListDTO> CarList { get; set; }
        public List<CreateNewBidDTO> CreateNewBid { get; set; }
    }
}
