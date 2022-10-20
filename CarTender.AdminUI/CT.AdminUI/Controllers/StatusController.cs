using Business.Abstract;
using CarTender.AdminUI.Models;
using CarTender.FluentValidation.DTO.CombineDTO.Car;
using CarTender.FluentValidation.VAL.AdminVAL.Status;
using CarTender.FluentValidation.VAL.CombineVAL.Car;
using Entity.DTO.Auth;
using Entity.DTO.Brand;
using Entity.DTO.Car;
using Entity.DTO.Status;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class StatusController : Controller
    {
        private readonly IApiService _apiService;
        private readonly IDictionary<string, string> _routes;

        //todo : Status'a ait Dtolar oluşturulacak.
        public StatusController(IApiService apiService, IApiRoutes routes)
        {
            this._apiService = apiService;
            _routes = routes.GetApiRoutes("Status");
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9." +
                "eyJuYmYiOjE2NjYyOTM1ODksImV4cCI6MTY3MTQ3NzU4OSwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb2" +
                "0ifQ.2QlIXo-1AwekkDDY3fe3tObmnCMvF5W-oBg1pYYPgOwigSq0dOpTp5eGz-AMcsVqmOBxkWYlz8EdkLQRYbtVZQ",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiService.Get<List<ListStatusDTO>>(tokenDTO, _routes["Index"]);
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Status",
                    Message = result.Message,
                    StatusCode = result.StatusCode
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }
        }


        [HttpGet]
        public IActionResult Add()
        {
            _apiService.Test("aaaa");
            return View(new AddStatusDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStatusDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9." +
                "eyJuYmYiOjE2NjYyOTM1ODksImV4cCI6MTY3MTQ3NzU4OSwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1Z" +
                "mZAaHVmZmxlcHVmZi5jb20ifQ.2QlIXo-1AwekkDDY3fe3tObmnCMvF5W-oBg1pYYPgOwigSq0dOpTp5eGz-AMcsVqmOBxkWYlz8EdkLQRYbtVZQ",
                ExpireTime = DateTime.Now.AddHours(1)
            };

            AdminStatusVAL validations = new AdminStatusVAL();
            ValidationResult validationResult = validations.Validate(new CarTender.FluentValidation.DTO.AdminDTO.Status.AdminStatusDTO()
            {
                StatusName = dto.StatusType[0]
            });

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                TempData["StatusType"] = dto.StatusType;

                return View("Add", dto);
            }
            var result = await _apiService.Post(tokenDTO, _routes["Create"], dto);

            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Edit(EditStatusDTO dto)
        {
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9." +
                "eyJuYmYiOjE2NjYyOTM1ODksImV4cCI6MTY3MTQ3NzU4OSwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb2" +
                "0ifQ.2QlIXo-1AwekkDDY3fe3tObmnCMvF5W-oBg1pYYPgOwigSq0dOpTp5eGz-AMcsVqmOBxkWYlz8EdkLQRYbtVZQ",
                ExpireTime = DateTime.Now.AddHours(1)
            };

            AdminStatusVAL validations = new AdminStatusVAL();
            ValidationResult validationResult = validations.Validate(new CarTender.FluentValidation.DTO.AdminDTO.Status.AdminStatusDTO
            {
                StatusName = dto.Name
            }) ;

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                TempData["StatusName"] = dto.Name;
                return View("Edit", dto);
            }

            var result = await _apiService.Post(tokenDTO, _routes["Update"], dto);
            return RedirectToAction("Index");
        }


    }
}
