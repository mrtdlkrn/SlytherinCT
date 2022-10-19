using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CT.UserUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)     
        {
            HttpContext httpContext = HttpContext.Current;
            if (httpContext.Request.Cookies["token"] != null)
            {
                HttpCookie gelenCookie = httpContext.Request.Cookies["Ihlae"];
                string token = gelenCookie.Values["token"];
            }
        }
    }
}
