
namespace Services.Models.Products
{
    public class ParagraphSectionModel : ContentSectionModel
    {
        public ParagraphSectionModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
