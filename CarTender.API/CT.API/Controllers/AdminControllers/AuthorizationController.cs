using CarTender.Core.Utilities;
using CT.Entities.Authorization;
using CT.Entities.DTOs.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        #region Roles

        [HttpGet("Roles")]
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
            return Ok(new SuccessDataResult<List<ListRoleDTO>>(roles, "Roller listelendi", 200));
        }

        [HttpPost("CreateRole")]
        public IActionResult CreateRole(CreateRoleDTO dto)
        {
            return Ok(new SuccessResult("Rol Ekleme Başarılı", 200));
        }

        [HttpPost("UpdateRole")]
        public IActionResult UpdateRole(UpdateRoleDTO dto)
        {
            return Ok(new SuccessResult("Rol Güncelleme Başarılı", 200));
        }

        [HttpPost("DeleteRole")]
        public IActionResult DeleteRole(object id)
        {
            return Ok(new SuccessResult("Rol Silme Başarılı", 200));
        }

        #endregion

        #region Authorizations

        [HttpGet("Authorizations")]
        public IActionResult Authorizations()
        {
            List<ListAuthorizationDTO> authorizations = new List<ListAuthorizationDTO>();
            authorizations.Add(new ListAuthorizationDTO() { Name = "Listele" });
            authorizations.Add(new ListAuthorizationDTO() { Name = "Ekle" });
            authorizations.Add(new ListAuthorizationDTO() { Name = "Güncelle" });
            authorizations.Add(new ListAuthorizationDTO() { Name = "Düzenle" });
            return Ok(new SuccessDataResult<List<ListAuthorizationDTO>>(authorizations, "Yetkiler listelendi", 200));
        }


        [HttpPost("CreateAuthorization")]
        public IActionResult CreateAuthorization(CreateAuthorizationDTO dto)
        {
            return Ok(new SuccessResult("Yetki Ekleme Başarılı", 200));
        }

        [HttpPost("UpdateAuthorization")]
        public IActionResult UpdateAuthorization(UpdateAuthorizationDTO dto)
        {
            return Ok(new SuccessResult("Yetki Güncelleme Başarılı", 200));
        }

        [HttpPost("DeleteAuthorization")]
        public IActionResult DeleteAuthorization(object id)
        {
            return Ok(new SuccessResult("Yetki Silme Başarılı", 200));
        }

        #endregion
    }
}
