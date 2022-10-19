using System;
using System.ComponentModel;

namespace Entity.DTO.Commission
{
    public class ListCommissionDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Komisyon Tutarı")]
        public int CommissionAmount { get; set; }

        [DisplayName("Eklenme Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
