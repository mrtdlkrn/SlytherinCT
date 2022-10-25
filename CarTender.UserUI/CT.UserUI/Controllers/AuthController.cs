using Business.Abstract;
using Business.Concrete;
using Common.Concrete;
using CT.UserUI.Logging.Concrete;
using Entity.DTO;
using Entity.DTO.Auth;
using FluentValidation.Results;
using System;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Security;

namespace CT.UserUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IApiManager _apiManager;

        private readonly Logger _logger = new Logger(new Creater().FactoryMethod(LoggerTypes.FileLogger));

        public AuthController()
        {
            _apiManager = new ApiManager(new BaseAPIService());
        }

        #region Login

        // GET: Auth Controller for Login

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginDTO());
        }

        //POST: Auth Controller for Login

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Login(LoginDTO dto)
        {
            //BaseValidator<UserLoginDTO> validator = new BaseValidator<UserLoginDTO>(dto);
            //UserLoginVAL validations = new UserLoginVAL();
            //ValidationResult result = validations.Validate(new CarTender.FluentValidation.DTO.UserDTO.Login_Register.UserLoginDTO()
            //{
            //    Username = username,
            //    Password = password
            //});

            //if (result.IsValid)
            //{

            //}

            var loginResult = await _apiManager.Login(dto);

            if (!loginResult.Success)
            {
                _logger.Log("hatalı kullanıcı girişi - USERUI");
                return RedirectToAction("Login");
            }

            //_logger.Log(username + " kullanıcı giriş yaptı. - USERUI");
            HttpCookie httpCookie = new HttpCookie("Bid");
            httpCookie.Expires = loginResult.Data.ExpireTime;
            httpCookie.Values.Add("token", loginResult.Data.Token);
            HttpContext.Response.Cookies.Add(httpCookie);

            FormsAuthentication.SetAuthCookie(dto.Username,false);
            Session["User"] = dto;

            return RedirectToAction("Index","Home");
        }

        #endregion

        [HttpGet]
        public ActionResult Logout()
        {
            if (HttpContext.Request.Cookies["Bid"] != null)
            {
                HttpCookie myCookie = HttpContext.Request.Cookies["Bid"];
                myCookie.Expires = DateTime.Now.AddDays(-999);
                Response.Cookies.Add(myCookie);
            }

            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }

        #region CustomerSignUp

        //GET: Auth Controller for CustomerSignUp
        [AllowAnonymous]
        [HttpGet]
        public ActionResult CustomerSignUp()
        {
            return View(new RabbitMQLoginDTO());
        }

        //POST: Auth Controller for CustomerSignUp
        //[HttpPost]
        //public async Task<ActionResult> CustomerSignUp(RabbitMQLoginDTO dto)
        //{
        //    var query = await _apiManager.Post<RabbitMQLoginDTO>("Auth/register", dto);
        //    return View(query);
        //}

        #endregion

        #region CompanySignUp
        //GET: Auth Controller for CompanySignUp
        [AllowAnonymous]
        [HttpGet]
        public ActionResult CompanySignUp()
        {
            return View();
        }

        //POST: Auth Controller for CompanySignUp
        [AllowAnonymous]
        [HttpPost]
        public ActionResult CompanySignUp(int id)
        {
            return View();
        }

        #endregion

        #region EmailVerification

        //GET: Auth Controller for EmailVerification
        [AllowAnonymous]
        [HttpGet]
        public ActionResult EmailVerification(RabbitMQLoginDTO dto)
        {
            TempData["Email"] = dto.Email;
            return View();
        }

        //POST: Auth Controller for EmailVerification
        [AllowAnonymous]
        [HttpPost]
        public ActionResult EmailVerification(int id)
        {
            return View();
        }

        #endregion

        #region EmailVerificationIsCorrect

        //GET: Auth Controller for EmailVerificationIsCorrect
        [AllowAnonymous]
        [HttpGet]
        public ActionResult EmailVerificationIsCorrect()
        {
            return View();
        }

        //POST: Auth Controller for EmailVerificationIsCorrect
        [AllowAnonymous]
        [HttpPost]
        public ActionResult EmailVerificationIsCorrect(int id)
        {
            return View();
        }

        #endregion

        #region ForgotPassword

        //GET: Auth Controller for ForgotPassword
        [AllowAnonymous]
        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //POST: Auth Controller for ForgotPassword
        [AllowAnonymous]
        [HttpPost]
        public ActionResult ForgotPassword(int id)
        {
            return View();
        }

        #endregion

        #region ResetPassword

        //GET: Auth Controller for ResetPassword
        [AllowAnonymous]
        [HttpGet]
        public ActionResult ResetPassword()
        {
            return View();
        }

        //POST: Auth Controller for ResetPassword
        [AllowAnonymous]
        [HttpPost]
        public ActionResult ResetPassword(int id)
        {
            return View();
        }

        #endregion
    }
}