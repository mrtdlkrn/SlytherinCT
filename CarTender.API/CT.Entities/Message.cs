using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }


        public string MessageContent { get; set; }

        public string EMail { get; set; }

        public int UserID { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
