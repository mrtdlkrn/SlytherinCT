using Entity.DTO.Corparate;
using Entity.DTO.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.BidCreate
{
    public class CreateBidViewDTO
    {
        public CreateNewBidDTO DTO { get; set; }

        public List<CorparateList> CorparateList { get; set; }

        public List<ListStatusDTO> StatusList { get; set; }
    }
}
