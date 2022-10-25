using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Expertise()
        {
            ViewBag.Message = "Expertise page.";

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Unauthorized()
        {

            return RedirectToAction("Login","Auth");
        }


        [AllowAnonymous]
        [HttpGet]
        public ActionResult NotFound()
        {

            return View();
        }
    }
}