using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.Entities.DTOs.Advert;
using CT.Entities.DTOs.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly IAdvertService _advertService;

        public AdvertController(IAdvertService advertService)
        {
            _advertService = advertService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListAdvertDTO> adverts = new List<ListAdvertDTO>();
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 E 555", CarBrand= "Ford", CarModel = "Connect", Title = "İlan 1", PrePrice = 150000, Price = 165000, Info = "İlk sahibinden temiz araç" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 T 555", CarBrand= "Ford", CarModel = "Mustang", Title = "İlan 2", PrePrice = 850000, Price = 865000, Info = "İlk sahibinden temiz araç" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 G 555", CarBrand= "Ford", CarModel = "Ranger", Title = "İlan 3", PrePrice = 650000, Price = 665000, Info = "İlk sahibinden temiz araç" });
            return Ok(new SuccessDataResult<List<ListAdvertDTO>>(adverts, "İlanlar listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateAdvertDTO dto)
        {
            return Ok(new SuccessResult("İlan Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateAdvertDTO dto)
        {
            return Ok(new SuccessResult("İlan Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object advertID)
        {
            return Ok(new SuccessResult("İlan Silme Başarılı", 200));
        }

        [HttpGet("GetByID")]
        public IActionResult GetByID(object advertID)
        {
            return Ok(new SuccessResult("İlan Detay Getirme Başarılı", 200));
        }

        // plaka ile de olabilir.

        [HttpGet("GetByCarID")]
        public IActionResult GetByCarID(object carID)
        {
            return Ok(new SuccessResult("Araç ID ile Tarihçe Detay Getirme Başarılı", 200));
        }
    }
}
