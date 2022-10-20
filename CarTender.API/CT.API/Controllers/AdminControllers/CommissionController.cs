using CarTender.Core.Utilities;
using CT.Entities.DTOs.Commission;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommissionController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListCommissionDTO> commissions = new List<ListCommissionDTO>();
            commissions.Add(new ListCommissionDTO() { CarPlate = "16 E 555", CommissionAmount = 5555, CreatedDate = DateTime.Now });
            commissions.Add(new ListCommissionDTO() { CarPlate = "16 F 555", CommissionAmount = 8522, CreatedDate = DateTime.Now });
            commissions.Add(new ListCommissionDTO() { CarPlate = "16 C 555", CommissionAmount = 4785, CreatedDate = DateTime.Now });
            return Ok(new SuccessDataResult<List<ListCommissionDTO>>(commissions, "Komisyonlar listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateCommissionDTO dto)
        {
            return Ok(new SuccessResult("Komisyon Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateCommissionDTO dto)
        {
            return Ok(new SuccessResult("Komisyon Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Komisyon Silme Başarılı", 200));
        }

        [HttpGet("GetByCarID")]
        public IActionResult GetByCarID (object carID)
        {
            return Ok(new SuccessResult("Araba ID'si İle Komisyon Bilgisi Getirme Başarılı", 200));
        }
    }
}
