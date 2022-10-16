using Business.Abstract;
using Business.Concrete;
using CarTender.FluentValidation.DAL.CombineDAL.Car;
using CarTender.FluentValidation.DTO.CombineDTO.Car;
using Common.Concrete;
using Entity.DTO;
using Entity.DTO.Car;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IApiManager _apiManager;
        private readonly IDictionary<string, string> _routes;
        List<ListCarDTO> Cars = new List<ListCarDTO>();

        public CarController()
        {
            _apiManager = new ApiManager(new BaseAPIService());
            Cars.Add(new ListCarDTO()
            {
                CarBrand = "Ford",
                CarModel = "Focus",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsCorporate = false,
                Price = 450000,
            });
        }

        // Car List Page    
        public ActionResult Index()
        {
            //todo: pagination eklenecek
            return View(Cars);
        }

        // Car Add Page GET
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new AddCarDTO());
        }

        // Car Add Page POST
        [HttpPost]
        public async Task<ActionResult> Create(AddCarDTO dto)
        {
            try
            {
                CombineAddOrEditVehicleDAL validations = new CombineAddOrEditVehicleDAL();
                ValidationResult validationResult = validations.Validate(new CombineAddOrEditVehicleDTO
                {

                    KM = dto.KM,
                    VehiclePrice = dto.Price,
                    Explanation = dto.Explanation,
                    PhotoPath1 = dto.PhotoPath1,
                    PhotoPath2 = dto.PhotoPath2,
                    PhotoPath3 = dto.PhotoPath3,
                    PhotoPath4 = dto.PhotoPath4,
                    PhotoPath5 = dto.PhotoPath5

                });

                if (!validationResult.IsValid)
                {
                    return View("Add", dto);
                }
                var result = await _apiManager.Post(_routes["Create"], dto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // Car Edit Page GET
        [HttpGet]
        public ActionResult Edit(int carID)
        {
            return View();
        }

        // Car Edit Page POST
        [HttpPost]
        public async Task<ActionResult> Edit(UpdateCarDTO dto)
        {
            try
            {
                var result = await _apiManager.Post(_routes["Update"], dto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// Car Delete Page GET
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// Car Delete Page POST
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
