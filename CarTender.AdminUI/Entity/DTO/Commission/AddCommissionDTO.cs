using System;
using System.ComponentModel;

namespace Entity.DTO.Commission
{
    public class AddCommissionDTO
    {
        [DisplayName("Komisyon Ücreti")]
        public decimal CommissionPrice { get; set; }

        [DisplayName("Minimum Ücret")]
        public decimal MinPrice { get; set; }

        [DisplayName("Maksimum Ücreti")]
        public decimal MaxPrice { get; set; }

        [DisplayName("Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [DisplayName("Bitiş Tarihi")]
        public DateTime EndDate { get; set; }
    }
}
