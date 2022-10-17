using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.AdminUI.Controllers
{
    public class AdvertController : Controller
    {
        //todo : Advert'e ait dtolar oluşturulacak.
        private readonly IApiService _apiService;
        private IDictionary<string, string> _routes;
        public AdvertController(IApiService apiService, IApiRoutes routes)
        {
            this._apiService = apiService;
            _routes = routes.GetApiRoutes("Advert");
        }
        [HttpGet]
        public IActionResult Index()
        {
            //todo : User'a göre tokenDto oluşturulacak
            /*TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiService.Get<>(tokenDTO, _routes["Index"]);
            if (result != null)
            {
                //todo: sayfaya veriler basılacak
                return View();
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Bid",
                    Message = "İhaleyle ilgili bilgiler bulunamadı",
                    StatusCode = 500
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }*/
            return View();
        }

        [HttpGet]
        public IActionResult ListAdvert()
        {//todo : User'a göre tokenDto oluşturulacak
            /*TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiService.Get<>(tokenDTO, _routes["ListAdvert"]);
            if (result != null)
            {
                //todo: sayfaya veriler basılacak
                return View();
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Bid",
                    Message = "İhaleyle ilgili bilgiler bulunamadı",
                    StatusCode = 500
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }*/
            return View();
        }

        [HttpGet]
        public IActionResult ListAdvertStatusHistory()
        {
            //todo : User'a göre tokenDto oluşturulacak
            /*TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiService.Get<>(tokenDTO, _routes["ListAdvertStatusHistory"]);
            if (result != null)
            {
                //todo: sayfaya veriler basılacak
                return View();
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Bid",
                    Message = "İhaleyle ilgili bilgiler bulunamadı",
                    StatusCode = 500
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }*/
            return View();
        }
    }
}
