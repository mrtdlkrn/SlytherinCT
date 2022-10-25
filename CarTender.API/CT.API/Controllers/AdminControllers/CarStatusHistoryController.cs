using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.Entities.DTOs.CarStatusHistory;
using CT.Entities.DTOs.Status;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarStatusHistoryController : ControllerBase
    {
        private readonly ICarStatusHistoryService _carStatusHistoryService;

        public CarStatusHistoryController(ICarStatusHistoryService carStatusHistoryService)
        {
            _carStatusHistoryService = carStatusHistoryService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListCarStatusHistoryDTO> carStatusHistories = new List<ListCarStatusHistoryDTO>();
            carStatusHistories.Add(new ListCarStatusHistoryDTO() { CarPlate = "16 E 555", Status = "Satışta", Info = "Araç satışa çıkartıldı.", CreatedBy = "Ahmet", CreatedDate = DateTime.Now, EditedBy = "", EditedDate = DateTime.MinValue });
            return Ok(new SuccessDataResult<List<ListCarStatusHistoryDTO>>(carStatusHistories, "Statü geçmişi listelendi", 200));
        }


        [HttpGet("GetByCarPlate")]
        public IActionResult GetByCarPlate(string carPlate)
        {
            List<ListCarStatusHistoryDTO> carStatusHistories = new List<ListCarStatusHistoryDTO>();
            carStatusHistories.Add(new ListCarStatusHistoryDTO() { CarPlate = "16 E 555", Status = "Satışta", Info = "Araç satışa çıkartıldı.", CreatedBy = "Ahmet", CreatedDate = DateTime.Now, EditedBy = "", EditedDate = DateTime.MinValue });
            return Ok(new SuccessDataResult<List<ListCarStatusHistoryDTO>>(carStatusHistories, "Statü geçmişi listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateCarStatusHistoryDTO dto)
        {
            return Ok(new SuccessResult("Statü Geçmişi Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateCarStatusHistoryDTO dto)
        {
            return Ok(new SuccessResult("Statü Geçmişi Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Statü Geçmişi Silme Başarılı", 200));
        }

    }
}
