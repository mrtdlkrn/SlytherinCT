using System.ComponentModel;

namespace Entity.DTO.MessageContent
{
    public class EditMessageContentDTO
    {
        [DisplayName("Mesaj Başlığı")]
        public string ContentTitle { get; set; }

        [DisplayName("Mesaj İçeriği")]
        public string ContentText { get; set; }
    }
}
