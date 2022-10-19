using CarTender.Core.Utilities;
using CT.Entities.DTOs.Expertise;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpertiseController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListExpertiseDTO> expertises = new List<ListExpertiseDTO>();
            expertises.Add(new ListExpertiseDTO() { Name = "szgn", City = "Bursa", Town = "Karacabey", Neighborhood = "Emirsultan", Latitude = 55, Longitude = 80 });
            expertises.Add(new ListExpertiseDTO() { Name = "altn", City = "Bursa", Town = "Karacabey", Neighborhood = "Uluabat", Latitude = 60, Longitude = 78 });
            return Ok(new SuccessDataResult<List<ListExpertiseDTO>>(expertises, "Ekspertizler listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateExpertiseDTO dto)
        {
            return Ok(new SuccessResult("Ekspertiz Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateExpertiseDTO dto)
        {
            return Ok(new SuccessResult("Ekspertiz Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Ekspertiz Silme Başarılı", 200));
        }
    }
}
