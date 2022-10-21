using CarTender.Core.Utilities;
using CT.Entities.DTOs.Message;
using CT.Entities.DTOs.MessageContent;
using CT.Entities.DTOs.Town;
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


        [HttpGet("GetByUserID")]
        public IActionResult GetByUserID(object userID)
        {
            List<ListMessageDTO> messages = new List<ListMessageDTO>();
            messages.Add(new ListMessageDTO() { MessageContentTitle = "Favori İlan Silindi Uyarısı", UserName = "Ahmetosmn", CreatedDate = DateTime.Now });
            messages.Add(new ListMessageDTO() { MessageContentTitle = "Favori İlan Silindi Uyarısı", UserName = "velizngn", CreatedDate = DateTime.Now });
            return Ok(new SuccessDataResult<List<ListMessageDTO>>(messages, "Mesajlar listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateMessageDTO dto)
        {
            return Ok(new SuccessResult("Mesaj Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateMessageDTO dto)
        {
            return Ok(new SuccessResult("Mesaj Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Mesaj Silme Başarılı", 200));
        }
    }
}
