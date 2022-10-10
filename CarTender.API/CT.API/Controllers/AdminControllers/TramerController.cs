using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CT.API.Controllers.AdminControllers
{
    /// <summary>
    /// All actions an admin needs regarding tramers will be here
    /// </summary>

    public class TramerController : Controller
    {
        // GET: TramerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TramerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TramerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TramerController/Create
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

        // GET: TramerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TramerController/Edit/5
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

        // GET: TramerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TramerController/Delete/5
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
