using Business.Abstract;
using Entity.DTO;
using Entity.DTO.Car;
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

        public CarController(IApiService apiService,IApiRoutes routes)
        {
            _apiService = apiService;
            _routes = routes.GetApiRoutes("Car");
        }


        //Araç listesi ekranı
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            /*var CarListDTO = new ListCarDTO();
            var result = await _apiService.Post(_routes["Index"], CarListDTO);
            //todo : sayfaya veriler basılacak*/
            return View();
        }


        [HttpGet]
        public IActionResult Add(int carID)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add( AddCarDTO dto)
        {            
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
        public async Task<IActionResult> BrandModel()
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<ListBrandModelDTO>(tokenDTO,_routes["BrandModel"]);
            //todo : sayfaya veriler basılacak

            return View();
        }

        [HttpGet("Detail/{id}")] 
        public async Task<IActionResult> Detail(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<ListCarDTO>(tokenDTO, _routes["Detail"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Detail
        [HttpGet("CarDetail")]
        public async Task<IActionResult> CarDetail()
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarDetail"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Image
        [HttpGet("CarImage/{id}")]
        public async  Task<IActionResult> CarImage(string plate)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarImage"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Modification
        [HttpGet("CarModification/{id}")]
        public async Task<IActionResult> CarModification(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarModification"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Commission
        [HttpGet("CarCommission/{id}")]
        public async Task<IActionResult> CarCommission(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarCommission"]);
            //todo : sayfaya veriler basılacak
            return View();
        }

        // Car Buyer Information
        [HttpGet("CarBuyerInformation/{id}")]
        public async Task<IActionResult> CarBuyerInformation(Guid id)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<CarDetailDTO>(tokenDTO, _routes["CarBuyerInformation"]);
            //todo : sayfaya veriler basılacak
            return View();
        }        
    }
}
