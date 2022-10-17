using Entity.DTO.TramerComponent;
using System.Collections.Generic;

namespace Entity.DTO.Tramer
{
    public class TramerViewDTO
    {
        public List<ListTramerDTO> Tramers { get; set; }
        public List<ListTramerComponentDTO> TramerComponents { get; set; }
    }
}
