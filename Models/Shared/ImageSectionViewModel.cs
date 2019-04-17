
namespace Tourtech.Models.Shared
{
    public class ImageSectionViewModel : ContentSectionViewModel
    {
        public ImageSectionViewModel(ImageViewModel image)
        {
            Image = image;
        }

        public ImageViewModel Image { get; private set; }
    }
}
