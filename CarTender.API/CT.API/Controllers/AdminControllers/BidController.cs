using CarTender.Core.Utilities;
using CT.API.Models.DTOs.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            List<CarDTO> carDTOs = new List<CarDTO>();
            for (int i = 0; i < 10; i++)
            {
                carDTOs.Add(new CarDTO()
                {
                    CarBrand = "Toyota",
                    CarModel = "Verso",
                    IsCorporate = false,
                    Status = "Beklemede",
                    CreatedBy = "Mert",
                    CreatedDate = System.DateTime.Now,
                    Price = 1000000
                });
            }
            var dataResult = new SuccessDataResult<List<CarDTO>>(carDTOs, "Data Eklendi");

            return Ok(dataResult);
        }
    }
}
