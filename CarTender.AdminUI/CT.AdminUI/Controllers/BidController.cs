using Business.Abstract;
using CarTender.AdminUI.Controllers;
using CarTender.FluentValidation.VAL.CombineVAL.Bid;
using Common.Abstract;
using Entity.DTO;
using Entity.DTO.Auth;
using Entity.DTO.Bid;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using Microsoft.AspNetCore.Http;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.DTO.BidCreate;
using Entity.DTO.Corparate;
using Entity.DTO.Status;
using Entity.DTO.Car;

namespace CT.AdminUI.Controllers
{
    public class BidController : Controller
    {
        private readonly IApiService _apiService;
        private readonly IMappingService _mappingService;
        private readonly IDictionary<string, string> _routes;
        TokenDTO tokenDTO = new TokenDTO()
        {
            Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
            ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
            ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
            ExpireTime = DateTime.Now.AddHours(1)
        };


        public BidController(IApiService apiService, IMappingService mappingService, IApiRoutes routes)
        {
            _apiService = apiService;
            _mappingService = mappingService;
            _routes = routes.GetApiRoutes("Bid");
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
            CreateBidViewDTO dto = new CreateBidViewDTO();

            dto.CorparateList = new List<CorparateList>(){
        new CorparateList{CorparateName = "Burkay Compy",CorparatePhone="12345"},
        new CorparateList{CorparateName = "Burkay2 Compy",CorparatePhone="12345"},
        new CorparateList{CorparateName = "Burkay3 Compy",CorparatePhone="12345"},
        new CorparateList{CorparateName = "Burkay4 Compy",CorparatePhone="12345"},
        new CorparateList{CorparateName = "Burkay5 Compy",CorparatePhone="12345"}
    };

            dto.StatusList = new List<ListStatusDTO>(){
        new ListStatusDTO{Name = "Basladi"},
        new ListStatusDTO{Name = "Devam Ediyor"},
        new ListStatusDTO{Name = "Iptal Edildi"},
        new ListStatusDTO{Name = "Ihale sonuclandi"}
    };

            dto.CarList = new List<ListCarDTO>()
            {
                new ListCarDTO{CarBrand="BMW",CarModel="I3",Plate="32abc4222",Price=50000},
                new ListCarDTO{CarBrand="Audi",CarModel="I3",Plate="32abc4222",Price=50000},
                new ListCarDTO{CarBrand="Mercedes",CarModel="I3",Plate="32abc4222",Price=50000},
                new ListCarDTO{CarBrand="Toyota",CarModel="I3",Plate="32abc4222",Price=50000},
            };

            return View(dto);
        }

        [HttpPost]
        //POST: Bid Controller for Create New Bid
        public IActionResult Create(IFormCollection formCollection)
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
        public async Task<IActionResult> ListBid(List<BidListDTO> listDTO = null)
        {
            if (listDTO.Count <= 0)
            {
                var result = await _apiService.Get<List<BidListDTO>>(tokenDTO, _routes["ListBid"]);
                if (result.Success)
                {
                    listDTO = result.Data;
                }

            }

            return View(listDTO);
        }

        //POST: List Bid Method with Filter

        [HttpPost]
        public async Task<IActionResult> ListBid(IFormCollection filteredBidInfo)
        {
            //Todo : validation kutuphanesi duzenlendikten sonra eklenecek
            //CombineBidListVAL bidVAL = new CombineBidListVAL();
            //ValidationResult validationResult = bidVAL.Validate(_mappingService.GetModel<CombineBidDTO>(filteredBidInfo));

            var result = await _apiService.Get1<List<BidListDTO>, BidFilterDTO>(tokenDTO, _routes["ListBidFilter"], _mappingService.GetModel<BidFilterDTO>(filteredBidInfo));

            return View(result.Data);
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
