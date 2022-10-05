﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CT.API.Controllers.AdminControllers
{
    /// <summary>
    /// All actions an admin needs regarding adverts will be here
    /// </summary>
    /// 
    public class AdvertController : Controller
    {
        // GET: AdvertController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdvertController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdvertController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdvertController/Create
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

        // GET: AdvertController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdvertController/Edit/5
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

        // GET: AdvertController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdvertController/Delete/5
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
