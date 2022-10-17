using CarTender.Core.Utilities;
using CT.API.Models.DTOs.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {

        [HttpGet("roles")]
        public IActionResult Roles()
        {
            List<ListRoleDTO> roles = new List<ListRoleDTO>();
            roles.Add(new ListRoleDTO() { Name = "Süper Admin" });
            roles.Add(new ListRoleDTO() { Name = "Admin" });
            roles.Add(new ListRoleDTO() { Name = "Moderatör" });
            roles.Add(new ListRoleDTO() { Name = "CEO" });
            roles.Add(new ListRoleDTO() { Name = "Satış Elemanı" });
            roles.Add(new ListRoleDTO() { Name = "İnsan Kaynakları" });
            roles.Add(new ListRoleDTO() { Name = "Bireysel Kullanıcı" });

            return Ok(new SuccessDataResult<List<ListRoleDTO>>(roles, "Roller listelendi"));
        }


        [HttpGet("authorizations")]
        public IActionResult Authorizations()
        {
            List<ListAuthorizationDTO> authorizations = new List<ListAuthorizationDTO>();
            authorizations.Add(new ListAuthorizationDTO() { Name = "Listele" });
            authorizations.Add(new ListAuthorizationDTO() { Name = "Ekle" });
            authorizations.Add(new ListAuthorizationDTO() { Name = "Güncelle" });
            authorizations.Add(new ListAuthorizationDTO() { Name = "Düzenle" });

            return Ok(new SuccessDataResult<List<ListAuthorizationDTO>>(authorizations, "Yetkiler listelendi"));
        }

    }
}
