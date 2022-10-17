using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.CarStatusHistory
{
    public class AddCarStatusHistoryDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Açıklama")]
        public string Info { get; set; }

        [DisplayName("Araç Statüsü")]
        public List<string> CarStatus { get; set; }

        [DisplayName("Ekleyen Kişinin Maili")]
        public string CreatedBy { get; set; }

        [DisplayName("Eklenme Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
