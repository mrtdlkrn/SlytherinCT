using Business.Abstract;
using CarTender.AdminUI.Models;
using Entity.DTO.Auth;
using Entity.DTO.RoleAuthorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class AuthorizationController : Controller
    {
        //todo : Authorization'a ait dtolar çıkarılacak
        private readonly IApiService _apiService;
        private readonly IDictionary<string, string> _routes;

        public AuthorizationController(IApiRoutes routes, IApiService apiService)
        {
            this._apiService = apiService;
            _routes = routes.GetApiRoutes("Authorization");
        }
        public async Task<IActionResult> Index()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJuYmYiOjE2NjYwMTI1NzUsImV4cCI6MTY3MTE5NjU3NSwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ.aE_pYtk8oo_0V2TIZ-G0cCk6sxbdQiVu8ePJyAExyWzd620OA2Qd0u7ZaWgeK72YKhXY6WTF0BGwBqFPYNQBFw",
                ExpireTime = DateTime.Now.AddHours(1)
            };

            var roles = await _apiService.Get<List<ListRoleDTO>>(tokenDTO, _routes["Roles"]);

            var authorizations = await _apiService.Get<List<ListAuthorizationDTO>>(tokenDTO, _routes["Authorizations"]);

            // bu if kontrolu düzenlenmeli
            if (authorizations.Success)
            {                
                return View(new AuthorizationViewDTO() { Auths = authorizations.Data, Roles = roles.Data});
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Authorization",
                    Message = authorizations.Message,
                    StatusCode = authorizations.StatusCode
                };
                return View("~/Views/Shared/Error.cshtml", model);
            }
        }
    }
}
