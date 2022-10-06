using Common.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IAPIService _apiService;

        public CarController(IAPIService apiService)
        {
            _apiService = apiService;
        }


        //Araç listesi ekranı
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Add(int carID)
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add()
        {


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

    }
}
