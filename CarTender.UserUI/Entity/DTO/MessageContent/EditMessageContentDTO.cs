using System.ComponentModel;

namespace Entity.DTO.MessageContent
{
    public class EditMessageContentDTO
    {
        [DisplayName("Mesaj İçeriği")]
        public string ContentText { get; set; }
    }
}
