using Entity.DTO.Car;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.BidCreate
{
    public class CreateNewBidDTO
    {
        public Guid ID { get; set; }

        [DisplayName("İhale Adı")]
        public string BidName { get; set; }

        [DisplayName("Bireysel/Kurumsal")]
        public bool CustomerType { get; set; }

        [DisplayName("Şirket Adı")]
        public string CompanyName { get; set; }

        [DisplayName("Statü")]
        public string Status { get; set; }

        [DisplayName("İhale Başlangıç Tarihi")]
        public DateTime BidStartDate { get; set; }

        [DisplayName("İhale Başlangıç Saati")]
        public string BidStartTime { get; set; }

        [DisplayName("İhale Başlangıç Tarihi")]
        public DateTime BidEndDate { get; set; }

        [DisplayName("İhale Başlangıç Saati")]
        public string BidEndTime { get; set; }

        [DisplayName("Araç İhale Listesi")]

        public List<ListCarDTO> CarList { get; set; }
    }
}
