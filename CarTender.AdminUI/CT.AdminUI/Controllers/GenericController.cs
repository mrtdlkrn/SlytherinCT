using CT.AdminUI.Models;
using Entity.DTO;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CT.AdminUI.Controllers
{
    public class GenericController : Controller
    {
        List<DenemeDTO> denemeList = new List<DenemeDTO>()
        {
            new DenemeDTO { Age = 25,IsRetired=false,Name="Burkay",Surname="Akgul",Salary=2000},
            new DenemeDTO { Age = 25,IsRetired=false,Name="Burkay",Surname="Akgul",Salary=2000},
            new DenemeDTO { Age = 25,IsRetired=false,Name="Burkay",Surname="Akgul",Salary=2000},
            new DenemeDTO { Age = 25,IsRetired=false,Name="Burkay",Surname="Akgul",Salary=2000},
            new DenemeDTO { Age = 25,IsRetired=false,Name="Burkay",Surname="Akgul",Salary=2000},
            new DenemeDTO { Age = 25,IsRetired=false,Name="Burkay",Surname="Akgul",Salary=2000},
        };

        [HttpGet]
        public IActionResult ListItems(string modelName)
        {
            ///<summary>
            /// Burada .net'in assembly kodlarindan veri tipleri arasindan tip adi bizim httpget ile aldigimiz model adina esit olan ilk tipin type bilgisini alir
            /// Boylece gonderdigimiz modelName bilgisine gore veri tipini elde etmis oluruz.
            /// </summary>
            Type myModelType = System.AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).First(x => x.Name == modelName);

            ///<summary>
            /// Oluşturduğumuz model tipimizi listeye referans olarak veremedğimizden dolayı makegenerictype ile modelimizle bağlantılı bir liste
            /// tipi oluşturmuş oluruz.
            /// </summary>
            Type customListType = typeof(List<>).MakeGenericType(myModelType);

            ///<summary>
            ///List<GelenModelTipi> şeklinde bir liste instance'ı oluşturuyoruz
            ///</summary>
            var list = Activator.CreateInstance(customListType);

            ///<summary>
            ///Oluşturduğumuz liste instance'na liste halindeki verilerimizi aktarıyoruz, şuan için api katmanında veritabanı bağlantısı bulunmadığından dolayı örnek verileri kendimiz oluşturup gönderiyoruz...
            ///</summary>
            list = denemeList;
            



            return View("~/Views/FlyPages/ListItems.cshtml", model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            //AddUserDTO dto = new AddUserDTO() { Name = "Burkay", Surname = "Akgul" };
            //AddVehicle dto = new AddVehicle() {BodyType="Sedan",Color="Red",Year="2022",CompanyName="burkaycompanisi",FuelType="Benzin" };
            ModelDeneme dto = new ModelDeneme();
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
