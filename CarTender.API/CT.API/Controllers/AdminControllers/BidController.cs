using CarTender.Core.Utilities;
using CT.Entities.Bid;
using CT.Entities.DTOs.Bid;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {



        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            //Todo : Dapper eklenecek
            List<ListBidDTO> bidDTOs = new List<ListBidDTO>();
            for (int i = 0; i < 15; i++)
            {
                bidDTOs.Add(new ListBidDTO()
                {
                    BidName = "Mert LTD",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    IsApproved = true,
                    IsCorporate = true,


                });
            }
            var dataResult = new SuccessDataResult<List<ListBidDTO>>(bidDTOs, "Data Added", 200);

            return Ok(dataResult);
        }

        [HttpPost("GetAllByQuery")]
        public IActionResult GetAllByQuery(BidQuerryDTO dto)
        {
            // Todo : dapper eklenecek bidquerrydto icinde gelen verilere gore sorgu yapilacak
            List<ListBidDTO> bidDTOs = new List<ListBidDTO>();

            for (int i = 0; i < 15; i++)
            {
                bidDTOs.Add(new ListBidDTO()
                {
                    BidName = "Slytherin Sirketi",
                    IsActive = true,
                    CreatedDate = DateTime.Now.AddDays(-5),
                    IsApproved = true,
                    IsCorporate = true,
                    FinishedDate = DateTime.Now,
                    UserID = new Guid(),

                });
            }
            var dataResult = new SuccessDataResult<List<ListBidDTO>>(bidDTOs, "Data Searched", 200);

            return Ok(dataResult);
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateModelDTO dto)
        {
            return Ok(new SuccessResult("İhale Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateBidDTO dto)
        {
            return Ok(new SuccessResult("İhale Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object bidID)
        {
            return Ok(new SuccessResult("İhale Silme Başarılı", 200));
        }

        [HttpGet("GetByID")]
        public IActionResult GetByID(object bidID)
        {
            return Ok(new SuccessResult("İhale Silme Başarılı", 200));
        }
    }
}
