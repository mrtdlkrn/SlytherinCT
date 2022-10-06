using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class AuthController : Controller
    {
        #region Login

        // GET: Auth Controller for Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //POST: Auth Controller for Login
        [HttpPost]
        public ActionResult Login(int id)
        {
            return View();
        }

        #endregion

        #region CustomerSignUp

        //GET: Auth Controller for CustomerSignUp
        [HttpGet]
        public ActionResult CustomerSignUp()
        {
            return View();
        }

        //POST: Auth Controller for CustomerSignUp
        [HttpPost]
        public ActionResult CustomerSignUp(int id)
        {
            return View();
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
        public ActionResult EmailVerification()
        {
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