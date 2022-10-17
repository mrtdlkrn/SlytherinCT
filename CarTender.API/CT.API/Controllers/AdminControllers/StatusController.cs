using CarTender.Core.Utilities;
using CT.Entities.Authorization;
using CT.Entities.DTOs.Status;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListStatusDTO> statuses = new List<ListStatusDTO>();
            statuses.Add(new ListStatusDTO() { Name = "Giriş", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Hemen Al Satışta", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "İhalede", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Satış komisyonu tahsil edildi", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu bekleniyor", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu alındı", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Satıldı", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Satış İptal", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "hede", Type = "İhale Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "bidi", Type = "İhale Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "büdü", Type = "İhale Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "hüdü", Type = "İhale Statüsü" });          
            return Ok(new SuccessDataResult<List<ListStatusDTO>>(statuses, "Statüler listelendi", 200));
        }

        [HttpGet("GetByType")]
        public IActionResult GetByType(string type)
        {
            List<ListStatusDTO> statuses = new List<ListStatusDTO>();
            statuses.Add(new ListStatusDTO() { Name = "Giriş",Type="Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Hemen Al Satışta", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "İhalede", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Satış komisyonu tahsil edildi", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu bekleniyor", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu alındı", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Satıldı", Type = "Araç Statüsü" });
            statuses.Add(new ListStatusDTO() { Name = "Satış İptal", Type = "Araç Statüsü" });
            return Ok(new SuccessDataResult<List<ListStatusDTO>>(statuses, "Statüler filtreye göre listelendi", 200));
        }

    }
}
