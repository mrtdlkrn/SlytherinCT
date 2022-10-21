using CarTender.Core.Utilities;
using CT.Entities.DTOs.AdvertStatusHistory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertStatusHistoryController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListAdvertStatusHistoryDTO> advertStatusHistories = new List<ListAdvertStatusHistoryDTO>();
            advertStatusHistories.Add(new ListAdvertStatusHistoryDTO() { AdvertTitle = "İlan 1", AdvertStatus = "Yayında", AdvertInfo = "İlan açıklaması 1", EditedBy="Ahmet", EditDate = DateTime.Now });
            advertStatusHistories.Add(new ListAdvertStatusHistoryDTO() { AdvertTitle = "İlan 2", AdvertStatus = "Yayında", AdvertInfo = "İlan açıklaması 2", EditedBy="Ali", EditDate = DateTime.Now });
            advertStatusHistories.Add(new ListAdvertStatusHistoryDTO() { AdvertTitle = "İlan 3", AdvertStatus = "Yayında", AdvertInfo = "İlan açıklaması 3", EditedBy="Veli", EditDate = DateTime.Now });
            advertStatusHistories.Add(new ListAdvertStatusHistoryDTO() { AdvertTitle = "İlan 4", AdvertStatus = "Yayında", AdvertInfo = "İlan açıklaması 4", EditedBy="Mert", EditDate = DateTime.Now });
            advertStatusHistories.Add(new ListAdvertStatusHistoryDTO() { AdvertTitle = "İlan 5", AdvertStatus = "Yayında", AdvertInfo = "İlan açıklaması 5", EditedBy="Sarp", EditDate = DateTime.Now });
            return Ok(new SuccessDataResult<List<ListAdvertStatusHistoryDTO>>(advertStatusHistories, "İlan statü geçmişleri listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateAdvertStatusHistoryDTO dto)
        {
            return Ok(new SuccessResult("İlan Statü Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateAdvertStatusHistoryDTO dto)
        {
            return Ok(new SuccessResult("İlan Statü Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object historyID)
        {
            return Ok(new SuccessResult("İlan Statü Silme Başarılı", 200));
        }

        [HttpGet("GetByID")]
        public IActionResult GetByID(object historyID)
        {
            return Ok(new SuccessResult("Tarihçe Detay Getirme Başarılı", 200));
        }       
    }
}
