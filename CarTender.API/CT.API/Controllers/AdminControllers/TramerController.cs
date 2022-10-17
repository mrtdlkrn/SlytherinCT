using CarTender.Core.Utilities;
using CT.Entities.Authorization;
using CT.Entities.DTOs.Tramer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TramerController : ControllerBase
    {

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<ListTramerDTO> tramers = new List<ListTramerDTO>();
            tramers.Add(new ListTramerDTO() { CarPlate = "16 E 16", TramerFee = 3500, CreatedBy = "Ahmet Sezgin", CreatedDate = DateTime.Now, EditedBy = "",EditedDate=DateTime.MinValue });
            tramers.Add(new ListTramerDTO() { CarPlate = "16 F 16", TramerFee = 3500, CreatedBy = "Ahmet Sezgin", CreatedDate = DateTime.Now, EditedBy = "",EditedDate=DateTime.MinValue });
            return Ok(new SuccessDataResult<List<ListTramerDTO>>(tramers, "Tramerler listelendi", 200));
        }


        [HttpGet("getcomponents")]
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

    }
}
