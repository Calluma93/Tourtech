using Services.Abstract;
using Services.Models.PageContent;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tourtech.Helpers;
using Tourtech.Models.Products;

namespace Tourtech.Controllers
{
    public class ProductsController : BaseController
    {
        public ProductsController(IPageContentService pageContentService, IProductsService productsService)
            : base(pageContentService, productsService)
        {
        }

        public ActionResult Index()
        {
            IEnumerable<CategoryViewModel> categories =
                productsService.GetCategories().Select(a =>
                    new CategoryViewModel()
                    {
                        Title = a.Title,
                        ImageUrl = TourtechUrlHelper.GetImageUrl(a.ImageRelativeUrl),
                        LinkUrl = TourtechUrlHelper.GetCategoryUrl(a.Name),
                        ComingSoon = a.ComingSoon
                    }
                )
            ;

            PageModel productsPageContent = pageContentService.ProductsPage;

            ProductsViewModel viewModel =
                new ProductsViewModel()
                {
                    Breadcrumb = BreadcrumbHelper.GetProductsBreadcrumb(Url),
                    MainHeading = productsPageContent.MainHeading,
                    Categories = categories,
                    Title = productsPageContent.MetaData.Title,
                    MetaDescription = productsPageContent.MetaData.MetaDescription
                }
            ;

            SetBannerToDefault(viewModel);

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}