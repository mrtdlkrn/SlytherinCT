using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.Bid
{
    public class BidPaymentDTO
    {
        public int UserID { get; set; }

        public int BidID { get; set; }

        public string PaymentType { get; set; } // Noter veya Komisyon

        public decimal Amount { get; set; } //

        public DateTime PaymentDate { get; set; }

    }
}
