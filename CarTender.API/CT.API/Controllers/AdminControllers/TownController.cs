using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.Entities.DTOs.Town;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownController : ControllerBase
    {
        private readonly ITownService townService;

        public TownController(ITownService townService)
        {
            this.townService = townService;
        }
        
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            //List<ListTownDTO> towns = new List<ListTownDTO>();
            //towns.Add(new ListTownDTO() { Name = "Karacabey", CityName="Bursa"});
            //towns.Add(new ListTownDTO() { Name = "Mustafa Kemal Paşa", CityName="Bursa"});
            //return Ok(new SuccessDataResult<List<ListTownDTO>>(towns, "İlçeler listelendi", 200));
        
            var result = await townService.GetAll();
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateTownDTO dto)
        {
            return Ok(new SuccessResult("İlçe Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateTownDTO dto)
        {
            return Ok(new SuccessResult("İlçe Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("İlçe Silme Başarılı", 200));
        }

    }
}
