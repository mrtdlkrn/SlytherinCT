using System.Web.Mvc;

namespace CT.UserUI.CookieHelper
{
    // yarım kaldı devam edilecek.
    public class MyCookieHelper
    {
        private readonly ControllerContext context;

        public MyCookieHelper(ControllerContext context)
        {
            this.context = context;
        }

        public string ReadToken(string cookieName)
        {
            var token = context.HttpContext.Request.Cookies.Get(cookieName);
            return "";
        }
    }
}