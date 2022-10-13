using Business.Concrete;
using CarTender.FluentValidation.DAL.UserDAL.Login_Register;
using Common.Validation.Concrete;
using CT.UserUI.Logging.Concrete;
using Entity.DTO;
using FluentValidation.Results;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly BaseAPIService _api = new BaseAPIService();

        private readonly Logger _logger = new Logger(new Creater().FactoryMethod(LoggerTypes.DbLogger));

        #region Login

        // GET: Auth Controller for Login
        [HttpGet]
        public ActionResult Login()
        {
            UserLoginDAL validations = new UserLoginDAL();
            ValidationResult result = validations.Validate( new CarTender.FluentValidation.DTO.UserDTO.Login_Register.UserLoginDTO()
            {
                Username = "yigit",
                Password = "1234"
            });

            if (result.IsValid)
            {

            }

            return View();
        }

        //POST: Auth Controller for Login
        [HttpPost]
        public ActionResult Login(UserLoginDTO dto)
        {
            string username = "ahmet";
            string password = "123";


            //BaseValidator<UserLoginDTO> validator = new BaseValidator<UserLoginDTO>(dto);
            UserLoginDAL validations = new UserLoginDAL();
            ValidationResult result = validations.Validate( new CarTender.FluentValidation.DTO.UserDTO.Login_Register.UserLoginDTO()
            {
                Username = username,
                Password = password
            });

            if (result.IsValid)
            {

            }
            if (dto.Password != password || dto.Username != username)
            {
                _logger.Log("hatalı kullanıcı girişi - USERUI");
                return RedirectToAction("Login");
            }

            _logger.Log(username + " kullanıcı giriş yaptı. - USERUI");

            return RedirectToAction("CustomerSignUp");
        }

        #endregion

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
            var query = await _api.POST<RabbitMQLoginDTO>("Auth/register", dto);
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