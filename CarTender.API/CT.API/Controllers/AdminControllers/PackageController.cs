using CarTender.Core.Utilities;
using CT.Entities.DTOs.Package;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListPackageDTO> packages = new List<ListPackageDTO>();
            packages.Add(new ListPackageDTO() { Name = "Altın", Capacity = 15 });
            packages.Add(new ListPackageDTO() { Name = "Gümüş", Capacity = 10 });
            packages.Add(new ListPackageDTO() { Name = "Bronz", Capacity = 5 });
            return Ok(new SuccessDataResult<List<ListPackageDTO>>(packages, "Paketler listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreatePackageDTO dto)
        {
            return Ok(new SuccessResult("Paket Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdatePackageDTO dto)
        {
            return Ok(new SuccessResult("Paket Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Paket Silme Başarılı", 200));
        }
    }
}
