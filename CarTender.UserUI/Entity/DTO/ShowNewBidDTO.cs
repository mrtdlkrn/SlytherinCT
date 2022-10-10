using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class ShowNewBidDTO
    {
        public List<CarListDTO> CarList { get; set; }
        public List<BidListDTO> Bids { get; set; }
    }
}
