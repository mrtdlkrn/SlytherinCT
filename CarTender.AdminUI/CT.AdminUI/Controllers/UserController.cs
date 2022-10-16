using Business.Abstract;
using CarTender.AdminUI.Models;
using Entity.DTO.Auth;
using Entity.DTO.Bid;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class UserController : Controller
    {
        //todo : User'a ait dtolar oluşturulacak
        private readonly IDictionary<string,string> _routes;
        private readonly IApiService _apiService;

        public UserController(IApiService apiService,IApiRoutes routes)
        {
            _apiService = apiService;
            _routes = routes.GetApiRoutes("User");
        }
        [HttpGet]
        public async Task<IActionResult> Index()
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
                    Header = "User",
                    Message = "User ilgili bilgiler bulunamadı",
                    StatusCode = 500
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }*/
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UserFavoriteCar()
        {
            //todo : User'a göre tokenDto oluşturulacak
            /*TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiService.Get<>(tokenDTO, _routes["Edit"]);
            if (result != null)
            {
                //todo: sayfaya veriler basılacak
                return View();
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "User",
                    Message = "User ilgili bilgiler bulunamadı",
                    StatusCode = 500
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }*/
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UserCar()
        {
            //todo : User'a göre tokenDto oluşturulacak
            /*TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiService.Get<>(tokenDTO, _routes["Edit"]);
            if (result != null)
            {
                //todo: sayfaya veriler basılacak
                return View();
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "User",
                    Message = "User ilgili bilgiler bulunamadı",
                    StatusCode = 500
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }*/
            return View();
        }
        
    }
}
