
using Services.Models.Shared;
using Tourtech.Models.Shared;

namespace Tourtech.Helpers
{
    public static class ImageHelper
    {
        public static ImageViewModel MapImageToViewModel(ImageModel image)
        {
            return new ImageViewModel(image.Title, TourtechUrlHelper.GetImageUrl(image.ImageRelativeUrl));
        }
    }
}