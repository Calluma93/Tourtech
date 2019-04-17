
using Services.Abstract;
using Services.Models.PageContent;
using Services.Models.Shared;

namespace Services.Concrete
{
    public class PageContentService : IPageContentService
    {
        private readonly string defaultBannerImageRelativeUrl = "Content/hero-short-banner.jpg";

        private readonly LayoutModel layout= 
            new LayoutModel(
                new ResponsiveImageModel("TOURTECH Logo", "Content/TT-desktop-logo.png", "Content/TT-mobile-logo.png"),
                new ImageModel("TOURTECH Logo Stripes", "Content/stripes-small.png"),
                new ImageModel("Hamburger Menu Icon", "Content/nav-hamburger-menu.png")
            )
        ;

        private readonly HomePageModel homePage =
            new HomePageModel(
                "Road Tested Tools for Musicians",
                new HomeBannerModel[] {
                    new HomeBannerModel(
                        new ImageModel("TOURTECH", "Content/tourtech-logo-main-white.png"),
                        new ResponsiveImageModel(
                            "Drummer playing drum kit",
                            "Content/drums.jpg",
                            "Content/drums-medium.jpg"
                        ),
                        "Practise, play and perform anytime, anywhere with TOURTECH digital drums.",
                        "drum-kits",
                        true
                    ),
                    new HomeBannerModel(
                        new ImageModel("TOURTECH", "Content/tourtech-logo-main.png"),
                        new ResponsiveImageModel(
                            "Singer with stand and microphone",
                            "Content/stands.jpg",
                            "Content/stands-medium.jpg"
                        ),
                        "Solid, dependable and tour-tested: TOURTECH stands are custom made for a life on the road.",
                        "stands-stools",
                        false
                    ),
                    new HomeBannerModel(
                        new ImageModel("TOURTECH", "Content/tourtech-logo-main.png"),
                        new ResponsiveImageModel(
                            "Musician using cable on stage",
                            "Content/cables.jpg",
                            "Content/cables-medium.jpg"
                        ),
                        "Make sure your connections don’t let you down: choose TOURTECH cables for performance and reliability.",
                        "cables",
                        false
                    )
                },
                new CategoryTileModel[] {
                    new CategoryTileModel(
                        new ImageModel("Accessories", "Content/puff-accessories.jpg"), "TOURTECH: Road-tested for reliability", "Accessories", "accessories"
                    ),
                    new CategoryTileModel(
                        new ImageModel("Audio Cables", "Content/puff-cables.jpg"), "Perfect performance, night after night", "Audio Cables", "cables"
                    ),
                    new CategoryTileModel(
                        new ImageModel("Stands and Stools", "Content/puff-stands.jpg"), "Rugged, road-tested reliability", "Stands and Stools", "stands-stools"
                    ),
                    new CategoryTileModel(
                        new ImageModel("Electric Drum Kits", "Content/puff-drums.jpg"), "Quiet is the new loud! Play any time, anywhere", "Electric Drum Kits", "drum-kits"
                    )
                },
                new MetaDataModel(
                    "TOURTECH: Road Tested for Musicians",
                    "Gigging musicians need look no further than TOURTECH for all of their touring essentials. High quality bags, cables, cases and more."
                )
            )
        ;

        private readonly PageModel whereToBuyPage = new PageModel(
            "Where To Buy TOURTECH", 
            new MetaDataModel(
                "TOURTECH: Where to Buy – Official Stockists", 
                "Visit these dealers to buy official TOURTECH drums, cables, bags, cases and accessories."
            )
        );

        private readonly PageModel productsPage = new PageModel(
            "The TOURTECH Range", 
            new MetaDataModel(
                "TOURTECH: Road Tested Accessories for Musicians",
                "TOURTECH makes reliable and professional equipment for musicians. TOURTECH stands, cases and accessories are industry standard and high quality."
            )
        );
        
        public string DefaultBannerImageRelativeUrl
        {
            get
            {
                return defaultBannerImageRelativeUrl;
            }
        }

        public LayoutModel Layout
        {
            get
            {
                return layout;
            }
        }

        public HomePageModel HomePage
        {
            get
            {
                return homePage;
            }
        }

        public PageModel WhereToBuyPage
        {
            get
            {
                return whereToBuyPage;
            }
        }

        public PageModel ProductsPage
        {
            get
            {
                return productsPage;
            }
        }
    }
}
