using System;

namespace Entity.DTO.MessageContent
{
    public class MessageContentDTO
    {
        public string ContentText { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan? Version { get; set; }
    }
}
