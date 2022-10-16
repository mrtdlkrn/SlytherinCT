using System.ComponentModel;
using System;

namespace Entity.DTO.CarCommission
{
    public class EditCarCommissionDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Komisyon Tutarı")]
        public decimal CommissionPrice { get; set; }

        [DisplayName("Açıklama")]
        public string Info { get; set; }

        [DisplayName("Minimum Araç Tutarı")]
        public decimal MinPrice { get; set; }

        [DisplayName("Maksimum Araç Tutarı")]
        public decimal MaxPrice { get; set; }

        [DisplayName("Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [DisplayName("Bitiş Tarihi")]
        public DateTime EndDate { get; set; }
    }
}
