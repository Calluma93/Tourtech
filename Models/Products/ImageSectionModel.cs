
using Services.Models.Shared;

namespace Services.Models.Products
{
    public class ImageSectionModel : ContentSectionModel
    {
        public ImageSectionModel(ImageModel image)
        {
            Image = image;
        }

        public ImageModel Image { get; private set; }
    }
}
