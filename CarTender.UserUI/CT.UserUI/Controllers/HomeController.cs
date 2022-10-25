using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string cookie = Request.Cookies.Get("Ihale").Value;
            //var token = Session["token"].ToString();
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
    }
}