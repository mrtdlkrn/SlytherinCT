using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.CorporatePackage
{
    public class AddCorporatePackageDTO
    {
        [DisplayName("Şirket Adı")]
        public Guid CorporateID{ get; set; }

        [DisplayName("Paket Adı")]
        public Guid PackageID { get; set; }
    }
}
