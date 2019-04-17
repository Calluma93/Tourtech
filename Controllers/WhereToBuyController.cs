using Services.Abstract;
using Services.Models.PageContent;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tourtech.Helpers;
using Tourtech.Models.WhereToBuy;

namespace Tourtech.Controllers
{
    public class WhereToBuyController : BaseController
    {
        private readonly IRetailerService retailerService;

        public WhereToBuyController(IPageContentService pageContentService, IProductsService productsService, IRetailerService retailerService)
            : base(pageContentService, productsService)
        {
            this.retailerService = retailerService;
        }

        public ActionResult Index()
        {
            IEnumerable<RetailerViewModel> retailers =
                retailerService.GetRetailers().Select(
                    a => new RetailerViewModel()
                    {
                        Name = a.Name,
                        DesktopImageUrl = TourtechUrlHelper.GetImageUrl(a.DesktopImageRelativeUrl),
                        MobileImageUrl = TourtechUrlHelper.GetImageUrl(a.MobileImageRelativeUrl),
                        WebsiteUrl = a.WebsiteUrl,
                        WebsiteUrlForDisplay = a.WebsiteUrlForDisplay,
                        BackgroundColourHex = a.BackgroundColourHex,
                        TextColourHex = a.TextColourHex
                    }
                )
            ;

            PageModel whereToBuyPage = pageContentService.WhereToBuyPage;

            WhereToBuyViewModel viewModel = new WhereToBuyViewModel()
            {
                Breadcrumb = BreadcrumbHelper.GetWhereToBuyBreadcrumb(Url, whereToBuyPage.MainHeading),
                MainHeading = whereToBuyPage.MainHeading,
                Retailers = retailers,
                Title = whereToBuyPage.MetaData.Title,
                MetaDescription = whereToBuyPage.MetaData.MetaDescription
            };

            SetBannerToDefault(viewModel);

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}