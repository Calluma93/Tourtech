
using Services.Models.Products;
using System.Collections.Generic;
using System.Linq;
using Tourtech.Models.Shared;

namespace Tourtech.Helpers
{
    public static class ProductHelper
    {
        public static IEnumerable<ProductOverviewViewModel> MapProductsToViewModels(IEnumerable<ProductModel> products)
        {
            return products.Select(
                a => new ProductOverviewViewModel()
                {
                    Title = a.Title,
                    Url = TourtechUrlHelper.GetProductUrl(a.Name),
                    ImageUrl = TourtechUrlHelper.GetImageUrl(a.ImageRelativeUrl)
                }
            );
        }
    }
}