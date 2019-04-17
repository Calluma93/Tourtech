
using Services.Models.Shared;

namespace Services.Models.PageContent
{
    public class HomeBannerModel
    {
        public HomeBannerModel(ImageModel bannerOverlayLogo, ResponsiveImageModel image, string overlayText, string overlayLinkCategoryName, bool alternateColorTheme)
        {
            BannerOverlayLogo = bannerOverlayLogo;
            Image = image;
            OverlayText = overlayText;
            OverlayLinkCategoryName = overlayLinkCategoryName;
            AlternateColorTheme = alternateColorTheme;
        }

        public ImageModel BannerOverlayLogo { get; private set; }

        public ResponsiveImageModel Image { get; private set; }

        public string OverlayText { get; private set; }

        public string OverlayLinkCategoryName { get; private set; }

        public bool AlternateColorTheme { get; private set; }
    }
}
