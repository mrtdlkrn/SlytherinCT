using CarTender.Core.Utilities;
using CT.Entities.DTOs.Tramer;
using CT.Entities.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TramerController : ControllerBase
    {
        #region Tramer

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListTramerDTO> tramers = new List<ListTramerDTO>();
            tramers.Add(new ListTramerDTO() { CarPlate = "16 E 16", TramerFee = 3500, CreatedBy = "Ahmet Sezgin", CreatedDate = DateTime.Now, EditedBy = "", EditedDate = DateTime.MinValue });
            tramers.Add(new ListTramerDTO() { CarPlate = "16 F 16", TramerFee = 3500, CreatedBy = "Ahmet Sezgin", CreatedDate = DateTime.Now, EditedBy = "", EditedDate = DateTime.MinValue });
            return Ok(new SuccessDataResult<List<ListTramerDTO>>(tramers, "Tramerler listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateTramerDTO dto)
        {
            return Ok(new SuccessResult("Tramer Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateTramerDTO dto)
        {
            return Ok(new SuccessResult("Tramer Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Tramer Silme Başarılı", 200));
        }

        #endregion

        #region Tramer Component

        [HttpGet("GetComponents")]
        public IActionResult GetComponents()
        {
            List<ListTramerComponentDTO> tramerComponents = new List<ListTramerComponentDTO>();
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Sağ Arka Çamurluk", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Sağ Ön Çamurluk", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Sağ Arka Kapı", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Sağ Ön Kapı", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Sol Arka Çamurluk", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Sol Ön Çamurluk", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Sağ Arka Kapı", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Sol Ön Kapı", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Tavan", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Arka Kaput", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Motor Kaputu", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Ön Tampon", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            tramerComponents.Add(new ListTramerComponentDTO() { ComponentName = "Arka Tampon", CreatedBy = "Ahmet", CreatedDate = DateTime.Now });
            return Ok(new SuccessDataResult<List<ListTramerComponentDTO>>(tramerComponents, "Tramerler bileşenleri listelendi", 200));
        }

        [HttpPost("CreateComponent")]
        public IActionResult CreateComponent(CreateTramerComponentDTO dto)
        {
            return Ok(new SuccessResult("Tramer Bileşeni Ekleme Başarılı", 200));
        }

        [HttpPost("UpdateComponent")]
        public IActionResult UpdateComponent(UpdateTramerComponentDTO dto)
        {
            return Ok(new SuccessResult("Tramer Bileşeni Güncelleme Başarılı", 200));
        }

        [HttpPost("DeleteComponent")]
        public IActionResult DeleteComponent(object id)
        {
            return Ok(new SuccessResult("Tramer Bileşeni Silme Başarılı", 200));
        }

        #endregion
    }
}
