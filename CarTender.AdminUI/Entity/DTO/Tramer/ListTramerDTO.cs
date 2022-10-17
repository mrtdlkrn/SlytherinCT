using System;
using System.ComponentModel;

namespace Entity.DTO.Tramer
{
    public class ListTramerDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Tramer Tutarı")]
        public int TramerFee { get; set; }

        [DisplayName("Ekleyen")]
        public string CreatedBy { get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Düzenleyen")]
        public string EditedBy { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public DateTime EditedDate { get; set; }
    }
}
