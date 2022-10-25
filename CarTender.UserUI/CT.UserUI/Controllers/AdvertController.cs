using Business.Abstract;
using Business.Concrete;
using Common.Concrete;
using CT.UserUI.CookieHelper;
using Entity.DTO.Advert;
using Entity.DTO.Auth;
using Entity.DTO.Bid;
using Entity.Security;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class AdvertController : Controller
    {
        private readonly IApiManager _apiManager;
        private readonly IDictionary<string, string> _routes;

        public AdvertController()
        {
            _apiManager = new ApiManager(new BaseAPIService());
            _routes = new ApiRoutes().GetApiRoutes("Advert");
        }

        // Advert List GET
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            //todo : User'a göre tokenDto oluşturulacak

            var result = await _apiManager.Get<List<ListAdvertDTO>>(ReadToken("BidToken"), _routes["Index"]);

            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                // bu kısımlar düzenlenecek.
                return RedirectToAction("NotFound", "Home");
            }
        }

        // Advert Details
        public async Task<ActionResult> Details()
        {

            var result = await _apiManager.Get<ListAdvertDTO>(ReadToken("BidToken"), _routes["Details"]);
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                return RedirectToAction("NotFound", "Home");
            }
        }

        // Advert Create GET
        public ActionResult Create()
        {
            return View();
        }

        // Advert Create POST

        [HttpPost]
        public async Task<ActionResult> Create(AddAdvertDTO dto)
        {
            var result = await _apiManager.Post(ReadToken("BidToken"), _routes["Create"], dto);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                //return RedirectToAction("NotFound", "Home");
                return View("~/Views/Shared/Error.cshtml");

            }
        }

        // Advert Edit GET
        public async Task<ActionResult> Edit()
        {
            var result = await _apiManager.Get<BidInformationDTO>(ReadToken("BidToken"), _routes["UpdateGet"]);
            if (result.Success)
            {
                return View();
            }
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        // Advert Edit POST
        [HttpPost]
        public async Task<ActionResult> Edit(int id, EditAdvertDTO dto)
        {
            var result = await _apiManager.Post(ReadToken("BidToken"),_routes["Update"], dto);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");

            }
        }

        // Advert Delete GET
        public async Task<ActionResult> Delete()
        {
            var result = await _apiManager.Get<EditAdvertDTO>(ReadToken("BidToken"), _routes["DeleteGet"]);
            if (result.Success)
            {
                return View();
            }
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        // Advert Delete POST
        [HttpPost]
        public async Task<ActionResult> Delete(EditAdvertDTO dto)
        {
            var result = await _apiManager.Post(ReadToken("BidToken"),_routes["Delete"], dto);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public string ReadToken(string cookieName)
        {
            return HttpContext.Request.Cookies.Get(cookieName).Value;
        }
    }
}
