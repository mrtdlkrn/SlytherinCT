using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{

    [DisplayName("Deneme")]
    public class DenemeDTO
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Isim")]
        public string Name { get; set; }

        [DisplayName("SoyIsim")]
        public string Surname { get; set; }

        [DisplayName("Yas")]
        public int Age { get; set; }

        [DisplayName("Maas")]
        public int Salary { get; set; }

        [DisplayName("Emekli Mi")]
        public bool IsRetired { get; set; }
    }
}
