using CarTender.Core.Utilities;
using CT.Entities.DTOs.Message;
using CT.Entities.DTOs.MessageContent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageContentController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListMessageContentDTO> messageContents = new List<ListMessageContentDTO>();
            messageContents.Add(new ListMessageContentDTO() { Title = "Favori İlan Silindi  Uyarısı", Content = "Değerli kullanıcımız favoriye eklediğiniz ilan kaldırıldı." });
            messageContents.Add(new ListMessageContentDTO() { Title = "Favori İlan Fiyat Azaldı Uyarısı", Content = "Değerli kullanıcımız favoriye eklediğiniz ilanın fiyatı azaldı." });
            messageContents.Add(new ListMessageContentDTO() { Title = "Favori İlan Fiyat Arttı Uyarısı", Content = "Değerli kullanıcımız favoriye eklediğiniz ilanın fiyatı arttı." });
            return Ok(new SuccessDataResult<List<ListMessageContentDTO>>(messageContents, "Mesaj içerikleri listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateMessageContentDTO dto)
        {
            return Ok(new SuccessResult("Mesaj İçeriği Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateMessageContentDTO dto)
        {
            return Ok(new SuccessResult("Mesaj İçeriği Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Mesaj İçeriği Silme Başarılı", 200));
        }
    }
}
