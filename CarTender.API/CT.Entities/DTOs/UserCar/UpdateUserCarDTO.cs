using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.Entities.DTOs.UserCar
{
    public class UpdateUserCarDTO
    {
        public string UserEmail { get; set; }
        public string CarPlate { get; set; }
    }
}
