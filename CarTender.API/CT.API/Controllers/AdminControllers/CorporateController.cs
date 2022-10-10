using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CT.API.Controllers.AdminControllers
{
    /// <summary>
    /// All actions an admin needs regarding corporates will be here
    /// </summary>

    public class CorporateController : Controller
    {
        // GET: CorporateController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CorporateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CorporateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CorporateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CorporateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CorporateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CorporateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CorporateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
