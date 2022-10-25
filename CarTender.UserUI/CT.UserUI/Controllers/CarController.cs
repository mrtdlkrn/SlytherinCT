using Business.Abstract;
using Business.Concrete;
using Common.Concrete;
using Entity.DTO.Advert;
using Entity.DTO.Auth;
using Entity.DTO.Car;
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
            _routes = new ApiRoutes().GetApiRoutes("Car");

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

        // Car List    
        public async Task<ActionResult> Index()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            //var result = await _apiManager.Get<ListCarDTO>(tokenDTO, _routes["ListCar"]);
            //if (result != null)
            //{
            //    //todo: sayfaya veriler basılacak
            //    return View();
            //}

            if (true)
                return View();
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        // Car Details
        [HttpGet]
        public async Task<ActionResult> Details(object ID)
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };

            var result = await _apiManager.Get<CarDTO>(tokenDTO.Token, _routes["Details"]);
            if (result != null)
            {
                //todo: sayfaya veriler basılacak
                return View(result);
            }
            if (true)
                return View();
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        // Car Create GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Car Add POST
        //[HttpPost]
        //public async Task<ActionResult> Create(AddCarDTO dto)
        //{
        //    var result = await _apiManager.Post(_routes["Create"], dto);
        //    if (result != null)
        //    {
        //        //todo: sayfaya veriler basılacak
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        //ErrorViewModel model = new ErrorViewModel()
        //        //{
        //        //    Header = "Bid",
        //        //    Message = "İhaleyle ilgili bilgiler bulunamadı",
        //        //    StatusCode = 500
        //        //};
        //        //return View("~/Views/Shared/Error.cshtml", model);
        //        return View("~/Views/Shared/Error.cshtml");
        //    }
        //}

        // Car Edit GET
        [HttpGet]
        public async Task<ActionResult> Edit()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            //var result = await _apiManager.Get<UpdateCarDTO>(tokenDTO, _routes["UpdateGet"]);
            //if (result != null)
            //{
            //    //todo: sayfaya veriler basılacak
            //    return View();
            //}
            if (true)
                return View();
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");

            }
        }

        // Car Edit POST
        //[HttpPost]
        //public async Task<ActionResult> Edit(UpdateCarDTO dto)
        //{
        //    var result = await _apiManager.Post(_routes["Update"], dto);
        //    if (result != null)
        //    {
        //        //todo: sayfaya veriler basılacak
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        //ErrorViewModel model = new ErrorViewModel()
        //        //{
        //        //    Header = "Bid",
        //        //    Message = "İhaleyle ilgili bilgiler bulunamadı",
        //        //    StatusCode = 500
        //        //};
        //        //return View("~/Views/Shared/Error.cshtml", model);
        //        return View("~/Views/Shared/Error.cshtml");

        //    }
        //}

        // Car Delete GET
        public async Task<ActionResult> Delete()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                 ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                 ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiManager.Get<UpdateCarDTO>(tokenDTO.Token, _routes["DeleteGet"]);
            if (result != null)
            {
                //todo: sayfaya veriler basılacak
                return View();
            }
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        // Car Delete POST
        //[HttpPost]
        //public async Task<ActionResult> Delete(UpdateCarDTO dto)
        //{
        //    //var result = await _apiManager.Post(_routes["Delete"], dto);
        //    //if (result != null)
        //    //{
        //    //    //todo: sayfaya veriler basılacak
        //    //    return RedirectToAction("Index");
        //    //}
        //    //else
        //    //{
        //    //    //ErrorViewModel model = new ErrorViewModel()
        //    //    //{
        //    //    //    Header = "Bid",
        //    //    //    Message = "İhaleyle ilgili bilgiler bulunamadı",
        //    //    //    StatusCode = 500
        //    //    //};
        //    //    //return View("~/Views/Shared/Error.cshtml", model);
        //    //    return View("~/Views/Shared/Error.cshtml");
        //    //}
        //}
    }
}
