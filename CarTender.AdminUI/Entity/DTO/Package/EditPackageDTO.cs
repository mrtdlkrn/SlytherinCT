﻿using System.ComponentModel;

namespace Entity.DTO.Package
{
    public class EditPackageDTO
    {
        [DisplayName("Paket Adı")]
        public string Name { get; set; }

        //[DisplayName("Kapasite")]
        //public int Capacity { get; set; }
    }
}
