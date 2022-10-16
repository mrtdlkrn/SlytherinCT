using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.Status
{
    public class AddStatusDTO
    {
        [DisplayName("Statü Adı")]
        public string Name { get; set; }

        [DisplayName("Statü Tipi")]
        public List<string> StatusType { get; set; }
    }
}
