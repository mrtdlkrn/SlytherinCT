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

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListNeighborhoodDTO> neighborhoods = new List<ListNeighborhoodDTO>();
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Emirsultan", CityName = "Bursa", TownName = "Karacabey" });
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Saadet", CityName = "Bursa", TownName = "Karacabey" });
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Esentepe", CityName = "Bursa", TownName = "Karacabey" });
            return Ok(new SuccessDataResult<List<ListNeighborhoodDTO>>(neighborhoods, "Mahalleler listelendi", 200));
        }

        [HttpGet("GetByCity")]
        public IActionResult GetByCity(object cityID)
        {
            List<ListNeighborhoodDTO> neighborhoods = new List<ListNeighborhoodDTO>();
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Emirsultan", CityName = "Bursa", TownName = "Karacabey" });
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Saadet", CityName = "Bursa", TownName = "Karacabey" });
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Esentepe", CityName = "Bursa", TownName = "Karacabey" });
            return Ok(new SuccessDataResult<List<ListNeighborhoodDTO>>(neighborhoods, "Mahalleler listelendi", 200));
        }


        [HttpGet("GetByTown")]
        public IActionResult GetByTown(object townID)
        {
            List<ListNeighborhoodDTO> neighborhoods = new List<ListNeighborhoodDTO>();
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Emirsultan", CityName = "Bursa", TownName = "Karacabey" });
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Saadet", CityName = "Bursa", TownName = "Karacabey" });
            neighborhoods.Add(new ListNeighborhoodDTO() { Name = "Esentepe", CityName = "Bursa", TownName = "Karacabey" });
            return Ok(new SuccessDataResult<List<ListNeighborhoodDTO>>(neighborhoods, "Mahalleler listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateNeighborhoodDTO dto)
        {
            return Ok(new SuccessResult("Mahalle Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateNeighborhoodDTO dto)
        {
            return Ok(new SuccessResult("Mahalle Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Mahalle Silme Başarılı", 200));
        }
    }
}
