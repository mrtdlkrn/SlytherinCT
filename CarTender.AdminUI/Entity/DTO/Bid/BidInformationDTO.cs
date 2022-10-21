using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;

namespace Entity.DTO.Bid
{
    public class BidInformationDTO
    {
        [DisplayName("İhale Adı")]
        public string BidName { get; set; }

        [DisplayName("Bireysel/Kurumsal")]
        public bool IsCorporate { get; set; }

        [DisplayName("Onaylandı Mı?")]
        public bool IsApproved { get; set; }

        [DisplayName("Bitiş Tarihi")]
        public DateTime? FinishedDate { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        [HiddenInput(DisplayValue = false)]
        public DateTime? ModifiedDate { get; set; }

        [DisplayName("Onaylayan")]
        [HiddenInput(DisplayValue = false)]
        public Guid? ApprovedBy { get; set; }

        [DisplayName("Bitiren")]
        public Guid? FinishedBy { get; set; }

        [DisplayName("Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; }



        [DisplayName("Düzenleyen")]
        [HiddenInput(DisplayValue = false)]
        public Guid? ModifiedBy { get; set; }

        [DisplayName("Oluşturan")]
        public Guid? UserID { get; set; }

        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }

        [DisplayName("Versiyon")]
        [HiddenInput(DisplayValue = false)]
        public TimeSpan? Version { get; set; }

        [DisplayName("Adres")]
        [HiddenInput(DisplayValue = false)]
        public Guid? AddressInformationID { get; set; }

        //todo: fk olan tabloları çekmedik...

    }
}
