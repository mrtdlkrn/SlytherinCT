using Business.Abstract;
using Entity.DTO.Advert;
using Entity.DTO.AdvertStatusHistory;
using Entity.DTO.Car;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.AdminUI.Controllers
{
    public class AdvertController : Controller
    {
        //todo : Advert'e ait dtolar oluşturulacak.
        private readonly IApiService _apiService;
        private IDictionary<string, string> _routes;
        List<ListAdvertDTO> adverts = new List<ListAdvertDTO>();
        List<ListAdvertStatusHistoryDTO> advertStatusHistories= new List<ListAdvertStatusHistoryDTO>();

        public AdvertController(IApiService apiService,IApiRoutes routes)
        {
            this._apiService = apiService;
            _routes = routes.GetApiRoutes("Advert");
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 R 123", CarBrand = "Audi", CarModel = "A1", Title = "İlan 1", PrePrice = 50000 ,Price = 56345, Info="İlan 1 açıklama" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 E 123", CarBrand = "Audi", CarModel = "A2", Title = "İlan 2", PrePrice = 70000 ,Price = 66345, Info="İlan 2 açıklama" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 T 123", CarBrand = "Audi", CarModel = "A3", Title = "İlan 3", PrePrice = 60000 ,Price = 46345, Info="İlan 3 açıklama" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 Y 123", CarBrand = "Audi", CarModel = "A4", Title = "İlan 4", PrePrice = 80000 ,Price = 36345, Info="İlan 4 açıklama" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 U 123", CarBrand = "Audi", CarModel = "A5", Title = "İlan 5", PrePrice = 90000 ,Price = 96345, Info="İlan 5 açıklama" });
            adverts.Add(new ListAdvertDTO() { CarPlate = "16 I 123", CarBrand = "Audi", CarModel = "A6", Title = "İlan 6", PrePrice = 100000 ,Price = 76345, Info="İlan 6 açıklama" });

            advertStatusHistories.Add(new ListAdvertStatusHistoryDTO() {AdvertTitle = "İlan 1", AdvertStatus = "Satışta", AdvertInfo = "Yeni açıldık.", EditedBy = "Ahmet", EditDate = DateTime.Now.ToShortDateString()});
            advertStatusHistories.Add(new ListAdvertStatusHistoryDTO() {AdvertTitle = "İlan 2", AdvertStatus = "Beklemede", AdvertInfo = "Bekleme durumundayız.", EditedBy = "Osman", EditDate = DateTime.Now.ToShortDateString()});
            advertStatusHistories.Add(new ListAdvertStatusHistoryDTO() {AdvertTitle = "İlan 3", AdvertStatus = "Satışta", AdvertInfo = "Yeni açıldık.", EditedBy = "Ahmet", EditDate = DateTime.Now.ToShortDateString()});
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
            return View(adverts);
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
            return View(advertStatusHistories);
        }
    }
}
