using Business.Abstract;
using Entity.DTO.Auth;
using Entity.DTO.Car;
using Entity.DTO.Pagination;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _routes = routes.GetApiRoutes("Car");
        }


        //Araç listesi ekranı       
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

            /*var CarListDTO = new ListCarDTO();
            var result = await _apiService.Post(_routes["Index"], CarListDTO);
            //todo : sayfaya veriler basılacak*/

            return View(PaginatedList<ListCarDTO>.Create(cars.AsQueryable(), pageNumber ?? 1, pageSize));
        }


        [HttpGet]
        public IActionResult Add()
        {

            return View(new AddCarDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCarDTO dto)
        {
            //CombineAddOrEditVehicleVAL validations = new CombineAddOrEditVehicleVAL();
            //ValidationResult validationResult = validations.Validate(new CombineAddOrEditVehicleDTO
            //{

            //    KM = dto.KM,
            //    VehiclePrice = dto.Price,
            //    Explanation = dto.Explanation,
            //    PhotoPath1 = dto.PhotoPath1,
            //    PhotoPath2 = dto.PhotoPath2,
            //    PhotoPath3 = dto.PhotoPath3,
            //    PhotoPath4 = dto.PhotoPath4,
            //    PhotoPath5 = dto.PhotoPath5

            //});

            //if (!validationResult.IsValid)
            //{
            //    validationResult.AddToModelState(this.ModelState);

            //    return View("Add", dto);
            //}
            var result = await _apiService.Post(_routes["Create"], dto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int carID)
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateCarDTO dto)
        {
            var result = await _apiService.Post(_routes["Update"], dto);
            return RedirectToAction("Index");
        }

        // Brand Model 
        [HttpGet]
        public IActionResult BrandModel()
        {
            //TokenDTO tokenDTO = new TokenDTO();
            //var result = await _apiService.Get<ListBrandModelDTO>(tokenDTO, _routes["BrandModel"]);
            //todo : sayfaya veriler basılacak

            return View();
        }

        //[HttpGet("Detail/{id}")]
        public async Task<IActionResult> Detail(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<ListCarDTO>(tokenDTO, _routes["Detail"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Detail
        //[HttpGet("CarDetail")]
        public async Task<IActionResult> CarDetail()
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarDetail"]);
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

        // Car Commission
        //[HttpGet("CarCommission/{id}")]
        public async Task<IActionResult> CarCommission(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarCommission"]);
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
    }
}
