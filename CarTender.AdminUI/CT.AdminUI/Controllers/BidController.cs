using Business.Abstract;
using CarTender.AdminUI.Controllers;
using CarTender.AdminUI.Models;
using CarTender.FluentValidation.DAL.CombineDAL.Car;
using CarTender.FluentValidation.DTO.CombineDTO.Car;
using Common.Abstract;
using Entity.DTO.Auth;
using Entity.DTO.Bid;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class BidController : Controller
    {
        private readonly IApiService _apiService;
        private readonly IDictionary<string,string> _routes;

        public BidController(IApiService apiService,IApiRoutes routes)
        {
            _apiService = apiService;
            _routes = routes.GetApiRoutes("Bid");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            TokenDTO tokenDTO = new TokenDTO();
            var result = await _apiService.Get<List<BidInformationDTO>>(tokenDTO, _routes["Index"]);
            if(result!= null)
            {
                //todo: sayfaya veriler basılacak
                return View();
            }
            else
            {
                ErrorViewModel model = new ErrorViewModel()
                {
                    Header = "Bid",
                    Message = "İhaleyle ilgili bilgiler bulunamadı",
                    StatusCode = 500
                };
                return View("~/Views/Shared/Error.cshtml",model);
            }
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
        public async Task<IActionResult> Create(CreateNewBidDTO createBidDTO)
        {
            return View();
        }

        #endregion

        #region Edit Bid

        //GET: Edit Bid Method

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            return View();
        }

        //POST: Edit Bid Method

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }


        #endregion

        #region List Bid

        //GET: List Bid Method

        [HttpGet]
        public async Task<IActionResult> ListBid()
        {
            return View();
        }

        //POST: List Bid Method with Filter

        [HttpGet]
        public async Task<IActionResult> ListBid(object filteredBidInfo)
        {
            return View();
        }


        #endregion

        #region BidCorporateUser
        [HttpGet]
        public async Task<IActionResult> BidCorporateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BidCorporateUser(BidCorporateUserDTO dto)
        {
            return View();
        }
        #endregion

        #region BidInformation
        [HttpGet]
        public async Task<IActionResult> BidInformation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BidInformation(BidInformationDTO dto)
        {
            return View();
        }
        #endregion

        #region BidOfferDetail
        [HttpGet]
        public async Task<IActionResult> BidOfferDetail()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BidOfferDetail(BidOfferDetailDTO dto)
        {
            return View();
        }
        #endregion

        #region BidStatusHistory
        
        [HttpGet]
        public async Task<IActionResult> BidStatusHistory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BidStatusHistory(BidStatusHistoryDTO dto)
        {
            return View();
        }
        #endregion
        #region BidUserOffer
        [HttpGet]
        public async Task<IActionResult> BidUserOffer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BidUserOffer(BidUserOfferDTO dto)
        {
            return View();
        }

        #endregion

        #region UserAutoBidOffer
        [HttpGet]
        public async Task<IActionResult> UserAutoBidOffer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserAutoBidOffer(BidUserOfferDTO dto) //todo : Yeni bir dto gerekebilir
        {

            return View();
        }
        #endregion
    }
}
