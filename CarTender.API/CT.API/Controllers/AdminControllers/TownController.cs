using CarTender.Core.Utilities;
using CT.Entities.DTOs.Town;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListTownDTO> towns = new List<ListTownDTO>();
            towns.Add(new ListTownDTO() { Name = "Karacabey", CityName="Bursa"});
            towns.Add(new ListTownDTO() { Name = "Mustafa Kemal Paşa", CityName="Bursa"});
            return Ok(new SuccessDataResult<List<ListTownDTO>>(towns, "İlçeler listelendi", 200));
        }

    }
}
