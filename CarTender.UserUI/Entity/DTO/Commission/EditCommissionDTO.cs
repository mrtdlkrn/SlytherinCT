using System;
using System.ComponentModel;

namespace Entity.DTO.Commission
{
    public class EditCommissionDTO
    {
        [DisplayName("Komisyon Ücreti")]
        public int CommissionPrice { get; set; }

        [DisplayName("Minimum Ücret")]
        public int MinPrice { get; set; }

        [DisplayName("Maksimum Ücreti")]
        public int MaxPrice { get; set; }

        [DisplayName("Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [DisplayName("Bitiş Tarihi")]
        public DateTime EndDate { get; set; }
    }
}
