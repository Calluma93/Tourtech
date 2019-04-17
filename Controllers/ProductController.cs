using Services.Abstract;
using Services.Exceptions;
using Services.Models.Products;
using System.Linq;
using System.Web.Mvc;
using Tourtech.Helpers;
using Tourtech.Models.Product;
using Tourtech.Models.Shared;

namespace Tourtech.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IPageContentService pageContentService, IProductsService productsService)
            : base(pageContentService, productsService)
        {
        }

        public ActionResult Index(string productName)
        {
            CategoryModel category;
            try
            {
                category = productsService.GetCategoryByProduct(productName);
            }
            catch(ClientException)
            {
                return NotFoundResult();                
            }

            ProductModel product = category.Products.Single(a => a.Name == productName);

            ProductViewModel indexViewModel = new ProductViewModel(
                ContentSectionHelper.MapContentSectionsToViewModels(product.ContentSections),
                product.GalleryImages.Select(b => ImageHelper.MapImageToViewModel(b)),
                product.OverviewParagraphs,
                product.Features
            )
            {
                Breadcrumb = BreadcrumbHelper.GetProductBreadcrumb(Url, category.Title, category.Name, product.Title, product.Name),
                MainHeading = product.Title,
                BannerImageUrl = TourtechUrlHelper.GetImageUrl(product.BannerImageRelativeUrl),
                Title = product.MetaData.Title,
                MetaDescription = product.MetaData.MetaDescription
            };

            SetLayout(indexViewModel);

            return View(indexViewModel);
        }
    }
}