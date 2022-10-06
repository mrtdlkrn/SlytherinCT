using CarTender.AdminUI.Controllers;
using Common.Abstract;
using Entity.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CT.AdminUI.Controllers
{
    public class BidController : Controller
    {
        private readonly IApiService _apiService;

        public BidController(IApiService apiService)
        {
            _apiService = apiService;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Create

        [HttpGet]
        //GET: Bid Controller for Create New Bid
        public IActionResult Create(CreateNewBidDTO createBidDTO)
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

        #region BidCorporateUSer
        public IActionResult BidCorporateUser()
        {
            return View();
        }
        #endregion

        #region BidInformation
        public IActionResult BidInformation()
        {
            return View();
        }
        #endregion

        #region BidOfferDetail
        public IActionResult BidOfferDetail()
        {
            return View();
        }
        #endregion

        #region BidStatusHistory
        public IActionResult BidStatusHistory()
        {
            return View();
        }
        #endregion
        #region BidUserOffer
        public IActionResult BidUserOffer()
        {
            return View();
        }

        #endregion

        #region dsfsa
        public IActionResult UserAutoBidOffer()
        {
            return View();
        }
        #endregion
    }
}
