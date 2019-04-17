
using System.Collections.Generic;
using Tourtech.Models.Shared;

namespace Tourtech.Models.Products
{
    public class ProductsViewModel : SubPageViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}