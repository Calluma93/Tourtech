using Services.Models.Shared;

namespace Services.Models.PageContent
{
    public class LayoutModel
    {
        public LayoutModel(
            ResponsiveImageModel logoImage, ImageModel stripesImage, ImageModel hamburgerImage
        )
        {
            LogoImage = logoImage;
            StripesImage = stripesImage;
            HamburgerImage = hamburgerImage;
        }

        public ResponsiveImageModel LogoImage { get; private set; }

        public ImageModel StripesImage { get; private set; }

        public ImageModel HamburgerImage { get; private set; }
    }
}