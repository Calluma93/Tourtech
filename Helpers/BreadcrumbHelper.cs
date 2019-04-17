
using System.Web.Mvc;
using Tourtech.Models.Shared;

namespace Tourtech.Helpers
{
    public static class BreadcrumbHelper
    {
        private static BreadcrumbViewModel getHomeBreadcrumb(UrlHelper urlHelper)
        {
            BreadcrumbViewModel breadcrumb = new BreadcrumbViewModel();
            breadcrumb.AddItem("Home", urlHelper.Action("Index", "Home"));
            return breadcrumb;
        }

        public static BreadcrumbViewModel GetProductsBreadcrumb(UrlHelper urlHelper)
        {
            BreadcrumbViewModel breadcrumb = getHomeBreadcrumb(urlHelper);
            breadcrumb.AddItem("Products", urlHelper.Action("Index", "Products"));
            return breadcrumb;
        }

        public static BreadcrumbViewModel GetWhereToBuyBreadcrumb(UrlHelper urlHelper, string mainHeading)
        {
            BreadcrumbViewModel breadcrumb = getHomeBreadcrumb(urlHelper);
            breadcrumb.AddItem(mainHeading, urlHelper.Action("Index", "WhereToBuy"));
            return breadcrumb;
        }

        public static BreadcrumbViewModel GetCategoryBreadcrumb(UrlHelper urlHelper, string categoryTitle, string categoryName)
        {
            BreadcrumbViewModel breadcrumb = GetProductsBreadcrumb(urlHelper);
            breadcrumb.AddItem(categoryTitle, urlHelper.Action("Index", "Category", new { categoryName = categoryName }));
            return breadcrumb;
        }

        public static BreadcrumbViewModel GetProductBreadcrumb(
            UrlHelper urlHelper, string categoryTitle, string categoryName, string productTitle, string productName
        ) {
            BreadcrumbViewModel breadcrumb = GetCategoryBreadcrumb(urlHelper, categoryTitle, categoryName);
            breadcrumb.AddItem(productTitle, urlHelper.Action("Index", "Product", new { productName = productName }));
            return breadcrumb;
        }
    }
}