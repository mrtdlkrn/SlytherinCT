﻿using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class BidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Create

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

        #region List Bid

        //GET: List Bid Method

        [HttpGet]
        public IActionResult ListBid()
        {
            return View();
        }

        //POST: List Bid Method with Filter

        [HttpPost]
        public IActionResult ListBid(object filteredBidInfo)
        {
            return View();
        }


        #endregion
    }
}