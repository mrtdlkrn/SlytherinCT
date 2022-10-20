using CarTender.Core.Utilities;
using CT.Entities.Bid;
using CT.Entities.Car;
using CT.Entities.DTOs.Car;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET: CarController

        #region Car

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            //Todo : Dapper eklenecek
            List<ListCarDTO> carDTOs = new List<ListCarDTO>();
            for (int i = 0; i < 10; i++)
            {
                carDTOs.Add(new ListCarDTO()
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
            var dataResult = new SuccessDataResult<List<ListCarDTO>>(carDTOs, "Data Eklendi", 200);

            return Ok(dataResult);
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateCarDTO dto)
        {
            return Ok(new SuccessResult("Araba Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateCarDTO dto)
        {
            return Ok(new SuccessResult("Araba Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object carID)
        {
            return Ok(new SuccessResult("Araba Silme Başarılı", 200));
        }

        [HttpGet("GetByID")]
        public IActionResult GetByID(object carID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByPlate")]
        public IActionResult GetByPlate(string carPlate)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByBrand")]
        public IActionResult GetByBrand(string brand)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByModel")]
        public IActionResult GetByModel(string model)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByAdvert")]
        public IActionResult GetByAdvert(object advertID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByBid")]
        public IActionResult GetByBid(object bidID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByUser")]
        public IActionResult GetByUser(object userID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetImages")]
        public IActionResult GetImages(object carID)
        {
            //Todo : Dapper eklenecek
            CarImageDTO data = new CarImageDTO();
            var dataResult = new SuccessDataResult<CarImageDTO>(data, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        #endregion

        [HttpGet("CarModification")]
        public IActionResult CarModification(object dto)
        {
            //Todo : Dapper eklenecek
            CarModificationDTO data = new CarModificationDTO();
            var dataResult = new SuccessDataResult<CarModificationDTO>(data, "Data Eklendi", 200);
            return Ok(dataResult);
        }
       

        [HttpGet("CarBuyerInformation")]
        public IActionResult CarBuyerInformation(object dto)
        {
            //Todo : Dapper eklenecek
            CarBuyerDTO data = new CarBuyerDTO();
            var dataResult = new SuccessDataResult<CarBuyerDTO>(data, "Data Eklendi",200);
            return Ok(dataResult);
        }
    }
}
