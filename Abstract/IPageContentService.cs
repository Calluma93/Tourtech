
using Services.Models.PageContent;

namespace Services.Abstract
{
    public interface IPageContentService
    {
        string DefaultBannerImageRelativeUrl
        {
            get;
        }

        LayoutModel Layout
        {
            get;
        }

        HomePageModel HomePage
        {
            get;
        }

        PageModel ProductsPage
        {
            get;
        }

        PageModel WhereToBuyPage
        {
            get;
        }
    }
}
