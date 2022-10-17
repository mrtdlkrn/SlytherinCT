using Business.Abstract;
using Business.Concrete;
using CarTender.FluentValidation.DTO.UserDTO.Favorite;
using Common.Concrete;
using Entity.DTO.Auth;
using Entity.DTO.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IApiManager _apiManager;
        private readonly IDictionary<string, string> _routes;

        public UserController()
        {
            _apiManager = new ApiManager(new BaseAPIService());
            _routes = new ApiRoutes().GetApiRoutes("User");
        }

        // User GET
        public async Task<ActionResult> IndexAsync()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiManager.Get<List<GetUserDTO>>(tokenDTO, _routes["Index"]);
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

        // User Edit GET
        public async Task<ActionResult> EditAsync(int id)
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            var result = await _apiManager.Get<EditUserDTO>(tokenDTO, _routes["UpdateGet"]);
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

        // User Edit POST
        [HttpPost]
        public async Task<ActionResult> EditAsync(int id, EditUserDTO dto)
        {
            var result = await _apiManager.Post(_routes["Update"], dto);
            if (result != null)
            {
                //todo: sayfaya veriler basılacak
                return RedirectToAction("Index");
            }
            else
            {
                //    ErrorViewModel model = new ErrorViewModel()
                //    {
                //        Header = "Bid",
                //        Message = "İhaleyle ilgili bilgiler bulunamadı",
                //        StatusCode = 500
                //    };
                //    return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }
        public ActionResult ViewFavorites()
        {
            var favoriteDTOs = _apiManager.Get<UserFavoriteDTO, UserFavoriteDTO>(new Entity.DTO.Auth.TokenDTO(), _routes["Favorite"], new UserFavoriteDTO() { UserID = new Guid() });
            return View(favoriteDTOs);
        }
    }
}
