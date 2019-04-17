
using Services.Abstract;
using Services.Models.PageContent;
using System.Linq;
using System.Web.Mvc;
using Tourtech.Helpers;
using Tourtech.Models.Home;
using Tourtech.Models.Shared;

namespace Tourtech.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IPageContentService pageContentService, IProductsService productsService)
            : base(pageContentService, productsService)
        {
        }

        public ActionResult Index()
        {
            HomePageModel homePageContent = pageContentService.HomePage;

            HomeViewModel viewModel =
                new HomeViewModel()
                {
                    MainHeading = homePageContent.MainHeading,
                    Banners = homePageContent.Banners.Select(
                        a => new BannerViewModel(
                            ImageHelper.MapImageToViewModel(a.BannerOverlayLogo),
                            new ResponsiveImageViewModel(
                                a.Image.Title,
                                TourtechUrlHelper.GetImageUrl(a.Image.ImageRelativeUrl),
                                TourtechUrlHelper.GetImageUrl(a.Image.MobileImageRelativeUrl)
                            ),
                            a.OverlayText,
                            TourtechUrlHelper.GetCategoryUrl(a.OverlayLinkCategoryName),
                            a.AlternateColorTheme
                        )
                    ),
                    CategoryTiles = homePageContent.CategoryTiles.Select(
                        b => new CategoryTileViewModel(
                            ImageHelper.MapImageToViewModel(b.Image),
                            b.Text, b.LinkText,
                            TourtechUrlHelper.GetCategoryUrl(b.LinkCategoryName)
                        )
                    ),
                    Products = ProductHelper.MapProductsToViewModels(productsService.GetProducts()),
                    Title = homePageContent.MetaData.Title,
                    MetaDescription = homePageContent.MetaData.MetaDescription
                }
            ;

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}