using Business.Abstract;
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
        public IActionResult Edit(int carID)
        {
            //var selectedCar = _apiService.GET<>

            //if (shipper == null)
            //{
            //    return RedirectToAction("Index");
            //}

            //UpdateShipperDTO dto = new UpdateShipperDTO()
            //{
            //    ShipperID = shipperID,
            //    CompanyName = shipper.CompanyName,
            //    Phone = shipper.Phone
            //};

            //return View(dto);
            return View();
        }

        [HttpPost]
        public IActionResult Edit()
        //public IActionResult Edit(UpdateShipperDTO dto)
        {
            //var shipperForUpdate = _context.Shippers.SingleOrDefault(x => x.ShipperID == dto.ShipperID);

            //if (shipperForUpdate != null)
            //{
            //    shipperForUpdate.Phone = dto.Phone;
            //    shipperForUpdate.CompanyName = dto.CompanyName;
            //    _context.SaveChanges();
            //}

            return RedirectToAction("Index");
        }

    }
}
