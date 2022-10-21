using Entity.DTO.Brand;
using Entity.DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO.BrandAndModel
{
    public class BrandAndModelDTO
    {
        public AddBrandDTO AddBrand { get; set; }
        public EditBrandDTO EditBrand { get; set; }
        public AddModelDTO AddModel { get; set; }
        public EditModelDTO EditModel { get; set; }
    }
}
