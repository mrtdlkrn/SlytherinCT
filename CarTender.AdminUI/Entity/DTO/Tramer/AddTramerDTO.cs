using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.Tramer
{
    public class AddTramerDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }
        
        [DisplayName("Ekleyen")]
        public string CreatedBy { get; set; }

        [DisplayName("Ekleme Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
