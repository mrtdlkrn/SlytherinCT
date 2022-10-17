using CarTender.Core.Utilities;
using Entity.DTO.Bid;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        [HttpGet("Index")]
        public IActionResult Index(object dto)
        {
            //Todo : Dapper eklenecek
            List<BidInformationDTO> bidDTOs = new List<BidInformationDTO>();
            for (int i = 0; i < 10; i++)
            {
                bidDTOs.Add(new BidInformationDTO()
                {
                    BidName ="Mert LTD",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    IsApproved = true,
                    IsCorporate = true,                    
                });
            }
            var dataResult = new SuccessDataResult<List<BidInformationDTO>>(bidDTOs, "Data Added");

            return Ok(dataResult);
        }

        [HttpPost("Create")]
        public IActionResult Create(object dto)
        {
            //Todo : Dapper eklenecek
            var dataResult = new SuccessResult("Data Added");
            return Ok(dataResult);
        }

        [HttpPost("Update")]
        public IActionResult Update(object dto)
        {
            //Todo : Dapper eklenecek
            var dataResult = new SuccessResult("Date Updated");
            return Ok(dataResult);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object dto)
        {
            //Todo : Dapper eklenecek
            var dataResult = new SuccessResult("Data Deleted");
            return Ok(dataResult);
        }

    }
}
