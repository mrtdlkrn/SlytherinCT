using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class PackageController : Controller
    {
        #region Package Controller

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

        #endregion
    }
}
