using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace elFinder.Net.FileManager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // elFinder's connector route
            routes.MapRoute(null, "connector", new { controller = "Files", action = "Index" });
            routes.MapRoute(null, "Thumbnails/{tmb}", new { controller = "Files", action = "Thumbs", tmb = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
