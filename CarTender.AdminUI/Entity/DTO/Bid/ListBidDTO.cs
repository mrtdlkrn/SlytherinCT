using Entity.DTO.Car;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.DTO.Bid
{
    public class ListBidDTO
    {
        [Key]
        public Guid ID { get; set; }

        [DisplayName("İhale Adı")]
        public string BidName { get; set; }

        [DisplayName("Bireysel/Kurumsal")]
        public bool IsCorporate { get; set; }

        [DisplayName("Onaylandı Mı?")]
        public bool IsApproved { get; set; }

        [DisplayName("Statü")]
        public string Status { get; set; }

        [DisplayName("Oluşturma Tarihi")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Oluşturan")]
        public Guid? UserID { get; set; }

        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }

    }
}
