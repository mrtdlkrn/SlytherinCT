using Business.Abstract;
using Common.Abstract;
using Entity.DTO;
using Entity.DTO.Pagination;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.AspNetCore;
using CarTender.FluentValidation.DAL.CombineDAL.Car;
using CarTender.FluentValidation.DTO.CombineDTO.Car;

namespace CT.AdminUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IApiService _apiService;
        List<CarListDTO> cars = new List<CarListDTO>();

        public CarController(IApiService apiService)
        {
            _apiService = apiService;
            cars.Add(new CarListDTO() { Plate = "16 r 123", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now });
            cars.Add(new CarListDTO() { Plate = "12 y 155", CarBrand = "Ford", CarModel = "Fiesta", CreatedDate = DateTime.Now.AddDays(2) });
            cars.Add(new CarListDTO() { Plate = "14 e 66", CarBrand = "Opel", CarModel = "Astra", CreatedDate = DateTime.Now.AddDays(-2) });
            cars.Add(new CarListDTO() { Plate = "11 x 54", CarBrand = "Volkswagen", CarModel = "Golf", CreatedDate = DateTime.Now.AddDays(23) });
            cars.Add(new CarListDTO() { Plate = "44 h 244", CarBrand = "Volkswagen", CarModel = "Golf", CreatedDate = DateTime.Now.AddDays(-3) });
            cars.Add(new CarListDTO() { Plate = "22 j 53", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(-11) });
            cars.Add(new CarListDTO() { Plate = "42 kl 22", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(-24) });
            cars.Add(new CarListDTO() { Plate = "55 ko 12", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
            cars.Add(new CarListDTO() { Plate = "17 li 64", CarBrand = "Audi", CarModel = "A3", CreatedDate = DateTime.Now.AddDays(6) });
        }


        //Araç listesi ekranı
        [HttpGet]
        public IActionResult Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(s => s.Plate.Contains(searchString)).ToList();
            }

            switch (sortOrder)
            {
                case "name_desc":
                    cars = cars.OrderByDescending(s => s.Plate).ToList();
                    break;
                case "Date":
                    cars = cars.OrderBy(s => s.CreatedDate).ToList();
                    break;
                case "date_desc":
                    cars = cars.OrderByDescending(s => s.CreatedDate).ToList();
                    break;
                default:
                    cars = cars.OrderBy(s => s.Plate).ToList();
                    break;
            }

            int pageSize = 4;

            return View(PaginatedList<CarListDTO>.Create(cars.AsQueryable(), pageNumber ?? 1, pageSize));
        }


        [HttpGet]
        public IActionResult Add()
        {

            return View(new AddVehicleDTO());
        }

        [HttpPost]
        public IActionResult Add(AddVehicleDTO dto)
        {
            CombineAddOrEditVecihleDAL validations = new CombineAddOrEditVecihleDAL();
            ValidationResult validationResult = validations.Validate(new CombineAddOrEditVehicleDTO
            {

                KM = dto.KM,
                VehiclePrice = dto.VehiclePrice,
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

                return View("Add", dto);
            }

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Edit(int carID)
        {

            return View();
        }

        [HttpPost]
        public IActionResult Edit()
        {


            return RedirectToAction("Index");
        }

        // Brand Model 
        [HttpGet]
        public IActionResult BrandModel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detail()
        {
            return View();
        }

        // Car Detail
        [HttpGet]
        public IActionResult CarDetail()
        {
            return View();
        }

        // Car Detail Value
        [HttpGet]
        public IActionResult CarDetailValue()
        {
            return View();
        }

        // Car Image
        [HttpGet]
        public IActionResult CarImage()
        {
            return View();
        }

        // Car Modification
        [HttpGet]
        public IActionResult CarModification()
        {
            return View();
        }

        // Car Commission
        [HttpGet]
        public IActionResult CarCommission()
        {
            return View();
        }

        // Car Buyer Information
        [HttpGet]
        public IActionResult CarBuyerInformation()
        {
            return View();
        }

    }
}
