using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.Advert
{
    public class ListAdvertDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("İlan Başlığı")]
        public string Title { get; set; }

        [DisplayName("İlan Açıklaması")]
        public string Info { get; set; }

        [DisplayName("Fiyat")]
        public decimal Price { get; set; }

        [DisplayName("Ön Değerlendirme Fiyatı")]
        public decimal PreliminaryPrice { get; set; }
    }
}
