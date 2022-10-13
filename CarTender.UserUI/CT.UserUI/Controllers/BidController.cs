using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class BidController : Controller
    {
        // GET: Bid
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bid/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bid/Create
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

        // GET: Bid/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bid/Edit/5
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

        // GET: Bid/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bid/Delete/5
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
    }
}
