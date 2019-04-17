using Services.Abstract;
using Services.Exceptions;
using Services.Models.Products;
using System.Linq;
using System.Web.Mvc;
using Tourtech.Helpers;
using Tourtech.Models.Category;
using Tourtech.Models.Shared;

namespace Tourtech.Controllers
{
    public class CategoryController : BaseController
    {

        public CategoryController(IPageContentService pageContentService, IProductsService productsService)
            : base(pageContentService, productsService)
        {
        }

        public ActionResult Index(string categoryName)
        {
            CategoryModel category;
            try
            {
                category = productsService.GetCategory(categoryName);
            }
            catch(ClientException)
            {
                return NotFoundResult();
            }

            CategoryViewModel viewModel =
                new CategoryViewModel()
                {
                    Breadcrumb = BreadcrumbHelper.GetCategoryBreadcrumb(Url, category.Title, categoryName),
                    MainHeading = category.Title,
                    Sections = ContentSectionHelper.MapContentSectionsToViewModels(category.ContentSections),
                    Products = ProductHelper.MapProductsToViewModels(category.Products),
                    BannerImageUrl = TourtechUrlHelper.GetImageUrl(category.BannerImageRelativeUrl),
                    Title = category.MetaData.Title,
                    MetaDescription = category.MetaData.MetaDescription
                }
            ;

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}