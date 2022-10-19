using CarTender.Core.Utilities;
using CT.Entities.DTOs.CarSaleHistory;
using CT.Entities.DTOs.CarStatusHistory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarSaleHistoryController : ControllerBase
    {

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListCarSaleHistoryDTO> carSaleHistories = new List<ListCarSaleHistoryDTO>();
            carSaleHistories.Add(new ListCarSaleHistoryDTO() {CarPlate="16 E 555", SellerName="Ahmet Sezgin", BuyerName = "Mert Dalkıran",Price=180000, Commission=8000, SaleDate = DateTime.Now });
            carSaleHistories.Add(new ListCarSaleHistoryDTO() {CarPlate="16 F 555", SellerName="Ahmet Sezgin", BuyerName = "Sarp İpkçi",Price=180000, Commission=8000, SaleDate = DateTime.Now });
            carSaleHistories.Add(new ListCarSaleHistoryDTO() {CarPlate="16 G 555", SellerName="Ahmet Sezgin", BuyerName = "Emine Baltacı",Price=180000, Commission=8000, SaleDate = DateTime.Now });
            carSaleHistories.Add(new ListCarSaleHistoryDTO() {CarPlate="16 J 555", SellerName="Ahmet Sezgin", BuyerName = "Yiğit Kaygısız",Price=180000, Commission=8000, SaleDate = DateTime.Now });
            return Ok(new SuccessDataResult<List<ListCarSaleHistoryDTO>>(carSaleHistories, "Araç satışları listelendi", 200));
        }


        [HttpGet("GetByUserName")]
        public IActionResult GetByUserName(string username)
        {
            List<ListCarSaleHistoryDTO> carSaleHistories = new List<ListCarSaleHistoryDTO>();
            carSaleHistories.Add(new ListCarSaleHistoryDTO() { CarPlate = "16 E 555", SellerName = "Ahmet Sezgin", BuyerName = "Mert Dalkıran", Price = 180000, Commission = 8000, SaleDate = DateTime.Now });
            carSaleHistories.Add(new ListCarSaleHistoryDTO() { CarPlate = "16 F 555", SellerName = "Ahmet Sezgin", BuyerName = "Sarp İpkçi", Price = 180000, Commission = 8000, SaleDate = DateTime.Now });
            carSaleHistories.Add(new ListCarSaleHistoryDTO() { CarPlate = "16 G 555", SellerName = "Ahmet Sezgin", BuyerName = "Emine Baltacı", Price = 180000, Commission = 8000, SaleDate = DateTime.Now });
            carSaleHistories.Add(new ListCarSaleHistoryDTO() { CarPlate = "16 J 555", SellerName = "Ahmet Sezgin", BuyerName = "Yiğit Kaygısız", Price = 180000, Commission = 8000, SaleDate = DateTime.Now });
            return Ok(new SuccessDataResult<List<ListCarSaleHistoryDTO>>(carSaleHistories, "Araç satışları listelendi", 200));
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateCarSaleHistoryDTO dto)
        {
            return Ok(new SuccessResult("Araç Satışı Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateCarSaleHistoryDTO dto)
        {
            return Ok(new SuccessResult("Araç Satışı Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Araç Satışı Silme Başarılı", 200));
        }
    }
}
