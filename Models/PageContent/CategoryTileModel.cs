
using Services.Models.Shared;

namespace Services.Models.PageContent
{
    public class CategoryTileModel
    {
        public CategoryTileModel(ImageModel image, string text, string linkText, string linkCategoryName)
        {
            Image = image;
            Text = text;
            LinkText = linkText;
            LinkCategoryName = linkCategoryName;
        }

        public ImageModel Image { get; private set; }

        public string Text { get; private set; }

        public string LinkText { get; private set; }

        public string LinkCategoryName { get; private set; }
    }
}