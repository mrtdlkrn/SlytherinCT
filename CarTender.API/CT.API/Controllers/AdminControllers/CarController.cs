using CarTender.Core.Utilities;
using CT.API.Models.DTOs.Car;
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
            var dataResult = new SuccessDataResult<List<CarDTO>>(carDTOs, "Data Eklendi", 200);

            return Ok(dataResult);
        }

        [HttpPost("Create")]
        public IActionResult Create(object dto)
        {
            //Todo : Dapper eklenecek
            var dataResult = new SuccessResult("Ekleme Başarılı", 200);
            return Ok(dataResult);
        }

        [HttpPost("Update")]
        public IActionResult Update(object dto)
        {
            //Todo : Dapper eklenecek
            var dataResult = new SuccessResult("Güncelleme Başarılı", 200);
            return Ok(dataResult);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object dto)
        {
            //Todo : Dapper eklenecek
            var dataResult = new SuccessResult("Silme Başarılı",200);
            return Ok(dataResult);
        }

        [HttpGet("BrandModel")]
        public IActionResult BrandModel(object dto)
        {
            BrandModelDTO data = new BrandModelDTO();
            //Todo : Dapper eklenecek
            var dataResult = new SuccessDataResult<BrandModelDTO>(data, "Data Eklendi",200);
            return Ok(dataResult);
        }

        [HttpGet("Detail")]
        public IActionResult Detail(object dto)
        {
            //Todo : Dapper eklenecek
            CarDTO car = new CarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<CarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("CarDetail")]
        public IActionResult CarDetail(object dto)
        {
            //Todo : Dapper eklenecek
            CarDetailDTO data = new CarDetailDTO();
            var dataResult = new SuccessDataResult<CarDetailDTO>(data, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("CarImage")]
        public IActionResult CarImage(object dto)
        {
            //Todo : Dapper eklenecek
            CarImageDTO data = new CarImageDTO();
            var dataResult = new SuccessDataResult<CarImageDTO>(data, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("CarModification")]
        public IActionResult CarModification(object dto)
        {
            //Todo : Dapper eklenecek
            CarModificationDTO data = new CarModificationDTO();
            var dataResult = new SuccessDataResult<CarModificationDTO>(data, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("CarCommission")]
        public IActionResult CarCommission(object dto)
        {
            //Todo : Dapper eklenecek
            List<CarCommissionDTO> data = new List<CarCommissionDTO>();
            data.Add(new CarCommissionDTO()
            {
                Price = 45000,
                MinPrice = 20000,
                MaxPrice = 50000,
                Information = "Ödenmedi",
                StartDate = DateTime.Today,
                FinishDate = DateTime.Now
            });
            data.Add(new CarCommissionDTO()
            {
                Price = 45000,
                MinPrice = 20000,
                MaxPrice = 50000,
                Information = "Ödenmedi",
                StartDate = DateTime.Today,
                FinishDate = DateTime.Now
            });
            var dataResult = new SuccessDataResult<List<CarCommissionDTO>>(data, "Data Eklendi",200);
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
