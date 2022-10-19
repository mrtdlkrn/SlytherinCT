using System.ComponentModel;

namespace Entity.DTO.MessageContent
{
    public class ListMessageConentDTO
    {
        [DisplayName("Başlık")]
        public string Title { get; set; }

        [DisplayName("Mesaj İçeriği")]
        public string Content { get; set; }
    }
}
