using Business.Abstract;
using Business.Concrete;
using CT.AdminUI.Models;
using Entity.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CT.AdminUI.Controllers
{
    public class GenericController : Controller
    {
        private readonly IMappingService _mappingService;


        public GenericController(IMappingService mappingService)
        {
            _mappingService = mappingService;
        }

        #region DenemeDTO Listesi
        List<DenemeDTO> denemeList = new List<DenemeDTO>()
        {
            new DenemeDTO { Age = 25,IsRetired=false,Name="Burkay",Surname="Akgul",Salary=2000},
            new DenemeDTO { Age = 23,IsRetired=false,Name="asdfdfas",Surname="12sdaf",Salary=3000},
            new DenemeDTO { Age = 21,IsRetired=false,Name="vxcsdaf",Surname="11123",Salary=4000},
            new DenemeDTO { Age = 29,IsRetired=false,Name="cvcvxsdf",Surname="bgrwwfgsa",Salary=2000},
            new DenemeDTO { Age = 24,IsRetired=false,Name="iyusdf",Surname="bndfgfd",Salary=1000},
            new DenemeDTO { Age = 26,IsRetired=false,Name="qwerqwre",Surname="trrtwe",Salary=5000},
        };
        #endregion

        [HttpGet]
        public IActionResult ListItems(string modelName)
        {

            var list = _mappingService.GetModelListByName(modelName);
            list = denemeList;
            GenericViewModel model = new GenericViewModel() { MyModel = list, ModelName = modelName, Title = modelName + " Listeleme Sayfasi" };

            
            return View("~/Views/FlyPages/ListItems.cshtml", model);


        }


        [HttpGet]
        public IActionResult Create(string modelName)
        {
            //AddUserDTO dto = new AddUserDTO() { Name = "Burkay", Surname = "Akgul" };
            //AddVehicle dto = new AddVehicle() {BodyType="Sedan",Color="Red",Year="2022",CompanyName="burkaycompanisi",FuelType="Benzin" };

            var dto = _mappingService.GetModelListByName(modelName);
            GenericViewModel model = new GenericViewModel() { MyModel = dto, ModelName = modelName, Title = "Burkay123" };

            return View("~/Views/FlyPages/Create.cshtml", model);

        }

        [HttpPost]
        public IActionResult Create(IFormCollection modelFormCollection, string modelName)
        {
            #region Generic Model Casting
            ///<summary>
            /// Burada formcollection verimizi mappingservice içerisindeki GetModel metodu ile istediğimiz tipe çevirebilmek için öncelikle GetModel metodu bir generic tip metod olduğundan dolayı veri tipimizi sadece variable olarak elde edebildiğimizden burada tekrardan Reflection kütüphanesine başvururuz. Reflection GetMethod ile metodumuzu elde ederiz daha sonra metodumuz generic tipte olduğu için MakeGenericType deyip modelimizden elde ettimiz tip değişkenini içine göndeririz şeklen yorumlamak istersek GetModel<T>(veriler) metodunu GetModel<ModelTipi>(veriler) 'e çevirmiş olduk. Metodumuzun cast edilmiş halini elde ettikten sonra artık Invoke metodu ile verimizi çağırabiliriz Invoke metodunun içerisine alacağı veri tipleri metodumuzun bulunduğu class'ın instance'ı ve object array tipinde modelin içine göndereceğimiz verilerimizdir.
            /// </summary>
            var dto = _mappingService.GetModelByName(modelName);
            Type type = dto.GetType();
            var method = _mappingService.GetType().GetMethod("GetModel");
            var genericMethod = method.MakeGenericMethod(type);
            var result = genericMethod.Invoke(new MappingService(), new object[] { modelFormCollection });
            #endregion

            return RedirectToAction("Index", "Admin");
        }


    }
}
