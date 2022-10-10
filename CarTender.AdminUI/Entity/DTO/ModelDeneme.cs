using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class ModelDeneme
    {
        public int ID { get; set; }

        [DisplayName("Burkay")]
        public string IsimAlani { get; set; }

        public DateTime Tarih { get; set; }

        public List<string> stringler { get; set; }

        public bool OnayliMi { get; set; }
    }
}
