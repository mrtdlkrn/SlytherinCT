using Business.Abstract;
using CarTender.FluentValidation.DTO.AdminDTO.Car;
using CarTender.FluentValidation.DTO.CombineDTO.Car;
using CarTender.FluentValidation.VAL.CombineVAL.Car;
using CT.AdminUI.Models.ModalDTOs;
using Entity.DTO.Auth;
using Entity.DTO.Brand;
using Entity.DTO.BrandAndModel;
using Entity.DTO.Car;
using Entity.DTO.CarBuyerInformation;
using Entity.DTO.Model;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IApiService _apiService;
        private readonly IDictionary<string, string> _routes;
        List<ListCarDTO> cars = new List<ListCarDTO>();

        public CarController(IApiService apiService, IApiRoutes routes)
        {
            _apiService = apiService;
            cars.Add(new ListCarDTO() { Price = 56345, Plate = "16 r 123", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now });
            cars.Add(new ListCarDTO() { Price = 363234, Plate = "12 y 155", CarBrand = "Ford", CarModel = "Fiesta", CreatedDate = DateTime.Now.AddDays(2) });
            cars.Add(new ListCarDTO() { Price = 12356, Plate = "14 e 66", CarBrand = "Opel", CarModel = "Astra", CreatedDate = DateTime.Now.AddDays(-2) });
            cars.Add(new ListCarDTO() { Price = 685342, Plate = "11 x 54", CarBrand = "Volkswagen", CarModel = "Golf", CreatedDate = DateTime.Now.AddDays(23) });
            cars.Add(new ListCarDTO() { Price = 64353, Plate = "44 h 244", CarBrand = "Volkswagen", CarModel = "Golf", CreatedDate = DateTime.Now.AddDays(-3) });
            cars.Add(new ListCarDTO() { Price = 456234, Plate = "22 j 53", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(-11) });
            cars.Add(new ListCarDTO() { Price = 234234, Plate = "42 kl 22", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(-24) });
            cars.Add(new ListCarDTO() { Price = 453421, Plate = "55 ko 12", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new ListCarDTO() { Price = 123412, Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            _routes = routes.GetApiRoutes("Car");
        }


        //Araç listesi ekranı       
        public IActionResult Index()
        {


            /*var CarListDTO = new ListCarDTO();
            var result = await _apiService.Post(_routes["Index"], CarListDTO);
            //todo : sayfaya veriler basılacak*/

            return View(cars);
        }


        [HttpGet]
        public IActionResult Add()
        {
            _apiService.Test("aaaa");
            return View(new AddCarDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCarDTO dto)
        {
            //todo PhotoPathler DTO lar içerisine gelmiyor.
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
            ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
            ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            dto.PhotoPath1 = "hede";
            dto.PhotoPath2 = "hede";
            dto.PhotoPath3 = "hede";
            dto.PhotoPath4 = "hede";
            dto.PhotoPath5 = "hede";

            CombineAddOrEditVehicleVAL validations = new CombineAddOrEditVehicleVAL();
            ValidationResult validationResult = validations.Validate(new CombineAddOrEditVehicleDTO
            {
                Price = (int)dto.Price,
                KM = dto.KM,
                Explanation = dto.Explanation,
                PhotoPath1 = dto.PhotoPath1,
                PhotoPath2 = dto.PhotoPath2,
                PhotoPath3 = dto.PhotoPath3,
                PhotoPath4 = dto.PhotoPath4,
                PhotoPath5 = dto.PhotoPath5

            });

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                TempData["CarPrice"] = dto.Price;
                TempData["KM"] = dto.KM;
                TempData["Information"] = dto.Explanation;

                return View("Add", dto);
            }
            var result = await _apiService.Post(tokenDTO, _routes["Create"], dto);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View(new UpdateCarDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateCarDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
            ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
            ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };

            dto.PhotoPath1 = "hede";
            dto.PhotoPath2 = "hede";
            dto.PhotoPath3 = "hede";
            dto.PhotoPath4 = "hede";
            dto.PhotoPath5 = "hede";

            CombineAddOrEditVehicleVAL validations = new CombineAddOrEditVehicleVAL();
            ValidationResult validationResult = validations.Validate(new CombineAddOrEditVehicleDTO
            {

                Price = (int)dto.Price,
                KM = dto.KM,
                Explanation = dto.Explanation,
                PhotoPath1 = dto.PhotoPath1,
                PhotoPath2 = dto.PhotoPath2,
                PhotoPath3 = dto.PhotoPath3,
                PhotoPath4 = dto.PhotoPath4,
                PhotoPath5 = dto.PhotoPath5

            });

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                TempData["CarPrice"] = dto.Price;
                TempData["KM"] = dto.KM;
                TempData["Information"] = dto.Explanation;

                return View("Edit", dto);
            }

            var result = await _apiService.Post(tokenDTO, _routes["Update"], dto);
            return RedirectToAction("Index");
        }

        // Brand Model 
        [HttpGet]
        public IActionResult BrandModel()
        {

            //TokenDTO tokenDTO = new TokenDTO();
            //var result = await _apiService.Get<ListBrandModelDTO>(tokenDTO, _routes["BrandModel"]);
            //todo : sayfaya veriler basılacak

            return View(new BrandAndModelDTO
            {
                AddBrand = new AddBrandDTO()
            });
        }

        [HttpPost]
        public IActionResult BrandModel(AddBrandDTO dto)
        {
            BrandVAL validations = new BrandVAL();
            ValidationResult validationResult = validations.Validate(new CarBrandDTO
            {
                VehicleBrand = dto.Name,
            });
            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                return View("BrandModel", dto);
            }
            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> AddBrand(BrandAndModelDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
            ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
            ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            BrandVAL validations = new BrandVAL();
            ValidationResult validationResult = validations.Validate(new CarBrandDTO
            {
                VehicleBrand = dto.AddBrand.Name,
            });
            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                return View("BrandModel", dto);
            }
            //var result = await _apiService.Post(tokenDTO, _routes["AddBrand"], dto);
            return RedirectToAction("BrandModel");
        }
        [HttpPost]
        public async Task<IActionResult> EditBrand(EditBrandDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
            ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
            ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };

            //var result = await _apiService.Post(tokenDTO, _routes["EditBrand"], dto);
            return RedirectToAction("BrandModel");
        }
        [HttpPost]
        public async Task<IActionResult> AddModel(AddModelDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
            ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
            ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            //var result = await _apiService.Post(tokenDTO, _routes["AddModel"], dto);
            return RedirectToAction("BrandModel");
        }
        [HttpPost]
        public async Task<IActionResult> EditModel(EditModelDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
            ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
            ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            //var result = await _apiService.Post(tokenDTO, _routes["EditModel"], dto);
            return RedirectToAction("BrandModel");
        }

        //[HttpGet("Detail/{id}")]
        public async Task<IActionResult> Detail(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<ListCarDTO>(tokenDTO, _routes["Detail"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Image
        //[HttpGet("CarImage/{id}")]
        public async Task<IActionResult> CarImage(string plate)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarImage"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Modification
        //[HttpGet("CarModification/{id}")]
        public async Task<IActionResult> CarModification(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarModification"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Buyer Information
        //[HttpGet("CarBuyerInformation/{id}")]
        [HttpGet]
        public async Task<IActionResult> CarBuyerInformation(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarBuyerInformation"]);
            //todo : sayfaya veriler basılacak
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCarBuyerInformation(AddCarBuyerInformationDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarBuyerInformation"]);
            //todo : sayfaya veriler basılacak
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditCarBuyerInformation(EditCarBuyerInformationDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarBuyerInformation"]);
            //todo : sayfaya veriler basılacak
            return View();
        }
    }
}
