
namespace Services.Models.Products
{
    public class HeadingSectionModel : ContentSectionModel
    {
        public HeadingSectionModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
