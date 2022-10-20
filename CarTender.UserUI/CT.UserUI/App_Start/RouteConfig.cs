using System.Web.Mvc;
using System.Web.Routing;

namespace CT.UserUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Enabling Attribute Routing   
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Advert",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Advert", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Bid",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Bid", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Car",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Car", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "User",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
