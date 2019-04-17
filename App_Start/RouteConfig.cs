using System.Web.Mvc;
using System.Web.Routing;

namespace Tourtech
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.LowercaseUrls = true;

            routes.AppendTrailingSlash = true;

            routes.MapRoute(
                name: "Products",
                url: "products",
                defaults: new { controller = "Products", action = "Index" }
            );

            routes.MapRoute(
                name: "WhereToBuy",
                url: "where-to-buy",
                defaults: new { controller = "WhereToBuy", action = "Index"}
            );

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "Category",
                url: "{categoryName}",
                defaults: new { controller = "Category", action = "Index" }
            );

            routes.MapRoute(
                name: "Product",
                url: "product/{productName}",
                defaults: new { controller = "Product", action = "Index" }
            );            
        }
    }
}
