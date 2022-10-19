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
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IApiManager _apiManager;

        private readonly Logger _logger = new Logger(new Creater().FactoryMethod(LoggerTypes.DbLogger));

        public AuthController()
        {
            _apiManager = new ApiManager(new BaseAPIService());
        }

        #region Login

        // GET: Auth Controller for Login
        [HttpGet]
        public ActionResult Login()
        {
            //UserLoginDAL validations = new UserLoginDAL();
            //ValidationResult result = validations.Validate( new CarTender.FluentValidation.DTO.UserDTO.Login_Register.UserLoginDTO()
            //{
            //    Username = "yigit",
            //    Password = "1234"
            //});

            //if (result.IsValid)
            //{

            //}
            if (HttpContext.Request.Cookies["token"] != null)
            {
                HttpCookie gelenCookie = HttpContext.Request.Cookies["Ihlae"];
                string token = gelenCookie.Values["token"];
            }

            return View();
        }

        //POST: Auth Controller for Login
        [HttpPost]
        public ActionResult Login(LoginDTO dto)
        {
            string username = "ahmet";
            string password = "123";


            //UserLoginDAL validations = new UserLoginDAL();
            //ValidationResult result = validations.Validate(new CarTender.FluentValidation.DTO.UserDTO.Login_Register.UserLoginDTO()
            //{
            //    Username = username,
            //    Password = password
            //});

            //if (result.IsValid)
            //{

            //}
            if (dto.Password != password || dto.Username != username)
            {
                _logger.Log("hatalı kullanıcı girişi - USERUI");
                return RedirectToAction("Login");
            }

            _logger.Log(username + " kullanıcı giriş yaptı. - USERUI");

            HttpCookie httpCookie = new HttpCookie("Ihale");
            httpCookie.Expires = DateTime.Now.AddDays(1);
            //httpCookie.Expires = DateTime.Now.AddDays(-1); silmek için bu şekilde kullanırız
            httpCookie.Values.Add("token", "hede");
            HttpContext.Response.Cookies.Add(httpCookie);

            return RedirectToAction("CustomerSignUp");
        }

        #endregion

        // todo: logout yazılacak

        #region CustomerSignUp

        //GET: Auth Controller for CustomerSignUp
        [HttpGet]
        public ActionResult CustomerSignUp()
        {
            return View(new RabbitMQLoginDTO());
        }

        //POST: Auth Controller for CustomerSignUp
        [HttpPost]
        public async Task<ActionResult> CustomerSignUp(RabbitMQLoginDTO dto)
        {
            var query = await _apiManager.Post<RabbitMQLoginDTO>("Auth/register", dto);
            return View(query);
        }

        #endregion

        #region CompanySignUp
        //GET: Auth Controller for CompanySignUp
        [HttpGet]
        public ActionResult CompanySignUp()
        {
            return View();
        }

        //POST: Auth Controller for CompanySignUp
        [HttpPost]
        public ActionResult CompanySignUp(int id)
        {
            return View();
        }

        #endregion

        #region EmailVerification

        //GET: Auth Controller for EmailVerification
        [HttpGet]
        public ActionResult EmailVerification(RabbitMQLoginDTO dto)
        {
            TempData["Email"] = dto.Email;
            return View();
        }

        //POST: Auth Controller for EmailVerification
        [HttpPost]
        public ActionResult EmailVerification(int id)
        {
            return View();
        }

        #endregion

        #region EmailVerificationIsCorrect

        //GET: Auth Controller for EmailVerificationIsCorrect
        [HttpGet]
        public ActionResult EmailVerificationIsCorrect()
        {
            return View();
        }

        //POST: Auth Controller for EmailVerificationIsCorrect
        [HttpPost]
        public ActionResult EmailVerificationIsCorrect(int id)
        {
            return View();
        }

        #endregion

        #region ForgotPassword

        //GET: Auth Controller for ForgotPassword
        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //POST: Auth Controller for ForgotPassword
        [HttpPost]
        public ActionResult ForgotPassword(int id)
        {
            return View();
        }

        #endregion

        #region ResetPassword

        //GET: Auth Controller for ResetPassword
        [HttpGet]
        public ActionResult ResetPassword()
        {
            return View();
        }

        //POST: Auth Controller for ResetPassword
        [HttpPost]
        public ActionResult ResetPassword(int id)
        {
            return View();
        }

        #endregion
    }
}