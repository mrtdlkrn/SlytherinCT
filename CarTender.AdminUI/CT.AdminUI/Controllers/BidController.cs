using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class BidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Create New Bid

        [HttpGet]
        //GET: Bid Controller for Create New Bid
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //POST: Bid Controller for Create New Bid
        public IActionResult Create(int id)
        {
            return View();
        }

        #endregion

        #region Edit Bid

        //GET: Edit Bid Method

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        //POST: Edit Bid Method

        [HttpPost]
        public IActionResult Edit(int id)
        {
            return View();
        }


        #endregion

    }
}
