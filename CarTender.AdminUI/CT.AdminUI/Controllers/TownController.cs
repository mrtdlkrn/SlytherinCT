using Business.Abstract;
using CarTender.AdminUI.Models;
using Entity.DTO.Auth;
using Entity.DTO.Town;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class TownController : Controller
    {
        //todo : Town'a ait Dtolar oluşturulacak.
        private readonly IApiService _apiService;
        private readonly IDictionary<string, string> _routes;

        public TownController(IApiService apiService, IApiRoutes routes)
        {
            this._routes = routes.GetApiRoutes("Town");
            this._apiService = apiService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiService.Get<List<ListTownDTO>>(tokenDTO, _routes["GetAll"]);
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Town",
                    Message = result.Message,
                    StatusCode = result.StatusCode
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }
        }
    }
}
