
using System.Collections.Generic;

namespace Tourtech.Models.Shared
{
    public class LayoutViewModel
    {
        public ResponsiveImageViewModel LogoImage { get; set; }

        public ImageViewModel StripesImage { get; set; }

        public ImageViewModel HamburgerImage { get; set; }

        public IEnumerable<MenuItemViewModel> MainMenu { get; set; }
    }
}