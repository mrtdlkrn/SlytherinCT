using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class BidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Create New Bind

        [HttpGet]
        //GET: Bid Controller for Create New Bind
        public IActionResult CreateNewBind()
        {
            return View();
        }

        [HttpPost]
        //POST: Bid Controller for Create New Bind
        public IActionResult CreateNewBind(int id)
        {
            return View();
        }

        #endregion
    }
}
