using System.Collections.Generic;
using Tourtech.Models.Shared;

namespace Tourtech.Models.Home
{
    public class HomeViewModel : PageViewModel
    {
        public IEnumerable<BannerViewModel> Banners { get; set; }

        public IEnumerable<CategoryTileViewModel> CategoryTiles { get; set; }
        
        public IEnumerable<ProductOverviewViewModel> Products { get; set; }
    }
}