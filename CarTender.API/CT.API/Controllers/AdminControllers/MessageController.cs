using CarTender.Core.Utilities;
using CT.Entities.DTOs.Message;
using CT.Entities.DTOs.MessageContent;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListMessageDTO> messages = new List<ListMessageDTO>();
            messages.Add(new ListMessageDTO() { MessageContentTitle = "Favori İlan Silindi Uyarısı", UserName = "Ahmetosmn", CreatedDate = DateTime.Now });
            messages.Add(new ListMessageDTO() { MessageContentTitle = "Favori İlan Silindi Uyarısı", UserName = "velizngn", CreatedDate = DateTime.Now });
            return Ok(new SuccessDataResult<List<ListMessageDTO>>(messages, "Mesajlar listelendi", 200));
        }       
    }
}
