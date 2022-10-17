using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.AdvertStatusHistory
{
    public class EditAdvertStatusHistoryDTO
    {
        [DisplayName("İlan No")]
        public string AdvertNo { get; set; }

        [DisplayName("Açıklama")]
        public string Info { get; set; }

        [DisplayName("İlan Statüleri")]
        public List<string> AdvertStatus { get; set; }
    }
}
