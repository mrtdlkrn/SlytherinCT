using CarTender.Core.Utilities;
using CT.Entities.Bid;
using CT.Entities.DTOs.BrandModel.Brand;
using CT.Entities.DTOs.BrandModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandModelController : ControllerBase
    {
        #region Brand

        [HttpGet("GetAllBrands")]
        public IActionResult GetAllBrands()
        {
            //Todo : Dapper eklenecek
            List<ListBrandDTO> brands = new List<ListBrandDTO>();
            for (int i = 0; i < 10; i++)
            {
                brands.Add(new ListBrandDTO()
                {
                    Name = "Ford"
                });
            }

            return Ok(new SuccessDataResult<List<ListBrandDTO>>(brands, "Markalar Listelendi", 200));
        }

        [HttpPost("CreateBrand")]
        public IActionResult CreateBrand(CreateModelDTO dto)
        {
            return Ok(new SuccessResult("Marka Ekleme Başarılı", 200));
        }

        [HttpPost("UpdateBrand")]
        public IActionResult UpdateBrand(UpdateBrandDTO dto)
        {
            return Ok(new SuccessResult("Marka Güncelleme Başarılı", 200));
        }

        [HttpPost("DeleteBrand")]
        public IActionResult DeleteBrand(object brandID)
        {
            return Ok(new SuccessResult("Marka Silme Başarılı", 200));
        }

        [HttpGet("GetBrandByID")]
        public IActionResult GetBrandByID(object brandID)
        {
            return Ok(new SuccessResult("Marka Getirme Başarılı", 200));
        }

        #endregion

        #region Model

        [HttpGet("GetAllModels")]
        public IActionResult GetAllModels()
        {
            //Todo : Dapper eklenecek
            List<ListModelDTO> models = new List<ListModelDTO>();
            for (int i = 0; i < 10; i++)
            {
                models.Add(new ListModelDTO()
                {
                    Name = "Connect"
                });
            }

            return Ok(new SuccessDataResult<List<ListModelDTO>>(models, "Markalar Listelendi", 200));
        }

        [HttpPost("CreateModel")]
        public IActionResult CreateModel(CreateModelDTO dto)
        {
            return Ok(new SuccessResult("Model Ekleme Başarılı", 200));
        }

        [HttpPost("UpdateModel")]
        public IActionResult UpdateModel(UpdateModelDTO dto)
        {
            return Ok(new SuccessResult("Model Güncelleme Başarılı", 200));
        }

        [HttpPost("DeleteModel")]
        public IActionResult DeleteModel(object modelID)
        {
            return Ok(new SuccessResult("Model Silme Başarılı", 200));
        }

        [HttpGet("GetModelByID")]
        public IActionResult GetModelByID(object modelID)
        {
            return Ok(new SuccessResult("Model Getirme Başarılı", 200));
        }

        [HttpGet("GetModelByBrand")]
        public IActionResult GetModelByBrand(object brandID)
        {
            return Ok(new SuccessResult("Model Getirme Başarılı", 200));
        }
        #endregion
    }
}
