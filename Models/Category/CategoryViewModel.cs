using System.Collections.Generic;
using Tourtech.Models.Shared;

namespace Tourtech.Models.Category
{
    public class CategoryViewModel : SubPageViewModel
    {
        public IEnumerable<ContentSectionViewModel> Sections { get; set; }

        public IEnumerable<ProductOverviewViewModel> Products { get; set; }
    }
}