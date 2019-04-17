
using Tourtech.Models.Shared;

namespace Tourtech.Models.Home
{
    public class BannerViewModel
    {
        public BannerViewModel(ImageViewModel bannerOverlayLogo, ResponsiveImageViewModel image, string overlayText, string overlayLinkUrl, bool alternateColorTheme)
        {
            BannerOverlayLogo = bannerOverlayLogo;
            Image = image;
            OverlayText = overlayText;
            OverlayLinkUrl = overlayLinkUrl;
            AlternateColorTheme = alternateColorTheme;
        }

        public ImageViewModel BannerOverlayLogo { get; set; }

        public ResponsiveImageViewModel Image { get; private set; }

        public string OverlayText { get; private set; }

        public string OverlayLinkUrl { get; private set; }

        public bool AlternateColorTheme { get; private set;  }
    }
}
