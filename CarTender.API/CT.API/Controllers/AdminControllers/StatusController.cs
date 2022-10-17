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

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<ListStatusDTO> statuses = new List<ListStatusDTO>();
            statuses.Add(new ListStatusDTO() { Name = "Giriş"});
            statuses.Add(new ListStatusDTO() { Name = "Hemen Al Satışta"});
            statuses.Add(new ListStatusDTO() { Name = "İhalede"});
            statuses.Add(new ListStatusDTO() { Name = "Satış komisyonu tahsil edildi"});
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu bekleniyor" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu alındı" });
            statuses.Add(new ListStatusDTO() { Name = "Satıldı" });
            statuses.Add(new ListStatusDTO() { Name = "Satış İptal" });
            statuses.Add(new ListStatusDTO() { Name = "Giriş"});
            statuses.Add(new ListStatusDTO() { Name = "Hemen Al Satışta"});
            statuses.Add(new ListStatusDTO() { Name = "İhalede"});
            statuses.Add(new ListStatusDTO() { Name = "Satış komisyonu tahsil edildi"});
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu bekleniyor" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu alındı" });
            statuses.Add(new ListStatusDTO() { Name = "Satıldı" });
            statuses.Add(new ListStatusDTO() { Name = "Satış İptal" });
            statuses.Add(new ListStatusDTO() { Name = "Giriş"});
            statuses.Add(new ListStatusDTO() { Name = "Hemen Al Satışta"});
            statuses.Add(new ListStatusDTO() { Name = "İhalede"});
            statuses.Add(new ListStatusDTO() { Name = "Satış komisyonu tahsil edildi"});
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu bekleniyor" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu alındı" });
            statuses.Add(new ListStatusDTO() { Name = "Satıldı" });
            statuses.Add(new ListStatusDTO() { Name = "Satış İptal" });
            statuses.Add(new ListStatusDTO() { Name = "Giriş"});
            statuses.Add(new ListStatusDTO() { Name = "Hemen Al Satışta"});
            statuses.Add(new ListStatusDTO() { Name = "İhalede"});
            statuses.Add(new ListStatusDTO() { Name = "Satış komisyonu tahsil edildi"});
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu bekleniyor" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu alındı" });
            statuses.Add(new ListStatusDTO() { Name = "Satıldı" });
            statuses.Add(new ListStatusDTO() { Name = "Satış İptal" });
            return Ok(new SuccessDataResult<List<ListStatusDTO>>(statuses, "Statüler listelendi", 200));
        }

        [HttpGet("getByType")]
        public IActionResult GetByType(string type)
        {
            List<ListStatusDTO> statuses = new List<ListStatusDTO>();
            statuses.Add(new ListStatusDTO() { Name = "Giriş" });
            statuses.Add(new ListStatusDTO() { Name = "Hemen Al Satışta" });
            statuses.Add(new ListStatusDTO() { Name = "İhalede" });
            statuses.Add(new ListStatusDTO() { Name = "Satış komisyonu tahsil edildi" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu bekleniyor" });
            statuses.Add(new ListStatusDTO() { Name = "Ekspertiz sonucu alındı" });
            statuses.Add(new ListStatusDTO() { Name = "Satıldı" });
            statuses.Add(new ListStatusDTO() { Name = "Satış İptal" });
            return Ok(new SuccessDataResult<List<ListStatusDTO>>(statuses, "Statüler filtreye göre listelendi", 200));
        }

    }
}
