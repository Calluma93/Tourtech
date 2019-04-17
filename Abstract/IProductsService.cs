using Services.Models.Products;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IProductsService
    {
        IEnumerable<CategoryModel> GetCategories();

        CategoryModel GetCategory(string categoryName);

        CategoryModel GetCategoryByProduct(string productName);

        IEnumerable<ProductModel> GetProducts();
    }
}
