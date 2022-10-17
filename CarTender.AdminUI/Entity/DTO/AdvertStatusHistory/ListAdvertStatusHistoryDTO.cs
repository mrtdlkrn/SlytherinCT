using System.ComponentModel;

namespace Entity.DTO.AdvertStatusHistory
{
    public class ListAdvertStatusHistoryDTO
    {
        [DisplayName("İlan Başlığı")]
        public string AdvertTitle { get; set; }

        [DisplayName("Statü")]
        public string AdvertStatus { get; set; }

        [DisplayName("Açıklama")]
        public string AdvertInfo { get; set; }

        [DisplayName("Düzenleyen")]
        public string EditedBy { get; set; }

        [DisplayName("Düzenleme Tarihi")]
        public string EditDate { get; set; }
    }
}
