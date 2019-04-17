using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.PageContent
{
    public class HomePageModel : PageModel
    {
        public HomePageModel(
            string mainHeading, IEnumerable<HomeBannerModel> banners, IEnumerable<CategoryTileModel> categoryTiles, MetaDataModel metaData
        ) :
            base(mainHeading, metaData)
        {
            Banners = banners;
            CategoryTiles = categoryTiles;
        }

        public IEnumerable<HomeBannerModel> Banners { get; private set; }

        public IEnumerable<CategoryTileModel> CategoryTiles { get; private set; }
    }
}