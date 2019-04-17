using Services.Abstract;
using Services.Models.PageContent;
using Services.Models.Products;
using Services.Models.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tourtech.Helpers;
using Tourtech.Models.Shared;

namespace Tourtech.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IPageContentService pageContentService;
        protected readonly IProductsService productsService;

        public BaseController(IPageContentService pageContentService, IProductsService productsService)
        {
            this.pageContentService = pageContentService;
            this.productsService = productsService;
        }

        public void SetBannerToDefault(SubPageViewModel pageViewModel)
        {
            pageViewModel.BannerImageUrl = TourtechUrlHelper.GetImageUrl(pageContentService.DefaultBannerImageRelativeUrl);
        }

        public void SetLayout(LayoutViewModel layoutViewModel)
        {
            LayoutModel layout = pageContentService.Layout;
            layoutViewModel.LogoImage = new ResponsiveImageViewModel(
                layout.LogoImage.Title,
                TourtechUrlHelper.GetImageUrl(layout.LogoImage.ImageRelativeUrl),
                TourtechUrlHelper.GetImageUrl(layout.LogoImage.MobileImageRelativeUrl)
            );
            layoutViewModel.StripesImage = ImageHelper.MapImageToViewModel(layout.StripesImage);
            layoutViewModel.HamburgerImage = ImageHelper.MapImageToViewModel(layout.HamburgerImage);

            IEnumerable<CategoryModel> categories = productsService.GetCategories();
            layoutViewModel.MainMenu =
                new MenuItemViewModel[]
                {
                    new MenuItemViewModel("Home", Url.Action("Index", "Home")),
                    new MenuItemViewModel(
                        "Products",
                        Url.Action("Index", "Products"),
                        categories.Select(a => new MenuItemViewModel(a.Title, TourtechUrlHelper.GetCategoryUrl(a.Name)))
                    ),
                    new MenuItemViewModel("Where To Buy", Url.Action("Index", "WhereToBuy")),
                }
            ;
        }

        protected ActionResult NotFoundResult() {
            LayoutViewModel layoutModel = new LayoutViewModel();
            SetLayout(layoutModel);
            Response.StatusCode = 404;
            return View("NotFound", layoutModel);
        }
    }
}