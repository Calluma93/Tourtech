
using System.Collections.Generic;

namespace Tourtech.Models.Shared
{
    public class BreadcrumbViewModel
    {
        private IList<BreadcrumbItemViewModel> breadcrumbItems;

        public BreadcrumbViewModel()
        {
            breadcrumbItems = new List<BreadcrumbItemViewModel>();
        }

        public void AddItem(string text, string url)
        {
            breadcrumbItems.Add(new BreadcrumbItemViewModel(text, url));
        }

        public IList<BreadcrumbItemViewModel> BreadcrumbItems
        {
            get
            {
                return breadcrumbItems;
            }
        }
    }
}