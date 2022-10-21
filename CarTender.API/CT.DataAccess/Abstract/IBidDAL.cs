using CT.Entities.Bid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.DataAccess.Abstract
{
    public interface IBidDAL
    {
        public List<ListBidDTO> GetListBid();
    }
}
