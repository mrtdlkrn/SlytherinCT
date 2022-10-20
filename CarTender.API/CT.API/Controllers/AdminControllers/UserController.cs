using CarTender.Core.Utilities;
using CT.Entities.DTOs.User;
using CT.Entities.DTOs.UserCar;
using CT.Entities.DTOs.UserFavoriteCar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region User

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<ListUserDTO> users = new List<ListUserDTO>();
            users.Add(new ListUserDTO() { UserName = "Ahmetosmn", NameSurname = "Ahmet Sezgin", Phone = "555555555", Email = "Ahmet@gmail.com", UserType = "Bireysel", ApprovedBy = "Ahmet", CreatedDate = DateTime.Now });
            users.Add(new ListUserDTO() { UserName = "osmn", NameSurname = "Osman Sezgin", Phone = "111111111", Email = "Osman@gmail.com", UserType = "Bireysel", ApprovedBy = "Ahmet", CreatedDate = DateTime.Now });
            users.Add(new ListUserDTO() { UserName = "veli", NameSurname = "Veli Sezgin", Phone = "222222222", Email = "Veli@gmail.com", UserType = "Bireysel", ApprovedBy = "Ahmet", CreatedDate = DateTime.Now });
            return Ok(new SuccessDataResult<List<ListUserDTO>>(users, "Kullanıcılar listelendi", 200));
        }


        [HttpPost("Create")]
        public IActionResult Create(CreateUserDTO dto)
        {
            return Ok(new SuccessResult("Kullanıcı Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateUserDTO dto)
        {
            return Ok(new SuccessResult("Kullanıcı Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object id)
        {
            return Ok(new SuccessResult("Kullanıcı Silme Başarılı", 200));
        }

        #endregion

        #region UserCar

        [HttpGet("Cars")]
        public IActionResult GetUsersCars()
        {
            List<ListUserCarDTO> userCarList = new List<ListUserCarDTO>();
            userCarList.Add(new ListUserCarDTO() { CarPlate = "16 E 555", UserEmail = "ahmet@gmail.com" });
            userCarList.Add(new ListUserCarDTO() { CarPlate = "16 F 555", UserEmail = "ahmet@gmail.com" });
            return Ok(new SuccessDataResult<List<ListUserCarDTO>>(userCarList, "Kullanıcılar ile arabaları listelendi", 200));
        }

        [HttpPost("CreateUsersCars")]
        public IActionResult CreateUsersCars(CreateUserDTO dto)
        {
            return Ok(new SuccessResult("\"Kullanıcı-araç Bilgisi Ekleme Başarılı", 200));
        }

        [HttpPost("UpdateUsersCars")]
        public IActionResult UpdateUsersCars(UpdateUserDTO dto)
        {
            return Ok(new SuccessResult("\"Kullanıcı-araç Bilgisi Güncelleme Başarılı", 200));
        }

        [HttpPost("DeleteUsersCars")]
        public IActionResult DeleteUsersCars(object id)
        {
            return Ok(new SuccessResult("Kullanıcı-araç Bilgisi Silme Başarılı", 200));
        }

        #endregion

        #region FavoriteCars

        [HttpGet("FavoriteCars")]
        public IActionResult GetUsersFavoriteCars()
        {
            List<ListUserFavoriteCarDTO> userFavoriteCars = new List<ListUserFavoriteCarDTO>();
            userFavoriteCars.Add(new ListUserFavoriteCarDTO() { CarPlate = "16 F 555", UserEmail = "ahmet@gmail.com", CarBrand = "Ford", CarModel = "Connect", CarPrice = 155000, UserNameSurname = "Ahmet Sezgin" });
            userFavoriteCars.Add(new ListUserFavoriteCarDTO() { CarPlate = "16 E 555", UserEmail = "osman@gmail.com", CarBrand = "Toyota", CarModel = "Supra", CarPrice = 4425000, UserNameSurname = "Osman Sezgin" });
            return Ok(new SuccessDataResult<List<ListUserFavoriteCarDTO>>(userFavoriteCars, "Kullanıcılar ile favori arabaları listelendi", 200));
        }

        [HttpPost("CreateUsersFavoriteCars")]
        public IActionResult CreateUsersFavoriteCars(CreateUserDTO dto)
        {
            return Ok(new SuccessResult("Kullanıcı Favori Araç Ekleme Başarılı", 200));
        }

        [HttpPost("UpdateUsersFavoriteCars")]
        public IActionResult UpdateUsersFavoriteCars(UpdateUserDTO dto)
        {
            return Ok(new SuccessResult("Kullanıcı Favori Araç Güncelleme Başarılı", 200));
        }

        [HttpPost("DeleteUsersFavoriteCars")]
        public IActionResult DeleteUsersFavoriteCars(object id)
        {
            return Ok(new SuccessResult("Kullanıcı Favori Araç Silme Başarılı", 200));
        }

        #endregion
    }
}
