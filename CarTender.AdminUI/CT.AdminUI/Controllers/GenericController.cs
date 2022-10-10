using CT.AdminUI.Models;
using Entity.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CT.AdminUI.Controllers
{
    public class GenericController : Controller
    {

        [HttpGet]
        public IActionResult Create()
        {
            //AddUserDTO dto = new AddUserDTO() { Name = "Burkay", Surname = "Akgul" };
            //AddVehicle dto = new AddVehicle() {BodyType="Sedan",Color="Red",Year="2022",CompanyName="burkaycompanisi",FuelType="Benzin" };
            ModelDeneme dto = new ModelDeneme() { ID = 1, IsimAlani = "Burkay", OnayliMi = false, stringler = new List<string>() { "burkay", "akgul" }};
            GenericViewModel model = new GenericViewModel() { MyModel = dto, ActionController = "Generic", ActionMethod = "Create", Title = "Burkay123" };
            return View("~/Views/FlyPages/Create.cshtml", model);

        }

        [HttpPost]
        public IActionResult Create(IFormCollection modelFormCollection)
        {
            //Gelen Formcollection modelini maplemek icin bu 
            //MappingService mappingService = new MappingService();
            //mappingService.GetModel<ModelDeneme>(modelFormCollection);

            

            return  View("~/Views/FlyPages/Create.cshtml");
        }


    }
}
