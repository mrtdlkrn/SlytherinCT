using System;
using System.ComponentModel;

namespace Entity.DTO.Message
{
    public class ListMessageDTO
    {
        [DisplayName("Mesaj İçeriği Başlığı")]
        public string MessageContentTitle { get; set; }

        [DisplayName("Alıcı")]
        public string UserName { get; set; }

        [DisplayName("Gönderilme Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
