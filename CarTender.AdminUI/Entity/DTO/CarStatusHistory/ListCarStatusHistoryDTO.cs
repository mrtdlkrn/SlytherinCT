using System;
using System.ComponentModel;

namespace Entity.DTO.CarStatusHistory
{
    public class ListCarStatusHistoryDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Araç Statüsü")]
        public string Status { get; set; }

        [DisplayName("Açıklama")]
        public string Info { get; set; }

        [DisplayName("Ekleyen")]
        public string CreatedBy { get; set; }

        [DisplayName("Eklenme Tarihi")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Düzenleyen")]
        public string EditedBy { get; set; }

        [DisplayName("Düzenlenme Tarihi")]
        public DateTime EditedDate { get; set; }
    }
}
