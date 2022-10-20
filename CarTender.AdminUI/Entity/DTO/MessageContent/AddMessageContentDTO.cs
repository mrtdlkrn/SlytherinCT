using System.ComponentModel;

namespace Entity.DTO.MessageContent
{
    public class AddMessageContentDTO
    {

        [DisplayName("Mesaj Başlığı")]
        public string ContentTitle { get; set; }

        [DisplayName("Mesaj İçeriği")]
        public string ContentText { get; set; }

    }
}
