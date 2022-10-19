using Business.Abstract;
using CarTender.AdminUI.Models;
using Entity.DTO.Auth;
using Entity.DTO.Tramer;
using Entity.DTO.TramerComponent;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class TramerController : Controller
    {
        //todo : Tramer'a ait dtolar oluşturulacak.
        private readonly IApiService _apiService;
        private readonly IDictionary<string, string> _routes;
        public TramerController(IApiService apiService, IApiRoutes routes)
        {
            this._apiService = apiService;
            _routes = routes.GetApiRoutes("Tramer");
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
            var tramers = await _apiService.Get<List<ListTramerDTO>>(tokenDTO, _routes["Index"]);
            var components = await _apiService.Get<List<ListTramerComponentDTO>>(tokenDTO, _routes["GetComponents"]);

            if (tramers.Success && components.Success)
            {
                return View(new TramerViewDTO { TramerComponents = components.Data, Tramers=tramers.Data});
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Tramer",
                    // todo burası düzenlenmeli.
                    Message = components.Message,
                    StatusCode = components.StatusCode
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }
        }
    }
}
