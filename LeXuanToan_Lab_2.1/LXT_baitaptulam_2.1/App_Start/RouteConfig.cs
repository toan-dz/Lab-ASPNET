using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LXT_baitaptulam_2._1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name : "Show Product",
                url: "Nhac-Viet-Nam/Danh-Sach-Nhac",
                defaults: new { controller = "Product", action = "ShowProduct" }
                );
            routes.MapRoute(
                name: "Product",
                url: "Nhac-Viet-Nam",
                defaults: new { controller = "Product", action = "ShowProduct" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
