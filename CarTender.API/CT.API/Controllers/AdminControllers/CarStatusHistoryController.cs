using CarTender.Core.Utilities;
using CT.Entities.DTOs.CarStatusHistory;
using CT.Entities.DTOs.Town;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarStatusHistoryController : ControllerBase
    {

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<ListCarStatusHistoryDTO> carStatusHistories = new List<ListCarStatusHistoryDTO>();
            carStatusHistories.Add(new ListCarStatusHistoryDTO() {CarPlate = "16 E 555", Status="Satışta",Info="Araç satışa çıkartıldı.",CreatedBy="Ahmet",CreatedDate=DateTime.Now, EditedBy="",EditedDate=DateTime.MinValue});
            return Ok(new SuccessDataResult<List<ListCarStatusHistoryDTO>>(carStatusHistories, "Statü geçmişi listelendi", 200));
        }


        [HttpGet("getByCarPlate")]
        public IActionResult GetByCarPlate(string carPlate)
        {
            List<ListCarStatusHistoryDTO> carStatusHistories = new List<ListCarStatusHistoryDTO>();
            carStatusHistories.Add(new ListCarStatusHistoryDTO() { CarPlate = "16 E 555", Status = "Satışta", Info = "Araç satışa çıkartıldı.", CreatedBy = "Ahmet", CreatedDate = DateTime.Now, EditedBy = "", EditedDate = DateTime.MinValue });
            return Ok(new SuccessDataResult<List<ListCarStatusHistoryDTO>>(carStatusHistories, "Statü geçmişi listelendi", 200));
        }

    }
}
