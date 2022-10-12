using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class AdvertController : Controller
    {
        // GET: Advert
        public ActionResult Index()
        {
            return View();
        }

        // GET: Advert/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Advert/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advert/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Advert/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Advert/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Advert/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Advert/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ViewAdvert(int id)
        {
            return View();
        }
    }
}
