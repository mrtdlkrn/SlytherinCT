using Business.Abstract;
using Business.Concrete;
using Common.Abstract;
using CT.AdminUI.Models;
using Entity.DTO.Auth;
using Entity.DTO.Bid;
using Entity.DTO.FlyPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class GenericController : Controller
    {
        private readonly IBaseAPIService _apiService;
        private readonly IMappingService _mappingService;
        private readonly IDictionary<string, string> _routes;
        //Todo: token duzenlenecek, giris islemi yapildiktan sonra cookiden alinacak
        TokenDTO tokenDTO = new TokenDTO()
        {
            Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
            ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
            ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
            ExpireTime = DateTime.Now.AddHours(1)
        };

        public GenericController(IBaseAPIService apiService, IMappingService mappingService, IApiRoutes routes)
        {
            _apiService = apiService;
            _mappingService = mappingService;
            _routes = routes.GetApiRoutes("FlyPage");
        }


        [HttpGet]
        public async Task<IActionResult> ListItems(string dtoName)
        {

            var list = _mappingService.GetModelListByName(dtoName);
            Type type = list.GetType();
            string actionName = dtoName.Remove(dtoName.IndexOf("DTO"), "DTO".Length);

            #region apiservice reflection işlemleri
            ///<summary>
            /// Aşağıdaki işlemlerde apiservice classında çağırdığımız GET metodu generic tipte olduğu için, reflection classı ile runtime instance'ımızı referans vererek metodu çağırma işlemi yapılmıştır.
            /// Ayrıca Get metodu asenkron metod olduğu için awaitable şekilde çağırma işlemeri yapılmıştır.
            /// 
            /// </summary>
            var method = _apiService.GetType().GetMethod("Get");
            var genericMethod = method.MakeGenericMethod(type);
            var result = (Task)genericMethod.Invoke(_apiService, new object[] { tokenDTO, _routes[actionName] });
            await result.ConfigureAwait(false);
            var returnType = result.GetType().GetProperty("Result").GetValue(result, null);
            var data = returnType.GetType().GetProperty("Data").GetValue(returnType, null);
            #endregion

            GenericViewModel model = new GenericViewModel() { MyModel = data, ModelName = dtoName, Title = dtoName + " Listeleme Sayfasi" };

            return View("~/Views/FlyPages/ListItems.cshtml", model);
        }


        [HttpGet]
        public IActionResult Create(string modelName)
        {
            //AddUserDTO dto = new AddUserDTO() { Name = "Burkay", Surname = "Akgul" };
            //AddVehicle dto = new AddVehicle() {BodyType="Sedan",Color="Red",Year="2022",CompanyName="burkaycompanisi",FuelType="Benzin" };

            var dto = _mappingService.GetModelByName(modelName);
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

        [HttpGet]
        public IActionResult Edit(Guid id, string modelName)
        {
            var dto = _mappingService.GetModelByName(modelName);
            var keyInfo = dto.GetType().GetProperties().Where(x => x.CustomAttributes.Any(x => x.AttributeType == typeof(KeyAttribute))).FirstOrDefault();

            var myKey = Convert.ChangeType(id, keyInfo.PropertyType);
            Type keyType = myKey.GetType();

            //var dsaf = denemeList.GetType().GetProperties().Where(x => x.GetType().GetProperty(keyInfo.Name).GetValue(myKey) == myKey).FirstOrDefault();
            //var ewqre = dto.GetType().GetProperty(keyInfo.Name).GetValue(dto) == (Int32)myKey;
            //var asdf = denemeList.ToList().Where(x => x.GetType().GetProperty(keyInfo.Name).GetValue(x) == myKey).FirstOrDefault();

            //.Where(x => x.GetType().GetProperty(keyInfo.Name).GetValue(x) == myKey);
            //dto = denemeList.ToList().First();
            GenericViewModel model = new GenericViewModel() { MyModel = dto, ModelName = modelName, Title = "Burkay123" };


            return View("~/Views/FlyPages/Edit.cshtml", model);
        }

        [HttpPost]
        public IActionResult Update(IFormCollection modelFormCollection, string modelName)
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

        public IActionResult Delete(string id, string modelName)
        {
            var dto = _mappingService.GetModelByName(modelName);
            var keyInfo = dto.GetType().GetProperties().Where(x => x.CustomAttributes.Any(x => x.AttributeType == typeof(KeyAttribute))).FirstOrDefault();

            var myKey = Convert.ChangeType(id, keyInfo.PropertyType);
            Type keyType = myKey.GetType();
            var myList = _mappingService.GetModelListByName(modelName);
            var asdf = myList.GetType().GetProperties()[2].PropertyType;
            //myList = denemeList;
            //var dsaf = denemeList.GetType().GetProperties().Where(x => x.GetType().GetProperty(keyInfo.Name).GetValue(myKey) == myKey).FirstOrDefault();
            //var ewqre = dto.GetType().GetProperty(keyInfo.Name).GetValue(dto) == (Int32)myKey;
            //var asdf = denemeList.ToList().Where(x => x.GetType().GetProperty(keyInfo.Name).GetValue(x) == myKey).FirstOrDefault();

            return View();
        }
    }
}
