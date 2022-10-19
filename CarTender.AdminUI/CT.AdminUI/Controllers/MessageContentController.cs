using Business.Abstract;
using CarTender.AdminUI.Models;
using Entity.DTO.Auth;
using Entity.DTO.MessageContent;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class MessageContentController : Controller
    {
        private readonly IApiService _apiService;
        private readonly IDictionary<string, string> _routes;

        public MessageContentController(IApiRoutes routes, IApiService apiService)
        {
            this._apiService = apiService;
            _routes = routes.GetApiRoutes("MessageContent");
        }

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
            var messageContents = await _apiService.Get<List<ListMessageConentDTO>>(tokenDTO, _routes["Index"]);
            if (messageContents.Success)
            {
                return View(messageContents.Data);
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Message Content",
                    Message = messageContents.Message,
                    StatusCode = messageContents.StatusCode
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }
        }
    }
}
