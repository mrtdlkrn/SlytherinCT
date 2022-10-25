using CT.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporateController : ControllerBase
    {
        private readonly ICorporateService _corporateService;

        public CorporateController(ICorporateService corporateService)
        {
            _corporateService = corporateService;
        }

        [HttpGet("GetListAllCorporate")]
        public async Task<IActionResult> GetListAllCorporate()
        {
            var result = await _corporateService.GetListAllCorporate();
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
    }
}
