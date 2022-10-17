using System.ComponentModel;

namespace Entity.DTO.MessageContent
{
    public class AddMessageContentDTO
    {
        [DisplayName("Mesaj İçeriği")]
        public string ContentText { get; set; }

    }
}
