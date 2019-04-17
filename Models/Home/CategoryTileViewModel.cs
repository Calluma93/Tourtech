using Tourtech.Models.Shared;

namespace Tourtech.Models.Home
{
    public class CategoryTileViewModel
    {
        public CategoryTileViewModel(ImageViewModel image, string text, string linkText, string linkUrl)
        {
            Image = image;
            Text = text;
            LinkText = linkText;
            LinkUrl = linkUrl;
        }

        public ImageViewModel Image { get; private set; }

        public string Text { get; private set; }

        public string LinkText { get; private set; }

        public string LinkUrl { get; private set; }
    }
}