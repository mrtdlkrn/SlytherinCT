using CarTender.Core.Utilities;
using CT.Entities.DTOs.Neighborhood;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighborhoodController : ControllerBase
    {

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<ListNeighborhoodDTO> neighborhoods = new List<ListNeighborhoodDTO>();
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Emirsultan", CityName = "Bursa", TownName = "Karacabey" });
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Saadet", CityName = "Bursa", TownName = "Karacabey" });
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Esentepe", CityName = "Bursa", TownName = "Karacabey" });
            return Ok(new SuccessDataResult<List<ListNeighborhoodDTO>>(neighborhoods, "Mahalleler listelendi", 200));
        }

    }
}
