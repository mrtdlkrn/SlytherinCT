using CarTender.Core.Utilities;
using CT.Entities.Car;
using Microsoft.AspNetCore.Mvc;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(new SuccessResult("Resimleri Listeleme Başarılı", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CarImageDTO dto)
        {
            return Ok(new SuccessResult("Resim Ekleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object imageID)
        {
            return Ok(new SuccessResult("Resim Silme Başarılı", 200));
        }

        //[HttpPost("DeleteImageFromCarWithCarID")]
        //public IActionResult DeleteImageFromCarWithCarID(object carID, object imageID)
        //{
        //    return Ok(new SuccessResult("Arabadan Resim Silme Başarılı", 200));
        //}

        //[HttpPost("AddImageToCarWithCarID")]
        //public IActionResult AddImageToCarWithCarID(object carID, object imageID)
        //{
        //    return Ok(new SuccessResult("Arabaya Resim Ekleme Başarılı", 200));
        //}
    }
}
