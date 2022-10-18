using CarTender.Core.Utilities;
using CT.Entities.DTOs.Advert;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListAdvertDTO> adverts = new List<ListAdvertDTO>();
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 E 555", CarBrand= "Ford", CarModel = "Connect", Title = "İlan 1", PrePrice = 150000, Price = 165000, Info = "İlk sahibinden temiz araç" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 T 555", CarBrand= "Ford", CarModel = "Mustang", Title = "İlan 2", PrePrice = 850000, Price = 865000, Info = "İlk sahibinden temiz araç" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 G 555", CarBrand= "Ford", CarModel = "Ranger", Title = "İlan 3", PrePrice = 650000, Price = 665000, Info = "İlk sahibinden temiz araç" });
            return Ok(new SuccessDataResult<List<ListAdvertDTO>>(adverts, "İlanlar listelendi", 200));
        }

    }
}
