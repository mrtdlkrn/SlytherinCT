using CarTender.Core.Utilities;
using CT.Entities.Authorization;
using CT.Entities.DTOs.Package;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<ListPackageDTO> packages = new List<ListPackageDTO>();
            packages.Add(new ListPackageDTO() { Name = "Altın", Capacity=15 });
            packages.Add(new ListPackageDTO() { Name = "Gümüş", Capacity=10 });
            packages.Add(new ListPackageDTO() { Name = "Bronz", Capacity=5 });
            return Ok(new SuccessDataResult<List<ListPackageDTO>>(packages, "Paketler listelendi", 200));
        }

    }
}
