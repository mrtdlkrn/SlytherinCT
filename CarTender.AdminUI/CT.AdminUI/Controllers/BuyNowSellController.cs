using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.AdminUI.Controllers
{
    public class BuyNowSellController : Controller
    {
        //todo : BuyNowSell'a ait dtolar çıkarılacak
        //todo : Araba'nın idsine göre veya plakasına göre işlem düşünülecek
        private readonly IApiService _apiService;
        private readonly IDictionary<string, string> _routes;
        public BuyNowSellController(IApiRoutes routes, IApiService apiService)
        {
            this._apiService = apiService;
            _routes = routes.GetApiRoutes("BuyNowSell");
        }
        [HttpGet("Index/{id}")]
        public IActionResult Index(int id)
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
                return RedirectToAction("Index","Car");
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "BuyNowSell",
                    Message = "BuyNowSell ilgili bilgiler bulunamadı",
                    StatusCode = 500
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }*/
            return RedirectToAction("Index","Car"); //todo: gelen sayfaya yönlendir 
        }        
    }
}
