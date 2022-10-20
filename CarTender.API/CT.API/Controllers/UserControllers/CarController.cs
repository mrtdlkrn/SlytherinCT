using CarTender.Core.Utilities;
using CT.Entities.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CT.API.Controllers.UserControllers
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {



        //Todo: detail bilgileri object id ile cekilecek
        //Todo : dapper baglantisi yapilacak
        [HttpGet("Detail")]
        public IActionResult Detail()
        {
            //Todo : Dapper eklenecek
            CarDTO car = new CarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Corolla",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Burkay",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<CarDTO>(car, "Veri Cekildi", 200);
            return Ok(dataResult);
        }
    }
}
