﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DTO.AdminDTO.User
{
    public class AdminUserDTO
    {
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Information { get; set; }
    }
}
